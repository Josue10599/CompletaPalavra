namespace CompletaNome
{
    partial class AccessBank
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
            this.components = new System.ComponentModel.Container();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.txt_palavra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.list_id = new System.Windows.Forms.ListBox();
            this.list_palavra = new System.Windows.Forms.ListBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Adicionar.Enabled = false;
            this.btn_Adicionar.Location = new System.Drawing.Point(0, 198);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(302, 30);
            this.btn_Adicionar.TabIndex = 0;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // txt_palavra
            // 
            this.txt_palavra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_palavra.Location = new System.Drawing.Point(96, 27);
            this.txt_palavra.MaxLength = 30;
            this.txt_palavra.Name = "txt_palavra";
            this.txt_palavra.Size = new System.Drawing.Size(194, 29);
            this.txt_palavra.TabIndex = 1;
            this.txt_palavra.TextChanged += new System.EventHandler(this.txt_palavra_TextChanged);
            this.txt_palavra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_insira_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira a palavra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Atualizar.Enabled = false;
            this.btn_Atualizar.Location = new System.Drawing.Point(0, 228);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(302, 30);
            this.btn_Atualizar.TabIndex = 3;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.Location = new System.Drawing.Point(0, 258);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(302, 30);
            this.btn_Deletar.TabIndex = 4;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // list_id
            // 
            this.list_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_id.FormattingEnabled = true;
            this.list_id.ItemHeight = 24;
            this.list_id.Location = new System.Drawing.Point(13, 71);
            this.list_id.Name = "list_id";
            this.list_id.Size = new System.Drawing.Size(76, 124);
            this.list_id.TabIndex = 5;
            this.list_id.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // list_palavra
            // 
            this.list_palavra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_palavra.FormattingEnabled = true;
            this.list_palavra.ItemHeight = 24;
            this.list_palavra.Location = new System.Drawing.Point(96, 71);
            this.list_palavra.Name = "list_palavra";
            this.list_palavra.Size = new System.Drawing.Size(194, 124);
            this.list_palavra.TabIndex = 6;
            this.list_palavra.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(14, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(76, 29);
            this.txt_id.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AccessBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(302, 288);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.list_palavra);
            this.Controls.Add(this.list_id);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_palavra);
            this.Name = "AccessBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Palavras";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.MenuHighlight;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.carregaForm);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox txt_palavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.ListBox list_id;
        private System.Windows.Forms.ListBox list_palavra;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}