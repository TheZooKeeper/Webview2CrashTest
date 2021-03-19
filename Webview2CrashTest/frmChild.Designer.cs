
namespace Webview2CrashTest
{
    partial class frmChild
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
            this.wv2Child = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wv2Child)).BeginInit();
            this.SuspendLayout();
            // 
            // wv2Child
            // 
            this.wv2Child.CreationProperties = null;
            this.wv2Child.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv2Child.Location = new System.Drawing.Point(12, 12);
            this.wv2Child.Name = "wv2Child";
            this.wv2Child.Size = new System.Drawing.Size(776, 426);
            this.wv2Child.Source = new System.Uri("https://google.com", System.UriKind.Absolute);
            this.wv2Child.TabIndex = 0;
            this.wv2Child.ZoomFactor = 1D;
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wv2Child);
            this.Name = "frmChild";
            this.Text = "frmChild";
            ((System.ComponentModel.ISupportInitialize)(this.wv2Child)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wv2Child;
    }
}