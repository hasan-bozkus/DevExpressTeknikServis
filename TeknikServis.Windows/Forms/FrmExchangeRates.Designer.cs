namespace TeknikServis.Windows.Forms
{
    partial class FrmExchangeRates
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
            this.WebBrowserExchangeRates = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebBrowserExchangeRates
            // 
            this.WebBrowserExchangeRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserExchangeRates.Location = new System.Drawing.Point(0, 0);
            this.WebBrowserExchangeRates.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserExchangeRates.Name = "WebBrowserExchangeRates";
            this.WebBrowserExchangeRates.Size = new System.Drawing.Size(1368, 533);
            this.WebBrowserExchangeRates.TabIndex = 0;
            // 
            // FrmExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.WebBrowserExchangeRates);
            this.Name = "FrmExchangeRates";
            this.Text = "FrmExchangeRates";
            this.Load += new System.EventHandler(this.FrmExchangeRates_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowserExchangeRates;
    }
}