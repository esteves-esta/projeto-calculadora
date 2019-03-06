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
    public partial class FormMenu : Form
    {
        public static FormMenu Menu;

        public FormMenu()
        {
            //nomeia este formulario como Menu
            //para poder reabri-lo nos outros formulários
            Menu = this;
            InitializeComponent();
        }
        
        //MÉTODO PARA O FORMULÁRIO NÃO PODER SER MOIDO
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


        //BOTÃO QUE REDIRECIONA PARA A CALCULADORA SIMPLES
        private void btCs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCalcS fc = new FormCalcS();
            fc.Show();
        }

        //BOTÃO QUE REDIRECIONA PARA A CALCULADORA 
        private void btCalc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCalculadora fc = new FormCalculadora();
            fc.Show();
        }

        //BOTÃO QUE REDIRECIONA PARA A RELÓGIO
        private void btRelogio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRelogio relogio = new FormRelogio();
            relogio.Show();
        }

        //METODO PARA MOSTRAR MENSAGEM SOBRE O PROGRAMA
        private void mnSobre_Click( object sender, EventArgs e ) {
            MessageBox.Show( "Programa feito em sala de aula na matéria de Desenvolvimento de Software no primeiro semestre de 2018", 
                "Sobre",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //BOTÕES PARA FECHAR O FORMULÁRIO
        private void mnSair_Click(object sender, EventArgs e)
        {
             Application.Exit(); //fecha toda a aplicação e começa a rotina abaixo de closing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //METODOS PARA FECHAMENTOS DO FORMULÁRIO
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo sair?", "SAINDO", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                //cancela o ato de fechamento desse formulario
                //se clicar no botao NO
            }

        }

    }
}
