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

    public partial class AccessBank : Form
    {
        private Banco banco;
        Form form;
        
        public Object Banco { get => this.banco; }

        public AccessBank()
        {
            InitializeComponent();
            this.banco = new Banco("localhost", "3306", "bancopal", "root", "", "banpal");
            atualizaCampos();
        }

        public AccessBank(Object banco, Form form)
        {
            InitializeComponent();
            this.banco = (Banco)banco;
            this.form = form;
            form.Visible = false;
            atualizaCampos();
        }

        public void atualizaCampos()
        {
            list_id.Items.Clear();
            list_palavra.Items.Clear();
            foreach (var item in banco.LoadList(0))
            {
                list_id.Items.Add(item.ToString());
            }
            foreach (var item in banco.LoadList(1))
            {
                list_palavra.Items.Add(item.ToString());
            }
            txt_palavra.Text = "";
            txt_id.Text = "";
            atualizaBotoes();
        }

        private void atualizaBotoes()
        {
            if (txt_palavra.Text.Equals(""))
            {
                btn_Adicionar.Enabled = false;
                btn_Atualizar.Enabled = false;
                btn_Deletar.Enabled = false;
            }
            else if (list_palavra.Items.Contains(txt_palavra.Text))
            {
                txt_id.Text = (list_palavra.Items.IndexOf(txt_palavra.Text) + 1).ToString();
                btn_Adicionar.Enabled = false;
                btn_Atualizar.Enabled = true;
                btn_Deletar.Enabled = true;
            }
            else
            {
                txt_id.Text = "";
                btn_Adicionar.Enabled = true;
                btn_Atualizar.Enabled = false;
                btn_Deletar.Enabled = false;
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {            
            banco.AddWord(txt_palavra.Text);
            atualizaCampos();
        }
      
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            banco.DeleteWord(txt_id.Text);
            atualizaCampos();
        }        

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            new Forms.FormAuxiliar(txt_palavra.Text, this).ShowDialog();           
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            list_id.SelectedIndex = l.SelectedIndex;
            list_palavra.SelectedIndex = l.SelectedIndex;
            txt_palavra.Text = list_palavra.SelectedItem.ToString();
            txt_id.Text = list_id.SelectedItem.ToString();
        }

        private void txt_insira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  
            }
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                if (btn_Adicionar.Enabled)
                {
                    btn_Adicionar.Focus();
                    btn_Adicionar.Select();
                }
                else
                {
                    btn_Atualizar.Focus();
                    btn_Atualizar.Select();
                } 
            }               
        }

        private void carregaForm(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
            form.Visible = true;                        
        }

        private void txt_palavra_TextChanged(object sender, EventArgs e)
        {
            atualizaBotoes();
        }        
    }
}
