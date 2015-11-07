namespace PassLib
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopiaSenha = new System.Windows.Forms.Button();
            this.btnCopiaUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxServico = new System.Windows.Forms.ComboBox();
            this.chkExibe = new System.Windows.Forms.CheckBox();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnIsere = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.footer1 = new PassLib.footer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxCategoria);
            this.groupBox1.Controls.Add(this.btnCopiaSenha);
            this.groupBox1.Controls.Add(this.btnCopiaUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxServico);
            this.groupBox1.Controls.Add(this.chkExibe);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Senhas armazenadas";
            // 
            // btnCopiaSenha
            // 
            this.btnCopiaSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopiaSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCopiaSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCopiaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCopiaSenha.Location = new System.Drawing.Point(218, 140);
            this.btnCopiaSenha.Name = "btnCopiaSenha";
            this.btnCopiaSenha.Size = new System.Drawing.Size(75, 23);
            this.btnCopiaSenha.TabIndex = 8;
            this.btnCopiaSenha.Text = "Copiar";
            this.btnCopiaSenha.UseVisualStyleBackColor = true;
            // 
            // btnCopiaUsuario
            // 
            this.btnCopiaUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopiaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCopiaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCopiaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCopiaUsuario.Location = new System.Drawing.Point(58, 140);
            this.btnCopiaUsuario.Name = "btnCopiaUsuario";
            this.btnCopiaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCopiaUsuario.TabIndex = 7;
            this.btnCopiaUsuario.Text = "Copiar";
            this.btnCopiaUsuario.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(190, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(133, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário";
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.Location = new System.Drawing.Point(9, 114);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.ReadOnly = true;
            this.cbxUsuario.Size = new System.Drawing.Size(175, 20);
            this.cbxUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serviço";
            // 
            // cbxServico
            // 
            this.cbxServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServico.FormattingEnabled = true;
            this.cbxServico.Location = new System.Drawing.Point(9, 72);
            this.cbxServico.Name = "cbxServico";
            this.cbxServico.Size = new System.Drawing.Size(175, 21);
            this.cbxServico.TabIndex = 1;
            // 
            // chkExibe
            // 
            this.chkExibe.AutoSize = true;
            this.chkExibe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkExibe.Location = new System.Drawing.Point(210, 72);
            this.chkExibe.Name = "chkExibe";
            this.chkExibe.Size = new System.Drawing.Size(83, 17);
            this.chkExibe.TabIndex = 0;
            this.chkExibe.Text = "Exibir senha";
            this.chkExibe.UseVisualStyleBackColor = true;
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.Color.Transparent;
            this.btnExclui.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExclui.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExclui.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExclui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExclui.ForeColor = System.Drawing.Color.White;
            this.btnExclui.Location = new System.Drawing.Point(238, 208);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(102, 30);
            this.btnExclui.TabIndex = 1;
            this.btnExclui.Text = "Excluir";
            this.btnExclui.UseVisualStyleBackColor = false;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Transparent;
            this.btnModifica.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnModifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(118, 208);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(114, 30);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = false;
            // 
            // btnIsere
            // 
            this.btnIsere.BackColor = System.Drawing.Color.Transparent;
            this.btnIsere.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnIsere.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnIsere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnIsere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnIsere.ForeColor = System.Drawing.Color.White;
            this.btnIsere.Location = new System.Drawing.Point(10, 208);
            this.btnIsere.Name = "btnIsere";
            this.btnIsere.Size = new System.Drawing.Size(102, 30);
            this.btnIsere.TabIndex = 3;
            this.btnIsere.Text = "Inserir";
            this.btnIsere.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(136, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "PassLib";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnSai
            // 
            this.btnSai.BackColor = System.Drawing.Color.DarkRed;
            this.btnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSai.Font = new System.Drawing.Font("Lucida Console", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSai.ForeColor = System.Drawing.Color.White;
            this.btnSai.Location = new System.Drawing.Point(323, 9);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(17, 17);
            this.btnSai.TabIndex = 28;
            this.btnSai.Text = "X";
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Todas as senhas"});
            this.cbxCategoria.Location = new System.Drawing.Point(106, 19);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(175, 21);
            this.cbxCategoria.TabIndex = 9;
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.DarkRed;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 244);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(351, 23);
            this.footer1.TabIndex = 29;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(351, 267);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.btnSai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIsere);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModifica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCopiaSenha;
        private System.Windows.Forms.Button btnCopiaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cbxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxServico;
        private System.Windows.Forms.CheckBox chkExibe;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnIsere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSai;
        private footer footer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}

