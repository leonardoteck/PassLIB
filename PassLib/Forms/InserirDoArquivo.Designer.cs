namespace PassLib
{
    partial class InserirDoArquivo
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbSepChar = new System.Windows.Forms.RadioButton();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.numSenha = new System.Windows.Forms.NumericUpDown();
            this.numUsuario = new System.Windows.Forms.NumericUpDown();
            this.numServico = new System.Windows.Forms.NumericUpDown();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.rdbSepLinha = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxChar = new System.Windows.Forms.ComboBox();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.chkCategoria = new System.Windows.Forms.CheckBox();
            this.numCategoria = new System.Windows.Forms.NumericUpDown();
            this.chkSenha = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkServico = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imgAlerta4 = new System.Windows.Forms.PictureBox();
            this.imgAlerta3 = new System.Windows.Forms.PictureBox();
            this.imgAlerta2 = new System.Windows.Forms.PictureBox();
            this.imgAlerta1 = new System.Windows.Forms.PictureBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnImporta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkExemplo = new System.Windows.Forms.LinkLabel();
            this.toolTipAlerta1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServico)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCategoria)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.Black;
            this.btnAbrir.Location = new System.Drawing.Point(229, 263);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(25, 22);
            this.btnAbrir.TabIndex = 11;
            this.btnAbrir.Text = "...";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(6, 265);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(217, 20);
            this.txtDiretorio.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço do arquivo:";
            // 
            // rdbSepChar
            // 
            this.rdbSepChar.AutoSize = true;
            this.rdbSepChar.Location = new System.Drawing.Point(6, 42);
            this.rdbSepChar.Name = "rdbSepChar";
            this.rdbSepChar.Size = new System.Drawing.Size(121, 17);
            this.rdbSepChar.TabIndex = 12;
            this.rdbSepChar.TabStop = true;
            this.rdbSepChar.Text = "Itens separados por:";
            this.rdbSepChar.UseVisualStyleBackColor = true;
            this.rdbSepChar.CheckedChanged += new System.EventHandler(this.rdbSepChar_CheckedChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.Gray;
            this.lblSenha.Location = new System.Drawing.Point(6, 99);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.Gray;
            this.lblUsuario.Location = new System.Drawing.Point(6, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.ForeColor = System.Drawing.Color.Gray;
            this.lblServico.Location = new System.Drawing.Point(6, 47);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 21;
            this.lblServico.Text = "Serviço";
            // 
            // numSenha
            // 
            this.numSenha.Enabled = false;
            this.numSenha.Location = new System.Drawing.Point(64, 97);
            this.numSenha.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSenha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSenha.Name = "numSenha";
            this.numSenha.Size = new System.Drawing.Size(30, 20);
            this.numSenha.TabIndex = 20;
            this.numSenha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSenha.ValueChanged += new System.EventHandler(this.numSenha_ValueChanged);
            // 
            // numUsuario
            // 
            this.numUsuario.Enabled = false;
            this.numUsuario.Location = new System.Drawing.Point(64, 71);
            this.numUsuario.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUsuario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUsuario.Name = "numUsuario";
            this.numUsuario.Size = new System.Drawing.Size(30, 20);
            this.numUsuario.TabIndex = 19;
            this.numUsuario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUsuario.ValueChanged += new System.EventHandler(this.numUsuario_ValueChanged);
            // 
            // numServico
            // 
            this.numServico.Enabled = false;
            this.numServico.Location = new System.Drawing.Point(64, 45);
            this.numServico.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numServico.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServico.Name = "numServico";
            this.numServico.Size = new System.Drawing.Size(30, 20);
            this.numServico.TabIndex = 18;
            this.numServico.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServico.ValueChanged += new System.EventHandler(this.numServico_ValueChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.Gray;
            this.lblCategoria.Location = new System.Drawing.Point(6, 21);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Categoria";
            // 
            // rdbSepLinha
            // 
            this.rdbSepLinha.AutoSize = true;
            this.rdbSepLinha.Checked = true;
            this.rdbSepLinha.Location = new System.Drawing.Point(6, 19);
            this.rdbSepLinha.Name = "rdbSepLinha";
            this.rdbSepLinha.Size = new System.Drawing.Size(148, 17);
            this.rdbSepLinha.TabIndex = 13;
            this.rdbSepLinha.TabStop = true;
            this.rdbSepLinha.Text = "Itens separados por linhas";
            this.rdbSepLinha.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxChar);
            this.groupBox2.Controls.Add(this.rdbSepLinha);
            this.groupBox2.Controls.Add(this.rdbSepChar);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formato do texto no arquivo";
            // 
            // cbxChar
            // 
            this.cbxChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChar.Enabled = false;
            this.cbxChar.FormattingEnabled = true;
            this.cbxChar.Items.AddRange(new object[] {
            ", (Vírgula)",
            "; (Ponto-e-vírgula)",
            "- (Traço)",
            ". (Ponto)",
            "/ (Barra)",
            "\\ (Barra invertida)",
            "_ (Underline)"});
            this.cbxChar.Location = new System.Drawing.Point(130, 41);
            this.cbxChar.Name = "cbxChar";
            this.cbxChar.Size = new System.Drawing.Size(112, 21);
            this.cbxChar.TabIndex = 14;
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.Location = new System.Drawing.Point(6, 72);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(67, 17);
            this.chkUsuario.TabIndex = 1;
            this.chkUsuario.Text = "Usuários";
            this.chkUsuario.UseVisualStyleBackColor = true;
            this.chkUsuario.CheckedChanged += new System.EventHandler(this.chkUsuario_CheckedChanged);
            // 
            // chkCategoria
            // 
            this.chkCategoria.AutoSize = true;
            this.chkCategoria.Location = new System.Drawing.Point(6, 20);
            this.chkCategoria.Name = "chkCategoria";
            this.chkCategoria.Size = new System.Drawing.Size(76, 17);
            this.chkCategoria.TabIndex = 0;
            this.chkCategoria.Text = "Categorias";
            this.chkCategoria.UseVisualStyleBackColor = true;
            this.chkCategoria.CheckedChanged += new System.EventHandler(this.chkCategoria_CheckedChanged);
            // 
            // numCategoria
            // 
            this.numCategoria.Enabled = false;
            this.numCategoria.Location = new System.Drawing.Point(64, 19);
            this.numCategoria.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCategoria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCategoria.Name = "numCategoria";
            this.numCategoria.Size = new System.Drawing.Size(30, 20);
            this.numCategoria.TabIndex = 16;
            this.numCategoria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCategoria.ValueChanged += new System.EventHandler(this.numCategoria_ValueChanged);
            // 
            // chkSenha
            // 
            this.chkSenha.AutoSize = true;
            this.chkSenha.Location = new System.Drawing.Point(6, 98);
            this.chkSenha.Name = "chkSenha";
            this.chkSenha.Size = new System.Drawing.Size(62, 17);
            this.chkSenha.TabIndex = 3;
            this.chkSenha.Text = "Senhas";
            this.chkSenha.UseVisualStyleBackColor = true;
            this.chkSenha.CheckedChanged += new System.EventHandler(this.chkSenha_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSenha);
            this.groupBox3.Controls.Add(this.chkServico);
            this.groupBox3.Controls.Add(this.chkUsuario);
            this.groupBox3.Controls.Add(this.chkCategoria);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 124);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens no texto";
            // 
            // chkServico
            // 
            this.chkServico.AutoSize = true;
            this.chkServico.Location = new System.Drawing.Point(6, 46);
            this.chkServico.Name = "chkServico";
            this.chkServico.Size = new System.Drawing.Size(67, 17);
            this.chkServico.TabIndex = 2;
            this.chkServico.Text = "Serviços";
            this.chkServico.UseVisualStyleBackColor = true;
            this.chkServico.CheckedChanged += new System.EventHandler(this.chkServico_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(103, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "PassLib";
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imgAlerta4);
            this.groupBox4.Controls.Add(this.imgAlerta3);
            this.groupBox4.Controls.Add(this.imgAlerta2);
            this.groupBox4.Controls.Add(this.imgAlerta1);
            this.groupBox4.Controls.Add(this.lblSenha);
            this.groupBox4.Controls.Add(this.lblUsuario);
            this.groupBox4.Controls.Add(this.lblServico);
            this.groupBox4.Controls.Add(this.numSenha);
            this.groupBox4.Controls.Add(this.numUsuario);
            this.groupBox4.Controls.Add(this.numServico);
            this.groupBox4.Controls.Add(this.lblCategoria);
            this.groupBox4.Controls.Add(this.numCategoria);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(121, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 124);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordem dos itens";
            // 
            // imgAlerta4
            // 
            this.imgAlerta4.Image = global::PassLib.Properties.Resources.warning;
            this.imgAlerta4.Location = new System.Drawing.Point(108, 99);
            this.imgAlerta4.Name = "imgAlerta4";
            this.imgAlerta4.Size = new System.Drawing.Size(16, 16);
            this.imgAlerta4.TabIndex = 27;
            this.imgAlerta4.TabStop = false;
            this.toolTipAlerta1.SetToolTip(this.imgAlerta4, "Não pode haver dois itens com o mesmo número!");
            this.imgAlerta4.Visible = false;
            // 
            // imgAlerta3
            // 
            this.imgAlerta3.Image = global::PassLib.Properties.Resources.warning;
            this.imgAlerta3.Location = new System.Drawing.Point(108, 73);
            this.imgAlerta3.Name = "imgAlerta3";
            this.imgAlerta3.Size = new System.Drawing.Size(16, 16);
            this.imgAlerta3.TabIndex = 26;
            this.imgAlerta3.TabStop = false;
            this.toolTipAlerta1.SetToolTip(this.imgAlerta3, "Não pode haver dois itens com o mesmo número!");
            this.imgAlerta3.Visible = false;
            // 
            // imgAlerta2
            // 
            this.imgAlerta2.Image = global::PassLib.Properties.Resources.warning;
            this.imgAlerta2.Location = new System.Drawing.Point(108, 47);
            this.imgAlerta2.Name = "imgAlerta2";
            this.imgAlerta2.Size = new System.Drawing.Size(16, 16);
            this.imgAlerta2.TabIndex = 25;
            this.imgAlerta2.TabStop = false;
            this.toolTipAlerta1.SetToolTip(this.imgAlerta2, "Não pode haver dois itens com o mesmo número!");
            this.imgAlerta2.Visible = false;
            // 
            // imgAlerta1
            // 
            this.imgAlerta1.Image = global::PassLib.Properties.Resources.warning;
            this.imgAlerta1.Location = new System.Drawing.Point(108, 21);
            this.imgAlerta1.Name = "imgAlerta1";
            this.imgAlerta1.Size = new System.Drawing.Size(16, 16);
            this.imgAlerta1.TabIndex = 24;
            this.imgAlerta1.TabStop = false;
            this.toolTipAlerta1.SetToolTip(this.imgAlerta1, "Não pode haver dois itens com o mesmo número!");
            this.imgAlerta1.Visible = false;
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Transparent;
            this.btnCancela.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.ForeColor = System.Drawing.Color.White;
            this.btnCancela.Location = new System.Drawing.Point(147, 329);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(125, 23);
            this.btnCancela.TabIndex = 17;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnImporta
            // 
            this.btnImporta.BackColor = System.Drawing.Color.Transparent;
            this.btnImporta.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnImporta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnImporta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnImporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImporta.ForeColor = System.Drawing.Color.White;
            this.btnImporta.Location = new System.Drawing.Point(12, 329);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(125, 23);
            this.btnImporta.TabIndex = 16;
            this.btnImporta.Text = "Importar";
            this.btnImporta.UseVisualStyleBackColor = false;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lnkExemplo);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.txtDiretorio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 291);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importar do arquivo";
            // 
            // lnkExemplo
            // 
            this.lnkExemplo.AutoSize = true;
            this.lnkExemplo.LinkColor = System.Drawing.Color.White;
            this.lnkExemplo.Location = new System.Drawing.Point(84, 220);
            this.lnkExemplo.Name = "lnkExemplo";
            this.lnkExemplo.Size = new System.Drawing.Size(93, 13);
            this.lnkExemplo.TabIndex = 18;
            this.lnkExemplo.TabStop = true;
            this.lnkExemplo.Text = "Visualizar exemplo";
            this.lnkExemplo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExemplo_LinkClicked);
            // 
            // toolTipAlerta1
            // 
            this.toolTipAlerta1.IsBalloon = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivos de texto|*.*";
            // 
            // InserirDoArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnImporta);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InserirDoArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PassLib - Inserir do arquivo";
            this.Load += new System.EventHandler(this.InserirDoArquivo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCategoria)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlerta1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbSepChar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.NumericUpDown numSenha;
        private System.Windows.Forms.NumericUpDown numUsuario;
        private System.Windows.Forms.NumericUpDown numServico;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.RadioButton rdbSepLinha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.CheckBox chkCategoria;
        private System.Windows.Forms.NumericUpDown numCategoria;
        private System.Windows.Forms.CheckBox chkSenha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxChar;
        private System.Windows.Forms.LinkLabel lnkExemplo;
        private System.Windows.Forms.ToolTip toolTipAlerta1;
        private System.Windows.Forms.PictureBox imgAlerta1;
        private System.Windows.Forms.PictureBox imgAlerta4;
        private System.Windows.Forms.PictureBox imgAlerta3;
        private System.Windows.Forms.PictureBox imgAlerta2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}