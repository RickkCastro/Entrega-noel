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
    public partial class mini_game : Form
    {
        public mini_game()
        {
            InitializeComponent();
        }

        int tempo = 15; // var do tempo 
        Random rnd = new Random(); // random de cliques
        int clique; // var do num de cliques necessario 
        public bool vitoria = false; // var para vitoria ou derrota

        private void click_button_Click(object sender, EventArgs e)
        {
            // cada fez clicada no botao
            clique -= 1;
            num_cliques.Text = clique.ToString() + " cliques";
            
            // se todos os cliques acabarem
            if (clique <= 0)
            {
                this.Close();
                vitoria = true;
            }
        }

        private void mini_game_Load(object sender, EventArgs e)
        {
            // ativa timer e randomifica o num de cliques
            timer1.Enabled = true;
            clique = rnd.Next(30, 55);
            num_cliques.Text = clique.ToString() + " cliques";
            timer.Text = tempo.ToString() + " seg";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // cada 1 seg
            tempo -= 1;
            timer.Text = tempo.ToString() + " seg";

            // se o tempo acabar
            if (tempo <= 0)
            {
                this.Close();
            }
        }
    }
}
