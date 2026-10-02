using System;
using System.Windows.Forms;

namespace Proyecto2_
{
    public partial class FormSession : Form
    {
        public FormSession()
        {
            InitializeComponent();
            
            this.btnConfig.Click += BtnConfig_Click;
            this.btnNewSession.Click += BtnNewSession_Click;
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            FormConfig config = new FormConfig();
            config.ShowDialog();
        }

        private void BtnNewSession_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
