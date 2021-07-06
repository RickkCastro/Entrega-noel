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
    public partial class select_pers : Form
    {
        public select_pers()
        {
            InitializeComponent();
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                home_menu form_menu = new home_menu();
                form_menu.ShowDialog();
            }
        }

        public int num_pers = 1;
        private void select_pers_Load(object sender, EventArgs e)
        {
            perso_pictureBox.ImageLocation = ("Projeto Entrega noel/Personagens/Personagem" + num_pers + ".png");
            papai_noel_veri.LoadFile("Projeto Entrega noel/papai_noel.txt", RichTextBoxStreamType.PlainText);
        }

        private void confirmar_button_Click(object sender, EventArgs e)
        {

            if (num_pers == 4 && papai_noel_veri.Text == "false")
            {
                MessageBox.Show("Personagem bloqueado", "ops", MessageBoxButtons.OK);
            }
            else
            {
                tela_tabuleiro form_tabuleiro = new tela_tabuleiro(num_pers.ToString());
                this.Hide();
                form_tabuleiro.ShowDialog();
                Application.Exit();
            }
        }

        private void prox_button_Click(object sender, EventArgs e)
        {
            num_pers += 1;

            if (num_pers > 4)
            {
                num_pers = 1;
            }

            perso_pictureBox.ImageLocation = ("Projeto Entrega noel/Personagens/Personagem" + num_pers + ".png");
            
            if (num_pers == 4 && papai_noel_veri.Text == "false")
            {
                perso_pictureBox.ImageLocation = ("Projeto Entrega noel/Personagens/Personagem4_off.png");
            }
        }

        private void ant_button_Click(object sender, EventArgs e)
        {
            num_pers -= 1;

            if (num_pers < 1)
            {
                num_pers = 4;
            }

            perso_pictureBox.ImageLocation = ("Projeto Entrega noel/Personagens/Personagem" + num_pers + ".png");

            if (num_pers == 4 && papai_noel_veri.Text == "false")
            {
                perso_pictureBox.ImageLocation = ("Projeto Entrega noel/Personagens/Personagem4_off.png");
            }
        }
    }
}
