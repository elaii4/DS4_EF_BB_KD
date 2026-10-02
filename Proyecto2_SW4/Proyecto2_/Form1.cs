using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Conectar eventos
            this.pbLogo.Cursor = Cursors.Hand;
            this.pbLogo.Click += PbLogo_Click;
            this.btnSend.Click += BtnSend_Click;
            this.btnSettings.Click += BtnSettings_Click;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FormConfig config = new FormConfig();
            config.ShowDialog();
        }

        private void PbLogo_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de información de sesión
            FormSession session = new FormSession();
            session.ShowDialog();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            // Simular el envío de un mensaje
            if (txtMessage.Text != "Escribe tu mensaje..." && !string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                txtMessage.Text = ""; // Limpiar input
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set double buffering to avoid flickering
            this.DoubleBuffered = true;
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            if (txtMessage.Text == "Escribe tu mensaje...")
            {
                txtMessage.Text = "";
                txtMessage.ForeColor = Color.White;
            }
        }

        private void txtMessage_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                txtMessage.Text = "Escribe tu mensaje...";
                txtMessage.ForeColor = Color.LightGray;
            }
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }
    }
}
