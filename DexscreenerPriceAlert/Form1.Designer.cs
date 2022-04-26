
namespace DexscreenerPriceAlert
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMagicContract = new System.Windows.Forms.TextBox();
            this.textBoxEthContract = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarAlert = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxRefresh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMagicPrice = new System.Windows.Forms.Label();
            this.textBoxAlertTargert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLastCheck = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlert)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magic arbitrum pair contract";
            // 
            // textBoxMagicContract
            // 
            this.textBoxMagicContract.Location = new System.Drawing.Point(154, 7);
            this.textBoxMagicContract.Name = "textBoxMagicContract";
            this.textBoxMagicContract.Size = new System.Drawing.Size(261, 20);
            this.textBoxMagicContract.TabIndex = 1;
            this.textBoxMagicContract.TextChanged += new System.EventHandler(this.textBoxMagicContract_TextChanged);
            // 
            // textBoxEthContract
            // 
            this.textBoxEthContract.Location = new System.Drawing.Point(154, 33);
            this.textBoxEthContract.Name = "textBoxEthContract";
            this.textBoxEthContract.Size = new System.Drawing.Size(261, 20);
            this.textBoxEthContract.TabIndex = 3;
            this.textBoxEthContract.TextChanged += new System.EventHandler(this.textBoxEthContract_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ETH ethereum pair contract";
            // 
            // trackBarAlert
            // 
            this.trackBarAlert.Location = new System.Drawing.Point(146, 109);
            this.trackBarAlert.Name = "trackBarAlert";
            this.trackBarAlert.Size = new System.Drawing.Size(279, 45);
            this.trackBarAlert.TabIndex = 4;
            this.trackBarAlert.Scroll += new System.EventHandler(this.trackBarAlert_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alert volume";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStart.Location = new System.Drawing.Point(361, 180);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxRefresh
            // 
            this.textBoxRefresh.Location = new System.Drawing.Point(154, 59);
            this.textBoxRefresh.Name = "textBoxRefresh";
            this.textBoxRefresh.Size = new System.Drawing.Size(85, 20);
            this.textBoxRefresh.TabIndex = 8;
            this.textBoxRefresh.TextChanged += new System.EventHandler(this.textBoxRefresh_TextChanged);
            this.textBoxRefresh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRefresh_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Refresh interval (sec)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Magic current price";
            // 
            // labelMagicPrice
            // 
            this.labelMagicPrice.AutoSize = true;
            this.labelMagicPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagicPrice.Location = new System.Drawing.Point(155, 11);
            this.labelMagicPrice.Name = "labelMagicPrice";
            this.labelMagicPrice.Size = new System.Drawing.Size(39, 17);
            this.labelMagicPrice.TabIndex = 10;
            this.labelMagicPrice.Text = "price";
            // 
            // textBoxAlertTargert
            // 
            this.textBoxAlertTargert.Location = new System.Drawing.Point(154, 85);
            this.textBoxAlertTargert.Name = "textBoxAlertTargert";
            this.textBoxAlertTargert.Size = new System.Drawing.Size(85, 20);
            this.textBoxAlertTargert.TabIndex = 12;
            this.textBoxAlertTargert.TextChanged += new System.EventHandler(this.textBoxAlertTargert_TextChanged);
            this.textBoxAlertTargert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlertTargert_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Alert target";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBarAlert);
            this.panel1.Controls.Add(this.textBoxAlertTargert);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxMagicContract);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxEthContract);
            this.panel1.Controls.Add(this.textBoxRefresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 162);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelLastCheck);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelMagicPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(21, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 89);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Stop sound";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLastCheck
            // 
            this.labelLastCheck.AutoSize = true;
            this.labelLastCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastCheck.Location = new System.Drawing.Point(155, 35);
            this.labelLastCheck.Name = "labelLastCheck";
            this.labelLastCheck.Size = new System.Drawing.Size(30, 17);
            this.labelLastCheck.TabIndex = 12;
            this.labelLastCheck.Text = "last";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Last checked";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(3, 303);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(22, 13);
            this.versionLabel.TabIndex = 15;
            this.versionLabel.Text = "ver";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 318);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DexscreenerPriceAlert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlert)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMagicContract;
        private System.Windows.Forms.TextBox textBoxEthContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarAlert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMagicPrice;
        private System.Windows.Forms.TextBox textBoxAlertTargert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLastCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label versionLabel;
    }
}

