using CompletaNome.Forms;
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
            if (palavra.Palavra.Equals(""))
            {
                this.Enabled = false;
                this.Visible = false;
                new AccessBank(palavra.Banco, this).Visible = true;                
            }
            else
            {
                criaBotoes();
                atualizaDados();
            }    
        }

        private void criaBotoes()
        {
            for (int i = 0, horizontal = 2, vertical = 100; i < button.Length; i++)
            {
                button[i] = new Button();
                button[i].AutoSize = true;
                button[i].Location = new System.Drawing.Point(horizontal, vertical);
                button[i].Size = new System.Drawing.Size(75, 23);
                button[i].Name = "button" + i;
                button[i].TabIndex = i;
                button[i].UseVisualStyleBackColor = true;
                button[i].Click += new System.EventHandler(this.button_Click);                
                button[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
                button[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letraPressionada);
                button[i].Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.panel2.Controls.Add(this.button[i]);
                if (i == 9 || i == 19)
                {
                    vertical += 70;
                    horizontal = 2;
                }
                else
                {
                    horizontal += 80;
                }
                    
            }
        }

        private void desativaBotao(Button bt)
        {
            bt.Visible = false;
            bt.Enabled = false;
        }

        private void desativaBotao()
        {
            foreach (var bt in button)
            {
                desativaBotao(bt);
            }
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

        private bool atualizaDados()
        {
            lblCompleto.Text = palavra.Palavra;
            if (!lblCompleto.Text.Equals(""))
            {
                lblIncompleto.Text = palavra.palavraIncompleta();
                desativaBotao();
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
                return true;
            }
            else
            {
                MessageBox.Show(Form1.ActiveForm, "Fim de jogo", "Fim");
                this.Close();
                return false;
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
            new AccessBank(palavra.Banco, this).Visible = true;
        }

        private void jogada(string sender)
        {
            if (sender.Equals(palavra.CaracterRemovido.ToString()))
            {                
                FormAuxiliar formAuxiliar = new FormAuxiliar();
                formAuxiliar.Show();
                this.Visible = false;
                MessageBox.Show("Parabéns");
                palavra.proximaPalavra();
                if (atualizaDados())
                {
                    formAuxiliar.Close();
                    this.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Tente novamente!");
            }
        }
    }
}
