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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        //MÉTODO QUE BLOQUEIA O MOVIMENTO DA JANELA
        //ELA SÓ FICARÁ NO CENTRO DA TELA COMO DETERMINADA NA PROPRIEDADE STARTPOSITION
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

        //METODO DE FECHAMENTO QUE CONFIRMA O FECHAMENTO
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
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
                //CONTINUA FECHAMENTO E ABRE OUTRO MENU
                //FormMenu fm = new FormMenu();
                //fm.Show();
                FormMenu.Menu.Show();
            }
        }

        //DECLARAÇÃO DAS VARIAVÉIS COM SEUS VALORES INICIAIS
        public double numConta = 0;
        public String operacao = "";

        public bool press = false; //SE O BOTÃO IGUAL FOI PRESSIONADO
        public bool pressOP = false; //SE UM BOTAO DE OPERAÇÃO FOI CLICADO

        public bool textChanged = true; 

        //METODO COM AS FUNÇÕES DOS BOTÕES QUE INCLUEM OS NÚMEROS NA CAIXA DE TEXTO
        private void inserirNumero(double numero)
        {
            //SE/IF O BOTÃO IGUAL OU ALGUM BOTÃO DE OPERAÇÃO TIVER SIDO ACIONADO ANTES
            //QUE O BOTÃO FOI CLICADO ELE IRÁ
            //RESETARÁ A CAIXA DE TEXTO
            //ANTES DE INCLUIR O NÚMERO DESEJADO
            if (press || pressOP)
            {
                txCampo.Clear();
                press = false;
                pressOP = false;
            }

            //INCLUI O CONTÉUDO QUE ESTÁ NA CAIXA DE TEXTO MAIS O NÚMERO DESEJADO
            txCampo.Text = txCampo.Text + numero;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            inserirNumero(0);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            inserirNumero(1);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            inserirNumero(2);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            inserirNumero(3);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            inserirNumero(4);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            inserirNumero(5);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            inserirNumero(6);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            inserirNumero(7);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            inserirNumero(8);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            inserirNumero(9);
        }

        //VERIFICA SE CAMPO DE TEXTO FOI MODIFICADO
        //APOS SER CLICADA UMA OPERACAO
        private void txCampo_TextChanged(object sender, EventArgs e)
        {
            //se operacao foi pressionada foir TRUE
            if (pressOP)
            {
                textChanged = true;
            }
        }

        //------------------
        //BOTÕES DE OPERAÇÃO
        //-------------------

        //BOTÃO DE LIMPAR-------------
        //RESETA A CAIXA DE TEXTO
        //RESETA A VAR QUE ARMAZENA OS NÚMEROS
        //RESETA A VAR QUE ARMAZENA A OPERACAO
        //RESETA O LABEL QUE MOSTRA O HISTÓRICO AS OPERAÇÕES FEITAS
        private void btClean_Click(object sender, EventArgs e)
        {
            txCampo.Clear();
            numConta = 0;
            operacao = "";
            lbNum.Text = "";
        }


        //BOTAO DE PORCENTAGEM----------
        //VERIFICA SE EXISTE UM NUMERO ANTEIROR ARMAZENADO
        //SE NEGATIVO VOLTA ZERO
        //DO CONTRARIO REALIZA CALCULO DA PORCENTAGEM
        private void Porcentagem_Click(object sender, EventArgs e)
        {
            if (numConta == 0)
            {
                txCampo.Text = "0";
            }
            else
            {
                txCampo.Text = ((numConta / 100) * Convert.ToDouble(txCampo.Text)).ToString();
            }
        }


        //BOTAO MAIS E MENOS------------
        //SE CONTEÚDO DA CAIXA DE TEXTO TIVER VALOR 
        //IRÁ CONVERTER EM NÚMERO E MULTIPLICAR POR -1
        //PARA IR TROCANDO DE SINAL
        private void btMaisMenos_Click(object sender, EventArgs e)
        {
            if (txCampo.Text != "")
                txCampo.Text = (Convert.ToDouble(txCampo.Text) * -1).ToString();
        }

        //BOTAO DE VIRGULA-------------
        //SE CONTEÚDO DA CAIXA DE TEXTO
        //NÃO CONTER VIRGULA IRÁ ADICIONAR
        private void btPonto_Click(object sender, EventArgs e)
        {
            if (txCampo.Text != "") {
                if (!(txCampo.Text.Contains(",")))
                {
                    txCampo.Text = txCampo.Text + ",";
                }
            }
        }

        //BOTÃO RAIZ QUADRADA-----------
        //UTILIZA METODO DA CLASSE MATH PARA REALIZAR OPERAÇÃO
        //ARMAZENA NO LABEL
        private void btRaiz_Click(object sender, EventArgs e)
        {
            if(txCampo.Text != ""){
                lbNum.Text = "√" + txCampo.Text + " ";

                txCampo.Text = Math.Sqrt(Convert.ToDouble(txCampo.Text)).ToString();
            }
        }

        //BOTÃO POTÊNCIA------------------
        //UTILIZA METODO DA CLASSE MATH PARA REALIZAR OPERAÇÃO
        //ARMAZENA NO LABEL
        private void btPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                lbNum.Text = txCampo.Text + " ^ " + 2 + " ";

                txCampo.Text = Math.Pow(Convert.ToDouble(txCampo.Text), 2).ToString();
            }
            catch (FormatException)
            {
            }
        }

        //BOTÃO POTÊNCIA Á N-------------------
        //UTILIZA METODO DA CLASSE MATH PARA REALIZAR OPERAÇÃO
        //ARMAZENA PRIMEIRO NUMERO EM NUMCONTA 
        //NO SEGUNDO CLIQUE REALIZA CONTA
        private void btPowN_Click(object sender, EventArgs e)
        {
            try
            {
                if (numConta == 0)
                {
                    numConta = Convert.ToDouble(txCampo.Text);
                    lbNum.Text = txCampo.Text + " ^ ";
                }
                else
                {
                    lbNum.Text = lbNum.Text + txCampo.Text;
                    txCampo.Text = Math.Pow(numConta, Convert.ToDouble(txCampo.Text)).ToString();
                }

                pressOP = true;
            }
            catch (FormatException)
            {
            }
        }

        //-----------------
        //BOTÃO MAIS / MENOS / DIVIDIR / MULTIPLICAR 
        //---------------

        //DENTRO DE TRY E CATCH PARA EVITAR ERROS 
        //QUANDO A CAIXA DE TEXTO ESTIVER VAZIA

        //SE USUÁRIOS JÁ CLICOU EM UMA OUTRA OPERAÇÃO 
        //ELE VERIFICA E SE NECESSÁRIO E CLICA NO BOTÃO IGUAL

        //DEPOIS ELE ARMAZENA O NÚMERO EM NUMCONTA
        //E SE O BOTÃO FOR CLICADO NOVAMENTE ELE REALIZARÁ A CONTA
        //ELE TAMBÉM VERIFICA SE O NUMERO FOI MUDADO 
        //PARA EVITAR QUE USUÁRIO REALIZE A OPERAÇÃO COM O RESULTADO SEM QUERER
       
        private void btAdd_Click(object sender, EventArgs e)
        {
            
            try {
                if (operacao != "" && operacao != "+")
                {
                    btIgual.PerformClick();
                }

                operacao = "+";

                if (numConta == 0)
                {
                    numConta = Convert.ToDouble(txCampo.Text);
                    //SE ELE FOI PARA O BOTAO IGUAL MOSTRA OS NUMEROS ANTERIORES
                    //E O RESULTADO NA CAIXA DE TEXTO
                    if (lbNum.Text != "")
                    {
                        lbNum.Text = lbNum.Text;
                    }
                    else
                    {
                        //SE NÃO RESETA A CAIXA DE TEXTO E O LABEL
                        txCampo.Clear();
                        lbNum.Text = numConta.ToString();
                    }
                }
                else if(textChanged)
                {
                    numConta = numConta + Convert.ToDouble(txCampo.Text);
                   
                    lbNum.Text = lbNum.Text + " + " + txCampo.Text + " ";
                    txCampo.Text = numConta.ToString();
                    textChanged = false;
                }
                
                pressOP = true;
            }
              catch (FormatException)
            {
            }
        }

        //BOTAO MENOS-----------------
        private void btSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao != "" && operacao != "-")
                {
                    btIgual.PerformClick();
                }

                operacao = "-";

                if (numConta == 0)
                {
                    numConta = Convert.ToDouble(txCampo.Text);
                    if (lbNum.Text != "")
                    {
                        lbNum.Text = lbNum.Text;
                    }
                    else
                    {
                        txCampo.Clear();
                        lbNum.Text = numConta.ToString();
                    }
                }
                else if (textChanged)
                {
                    numConta = numConta - double.Parse(txCampo.Text);
                    lbNum.Text = lbNum.Text + " - " + txCampo.Text + " ";
                    txCampo.Text = numConta.ToString();
                    textChanged = false;
                }

               
                pressOP = true;
            }
            catch (FormatException)
            {
            }
        }

        //BOTAO DIVIDIR----------------
        private void btDivi_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao != "" && operacao != "/")
                {
                    btIgual.PerformClick();
                }

                operacao = "/";

                if (numConta == 0)
                {
                    numConta = Convert.ToDouble(txCampo.Text);
                    if (lbNum.Text != "")
                    {
                        lbNum.Text = lbNum.Text;
                    }
                    else
                    {
                        txCampo.Clear();
                        lbNum.Text = numConta.ToString();
                    }
                }
                else if(textChanged)
                {
                    numConta = numConta / double.Parse(txCampo.Text);
                    lbNum.Text = lbNum.Text + " ÷ " + txCampo.Text + " ";
                    txCampo.Text = numConta.ToString();
                    textChanged = false;
                }

                
                pressOP = true;
            }
            catch (FormatException)
            {
            }
        }

        //BOTAO MULTIPLICAR--------------
        private void btVezes_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao != "" && operacao != "*")
                {
                    btIgual.PerformClick();
                }

                operacao = "*";

                if (numConta == 0)
                {
                    numConta = Convert.ToDouble(txCampo.Text);
                    if (lbNum.Text != "")
                    {
                        lbNum.Text = lbNum.Text;
                    }
                    else
                    {
                        txCampo.Clear();
                        lbNum.Text = numConta.ToString();
                    }
                }
                else if (textChanged)
                {
                    numConta = numConta * double.Parse(txCampo.Text);
                    lbNum.Text = lbNum.Text + " x " + txCampo.Text + " ";
                    txCampo.Text = numConta.ToString();
                    textChanged = false;
                }
                
                pressOP = true;
            }
            catch (FormatException)
            {
            }
        }

        //------------
        //BOTAO IGUAL
        //------------
        //EM UM SWITCH CASE VERIFICA O VALOR DA VARIAVEL OPERACAO
        //E REALIZA A OPERACAO APROPRIADA
        //SE USUARIO CLICOU EM IGUAL COM CAIXA DE TEXTO VAZIA
        //ELE CAI NO BLOCO CATCH, AVISA E ACIONA BOTAO LIMPAR
        //DEPOIS LIMPA O VALOR DE NUMCONTA
        //E RESETA VALORES BOLEANOS E VARIAVEL OPERACAO
        private void btIgual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operacao)
                {
                    case "+":
                        lbNum.Text = lbNum.Text + " + " + txCampo.Text;
                        numConta = numConta + double.Parse(txCampo.Text);
                        break;
                    case "-":
                        lbNum.Text = lbNum.Text + " - " + txCampo.Text;
                        numConta = numConta - double.Parse(txCampo.Text);
                        break;
                    case "/":
                        lbNum.Text = lbNum.Text + " ÷ " + txCampo.Text;
                        numConta = numConta / double.Parse(txCampo.Text);
                        break;
                    case "*":
                        lbNum.Text = lbNum.Text + " x " + txCampo.Text;
                        numConta = numConta * double.Parse(txCampo.Text);
                        break;
                    default:
                        break;
                }
            txCampo.Text = numConta.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de formato, Tente Novamente.");
                btClean.PerformClick();
            }
            
            operacao = "";
            numConta = 0;
            press = true;
            pressOP = false;
        }
    }
}
