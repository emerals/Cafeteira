using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFÉ
{
    public partial class CAFETEIRA : Form
    {
        public CAFETEIRA()
        {
            InitializeComponent();
            txtSaldo.Enabled = false;//Impedir que o usuário digite algo na text do saldo
            validacao();
            txtCredito.Select();//Para iniciar direto na digitação dos creditos        
        }
        //Variáveis globais
        float valorSaldo = 0;
        float troco = 0;

        //Contadores de moedas
        int conta1 = 0;
        int conta50 = 0;
        int conta25 = 0;
        int conta10 = 0;
        int conta5 = 0;

        //Saldo da máquina em moedas
        int moeda1 = 10;
        int moeda50 = 10;
        int moeda25 = 10;
        int moeda10 = 10;
        int moeda5 = 10;

        //Metódos=========================>
        public void receberValor()//Aqui eu recebo valor do txtCredito
        {
            valorSaldo += float.Parse(txtCredito.Text);//Aqui eu recebo o valor que tem dentro de txtCredito e converto para float

            if (valorSaldo <= 3.00)
            {
                txtSaldo.Text = valorSaldo.ToString("F");//txtSaldo exibi o valor de saldo "F"=(R$0.00)
                txtCredito.Text = "";//Toda vez que eu colocar o crédito,
                //é adicionado ao saldo e zerado na inserção de crédito,
                //assim o usuário poderá inserir mais  
            }
            else
            {
                MessageBox.Show("Não é possível inserir mais que R$3.00 de saldo");
                txtCredito.Text = "";
                
            }
        }

        public void VerificarValor()//Método para aceitar apenas as moedas indicadas
        {
            float moedaUmreal = 1.00f;
            float moedaCinquenta = 0.50f;
            float moedaVinteCinco = 0.25f;
            float moedaDez = 0.10f;
            float moedaCinco = 0.05f;

            if (txtCredito.Text != moedaUmreal.ToString("F") &&
                txtCredito.Text != moedaCinquenta.ToString("F") &&
                txtCredito.Text != moedaVinteCinco.ToString("F") &&
                txtCredito.Text != moedaDez.ToString("F") &&
                txtCredito.Text != moedaCinco.ToString("F"))
            {
                MessageBox.Show("VALOR INVÁLIDO!!! \nDigite apenas as moedas indicadas abaixo: \nR$1,00 \nR$0,50 \nR$0,25 \nR$0.10 \nR$0.05");
                txtCredito.Text = "";
                txtCredito.Focus();
            }

            else
            {
                receberValor();//Se der tudo certo executa isso
            }
        }    

        public void validacao()//Para o máximo de caracteres a ser digitado
        {
            txtCredito.MaxLength = 4;//Só pode ser digitado 3 digitos e a virgula
            txtTroco.Text = "0,00";
            txtSaldo.Text = "0,00";
        }      

        public void RecarregarMoedas()
        {
            
             moeda1 = 10;
             moeda50 = 10;
             moeda25 = 10;
             moeda10 = 10;
             moeda5 = 10;

            MessageBox.Show("SALDO DA MÁQUINA RECARREGADO");
        }

        public void zerarCountMoedas()
        {
            conta1 = 0;
            conta5 = 0;
            conta10 = 0;
            conta25 = 0;
            conta50 = 0;
        }

        public double passaTroco(double troco)//Método para percorrer o troco e devolver o valor certinho de moedas
        {
            if (troco != 0)
            {
                do
                {
                    troco = Math.Round(troco, 2);
                    if (troco >= 1.00)
                    {
                        troco -= 1.00f;
                        conta1++;
                        
                    }

                    else if (troco >= 0.50)
                    {
                        troco -= 0.50f;
                        conta50++;
                        
                    }

                    else if (troco >= 0.25)
                    {
                        troco -= 0.25f;
                        conta25++;
                        
                    }

                    else if (troco >= 0.10)
                    {
                        troco -= 0.10f;
                        conta10++;
                        
                    }

                    else if (troco >= 0.05)
                    {
                        troco -= 0.05f;
                        conta5++;

                    }

                    else
                    {
                        troco = 0;
                    }

                } while (troco > 0);
            }

            return troco;//Sempre retorna 0
        }

        public void devolverMoedas()//Método para mandar o troco para o cliente e subtrair do saldo da máquina
        {
            if (troco != 0)//Se o usuário tiver troco
            {
                if (moeda1 != 0 && moeda50 != 0 && moeda25 != 0 && moeda10 != 0 && moeda5 != 0)//E a máquina tiver saldo
                {
                    moeda1 -= conta1;
                    moeda50 -= conta50;
                    moeda25 -= conta25;
                    moeda10 -= conta10;
                    moeda5 -= conta5;

                    MessageBox.Show("\t<-----SEU TROCO----->\n\n" +
                        "Quantidade de moeda(s) de R$1,00:  " + conta1 + " moeda(s)" + "\n\n" +
                        "Quantidade de moeda(s) R$0.50:  " + conta50 + " moeda(s)" + "\n\n" +
                        "Quantidade de moeda(s) R$0.25:  " + conta25 + " moeda(s)" + "\n\n" +
                        "Quantidade de moeda(s) R$0.10:  " + conta10 + " moeda(s)" + "\n\n" +
                        "Quantidade de moeda(s) R$0.05:  " + conta5 + " moeda(s)" + "\n\n"
                        );


                    troco = 0;
                    txtTroco.Text = "0,00";
                    zerarCountMoedas();
                }

                else
                {
                    MessageBox.Show("<MÁQUINA SEM SALDO>\n\n Por favor, peça a um funcionário para recarregar o saldo de troco da máquina");
                }
            }

            else
            {
                MessageBox.Show("VOCÊ NÃO TEM TROCO PARA RECEBER");
            }


        }

        //EVENTOS 
        private void Beber(object sender, EventArgs e)//Evento para os quatro botôes de escolha de bebida
        {
            //Valores das bebidas
            float valorCafe = 0.50f;
            float valorCapuccino = 2.00f;
            float valorCafe_Leite = 1.00f;
            float valorChocolate = 3.00f;


            if (txtSaldo.Text == "0,00")//ValorSaldo está armazenado na memória
            {
                MessageBox.Show("Saldo insuficiente!!! \nPor favor, insira seus créditos.");//Aqui eu trato caso o usuário tente beber algo sem saldo
                txtCredito.Focus();
            }

            else
            {
                //Aqui eu pego os textos dos buttons, com as opções escolhidas pelo cliente
                if ((sender as Button).Text == "CAPUCCINO")
                {
                    if (valorSaldo < valorCapuccino)//Aqui eu trato caso o saldo do usuário seja insuficiente
                    {
                        MessageBox.Show("Saldo insuficiente, o capuccino custa " + valorCapuccino.ToString("F") + "!!" + "\nVocê tem as seguintes opções: \nInserir mais créditos e creditar o seu saldo de troco. \nReceber o saldo de troco."); //Acontece a mesma coisa com todos os outros botôes
                       
                        troco += valorSaldo;

                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";                            
                        }
                    }

                    else
                    {
                        MessageBox.Show("saboreie o seu" + " " + (sender as Button).Text+"!!");
                        valorSaldo -= valorCapuccino;
                        troco += valorSaldo;
                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";
                        }

                    }
                }


                else if ((sender as Button).Text == "CAFÉ")
                {
                    if (valorSaldo < valorCafe)
                    {
                        MessageBox.Show("Saldo insuficiente, o café custa " + valorCafe.ToString("F")+ "!!" + "\nVocê tem as seguintes opções: \nInserir mais créditos e creditar o seu saldo de troco. \nReceber o saldo de troco.");
                        troco += valorSaldo;
                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";
                        }
                    }
                    else
                    {
                        MessageBox.Show("saboreie o seu" + " " + (sender as Button).Text + "!!");
                        valorSaldo -= valorCafe;
                        troco += valorSaldo;
                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";
                        }
                    }
                }


                else if ((sender as Button).Text == "CHOCOLATE")
                {
                    if (valorSaldo < valorChocolate)
                    {
                        MessageBox.Show("Saldo insuficiente, o chocolate custa " + valorChocolate.ToString("F") + "!!" + "\nVocê tem as seguintes opções: \nInserir mais créditos e creditar o seu saldo de troco. \nReceber o saldo de troco.");
                        troco += valorSaldo;
                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";
                        }
                    }

                    else
                    {
                        MessageBox.Show("saboreie o seu" + " " + (sender as Button).Text + "!!");
                        valorSaldo -= valorChocolate;
                        troco += valorSaldo;
                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";
                        }
                    }
                }

                else if ((sender as Button).Text == "CAFÉ COM LEITE")
                {
                    if (valorSaldo < valorCafe_Leite)
                    {
                        MessageBox.Show("Saldo insuficiente, o café com leite custa " + valorCafe_Leite.ToString("F")+ "!!" + "\nVocê tem as seguintes opções: \nInserir mais créditos e creditar o seu saldo de troco. \nReceber o saldo de troco.");
                        troco += valorSaldo;
                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";
                        }
                    }
                    else
                    {
                        MessageBox.Show("saboreie o seu" + " " + (sender as Button).Text + "!!");
                        valorSaldo -= valorCafe_Leite;
                        troco += valorSaldo;
                        if (troco > 3.00)
                        {
                            MessageBox.Show("'Meu Troco' atingiu o limte. Por favor, receba/credite o saldo de 'Meu Troco'!!!");
                        }

                        else
                        {
                            txtTroco.Text = troco.ToString("F");
                            valorSaldo = 0;
                            txtSaldo.Text = "0,00";
                        }
                    }
                }
                                   
                    txtSaldo.Text = valorSaldo.ToString("F");                                 
                txtCredito.Focus();
            }
        }

        //Ações dos botões
        private void btnCreditarSaldo_Click(object sender, EventArgs e)//Botão para creditar o saldo
        {                       
                VerificarValor();///Método para pegar os créditos digitados pelo usuário
                txtCredito.Focus();            
        }

        private void ValidarCreditos(object sender, KeyPressEventArgs e)//Botão para receber o valor
        {
            if (char.IsNumber(e.KeyChar) ||//Se o caractere que eu to pressionando for uma letra ///char.Isdigite para número
                e.KeyChar == (char)(Keys.Back))

            {
                e.Handled = false;//Bloqueio desligado
                if (e.KeyChar == (char)(Keys.Back))//Aqui apago tudo, caso o usuário digite o backspace
                {
                    txtCredito.Text = "";
                }
                if(txtCredito.Text.Length == 1)//Aqui eu coloco a virgula depois da primeira casa decimal
                {
                    txtCredito.Text += ",";
                }
                txtCredito.SelectionStart = txtCredito.TextLength + 1;//Ponto inicial do texto = o tamanho do texto +1
            }
            else
            {
                e.Handled = true;//Bloqueio ligado
            }
        }

        private void FuncaoTroco(object sender, EventArgs e)//Trabalhar com o valor de troco
        {
            if ((sender as Button).Text == "Creditar Troco")//Pego o botão creditar troco
            {
                if (txtTroco.Text != "0,00")
                {
                    troco = float.Parse(txtTroco.Text);//Converto o valor que está em txtTroco

                    if (troco < 0.50)//Verifico se o valor é menor que 50 centavos
                    {
                        MessageBox.Show("Você não pode creditar um valor menor que 0,50, não há nenhuma bebida com este valor. \nPor favor, retire o saldo do meu troco em 'Receber Troco'");
                    }

                    else
                    {
                        valorSaldo += troco;//retorno o troco para o saldo 
                        txtSaldo.Text = valorSaldo.ToString("F");
                        txtTroco.Text = "0,00";
                        troco = 0.00f;
                    }
                }

                else 
                {
                    MessageBox.Show("Você não tem troco para creditar");//Para caso ele tente pegar o troco sem ter
                                                                        //Se não fizer isso meu troco irá receber 0
                }

                
            }

            if ((sender as Button).Text == "Receber Troco")//Devolução do troco
            {               
                if (moeda5 == 0 || moeda10 == 0 || moeda25 == 0 || moeda50 == 0 || moeda1 == 0)//Verificar se a máquina tem saldo para devolver
                {
                    txtCredito.Enabled = false;                   
                    MessageBox.Show("Saldo da máquina insuficiente, peça para um funcionário recarregar a máquina");
                }

                else
                {
                    txtCredito.Enabled = true;
                    troco = float.Parse(txtTroco.Text);
                    Convert.ToDouble(troco);
                    passaTroco(troco);
                    devolverMoedas();
                    zerarCountMoedas();                   
                }
            }
        }

        private void ColocarCredito(object sender, KeyEventArgs e)//Evento para apertar f1 e recarregar o saldo da máquina
        {
            if (e.KeyCode == Keys.F1)
                RecarregarMoedas();
                   
        }
      

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value = progressBar1.Value + 10;    
            }
            
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                progressBar1.Value = progressBar1.Value - 10;
            }
        }
    }
}
