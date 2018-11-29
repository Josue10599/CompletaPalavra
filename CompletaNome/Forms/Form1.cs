using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompletaNome
{
    public partial class Form1 : Form
    {
        Button[] button;
        Palavras palavra;

        public Form1()
        {
            InitializeComponent();
            button = new Button[30];
            palavra = new Palavras();
            criaBotoes();
            atualizaDados();
        }

        private void criaBotoes()
        {
            for (int i = 0, horizontal = 2; i < button.Length; i++, horizontal += 30)
            {
                button[i] = new Button();
                button[i].AutoSize = true;
                button[i].Location = new System.Drawing.Point(horizontal, 6);
                button[i].Size = new System.Drawing.Size(75, 23);
                button[i].Name = "button" + i;
                button[i].TabIndex = i;
                button[i].UseVisualStyleBackColor = true;
                button[i].Click += new System.EventHandler(this.button_Click);                
                button[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                button[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letraPressionada);
                this.panel2.Controls.Add(this.button[i]);
            }
        }

        private void desativaBotao(Button bt)
        {
            bt.Visible = false;
            bt.Enabled = false;
        }

        private void ativaBotao(Button button, string txt)
        {
            button.Visible = true;
            button.Enabled = true;
            button.Text = txt;
        }

        private string caracterAleatorio(int posicao)
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return letras[posicao].ToString();
        }

        private void atualizaDados()
        {
            lblCompleto.Text = palavra.Palavra;
            if (!lblCompleto.Text.Equals(""))
            {
                lblIncompleto.Text = palavra.palavraIncompleta();
                foreach (var bt in button)
                {
                    desativaBotao(bt);
                }
                for (int i = 0; i < palavra.retornaCaracter().Count; i++)
                {
                    ativaBotao(button[i], palavra.retornaCaracter()[i].ToString());
                }
                ArrayList sequencia = new ArrayList();
                for (int i = palavra.retornaCaracter().Count, posicao = new Random().Next(26); i < button.Length;
                    posicao = new Random().Next(26))
                {                    
                    if (!sequencia.Contains(posicao) || sequencia.Count >= 26)
                    {
                        ativaBotao(button[i], caracterAleatorio(posicao));
                        sequencia.Add(posicao);
                        i++;
                    }
                }
                button[0].Focus();
            }
            else
            {
                MessageBox.Show(Form1.ActiveForm, "Fim de jogo", "Fim");
                ActiveForm.Close();
            }            
        }

        private void button_Click(object sender, EventArgs e)
        {
            jogada(((Button)sender).Text.ToUpper());
        }

        private void letraPressionada(object sender, KeyPressEventArgs e)
        {
            jogada(e.KeyChar.ToString().ToUpper());
        }

        private void gerenciarPalavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AccessBank().Visible = true;
        }

        private void jogada(string sender)
        {
            if (sender.Equals(palavra.CaracterRemovido.ToString()))
            {
                MessageBox.Show("Parabéns");
                palavra.proximaPalavra();
                atualizaDados();
            }
            else
            {
                MessageBox.Show("Tente novamente!");
            }
        }
    }
}
