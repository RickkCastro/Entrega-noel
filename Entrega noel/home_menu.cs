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
    public partial class home_menu : Form
    {
        public home_menu()
        {
            InitializeComponent();
        }

        select_pers form_selc_pers = new select_pers(); // tela de selecionar personagem

        public void play_buttom_Click(object sender, EventArgs e) // começar a jogatt
        {
            this.Hide();
            form_selc_pers.ShowDialog();
            Application.Exit();
        }

        private void sair_button_Click(object sender, EventArgs e) // sair do jogo
        {
            Application.Exit();
        }

        private void home_menu_Load(object sender, EventArgs e) 
        {
            // tocar musiquinha
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Projeto Entrega noel/Pink-Floyd.wav";
            player.PlayLooping(); 
        }

        private void como_jogar_button_Click(object sender, EventArgs e)
        {
            // tela de como jogar
            como_jogar form_como_jogar = new como_jogar();
            this.Hide();
            form_como_jogar.ShowDialog();
            Application.Exit();
        }
    }
}
