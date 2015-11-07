namespace PassLib
{
    partial class GroupBoxSenhas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupBoxSenhas));
            this.boxSenha1 = new System.Windows.Forms.GroupBox();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.cbxServico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnOlho = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxSenha1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxSenha1
            // 
            this.boxSenha1.BackColor = System.Drawing.Color.Transparent;
            this.boxSenha1.Controls.Add(this.cbxUsuario);
            this.boxSenha1.Controls.Add(this.cbxServico);
            this.boxSenha1.Controls.Add(this.label4);
            this.boxSenha1.Controls.Add(this.cbxCategoria);
            this.boxSenha1.Controls.Add(this.btnOlho);
            this.boxSenha1.Controls.Add(this.btnRemove);
            this.boxSenha1.Controls.Add(this.txtSenha);
            this.boxSenha1.Controls.Add(this.label3);
            this.boxSenha1.Controls.Add(this.label2);
            this.boxSenha1.Controls.Add(this.label1);
            this.boxSenha1.ForeColor = System.Drawing.Color.White;
            this.boxSenha1.Location = new System.Drawing.Point(3, 3);
            this.boxSenha1.Name = "boxSenha1";
            this.boxSenha1.Size = new System.Drawing.Size(263, 130);
            this.boxSenha1.TabIndex = 7;
            this.boxSenha1.TabStop = false;
            this.boxSenha1.Text = "Senha 1";
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(55, 74);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(197, 21);
            this.cbxUsuario.TabIndex = 3;
            this.cbxUsuario.Leave += new System.EventHandler(this.cbxUsuario_Leave);
            // 
            // cbxServico
            // 
            this.cbxServico.FormattingEnabled = true;
            this.cbxServico.Location = new System.Drawing.Point(59, 47);
            this.cbxServico.Name = "cbxServico";
            this.cbxServico.Size = new System.Drawing.Size(193, 21);
            this.cbxServico.TabIndex = 2;
            this.cbxServico.Leave += new System.EventHandler(this.cbxServico_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(64, 20);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(164, 21);
            this.cbxCategoria.TabIndex = 1;
            this.cbxCategoria.Text = "Sem categoria";
            this.cbxCategoria.Enter += new System.EventHandler(this.cbxCategoria_Enter);
            this.cbxCategoria.Leave += new System.EventHandler(this.cbxCategoria_Leave);
            // 
            // btnOlho
            // 
            this.btnOlho.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnOlho.FlatAppearance.BorderSize = 0;
            this.btnOlho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOlho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnOlho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlho.Image = ((System.Drawing.Image)(resources.GetObject("btnOlho.Image")));
            this.btnOlho.Location = new System.Drawing.Point(230, 97);
            this.btnOlho.Name = "btnOlho";
            this.btnOlho.Size = new System.Drawing.Size(23, 23);
            this.btnOlho.TabIndex = 50;
            this.btnOlho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOlho.UseVisualStyleBackColor = true;
            this.btnOlho.Click += new System.EventHandler(this.btnOlho_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(230, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 23);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "x";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(50, 101);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(178, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviço*";
            // 
            // GroupBoxSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.boxSenha1);
            this.Name = "GroupBoxSenhas";
            this.Size = new System.Drawing.Size(266, 143);
            this.Load += new System.EventHandler(this.GroupBoxSenhas_Load);
            this.boxSenha1.ResumeLayout(false);
            this.boxSenha1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox boxSenha1;
        internal System.Windows.Forms.Button btnOlho;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.TextBox txtSenha;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cbxServico;
        internal System.Windows.Forms.ComboBox cbxUsuario;
        internal System.Windows.Forms.ComboBox cbxCategoria;

    }
}
