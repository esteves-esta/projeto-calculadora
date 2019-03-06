namespace ProjetoCalculadora
{
    partial class FormCalcS
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
            this.btLimpa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btMulti = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btAdi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txNum1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLimpa
            // 
            this.btLimpa.BackColor = System.Drawing.Color.Gold;
            this.btLimpa.FlatAppearance.BorderSize = 0;
            this.btLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btLimpa.Location = new System.Drawing.Point(273, 10);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(55, 55);
            this.btLimpa.TabIndex = 7;
            this.btLimpa.Text = "C";
            this.btLimpa.UseVisualStyleBackColor = false;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "1º NÚMERO";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(37, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "2º NÚMERO";
            // 
            // txNum2
            // 
            this.txNum2.BackColor = System.Drawing.Color.White;
            this.txNum2.Font = new System.Drawing.Font("Arial", 18F);
            this.txNum2.Location = new System.Drawing.Point(181, 132);
            this.txNum2.Name = "txNum2";
            this.txNum2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txNum2.Size = new System.Drawing.Size(145, 35);
            this.txNum2.TabIndex = 2;
            this.txNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txNum2.TextChanged += new System.EventHandler(this.txNum2_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "RESULTADO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.White;
            this.lbResult.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(40, 53);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(281, 61);
            this.lbResult.TabIndex = 8;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMulti
            // 
            this.btMulti.BackColor = System.Drawing.Color.Gold;
            this.btMulti.FlatAppearance.BorderSize = 0;
            this.btMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMulti.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.btMulti.Location = new System.Drawing.Point(212, 10);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(55, 55);
            this.btMulti.TabIndex = 6;
            this.btMulti.Text = "x";
            this.btMulti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMulti.UseVisualStyleBackColor = false;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btDiv
            // 
            this.btDiv.BackColor = System.Drawing.Color.Gold;
            this.btDiv.FlatAppearance.BorderSize = 0;
            this.btDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDiv.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.btDiv.Location = new System.Drawing.Point(151, 10);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(55, 55);
            this.btDiv.TabIndex = 5;
            this.btDiv.Text = "/";
            this.btDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDiv.UseVisualStyleBackColor = false;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btSub
            // 
            this.btSub.BackColor = System.Drawing.Color.Gold;
            this.btSub.FlatAppearance.BorderSize = 0;
            this.btSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSub.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold);
            this.btSub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSub.Location = new System.Drawing.Point(90, 6);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(55, 55);
            this.btSub.TabIndex = 4;
            this.btSub.Text = "-";
            this.btSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSub.UseVisualStyleBackColor = false;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btAdi
            // 
            this.btAdi.BackColor = System.Drawing.Color.Gold;
            this.btAdi.FlatAppearance.BorderSize = 0;
            this.btAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.btAdi.Location = new System.Drawing.Point(27, 215);
            this.btAdi.Name = "btAdi";
            this.btAdi.Size = new System.Drawing.Size(55, 55);
            this.btAdi.TabIndex = 3;
            this.btAdi.Text = "+";
            this.btAdi.UseVisualStyleBackColor = false;
            this.btAdi.Click += new System.EventHandler(this.btAdi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbResult);
            this.panel1.Location = new System.Drawing.Point(-2, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 125);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.btSub);
            this.panel2.Controls.Add(this.btMulti);
            this.panel2.Controls.Add(this.btDiv);
            this.panel2.Controls.Add(this.btLimpa);
            this.panel2.Location = new System.Drawing.Point(-2, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 68);
            this.panel2.TabIndex = 11;
            // 
            // txNum1
            // 
            this.txNum1.BackColor = System.Drawing.Color.White;
            this.txNum1.Font = new System.Drawing.Font("Arial", 18F);
            this.txNum1.Location = new System.Drawing.Point(181, 43);
            this.txNum1.Name = "txNum1";
            this.txNum1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txNum1.Size = new System.Drawing.Size(145, 35);
            this.txNum1.TabIndex = 1;
            this.txNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txNum1.TextChanged += new System.EventHandler(this.txNum1_TextChanged);
            // 
            // FormCalcS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(352, 401);
            this.Controls.Add(this.btAdi);
            this.Controls.Add(this.txNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNum1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalcS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalcS_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCalcS_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txNum1;
    }
}