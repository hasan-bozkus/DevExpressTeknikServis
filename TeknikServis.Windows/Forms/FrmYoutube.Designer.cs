namespace TeknikServis.Windows.Forms
{
    partial class FrmYoutube
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
            this.WebBrowserYoutube = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebBrowserYoutube
            // 
            this.WebBrowserYoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserYoutube.Location = new System.Drawing.Point(0, 0);
            this.WebBrowserYoutube.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserYoutube.Name = "WebBrowserYoutube";
            this.WebBrowserYoutube.Size = new System.Drawing.Size(1368, 533);
            this.WebBrowserYoutube.TabIndex = 0;
            // 
            // FrmYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.WebBrowserYoutube);
            this.Name = "FrmYoutube";
            this.Text = "Youtube";
            this.Load += new System.EventHandler(this.FrmYoutube_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowserYoutube;
    }
}