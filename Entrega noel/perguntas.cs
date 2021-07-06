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
    public partial class perguntas : Form
    {
        public perguntas()
        {
            InitializeComponent();
        }

        public bool resposta = false; // var de resposta certa ou errada
        int num_resp; // num da resposta certa

        public void perguntas_Load(object sender, EventArgs e)
        {
            // carregar a pergunta
            perguntas_box.LoadFile ("Projeto Entrega noel/perguntas.txt", RichTextBoxStreamType.PlainText);

            // randomificar a pergunta
            Random rnd = new Random();
            int num_pergunta = rnd.Next(1, 41);

            // separar a pergunta em partes
            String[] pergunta_final = perguntas_box.Lines[num_pergunta].Split('#');

            // se for ativa a pergunta
            if (pergunta_final[7] == "a")
            {
                label_pergunta.Text = pergunta_final[1];
                resposta1.Text = pergunta_final[2];
                resposta2.Text = pergunta_final[3];
                resposta3.Text = pergunta_final[4];
                resposta4.Text = pergunta_final[5];
                num_resp = int.Parse(pergunta_final[6]);

                String dados_novos = ("#" + pergunta_final[1] + "#" + pergunta_final[2] + "#" + pergunta_final[3] + "#" + pergunta_final[4] + "#" +
                pergunta_final[5] + "#" + pergunta_final[6] + "#d");

                String dados_antigos = perguntas_box.Lines[num_pergunta];

                perguntas_box.Text = perguntas_box.Text.Replace(dados_antigos, dados_novos);
            }

            // se estiver desativada
            else
            {
                // loop ate a pergunta ser ativa
                while (pergunta_final[7] != "a")
                {
                    num_pergunta = rnd.Next(1, 41);
                    pergunta_final = perguntas_box.Lines[num_pergunta].Split('#');
                }

                // colocar a pergunta na tela
                label_pergunta.Text = pergunta_final[1];
                resposta1.Text = pergunta_final[2];
                resposta2.Text = pergunta_final[3];
                resposta3.Text = pergunta_final[4];
                resposta4.Text = pergunta_final[5];
                num_resp = int.Parse(pergunta_final[6]);

                // modificar a pergunta para desativada 
                String dados_novos = ("#" + pergunta_final[1] + "#" + pergunta_final[2] + "#" + pergunta_final[3] + "#" + pergunta_final[4] + "#" +
                pergunta_final[5] + "#" + pergunta_final[6] + "#d");

                String dados_antigos = perguntas_box.Lines[num_pergunta];

                perguntas_box.Text = perguntas_box.Text.Replace(dados_antigos, dados_novos);
            }
        }

        public void confirmar_button_Click(object sender, EventArgs e)
        {
            // checar se a pergunta selecionada foi a correta
            if (resposta1.Checked == true && num_resp == 1)
            {
                resposta = true;
            }

            else if (resposta2.Checked == true && num_resp == 2)
            {
                resposta = true;
            }

            else if (resposta3.Checked == true && num_resp == 3)
            {
                resposta = true;
            }

            else if (resposta4.Checked == true && num_resp == 4)
            {
                resposta = true;
            }

            this.Close();
            resposta1.Checked = true;
        }
    }
}
