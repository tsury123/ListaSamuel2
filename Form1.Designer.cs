namespace Listinha_da_Cida_T4__VS_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lstContatos = new System.Windows.Forms.ListBox();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btmOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(127, 73);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(127, 47);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 5;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lstContatos
            // 
            this.lstContatos.FormattingEnabled = true;
            this.lstContatos.Location = new System.Drawing.Point(246, 12);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(291, 212);
            this.lstContatos.TabIndex = 6;
            this.lstContatos.SelectedIndexChanged += new System.EventHandler(this.lstContatos_SelectedIndexChanged);
            // 
            // btnAddContato
            // 
            this.btnAddContato.Location = new System.Drawing.Point(70, 144);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(157, 45);
            this.btnAddContato.TabIndex = 7;
            this.btnAddContato.Text = "Inserir Contato";
            this.btnAddContato.UseVisualStyleBackColor = true;
            this.btnAddContato.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(127, 95);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 9;
            // 
            // btmOrdenar
            // 
            this.btmOrdenar.Location = new System.Drawing.Point(246, 230);
            this.btmOrdenar.Name = "btmOrdenar";
            this.btmOrdenar.Size = new System.Drawing.Size(291, 26);
            this.btmOrdenar.TabIndex = 10;
            this.btmOrdenar.Text = "Ordenar";
            this.btmOrdenar.UseVisualStyleBackColor = true;
            this.btmOrdenar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 291);
            this.Controls.Add(this.btmOrdenar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddContato);
            this.Controls.Add(this.lstContatos);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.ListBox lstContatos;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btmOrdenar;
    }
}

