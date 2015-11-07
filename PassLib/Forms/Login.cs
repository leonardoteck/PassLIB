using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PassLib
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region código para tirar a borda do form

        Point mv = new Point();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mv.X = this.Left - MousePosition.X;
            mv.Y = this.Top - MousePosition.Y;
            Cursor.Current = Cursors.SizeAll;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = mv.X + MousePosition.X;
            this.Top = mv.Y + MousePosition.Y;
        }

        // <!-- Adicional que coloca a borda vermelha em volta do form ;D --> //
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = new Pen(Color.DarkRed, 2);
            Brush brocha = Brushes.DarkRed;
            Graphics desenhista = this.CreateGraphics();

            Rectangle borda = new Rectangle(1, 1, this.Size.Width - 2, this.Size.Height - 2);
            desenhista.DrawRectangle(caneta, borda);
        }
        // <!-- Fim código adicional --> //
        #endregion

        private void btnSai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string[] caminhos = Directory.GetFiles(Application.StartupPath, "*.codex");
        bool hashear = true;
        string hashDigitado;
        string hashLido;

        private void Login_Load(object sender, EventArgs e)
        {
            string[] arquivos = new string[caminhos.Length];
            for (int i = 0; i < caminhos.Length; i++)
            {
                arquivos[i] = Path.GetFileNameWithoutExtension(caminhos[i]);
            }
            cbxLib.Items.AddRange(arquivos);
            cbxLib.SelectedIndex = 0;
            Arquivo.codexAtivoPath = caminhos[0];
        }

        private void btnAbrirCodex_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialogAbrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Arquivo.codexAtivoPath = openFileDialogAbrir.FileName;
                cbxLib.Items.Clear();
                cbxLib.Items.Add(Path.GetDirectoryName(Arquivo.codexAtivoPath) + " - (" +
                    Arquivo.codexAtivoPath + ")");
                cbxLib.SelectedIndex = 0;
            }
        }

        private void lnkNovo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Novo frmNovo = new Novo();
            frmNovo.ShowDialog();

            if (frmNovo.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Principal frmPrincipal = new Principal();
                Inserir frmInserir = new Inserir();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                if (cbxLib.Items.Count != 0)
                    Arquivo.codexAtivoPath = caminhos[cbxLib.SelectedIndex];
            }
        }

        // programação do login

        private void cbxLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIncorreto.Visible = false;
            Arquivo.codexAtivoPath = caminhos[cbxLib.SelectedIndex];
            hashear = true;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.TextLength == 1 && hashear)
            {
                hashLido = Arquivo.LeitorSenha(Arquivo.codexAtivoPath);
                hashear = false;
            }

            hashDigitado = Criptografia.GlobalCryptoServiceProvider(
                Criptografia.Process.Hash, txtSenha.Text);

            if (hashLido == hashDigitado)
            {
                Principal frm = new Principal();
                frm.Show();
                this.Hide();

                // @@@ AGORA TEM QUE FAZER ESSA PORRA DECRIPTOGRAFAR TUDO! @@@ \\

            }
        }
    }
}