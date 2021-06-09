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
    public partial class Nomes : Form
    {
        public string Nome;
        public string Nome2;

        

        public Nomes()
        {
            InitializeComponent();

            



        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmJogodaVelha formInicial = new frmJogodaVelha();
            Nome = txtNome1.Text;
            Nome2 = txtNome2.Text;
            if (txtNome1.Text == "" && txtNome2.Text == "")
            {
                MessageBox.Show("Favor Preencher os Nomes ");
                
            }
            else
            {
                this.Close();
                
            }


            
            formInicial.names();
            
        }
        
        
    }
}
