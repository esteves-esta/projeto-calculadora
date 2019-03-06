namespace ProjetoCalculadora
{
    partial class FormRelogio
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
            this.components = new System.ComponentModel.Container();
            this.lbHora = new System.Windows.Forms.Label();
            this.btAtiva = new System.Windows.Forms.Button();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.btDesativa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.lbDM = new System.Windows.Forms.Label();
            this.lbDia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHora
            // 
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHora.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbHora.Location = new System.Drawing.Point(3, 119);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(300, 75);
            this.lbHora.TabIndex = 0;
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAtiva
            // 
            this.btAtiva.BackColor = System.Drawing.Color.Transparent;
            this.btAtiva.FlatAppearance.BorderSize = 0;
            this.btAtiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtiva.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtiva.ForeColor = System.Drawing.Color.DimGray;
            this.btAtiva.Location = new System.Drawing.Point(-3, 248);
            this.btAtiva.Name = "btAtiva";
            this.btAtiva.Size = new System.Drawing.Size(303, 52);
            this.btAtiva.TabIndex = 1;
            this.btAtiva.Text = "ATIVAR";
            this.btAtiva.UseVisualStyleBackColor = false;
            this.btAtiva.Click += new System.EventHandler(this.btAtiva_Click);
            // 
            // timerRelogio
            // 
            this.timerRelogio.Interval = 500;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // btDesativa
            // 
            this.btDesativa.BackColor = System.Drawing.Color.Transparent;
            this.btDesativa.FlatAppearance.BorderSize = 0;
            this.btDesativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesativa.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesativa.ForeColor = System.Drawing.Color.DimGray;
            this.btDesativa.Location = new System.Drawing.Point(-3, 306);
            this.btDesativa.Name = "btDesativa";
            this.btDesativa.Size = new System.Drawing.Size(309, 52);
            this.btDesativa.TabIndex = 2;
            this.btDesativa.Text = "DESATIVAR";
            this.btDesativa.UseVisualStyleBackColor = false;
            this.btDesativa.Click += new System.EventHandler(this.btDesativa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.lbHora);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 227);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.btSair);
            this.panel2.Controls.Add(this.lbDM);
            this.panel2.Controls.Add(this.lbDia);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 81);
            this.panel2.TabIndex = 2;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(262, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(37, 35);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "X";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbDM
            // 
            this.lbDM.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDM.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbDM.Location = new System.Drawing.Point(27, 42);
            this.lbDM.Name = "lbDM";
            this.lbDM.Size = new System.Drawing.Size(201, 26);
            this.lbDM.TabIndex = 1;
            // 
            // lbDia
            // 
            this.lbDia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDia.ForeColor = System.Drawing.Color.White;
            this.lbDia.Location = new System.Drawing.Point(27, 18);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(201, 26);
            this.lbDia.TabIndex = 0;
            // 
            // FormRelogio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(300, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btDesativa);
            this.Controls.Add(this.btAtiva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelogio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRelogio_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Button btAtiva;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Button btDesativa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDM;
        private System.Windows.Forms.Label lbDia;
    }
}