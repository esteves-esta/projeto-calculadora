using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class FormCalcS : Form
    {
        public FormCalcS()
        {
            InitializeComponent();
        }

        public double num1, num2;

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref message);
        }

        //CONVERTE OS NÚMEROS INSERIDOS PARA DOUBLE ASSIM QUE O TEXTO FOR INSERIDO
        private void txNum1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txNum1.Text);
        }

        private void txNum2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txNum2.Text);
        }

        //BOTÃO DE ADIÇÃO
        private void btAdi_Click(object sender, EventArgs e)
        {
            lbResult.Text = (num1 + num2).ToString();
        }

        //BOTÃO DE SUBTRAÇÃO
        private void btSub_Click(object sender, EventArgs e)
        {
            lbResult.Text = (num1 - num2).ToString();
        }

        //BOTÃO DE MULTIPLICAÇÃO
        private void btMulti_Click(object sender, EventArgs e)
        {
            lbResult.Text = (num1 * num2).ToString();
        }

        //BOTÃO DE DIVISÃO
        private void btDiv_Click(object sender, EventArgs e)
        {
            lbResult.Text = (num1 / num2).ToString();
        }

        //BOTÃO PARA FECHAR O FORMULÁRIO E ABRIR NOVAMENTE O MENU
        private void FormCalcS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja voltar ao menu?", "SAINDO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //FormMenu fm = new FormMenu();
                //fm.Show();
                FormMenu.Menu.Show();
            }
        }

        //METODO PARA FAZER O CLIQUE DO ENTER IR PARA O PRÓXIMO CAMPO
        private void FormCalcS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

                //O código e!.Shift indica que é para mudar para o próximo campo 
                //se pressionando ENTER, e ir para o campo anterior  se pressionado
                //SHIT + ENTER simultaneamente
            }
        }

        //BOTÃO QUE LIMPA AS CAIXA DE TEXTO E MANTEM O FOCO NA PRIMEIRA CAIXA DE TEXTO
        private void btLimpa_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            txNum1.Text = Convert.ToDouble(0).ToString();
            txNum2.Text = Convert.ToDouble(0).ToString();
            txNum1.Focus();
        }





    }
}
