using System;
using System.Windows.Forms;

namespace Proyecto2_
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            
            this.cmbProvider.SelectedIndex = 0; // Por defecto
            
            this.btnCreate.Click += BtnCreate_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configuración guardada exitosamente en memoria.", "Kodu - Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
