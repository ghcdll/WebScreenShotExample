using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScreenShot
{
    public partial class FromTest : Form
    {
        public FromTest()
        {
            InitializeComponent();
        }

        private void TbnSaveWithAlx_Click(object sender, EventArgs e)
        {
            WebTools.AlxWeb alxWeb = new WebTools.AlxWeb();
            lblStatus.Text = alxWeb.CreateWebsiteScreenshot(tbxResourceURL.Text, tbxSavePath.Text).ToString();
        }

        private void BtnSaveWithFreezer_Click(object sender, EventArgs e)
        {
            WebTools.FreezerLib freezerLib = new WebTools.FreezerLib();
            lblStatus.Text = freezerLib.CreateWebsiteScreenshot(tbxResourceURL.Text, tbxSavePath.Text).ToString();
        }
    }
}
