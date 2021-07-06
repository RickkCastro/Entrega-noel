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
    public partial class tela_tabuleiro : Form
    {
        public tela_tabuleiro()
        {
            InitializeComponent();
        }
        public tela_tabuleiro(string valor)
        {
            // trazer personagem selecionado
            InitializeComponent();
            Personagem.ImageLocation = ("Projeto Entrega noel/Personagens/Personagem" + valor + ".png"); 
        }

        int casa = 1; // casa do tabuleiro atual
        int presentes = 3; // vidas
        perguntas form_perguntas = new perguntas(); 

        private void menu_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // voltar menu
                this.Hide();
                home_menu form_menu = new home_menu();
                form_menu.ShowDialog();
            }
        }

        public void tela_tabuleiro_Load(object sender, EventArgs e)
        {
            // imagem de fundo aleatoria
            Random rnd = new Random();
            int tabuleiro_random = rnd.Next(1, 6);
            this.BackgroundImage = Image.FromFile("Projeto Entrega noel/Tabuleiro/Tabuleiro" + tabuleiro_random + ".png");
            
            Personagem.Parent = panel1;
            Personagem.Left = 0;
            Personagem.Top = 0;
        }

        private void dado_button_Click(object sender, EventArgs e)
        {
            // rolar dado
            Random rnd = new Random();
            int valor_dado = rnd.Next(1, 5);
            dado_button.BackgroundImage = Image.FromFile ("Projeto Entrega noel/dadus/dado" + valor_dado + ".jpeg");
            casa += valor_dado;

            // voltar casas
            if (casa == 32 | casa == 28 | casa == 22 | casa == 15 | casa == 9 | casa == 4)
            {
                Personagem.Parent = this.Controls["panel" + casa];
                MessageBox.Show("Você perdeu alguns presentes, volte 3 casas", "Ops!!", MessageBoxButtons.OK);
                casa -= 3;
            }

            // vencer jogo
            if (casa > 34)
            {
                // desbloquear papai noel
                papai_noel_ligar.LoadFile("Projeto Entrega noel/papai_noel.txt", RichTextBoxStreamType.PlainText);

                Personagem.Parent = panel35;
                MessageBox.Show("Você conseguiu entregar todos os presentes, você Salvou o natal!!", "Parabéns", MessageBoxButtons.OK);
                
                // mensagem de desbloqueio de personagem
                if (papai_noel_ligar.Text == "false")
                {
                    MessageBox.Show("Você Desbloqueou um novo personagem!!", "Parabéns", MessageBoxButtons.OK);
                    papai_noel_ligar.Text = "true";
                    papai_noel_ligar.SaveFile("Projeto Entrega noel/papai_noel.txt", RichTextBoxStreamType.PlainText);
                }

                this.Hide();
                home_menu form_menu = new home_menu();
                form_menu.ShowDialog();
            }

            // casas vermelhas
            if (casa == 2 | casa == 7 | casa == 10 | casa == 13 | casa == 16 | casa == 18 | casa == 19 | casa == 20 | casa == 23 | casa == 26 | casa == 31 | casa == 34)
            {
                // random para minigame ou pergunta
                Random rnd2 = new Random();
                int aleatorio = rnd2.Next(1, 46);
                Personagem.Parent = this.Controls["panel" + casa];

                // minigame
                if (aleatorio == 1 | aleatorio == 2)
                {
                    mini_game form_mini_game = new mini_game();
                    MessageBox.Show("você encontrou um presente?, o que é isso??", "!!!!", MessageBoxButtons.OK);
                    form_mini_game.ShowDialog();

                    if (form_mini_game.vitoria == false)
                    {
                        // caso acabe o tempo
                        presentes -= 1;
                        num_presentes.Text = (presentes + " / 3");
                        MessageBox.Show("Aaa não, você não clicou o suficiente e acabou perdendo um presente :(", "putsss",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // caso clique o suficiente antes do tempo acabar
                        MessageBox.Show("Uauu, você foi rápido como um jato", "Parabéns",
                        MessageBoxButtons.OK);
                    }
                }

                // pergunta
                else
                {
                    
                    MessageBox.Show("Você se perdeu, responda corretamente a pergunta, para não perder presentes", "ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    form_perguntas.ShowDialog();
                    if (form_perguntas.resposta == true)
                    {
                        // caso acerte
                        MessageBox.Show("Você acertou, continue sua jornada", "Parabéns", MessageBoxButtons.OK);
                        form_perguntas.resposta = false;
                    }
                    else
                    {
                        // caso erre
                        presentes -= 1;
                        num_presentes.Text = (presentes + " / 3");
                        MessageBox.Show("Aaa não, você errou a pergunta e acabou perdendo um presente :(", "putsss",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (presentes == 0)
                    {
                        // perder todas as vidas
                        MessageBox.Show("Você perdeu todos os presentes e não conseguiu ajudar o noel",
                        "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        home_menu form_menu = new home_menu();
                        form_menu.ShowDialog();
                    }
                }
            }
            // mover personagem
            Personagem.Parent = this.Controls["panel" + casa];
        }
    }
}
