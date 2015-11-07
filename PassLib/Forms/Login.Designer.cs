namespace PassLib
{
    partial class Login
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSai = new System.Windows.Forms.Button();
            this.lnkNovo = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialogAbrir = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirCodex = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbxLib = new System.Windows.Forms.ComboBox();
            this.lblIncorreto = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.footer1 = new PassLib.footer();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "PassLIB";
            // 
            // btnSai
            // 
            this.btnSai.BackColor = System.Drawing.Color.DarkRed;
            this.btnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSai.Font = new System.Drawing.Font("Lucida Console", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSai.ForeColor = System.Drawing.Color.White;
            this.btnSai.Location = new System.Drawing.Point(255, 8);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(17, 17);
            this.btnSai.TabIndex = 6;
            this.btnSai.Text = "X";
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // lnkNovo
            // 
            this.lnkNovo.AutoSize = true;
            this.lnkNovo.BackColor = System.Drawing.Color.Transparent;
            this.lnkNovo.LinkColor = System.Drawing.Color.White;
            this.lnkNovo.Location = new System.Drawing.Point(52, 132);
            this.lnkNovo.Name = "lnkNovo";
            this.lnkNovo.Size = new System.Drawing.Size(88, 13);
            this.lnkNovo.TabIndex = 4;
            this.lnkNovo.TabStop = true;
            this.lnkNovo.Text = "Criar novo Codex";
            this.lnkNovo.VisitedLinkColor = System.Drawing.Color.White;
            this.lnkNovo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNovo_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Codex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Senha";
            // 
            // openFileDialogAbrir
            // 
            this.openFileDialogAbrir.DefaultExt = "*.codex";
            this.openFileDialogAbrir.FileName = "*.codex";
            this.openFileDialogAbrir.Filter = "\"Arquivos PassLIB|*.codex\"";
            // 
            // btnAbrirCodex
            // 
            this.btnAbrirCodex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCodex.Location = new System.Drawing.Point(240, 56);
            this.btnAbrirCodex.Name = "btnAbrirCodex";
            this.btnAbrirCodex.Size = new System.Drawing.Size(25, 22);
            this.btnAbrirCodex.TabIndex = 3;
            this.btnAbrirCodex.Text = "...";
            this.btnAbrirCodex.UseVisualStyleBackColor = true;
            this.btnAbrirCodex.Click += new System.EventHandler(this.btnAbrirCodex_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(150, 132);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sobre o PassLib";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // cbxLib
            // 
            this.cbxLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLib.FormattingEnabled = true;
            this.cbxLib.Location = new System.Drawing.Point(55, 57);
            this.cbxLib.Name = "cbxLib";
            this.cbxLib.Size = new System.Drawing.Size(179, 21);
            this.cbxLib.TabIndex = 1;
            this.cbxLib.SelectedIndexChanged += new System.EventHandler(this.cbxLib_SelectedIndexChanged);
            // 
            // lblIncorreto
            // 
            this.lblIncorreto.AutoSize = true;
            this.lblIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lblIncorreto.Location = new System.Drawing.Point(64, 106);
            this.lblIncorreto.Name = "lblIncorreto";
            this.lblIncorreto.Size = new System.Drawing.Size(170, 13);
            this.lblIncorreto.TabIndex = 36;
            this.lblIncorreto.Text = "Senha Incorreta. Algum problema?";
            this.lblIncorreto.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(55, 83);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.Size = new System.Drawing.Size(210, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.DarkRed;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 169);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(284, 23);
            this.footer1.TabIndex = 39;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblIncorreto);
            this.Controls.Add(this.cbxLib);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAbrirCodex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkNovo);
            this.Controls.Add(this.btnSai);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.LinkLabel lnkNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialogAbrir;
        private System.Windows.Forms.Button btnAbrirCodex;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbxLib;
        private System.Windows.Forms.Label lblIncorreto;
        private System.Windows.Forms.TextBox txtSenha;
        private footer footer1;
    }
}