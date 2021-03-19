using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace Webview2CrashTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            wv2Main.EnsureCoreWebView2Async();
            wv2Main.CoreWebView2InitializationCompleted += Webviewready;
        }

        private void Webviewready(Object sender, Object e)
        {
            //wv2Main.Source = new Uri("https://google.com");
            //AddHandler WebView1.CoreWebView2.ProcessFailed, AddressOf WebviewProcessFailed
            //wv2Main.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(initscript);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChild frmChild = new frmChild();
            frmChild.Show();
        }
    }
}