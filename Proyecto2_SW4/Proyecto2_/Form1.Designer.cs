namespace Proyecto2_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbLogo = new PictureBox();
            lblGreeting = new Label();
            lblSubtitle = new Label();
            lblCategories = new Label();
            pnlInput = new Panel();
            btnSend = new Button();
            btnSettings = new Button();
            txtMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlInput.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(330, 125);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(140, 140);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblGreeting
            // 
            lblGreeting.Anchor = AnchorStyles.None;
            lblGreeting.AutoSize = false;
            lblGreeting.BackColor = Color.Transparent;
            lblGreeting.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblGreeting.ForeColor = Color.White;
            lblGreeting.Location = new Point(100, 230);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(600, 54);
            lblGreeting.TabIndex = 1;
            lblGreeting.Text = "Hola, soy Kodu";
            lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.None;
            lblSubtitle.AutoSize = false;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 220, 255);
            lblSubtitle.Location = new Point(100, 285);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Te ayudo a tomar mejores decisiones para tu negocio.";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategories
            // 
            lblCategories.Anchor = AnchorStyles.None;
            lblCategories.AutoSize = false;
            lblCategories.BackColor = Color.Transparent;
            lblCategories.Font = new Font("Segoe UI", 10F);
            lblCategories.ForeColor = Color.LightGray;
            lblCategories.Location = new Point(100, 440);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(600, 23);
            lblCategories.TabIndex = 4;
            lblCategories.Text = "Ventas · Precios · Promociones · Clientes";
            lblCategories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            pnlInput.Anchor = AnchorStyles.None;
            pnlInput.BackColor = Color.FromArgb(40, 80, 140);
            pnlInput.Controls.Add(btnSend);
            pnlInput.Controls.Add(txtMessage);
            pnlInput.Location = new Point(100, 360);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(600, 64);
            pnlInput.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Right;
            btnSend.BackColor = Color.White;
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSend.ForeColor = Color.FromArgb(12, 34, 79);
            btnSend.Location = new Point(546, 12);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(40, 40);
            btnSend.TabIndex = 1;
            btnSend.Text = "↑";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 80, 140);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F);
            btnSettings.ForeColor = Color.LightGray;
            btnSettings.Location = new Point(730, 20);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(40, 40);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "⚙️";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // txtMessage
            // 
            txtMessage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMessage.BackColor = Color.FromArgb(40, 80, 140);
            txtMessage.BorderStyle = BorderStyle.None;
            txtMessage.Font = new Font("Segoe UI", 12F);
            txtMessage.ForeColor = Color.LightGray;
            txtMessage.Location = new Point(25, 18);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(510, 27);
            txtMessage.TabIndex = 0;
            txtMessage.Text = "Escribe tu mensaje...";
            txtMessage.Enter += txtMessage_Enter;
            txtMessage.Leave += txtMessage_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 34, 79);
            ClientSize = new Size(800, 600);
            Controls.Add(btnSettings);
            Controls.Add(lblCategories);
            Controls.Add(pnlInput);
            Controls.Add(lblSubtitle);
            Controls.Add(lblGreeting);
            Controls.Add(pbLogo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kodu Chat";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSettings;
    }
}
