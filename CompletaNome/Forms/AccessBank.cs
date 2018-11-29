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
        Banco banco;
        Validate v = new Validate();
        
        public AccessBank()
        {
            InitializeComponent();
            this.banco = new Banco("localhost", "3306", "bancopal", "root", "", "banpal");
            atualizaCampos();
        }

        public AccessBank(Object banco)
        {
            InitializeComponent();
            this.banco = (Banco)banco;
            atualizaCampos();
        }

        private void atualizaCampos()
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
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {            
            v.ValidaVazio(txt_palavra,errorProvider1);
            banco.AddWord(txt_palavra.Text);
            atualizaCampos();
        }
      
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            v.ValidaVazio(txt_id, errorProvider1);
            v.ValidaVazio(txt_palavra, errorProvider1);
            banco.DeleteWord(txt_id.Text);
            atualizaCampos();
        }        

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            v.ValidaVazio(txt_id, errorProvider1);
            v.ValidaVazio(txt_palavra, errorProvider1);
            banco.UpdateWord(txt_palavra.Text,txt_id.Text);
            atualizaCampos();
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            list_id.SelectedIndex = l.SelectedIndex;
            list_palavra.SelectedIndex = l.SelectedIndex;
            txt_palavra.Text = list_palavra.SelectedItem.ToString();
            txt_id.Text = list_id.SelectedItem.ToString();
        }

        private void txt_insira_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBanco_Load(object sender, EventArgs e)
        {

        }

        private void txt_insira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar)||char.IsSeparator(e.KeyChar)||char.IsControl(e.KeyChar))
            {
                e.Handled = true;
  
            }
        }

        private void txt_CODPAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_Adicionar_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
