using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webview2CrashTest
{
    public partial class frmChild : Form
    {
        public frmChild()
        {
            InitializeComponent();
            wv2Child.EnsureCoreWebView2Async();
            wv2Child.CoreWebView2InitializationCompleted += Webviewready;
        }

        private void Webviewready(Object sender, Object e)
        {
            wv2Child.Source = new Uri("https://google.com");
            //AddHandler WebView1.CoreWebView2.ProcessFailed, AddressOf WebviewProcessFailed
            //wv2Main.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(initscript);
        }

        ~frmChild()
        {
            wv2Child.Dispose();
        }
    }
}