using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassLib
{
    public partial class Novo : Form
    {
        public Novo()
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
            Graphics desenhista = this.CreateGraphics();

            Rectangle borda = new Rectangle(1, 1, this.Size.Width - 2, this.Size.Height - 2);
            desenhista.DrawRectangle(caneta, borda);
        }
        // <!-- Fim código adicional --> //
        #endregion

        private void Novo_Load(object sender, EventArgs e)
        {
            txtDiretorio.Text = Application.StartupPath;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnCria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite um nome.");
                txtNome.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Digite uma senha.");
                txtSenha.Focus();
            }
            else if (txtSenha.TextLength < 6)
            {
                MessageBox.Show("Digite uma senha de no mínimo 6 caracteres.");
                txtSenha.Focus();
            }
            else
            {
                if (System.IO.File.Exists(txtDiretorio.Text + "/" + txtNome.Text + ".codex"))
                {
                    DialogResult resultado1 = MessageBox.Show(this, "Já existe um Codex com este nome nesta pasta. Indicar outra pasta?",
                        "O arquivo já existe", MessageBoxButtons.OKCancel);

                    if (resultado1 == DialogResult.OK)
                    {
                        DialogResult resultado2 = folderBrowserDialog.ShowDialog();

                        if (resultado2 == DialogResult.OK)
                            Arquivo.codexAtivoPath = folderBrowserDialog.SelectedPath + txtNome.Text;
                        else
                            txtNome.Focus();
                    }
                    else
                        txtNome.Focus();
                }
                else
                {
                    if (txtDiretorio.Text.IndexOf('\\') != txtDiretorio.TextLength - 1)
                        Arquivo.codexAtivoPath = txtDiretorio.Text + "/" + txtNome.Text;
                    else
                        Arquivo.codexAtivoPath = txtDiretorio.Text + txtNome.Text;

                    System.IO.File.WriteAllText(Arquivo.codexAtivoPath + ".codex",
                        Criptografia.GlobalCryptoServiceProvider(Criptografia.Process.Hash, txtSenha.Text));
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnAbrirCodex_Click(object sender, EventArgs e)
        {
            DialogResult resultado2 = folderBrowserDialog.ShowDialog();
            if (resultado2 == DialogResult.OK)
                txtDiretorio.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
