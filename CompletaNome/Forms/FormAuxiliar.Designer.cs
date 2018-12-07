namespace CompletaNome.Forms
{
    partial class FormAuxiliar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuxiliar));
            this.txbPalavra = new System.Windows.Forms.TextBox();
            this.pnlTexto = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblInformativo = new System.Windows.Forms.Label();
            this.pnlImagem = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.pnlTexto.SuspendLayout();
            this.pnlImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPalavra
            // 
            this.txbPalavra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPalavra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalavra.Location = new System.Drawing.Point(74, 42);
            this.txbPalavra.MaxLength = 250;
            this.txbPalavra.Name = "txbPalavra";
            this.txbPalavra.Size = new System.Drawing.Size(482, 26);
            this.txbPalavra.TabIndex = 0;
            // 
            // pnlTexto
            // 
            this.pnlTexto.Controls.Add(this.btnCancelar);
            this.pnlTexto.Controls.Add(this.btnSalvar);
            this.pnlTexto.Controls.Add(this.lblInformativo);
            this.pnlTexto.Controls.Add(this.txbPalavra);
            this.pnlTexto.Location = new System.Drawing.Point(12, 12);
            this.pnlTexto.MinimumSize = new System.Drawing.Size(523, 100);
            this.pnlTexto.Name = "pnlTexto";
            this.pnlTexto.Size = new System.Drawing.Size(636, 100);
            this.pnlTexto.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(386, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(74, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblInformativo
            // 
            this.lblInformativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformativo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo.Location = new System.Drawing.Point(3, 0);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(630, 34);
            this.lblInformativo.TabIndex = 1;
            this.lblInformativo.Text = "Digite a nova palavra";
            this.lblInformativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlImagem
            // 
            this.pnlImagem.AutoSize = true;
            this.pnlImagem.Controls.Add(this.btnContinuar);
            this.pnlImagem.Controls.Add(this.imagem);
            this.pnlImagem.Location = new System.Drawing.Point(3, 121);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Size = new System.Drawing.Size(96, 148);
            this.pnlImagem.TabIndex = 3;
            // 
            // btnContinuar
            // 
            this.btnContinuar.AutoSize = true;
            this.btnContinuar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinuar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContinuar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(0, 112);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(96, 36);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // imagem
            // 
            this.imagem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagem.Image = ((System.Drawing.Image)(resources.GetObject("imagem.Image")));
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.MinimumSize = new System.Drawing.Size(90, 100);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(96, 148);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagem.TabIndex = 1;
            this.imagem.TabStop = false;
            // 
            // FormAuxiliar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 271);
            this.ControlBox = false;
            this.Controls.Add(this.pnlImagem);
            this.Controls.Add(this.pnlTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(96, 148);
            this.Name = "FormAuxiliar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnlTexto.ResumeLayout(false);
            this.pnlTexto.PerformLayout();
            this.pnlImagem.ResumeLayout(false);
            this.pnlImagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPalavra;
        private System.Windows.Forms.Panel pnlTexto;
        private System.Windows.Forms.Panel pnlImagem;
        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Button btnContinuar;
    }
}