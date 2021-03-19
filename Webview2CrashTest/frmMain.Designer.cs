
namespace Webview2CrashTest
{
    partial class frmMain
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
            this.wv2Main = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wv2Main)).BeginInit();
            this.SuspendLayout();
            // 
            // wv2Main
            // 
            this.wv2Main.CreationProperties = null;
            this.wv2Main.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv2Main.Location = new System.Drawing.Point(12, 12);
            this.wv2Main.Name = "wv2Main";
            this.wv2Main.Size = new System.Drawing.Size(776, 396);
            this.wv2Main.Source = new System.Uri("https://google.com", System.UriKind.Absolute);
            this.wv2Main.TabIndex = 0;
            this.wv2Main.ZoomFactor = 1D;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wv2Main);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wv2Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wv2Main;
        private System.Windows.Forms.Button button1;
    }
}

