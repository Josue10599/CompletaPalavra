using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompletaNome.Forms
{
    public partial class FormAuxiliar : Form
    {
        private string palavraNaoModificada;
        private AccessBank formPai;
        private string palavraModificada;

        public string PalavraModificada { get => this.palavraModificada; }

        public FormAuxiliar(string texto, AccessBank formPai)
        {
            InitializeComponent();
            this.formPai = formPai;
            this.palavraNaoModificada = texto;
            this.palavraModificada = texto;
            txbPalavra.Text = texto;
            pnlImagem.Hide();
        }

        public FormAuxiliar()
        {
            InitializeComponent();
            pnlTexto.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.palavraModificada = txbPalavra.Text;
            ((Banco)formPai.Banco).UpdateWord(formPai.txt_id.Text, palavraModificada);
            formPai.atualizaCampos();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPai.atualizaCampos();
            this.Close();
        }     
    }
}
