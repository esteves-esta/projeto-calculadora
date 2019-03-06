namespace ProjetoCalculadora
{
    partial class FormCalculadora
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
            this.txCampo = new System.Windows.Forms.TextBox();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btDivi = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btVezes = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.btMaisMenos = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btPotencia = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.lbNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLimUm = new System.Windows.Forms.Button();
            this.Porcentagem = new System.Windows.Forms.Button();
            this.btPowN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txCampo
            // 
            this.txCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.txCampo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txCampo.Font = new System.Drawing.Font("Arial", 25F);
            this.txCampo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txCampo.Location = new System.Drawing.Point(30, 56);
            this.txCampo.MaximumSize = new System.Drawing.Size(218, 0);
            this.txCampo.MinimumSize = new System.Drawing.Size(218, 0);
            this.txCampo.Name = "txCampo";
            this.txCampo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txCampo.Size = new System.Drawing.Size(218, 39);
            this.txCampo.TabIndex = 0;
            this.txCampo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txCampo.TextChanged += new System.EventHandler(this.txCampo_TextChanged);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.White;
            this.bt7.FlatAppearance.BorderSize = 0;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt7.Location = new System.Drawing.Point(26, 223);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(50, 50);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.White;
            this.bt8.FlatAppearance.BorderSize = 0;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt8.Location = new System.Drawing.Point(82, 223);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(50, 50);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.White;
            this.bt9.FlatAppearance.BorderSize = 0;
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt9.Location = new System.Drawing.Point(138, 223);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(50, 50);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btAdd.Location = new System.Drawing.Point(194, 168);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 50);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSub
            // 
            this.btSub.BackColor = System.Drawing.Color.White;
            this.btSub.FlatAppearance.BorderSize = 0;
            this.btSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSub.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btSub.Location = new System.Drawing.Point(194, 223);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(50, 50);
            this.btSub.TabIndex = 8;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = false;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.White;
            this.bt6.FlatAppearance.BorderSize = 0;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt6.Location = new System.Drawing.Point(138, 279);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(50, 50);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.White;
            this.bt5.FlatAppearance.BorderSize = 0;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt5.Location = new System.Drawing.Point(82, 279);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(50, 50);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.White;
            this.bt4.FlatAppearance.BorderSize = 0;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt4.Location = new System.Drawing.Point(26, 279);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(50, 50);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btDivi
            // 
            this.btDivi.BackColor = System.Drawing.Color.White;
            this.btDivi.FlatAppearance.BorderSize = 0;
            this.btDivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDivi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btDivi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btDivi.Location = new System.Drawing.Point(194, 279);
            this.btDivi.Name = "btDivi";
            this.btDivi.Size = new System.Drawing.Size(50, 50);
            this.btDivi.TabIndex = 12;
            this.btDivi.Text = "÷";
            this.btDivi.UseVisualStyleBackColor = false;
            this.btDivi.Click += new System.EventHandler(this.btDivi_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.White;
            this.bt3.FlatAppearance.BorderSize = 0;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt3.Location = new System.Drawing.Point(138, 335);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(50, 50);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.White;
            this.bt2.FlatAppearance.BorderSize = 0;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt2.Location = new System.Drawing.Point(82, 335);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(50, 50);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.White;
            this.bt1.FlatAppearance.BorderSize = 0;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt1.Location = new System.Drawing.Point(26, 335);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(50, 50);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btVezes
            // 
            this.btVezes.BackColor = System.Drawing.Color.White;
            this.btVezes.FlatAppearance.BorderSize = 0;
            this.btVezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVezes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btVezes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btVezes.Location = new System.Drawing.Point(194, 335);
            this.btVezes.Name = "btVezes";
            this.btVezes.Size = new System.Drawing.Size(50, 50);
            this.btVezes.TabIndex = 16;
            this.btVezes.Text = "x";
            this.btVezes.UseVisualStyleBackColor = false;
            this.btVezes.Click += new System.EventHandler(this.btVezes_Click);
            // 
            // btPonto
            // 
            this.btPonto.BackColor = System.Drawing.Color.White;
            this.btPonto.FlatAppearance.BorderSize = 0;
            this.btPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPonto.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btPonto.Location = new System.Drawing.Point(138, 394);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(50, 50);
            this.btPonto.TabIndex = 15;
            this.btPonto.Text = ",";
            this.btPonto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPonto.UseVisualStyleBackColor = false;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // btMaisMenos
            // 
            this.btMaisMenos.BackColor = System.Drawing.Color.Transparent;
            this.btMaisMenos.FlatAppearance.BorderSize = 0;
            this.btMaisMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaisMenos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btMaisMenos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btMaisMenos.Location = new System.Drawing.Point(138, 168);
            this.btMaisMenos.Name = "btMaisMenos";
            this.btMaisMenos.Size = new System.Drawing.Size(50, 50);
            this.btMaisMenos.TabIndex = 14;
            this.btMaisMenos.Text = "±";
            this.btMaisMenos.UseVisualStyleBackColor = false;
            this.btMaisMenos.Click += new System.EventHandler(this.btMaisMenos_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.White;
            this.bt0.FlatAppearance.BorderSize = 0;
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt0.Location = new System.Drawing.Point(30, 391);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(102, 50);
            this.bt0.TabIndex = 13;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btIgual.FlatAppearance.BorderSize = 0;
            this.btIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIgual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btIgual.Location = new System.Drawing.Point(194, 394);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(50, 50);
            this.btIgual.TabIndex = 20;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btPotencia
            // 
            this.btPotencia.BackColor = System.Drawing.Color.Transparent;
            this.btPotencia.FlatAppearance.BorderSize = 0;
            this.btPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPotencia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btPotencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btPotencia.Location = new System.Drawing.Point(30, 168);
            this.btPotencia.Name = "btPotencia";
            this.btPotencia.Size = new System.Drawing.Size(50, 50);
            this.btPotencia.TabIndex = 19;
            this.btPotencia.Text = "x²";
            this.btPotencia.UseVisualStyleBackColor = false;
            this.btPotencia.Click += new System.EventHandler(this.btPotencia_Click);
            // 
            // btRaiz
            // 
            this.btRaiz.BackColor = System.Drawing.Color.Transparent;
            this.btRaiz.FlatAppearance.BorderSize = 0;
            this.btRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRaiz.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btRaiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btRaiz.Location = new System.Drawing.Point(138, 1);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(50, 50);
            this.btRaiz.TabIndex = 18;
            this.btRaiz.Text = "√";
            this.btRaiz.UseVisualStyleBackColor = false;
            this.btRaiz.Click += new System.EventHandler(this.btRaiz_Click);
            // 
            // btClean
            // 
            this.btClean.BackColor = System.Drawing.Color.Transparent;
            this.btClean.FlatAppearance.BorderSize = 0;
            this.btClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClean.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btClean.Location = new System.Drawing.Point(30, 1);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(50, 50);
            this.btClean.TabIndex = 17;
            this.btClean.Text = "C";
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lbNum.Font = new System.Drawing.Font("Arial", 10F);
            this.lbNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNum.Location = new System.Drawing.Point(27, 9);
            this.lbNum.MaximumSize = new System.Drawing.Size(220, 0);
            this.lbNum.MinimumSize = new System.Drawing.Size(220, 0);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(220, 16);
            this.lbNum.TabIndex = 21;
            this.lbNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.txCampo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 111);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btLimUm);
            this.panel2.Controls.Add(this.Porcentagem);
            this.panel2.Controls.Add(this.btRaiz);
            this.panel2.Controls.Add(this.btClean);
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 53);
            this.panel2.TabIndex = 23;
            // 
            // btLimUm
            // 
            this.btLimUm.BackColor = System.Drawing.Color.Transparent;
            this.btLimUm.FlatAppearance.BorderSize = 0;
            this.btLimUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimUm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btLimUm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btLimUm.Location = new System.Drawing.Point(82, 1);
            this.btLimUm.Name = "btLimUm";
            this.btLimUm.Size = new System.Drawing.Size(50, 50);
            this.btLimUm.TabIndex = 25;
            this.btLimUm.Text = "CE";
            this.btLimUm.UseVisualStyleBackColor = false;
            // 
            // Porcentagem
            // 
            this.Porcentagem.BackColor = System.Drawing.Color.Transparent;
            this.Porcentagem.FlatAppearance.BorderSize = 0;
            this.Porcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Porcentagem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Porcentagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Porcentagem.Location = new System.Drawing.Point(194, 0);
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(50, 50);
            this.Porcentagem.TabIndex = 24;
            this.Porcentagem.Text = "%";
            this.Porcentagem.UseVisualStyleBackColor = false;
            this.Porcentagem.Click += new System.EventHandler(this.Porcentagem_Click);
            // 
            // btPowN
            // 
            this.btPowN.BackColor = System.Drawing.Color.Transparent;
            this.btPowN.FlatAppearance.BorderSize = 0;
            this.btPowN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPowN.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btPowN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btPowN.Location = new System.Drawing.Point(86, 168);
            this.btPowN.Name = "btPowN";
            this.btPowN.Size = new System.Drawing.Size(50, 50);
            this.btPowN.TabIndex = 26;
            this.btPowN.Text = "xⁿ";
            this.btPowN.UseVisualStyleBackColor = false;
            this.btPowN.Click += new System.EventHandler(this.btPowN_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 453);
            this.Controls.Add(this.btPowN);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.btMaisMenos);
            this.Controls.Add(this.btPotencia);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btVezes);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btDivi);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txCampo;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btDivi;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btVezes;
        private System.Windows.Forms.Button btPonto;
        private System.Windows.Forms.Button btMaisMenos;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btPotencia;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLimUm;
        private System.Windows.Forms.Button Porcentagem;
        private System.Windows.Forms.Button btPowN;
    }
}