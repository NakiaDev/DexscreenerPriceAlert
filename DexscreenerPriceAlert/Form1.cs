using DexscreenerPriceAlert.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Windows.Media;

namespace DexscreenerPriceAlert
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;
        private Timer priceAlertTimer = new Timer();
        private static HttpClient client;
        private List<MediaPlayer> sounds = new List<MediaPlayer>();

        public Form1()
        {
            InitializeComponent();

            priceAlertTimer.Tick += PriceAlertTimer_Tick;

            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UpdateSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpdateSettings = false;
                Properties.Settings.Default.Save();
            }

            textBoxMagicContract.Text = Properties.Settings.Default.MagicContract;
            textBoxEthContract.Text = Properties.Settings.Default.EthContract;
            textBoxRefresh.Text = Properties.Settings.Default.Refresh.ToString();
            textBoxAlertTargert.Text = Properties.Settings.Default.AlertTarget.ToString();
            trackBarAlert.Value = Properties.Settings.Default.AlertVolume;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.MagicContract) || Properties.Settings.Default.Refresh <= 0 || Properties.Settings.Default.AlertTarget <= 0) return;

            isRunning = !isRunning;

            if (isRunning)
            {
                buttonStart.Text = "Stop";
                buttonStart.BackColor = System.Drawing.Color.Red;
                labelMagicPrice.Text = "";
                labelLastCheck.Text = "";
                panel1.Enabled = false;
                panel2.Visible = true;

                priceAlertTimer.Interval = 100; // so we start immediatly after clicking the start button
                priceAlertTimer.Start();
            }
            else
            {
                priceAlertTimer.Stop();

                buttonStart.Text = "Start";
                buttonStart.BackColor = System.Drawing.Color.LightGreen;
                panel1.Enabled = true;
                panel2.Visible = false;
            }
        }

        private async void PriceAlertTimer_Tick(object sender, EventArgs e)
        {
            priceAlertTimer.Stop();

            double ethprice = 0;
            double magicPrice = 0;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.EthContract))
            {
                HttpResponseMessage ethResponse = await client.GetAsync($"https://api.dexscreener.io/latest/dex/pairs/ethereum/{Properties.Settings.Default.EthContract}");
                if (ethResponse.StatusCode == HttpStatusCode.OK)
                {
                    string responseString = await ethResponse.Content.ReadAsStringAsync();
                    DexscreenerResponse result = JsonConvert.DeserializeObject<DexscreenerResponse>(responseString);
                    ethprice = result.pair.priceNative;
                }
            }
            
            HttpResponseMessage magicResponse = await client.GetAsync($"https://api.dexscreener.io/latest/dex/pairs/arbitrum/{Properties.Settings.Default.MagicContract}");
            if (magicResponse.StatusCode == HttpStatusCode.OK)
            {
                string responseString = await magicResponse.Content.ReadAsStringAsync();
                DexscreenerResponse result = JsonConvert.DeserializeObject<DexscreenerResponse>(responseString);

                if (ethprice > 0)
                    magicPrice = ethprice * result.pair.priceNative;
                else
                    magicPrice = result.pair.priceUsd;
            }

            labelMagicPrice.Text = magicPrice.ToString("C4", new CultureInfo("en-US"));
            labelLastCheck.Text = DateTime.Now.ToString();

            if (magicPrice > Properties.Settings.Default.AlertTarget)
            {
                StopSounds();

                string basePath = Environment.CurrentDirectory;
                string relativePath = @"Sound\alarm.mp3";

                MediaPlayer sound = new MediaPlayer();
                sound.Open(new Uri(Path.Combine(basePath, relativePath)));
                sound.Volume = Properties.Settings.Default.AlertVolume * 10 / 100.0f;
                sound.Play();
                sounds.Add(sound);
            }

            priceAlertTimer.Interval = Properties.Settings.Default.Refresh * 1000;
            priceAlertTimer.Start();
        }

        private void KeyPressHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxRefresh_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressHandler(sender, e);
        }

        private void textBoxAlertTargert_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressHandler(sender, e);
        }

        private void textBoxMagicContract_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MagicContract = textBoxMagicContract.Text;
            Properties.Settings.Default.Save();
        }

        private void textBoxEthContract_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EthContract = textBoxEthContract.Text;
            Properties.Settings.Default.Save();
        }

        private void textBoxRefresh_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxRefresh.Text, out int result);
            Properties.Settings.Default.Refresh = result;
            Properties.Settings.Default.Save();
        }

        private void textBoxAlertTargert_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxAlertTargert.Text, out int result);
            Properties.Settings.Default.AlertTarget = result;
            Properties.Settings.Default.Save();
        }

        private void trackBarAlert_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlertVolume = trackBarAlert.Value;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopSounds();
        }

        private void StopSounds()
        {
            for (int i = sounds.Count - 1; i >= 0; i--)
            {
                sounds[i].Stop();
                sounds.RemoveAt(i);
            }
        }
    }
}
