using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetoJogodaVelha
{

    public partial class frmJogodaVelha : Form
    {
        //CRIAR UMA VARIAVEL PARA A LETRA X OU O
        string letra = "X";
        public int Jogadas;
        public string ganhadorX, ganhadorO;
        public int velha;
        public int y, v, x = 0;
        public string n1;

        Nomes form2 = new Nomes();

        public frmJogodaVelha()

        {
            InitializeComponent();
            gpbBomJogo.Visible = false;
            btnReiTudo.Visible = false;
            names();

            
            pgbJogadorX.Maximum = 10;
            pgbJogadorO.Maximum = 10;
            pgbVelha.Maximum = 10;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //btn1.Text = letra;
            /*            ((Button)sender).Text = letra;
                        ((Button)sender).Enabled = false;
                        verGanhador();
                        trocarletra();
             */

            btn1.Text = letra;
            btn1.Enabled = false;
            clicarbutton(sender);
        }
        // criar um método para trocar a letra


        private void trocarletra()
        {
            


            if (letra == "X")
            {
                //SE FOR VERDADEIRO
                letra = "O";
                
                
            }
            else
            {
                //SE FOR FALSO
                letra = "X";
                


            }

        }
        public void Marcador()
        {
            
            if (btn1.Text == letra && letra == "X" && btn2.Text == letra && letra == "X" && btn3.Text == letra && letra == "X")
            {
                letra = ganhadorX;
                lblPlacarX.Text = Convert.ToString(ganhadorX);
                x += 1;
                lblPlacarX.Text = x.ToString();
                n1 = lblNomeX.Text;
                pgbJogadorX.Increment(1);
                
            }

            else if (btn1.Text == letra && letra == "X" && btn5.Text == letra && letra == "X" && btn9.Text == letra && letra == "X")
            {
                letra = ganhadorX;
                lblPlacarX.Text = Convert.ToString(ganhadorX);
                // adicionar os valores do placar do X
                x += 1;
                lblPlacarX.Text = x.ToString();
                n1 = lblNomeX.Text;
                pgbJogadorX.Increment(1);
            }

            else if (btn4.Text == letra && letra == "X" && btn5.Text == letra && letra == "X" && btn6.Text == letra && letra == "X")
            {
                letra = ganhadorX;
                lblPlacarX.Text = Convert.ToString(ganhadorX);
                x += 1;
                lblPlacarX.Text = x.ToString();
                n1 = lblNomeX.Text;
                pgbJogadorX.Increment(1);
            }
            else if (btn7.Text == letra && letra == "X" && btn8.Text == letra && letra == "X" && btn9.Text == letra && letra == "X")
            {
                letra = ganhadorX;
                lblPlacarX.Text = Convert.ToString(ganhadorX);
                x += 1;
                lblPlacarX.Text = x.ToString();
                n1 = lblNomeX.Text;
                pgbJogadorX.Increment(1);
            }

            else if (btn3.Text == letra && letra == "X" && btn5.Text == letra && letra == "X" && btn7.Text == letra && letra == "X")
            {
                letra = ganhadorX;
                lblPlacarX.Text = Convert.ToString(ganhadorX);
                x += 1;
                lblPlacarX.Text = x.ToString();
                n1 = lblNomeX.Text;
                pgbJogadorX.Increment(1);
            }
            else if (btn2.Text == letra && letra == "X" && btn5.Text == letra && letra == "X" && btn8.Text == letra && letra == "X")
            {
                letra = ganhadorX;
                lblPlacarX.Text = Convert.ToString(ganhadorX);
                x += 1;
                lblPlacarX.Text = x.ToString();
                n1 = lblNomeX.Text;
                pgbJogadorX.Increment(1);
            }
            else if (btn1.Text == letra && letra == "X" && btn5.Text == letra && letra == "X" && btn9.Text == letra && letra == "X")
            {
                letra = ganhadorX;
                lblPlacarX.Text = Convert.ToString(ganhadorX);
                x += 1;
                lblPlacarX.Text = x.ToString();
                n1 = lblNomeX.Text;
                pgbJogadorX.Increment(1);
            }
            else
            {
                // adicionar os valores do placar do placar O
                letra = ganhadorO;
                lblJogadorO.Text = Convert.ToString(ganhadorO);
                y += 1;
                lblJogadorO.Text = y.ToString();
                pgbJogadorO.Increment(1);
                n1 = lblNomeO.Text;
            }
            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            if (pgbJogadorX.Value == pgbJogadorX.Maximum)
            {
                
                MessageBox.Show("O jogador " + lblNomeX.Text + " Ganhou!!");
                Limpeza();
                Limpeza2();
                

            }
            else if (pgbJogadorO.Value == pgbJogadorO.Maximum)
            {
                MessageBox.Show("O Jogador " + lblNomeO.Text + " Ganhou!!");
                Limpeza();
                Limpeza2();
                
                
            }

        }
        
        // criar um metodo para verificar se houve ganhador
        private void verGanhador()
        {

            for (int i = 0; i < 1;)
            {


                if (letra == "X")
                {

                    n1 = lblNomeX.Text;
                    i = 1;

                }
                else if (letra == "O")
                {
                    n1 = lblNomeO.Text;
                    i = 1;
                    
                }
                else
                {
                    i = 1;
                }

            }
            // verificar se ganhou na 1° linha
            if (btn1.Text == letra && btn2.Text == letra && btn3.Text == letra)
            {// inicio do IF
                MessageBox.Show("Voce ganhou na 1º linha: " + n1 + " da letra: "+ letra + ", Parabéns!!");
                //atualizar o placar
                Marcador();
                Limpeza();




            }// fim do IF
            else if (btn1.Text == letra && btn4.Text == letra && btn7.Text == letra)
            {
                MessageBox.Show("Voce ganhou " + n1 + " da letra: " + letra + ", Parabéns!! ");
                Marcador();
                Limpeza();
            }
            else if (btn1.Text == letra && btn5.Text == letra && btn9.Text == letra)
            {
                MessageBox.Show("Voce ganhou " + n1 + " da letra: " + letra + ", Parabéns!! ");
                Marcador();
                Limpeza();

            }
            else if (btn2.Text == letra && btn5.Text == letra && btn8.Text == letra)
            {
                MessageBox.Show("Voce ganhou " + n1 + " da letra: " + letra + ", Parabéns!! ");
                Marcador();
                Limpeza();
            }
            else if (btn3.Text == letra && btn5.Text == letra && btn7.Text == letra)
            {
                MessageBox.Show("Voce ganhou " + n1 + " da letra: " + letra + ", Parabéns!! ");
                Marcador();
                Limpeza();
            }
            else if (btn4.Text == letra && btn5.Text == letra && btn6.Text == letra) // 
            {
                MessageBox.Show("Voce ganhou " + n1 + " da letra: " + letra + ", Parabéns!! ");
                Marcador();
                Limpeza();
            }
            else if (btn3.Text == letra && btn6.Text == letra && btn9.Text == letra)
            {
                MessageBox.Show("Voce ganhou " + n1 + " da letra: " + letra + ", Parabéns!! ");
                Marcador();
                Limpeza();
            }
            else if (btn7.Text == letra && btn8.Text == letra && btn9.Text == letra)
            {
                MessageBox.Show("Voce ganhou " + n1 + " da letra: " + letra + ", Parabéns!! ");
                Marcador();
                Limpeza();
            }
            else if (btn1.Text.Length != 0 && btn2.Text.Length != 0 && btn3.Text.Length != 0 && btn4.Text.Length != 0 && btn5.Text.Length != 0 && btn6.Text.Length != 0 && btn7.Text.Length != 0 && btn8.Text.Length != 0 && btn9.Text.Length != 0)
            {
                MessageBox.Show("Velhaa!!");
                if (btn1.Text.Length != 0 && btn1.Text.Length == velha) {
                    lblVelha.Text = Convert.ToString(velha);

                    velha = velha + 1;
                    

                }
                Limpeza();
                // adicionar o valor aos resultados de velha
                v += 1;
                lblVelha.Text = v.ToString();
                pgbVelha.Increment(1);
                if (pgbVelha.Value == pgbVelha.Maximum)
                {
                    MessageBox.Show("Vishh... A velha venceu!");
                    Limpeza();
                    Limpeza2();
                }


            }
            
        }
        // criar um metodo para realizar ações ao clicar em qualquer button
        private void clicarbutton(Object sender)
        {
            ((Button)sender).Text = letra;
            ((Button)sender).Enabled = false;
            verGanhador();
            trocarletra();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Nomes();
            // this.Hide();//vai “esconder” o formulário atual
            form2.ShowDialog();


              

            lblNomeX.Text = form2.Nome;

            lblNomeO.Text = form2.Nome2;
            
            gpbBomJogo.Show();
            btnReiTudo.Visible = true;
            button1.Visible = false;
            Validar();

        }
        public void Validar()
        {


            if (lblNomeX.Text != null || lblNomeO.Text != null)
            {

            }
            else
            {
                MessageBox.Show("Favor Digitar os Nomes ");
                form2.ShowDialog();

                lblNomeX.Text = form2.Nome;

                lblNomeO.Text = form2.Nome2;
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }

        private void gpbBomJogo_Enter(object sender, EventArgs e)
        {


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }

        public void names()
        {
            lblNomeX.Text = form2.Nome;
            lblNomeO.Text = form2.Nome2;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clicarbutton(sender);
        }


        // criar um metodo para limpar os objetos do jogo
        private void Limpeza()
        {
            /*           foreach (Control item in this.Controls)
                       {
                           if (item is Button)
                           {
                               item.Enabled = true;
                               item.Text = String.Empty;
                           }
                       }
                   }
            */
            // Limpezar todos os botões e deixar vazio.
            btn1.Text = String.Empty;
            btn2.Text = String.Empty;
            btn3.Text = String.Empty;
            btn4.Text = String.Empty;
            btn5.Text = String.Empty;
            btn6.Text = String.Empty;
            btn7.Text = String.Empty;
            btn8.Text = String.Empty;
            btn9.Text = String.Empty;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            Jogadas = 0;

        }
        private void Limpeza2()
        {
            x = 0;
            y = 0;
            v = 0;


            lblPlacarX.Text = x.ToString();
            lblVelha.Text = Convert.ToString(velha);
            lblJogadorO.Text = x.ToString();
            pgbJogadorX.Value = 0;
            pgbJogadorO.Value = 0;
            pgbVelha.Value = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Limpeza();
        }

        private void btnReiTudo_Click(object sender, EventArgs e)
        {
            var form2 = new Nomes();
            
            Limpeza();
            Limpeza2();

            form2.ShowDialog();

            lblNomeX.Text = form2.Nome;

            lblNomeO.Text = form2.Nome2;
            Validar();
        }

        private void pgbJogadorX_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gpbPlacarGeral_Enter(object sender, EventArgs e)
        {

        }
        private void gpbBomJogo_VisibleChanged(object sender, EventArgs e)
        {

            
        }

        private void lblPlacarX_Click(object sender, EventArgs e)
        {
            
        }

        private void rbnJogadorX_CheckedChanged(object sender, EventArgs e)
        {


        }
        

    } // fim da classe
}
   // fim do projeto
