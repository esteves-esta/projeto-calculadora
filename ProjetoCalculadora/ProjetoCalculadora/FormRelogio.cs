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
    public partial class FormRelogio : Form {
        public FormRelogio()
        {
            InitializeComponent();
        }

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

        private void FormRelogio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja voltar ao menu?", "SAINDO",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.No)
            {
                //SE USUÁRIO CLICAR EM NÃO, CANCELA O FECHAMENTO
                e.Cancel = true;
            }
            else
            {
                //FormMenu fm = new FormMenu();
                //fm.Show();
                FormMenu.Menu.Show();
                //new FormMenu().Show();

            }
        }

        private void btAtiva_Click(object sender, EventArgs e)
        {
            timerRelogio.Enabled = true;
        }

        private void btDesativa_Click(object sender, EventArgs e)
        {
            timerRelogio.Enabled = false;
        }

        //EVENTO TIMER QUE USA A CLASSE DATE TIME PARA PEGAR - A HORA COM MINUTOS E SEGUNDOS
        //O DIA DA SEMANA, E A DATA
        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            //Dia da semana e HORA COM PM
            lbDia.Text = DateTime.Now.ToString("dddd").ToUpper() + ", " + DateTime.Now.ToString("hh:mm tt", 
                System.Globalization.CultureInfo.InvariantCulture);

            //HORA
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");

            //DATA COM MES ESCRITO E ANO CURTO
            lbDM.Text = DateTime.Now.ToString("d MMMM yy").ToUpper();

            //lbHora.Text = DateTime.Today.Date.ToString();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
