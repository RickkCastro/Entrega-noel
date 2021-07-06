using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_noel
{
    public partial class como_jogar : Form
    {
        public como_jogar()
        {
            InitializeComponent();
        }

        int num_imagem = 1;

        private void proximo_button_Click(object sender, EventArgs e)
        {
            // proxima tela de tutorial 
            num_imagem ++;

            if (num_imagem > 5)
            {
                num_imagem = 1;
            }

            telas_box.ImageLocation = ("Projeto Entrega noel/como_jogar_" + num_imagem + ".png");
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            // voltar pro menu
            if (MessageBox.Show("Deseja voltar ao menu?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                home_menu form_menu = new home_menu();
                form_menu.ShowDialog();
            }
        }

        private void anterior_button_Click(object sender, EventArgs e)
        {
            // tela anterior de tutorial
            num_imagem--;

            if (num_imagem < 1)
            {
                num_imagem = 5;
            }

            telas_box.ImageLocation = ("Projeto Entrega noel/como_jogar_" + num_imagem + ".png");
        }
    }
}
