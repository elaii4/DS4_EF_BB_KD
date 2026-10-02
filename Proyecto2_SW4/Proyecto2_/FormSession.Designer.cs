namespace Proyecto2_
{
    partial class FormSession
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblProblem = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTool = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pbAgentIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kodu";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSubtitle.Location = new System.Drawing.Point(35, 74);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(107, 23);
            this.lblSubtitle.TabIndex = 9;
            this.lblSubtitle.Text = "Sesión activa";
            // 
            // pbAgentIcon
            // 
            this.pbAgentIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbAgentIcon.Location = new System.Drawing.Point(300, 20);
            this.pbAgentIcon.Name = "pbAgentIcon";
            this.pbAgentIcon.Size = new System.Drawing.Size(60, 60);
            this.pbAgentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgentIcon.TabIndex = 1;
            this.pbAgentIcon.TabStop = false;
            this.pbAgentIcon.Image = System.Drawing.Image.FromFile(@"c:\Users\VICTUS15FB\source\repos\Proyecto2_\Proyecto2_\Resources\kodu_logo.png");
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgentName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAgentName.Location = new System.Drawing.Point(35, 110);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(142, 28);
            this.lblAgentName.TabIndex = 2;
            this.lblAgentName.Text = "Agente: Kodu";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProvider.ForeColor = System.Drawing.Color.LightGray;
            this.lblProvider.Location = new System.Drawing.Point(35, 150);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(182, 28);
            this.lblProvider.TabIndex = 3;
            this.lblProvider.Text = "Proveedor: OpenAI";
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProblem.ForeColor = System.Drawing.Color.LightGray;
            this.lblProblem.Location = new System.Drawing.Point(35, 180);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProblem.ForeColor = System.Drawing.Color.LightGray;
            this.lblProblem.Location = new System.Drawing.Point(35, 190);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(315, 28);
            this.lblProblem.TabIndex = 4;
            this.lblProblem.Text = "Especialidad: Pequeños negocios";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArea.ForeColor = System.Drawing.Color.LightGray;
            this.lblArea.Location = new System.Drawing.Point(35, 230);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(262, 28);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Área: Ventas y promociones";
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTool.ForeColor = System.Drawing.Color.LightGray;
            this.lblTool.Location = new System.Drawing.Point(35, 270);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(350, 28);
            this.lblTool.TabIndex = 5;
            this.lblTool.Text = "Herramienta: Calculadora comercial";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblStatus.Location = new System.Drawing.Point(35, 320);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(217, 28);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Estado: Sesión activa";
            // 
            // btnNewSession
            // 
            this.btnNewSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnNewSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSession.FlatAppearance.BorderSize = 0;
            this.btnNewSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSession.ForeColor = System.Drawing.Color.White;
            this.btnNewSession.Location = new System.Drawing.Point(40, 380);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(160, 45);
            this.btnNewSession.TabIndex = 7;
            this.btnNewSession.Text = "Nueva sesión";
            this.btnNewSession.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(220, 380);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(160, 45);
            this.btnConfig.TabIndex = 8;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // FormSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnNewSession);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTool);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.lblAgentName);
            this.Controls.Add(this.pbAgentIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Name = "FormSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sesión Activa";
            ((System.ComponentModel.ISupportInitialize)(this.pbAgentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox pbAgentIcon;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNewSession;
        private System.Windows.Forms.Button btnConfig;
    }
}
