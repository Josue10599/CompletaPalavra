using System;
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
            atualizaDados();
        }

        private void atualizaDados()
        {
            palavra = new Palavras();
            criaBotoes();
            label1.Text = palavra.palavraIncompleta();
            label2.Text = palavra.getPalavra();
        }

        private void criaBotoes()
        {
            button = new Button[palavra.numCaracter()];
            int i = 0, horizontal = 2;
            foreach (var item in palavra.retornaCaracter())
            {
                button[i] = new Button();
                button[i].AutoSize = true;
                button[i].Location = new System.Drawing.Point(horizontal, 6);            
                button[i].Size = new System.Drawing.Size(75, 23);                
                button[i].Name = "button" + i;
                button[i].TabIndex = i;
                button[i].Text = item.ToString();
                button[i].UseVisualStyleBackColor = true;
                button[i].Click += new System.EventHandler(this.button_Click);
                button[i].Visible = true;
                button[i].Enabled = true;
                button[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                this.panel2.Controls.Add(this.button[i]);
                horizontal += 30;
                i++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals(palavra.getCaracterRemovido().ToString()))
                MessageBox.Show("Parabéns");
        }
    }
}
