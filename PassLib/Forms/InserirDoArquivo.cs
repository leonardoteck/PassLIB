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
    public partial class InserirDoArquivo : Form
    {
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

        public InserirDoArquivo()
        {
            InitializeComponent();
        }

        int chkChecked = 0;

        private void InserirDoArquivo_Load(object sender, EventArgs e)
        {
            cbxChar.SelectedIndex = 0;
        }

        private void rdbSepChar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSepChar.Checked)
                cbxChar.Enabled = true;
            else
                cbxChar.Enabled = false;
        }

        private void chkCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCategoria.Checked)
            {
                lblCategoria.ForeColor = Color.White;
                numCategoria.Enabled = true;
                valueChanged();
                chkCheckedMais();
            }
            else
            {
                lblCategoria.ForeColor = Color.Gray;
                numCategoria.Enabled = false;
                valueChanged();
                chkCheckedMenos();
                imgAlerta1.Visible = false;
            }
        }

        private void chkServico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkServico.Checked)
            {
                lblServico.ForeColor = Color.White;
                numServico.Enabled = true;
                valueChanged();
                chkCheckedMais();
            }
            else
            {
                lblServico.ForeColor = Color.Gray;
                numServico.Enabled = false;
                valueChanged();
                chkCheckedMenos();
                imgAlerta2.Visible = false;
            }
        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsuario.Checked)
            {
                lblUsuario.ForeColor = Color.White;
                numUsuario.Enabled = true;
                valueChanged();
                chkCheckedMais();
            }
            else
            {
                lblUsuario.ForeColor = Color.Gray;
                numUsuario.Enabled = false;
                valueChanged();
                chkCheckedMenos();
                imgAlerta3.Visible = false;
            }
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
            {
                lblSenha.ForeColor = Color.White;
                numSenha.Enabled = true;
                valueChanged();
                chkCheckedMais();
            }
            else
            {
                lblSenha.ForeColor = Color.Gray;
                numSenha.Enabled = false;
                valueChanged();
                chkCheckedMenos();
                imgAlerta4.Visible = false;
            }
        }

        private void chkCheckedMais()
        {
            chkChecked++;
            numCategoria.Maximum = chkChecked;
            numServico.Maximum = chkChecked;
            numUsuario.Maximum = chkChecked;
            numSenha.Maximum = chkChecked;
        }

        private void chkCheckedMenos()
        {
            chkChecked--;
            if (chkChecked > 0)
            {
                numCategoria.Maximum = chkChecked;
                numServico.Maximum = chkChecked;
                numUsuario.Maximum = chkChecked;
                numSenha.Maximum = chkChecked;
            }
        }

        #region MIL TRETAS COM ALERTAS
        private void numCategoria_ValueChanged(object sender, EventArgs e)
        {
            valueChanged();
        }

        private void numServico_ValueChanged(object sender, EventArgs e)
        {
            valueChanged();
        }

        private void numUsuario_ValueChanged(object sender, EventArgs e)
        {
            valueChanged();
        }

        private void numSenha_ValueChanged(object sender, EventArgs e)
        {
            valueChanged();
        }

        void valueChanged()
        {
            // 1
            imgAlerta1.Visible = false;
            if (numCategoria.Enabled)
            {
                if (numServico.Enabled && numServico.Value == numCategoria.Value)
                {
                    imgAlerta2.Visible = true;
                }
                else if (numUsuario.Enabled && numUsuario.Value == numCategoria.Value)
                {
                    imgAlerta3.Visible = true;
                }
                else if (numSenha.Enabled && numSenha.Value == numCategoria.Value)
                {
                    imgAlerta4.Visible = true;
                }

                if (numUsuario.Enabled && numUsuario.Value == numCategoria.Value)
                {
                    imgAlerta3.Visible = true;
                }
                if (numSenha.Enabled && numSenha.Value == numCategoria.Value)
                {
                    imgAlerta4.Visible = true;
                }
            }

            // 2
            if (numServico.Enabled)
            {
                if (numCategoria.Enabled && numCategoria.Value == numServico.Value)
                {
                    imgAlerta1.Visible = true;
                }
                else if (numUsuario.Enabled && numUsuario.Value == numServico.Value)
                {
                    imgAlerta3.Visible = true;
                }
                else if (numSenha.Enabled && numSenha.Value == numServico.Value)
                {
                    imgAlerta4.Visible = true;
                }
                else
                {
                    imgAlerta2.Visible = false;
                }

                if (numUsuario.Enabled && numUsuario.Value == numServico.Value)
                {
                    imgAlerta3.Visible = true;
                }
                if (numSenha.Enabled && numSenha.Value == numServico.Value)
                {
                    imgAlerta4.Visible = true;
                }
            }

            // 3
            if (numUsuario.Enabled)
            {
                if (numServico.Enabled && numServico.Value == numUsuario.Value)
                {
                    imgAlerta2.Visible = true;
                }
                else if (numCategoria.Enabled && numCategoria.Value == numUsuario.Value)
                {
                    imgAlerta1.Visible = true;
                }
                else if (numSenha.Enabled && numSenha.Value == numUsuario.Value)
                {
                    imgAlerta4.Visible = true;
                }
                else
                {
                    imgAlerta3.Visible = false;
                }

                if (numCategoria.Enabled && numCategoria.Value == numUsuario.Value)
                {
                    imgAlerta1.Visible = true;
                }
                if (numSenha.Enabled && numSenha.Value == numUsuario.Value)
                {
                    imgAlerta4.Visible = true;
                }
            }

            // 4
            if (numSenha.Enabled)
            {
                if (numServico.Enabled && numServico.Value == numSenha.Value)
                {
                    imgAlerta2.Visible = true;
                }
                else if (numUsuario.Enabled && numUsuario.Value == numSenha.Value)
                {
                    imgAlerta3.Visible = true;
                }
                else if (numCategoria.Enabled && numCategoria.Value == numSenha.Value)
                {
                    imgAlerta1.Visible = true;
                }
                else
                {
                    imgAlerta4.Visible = false;
                }

                if (numUsuario.Enabled && numUsuario.Value == numSenha.Value)
                {
                    imgAlerta3.Visible = true;
                }
                if (numCategoria.Enabled && numCategoria.Value == numSenha.Value)
                {
                    imgAlerta1.Visible = true;
                }
            }
        }
        #endregion

        private bool validacao()
        {
            if (imgAlerta1.Visible || imgAlerta2.Visible || imgAlerta3.Visible || imgAlerta4.Visible)
            {
                MessageBox.Show("Por favor, corrija a ordem dos itens no texto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (chkCategoria.Checked == false && chkServico.Checked == false && chkUsuario.Checked == false && chkSenha.Checked == false)
            {
                MessageBox.Show("Selecione ao menos 1 item no texto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void lnkExemplo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!validacao())
                return;

            string separador;
            if (rdbSepLinha.Checked)
                separador = "\n";
            else
                separador = cbxChar.Text.Substring(0, 2);
            string[,] senha = new string[3,4];
            string exemplo = "";

            int ativos = 0;
            if (numCategoria.Enabled)
            {
                senha[0, (int)numCategoria.Value - 1] = "Emails";
                senha[1, (int)numCategoria.Value - 1] = "Jogos";
                senha[2, (int)numCategoria.Value - 1] = "Social";
                ativos++;
            }
            if (numServico.Enabled)
            {
                senha[0, (int)numServico.Value - 1] = "Outlook";
                senha[1, (int)numServico.Value - 1] = "GrandChase";
                senha[2, (int)numServico.Value - 1] = "Twitter";
                ativos++;
            }
            if (numUsuario.Enabled)
            {
                senha[0, (int)numUsuario.Value - 1] = "fulanodetal@outlook.com";
                senha[1, (int)numUsuario.Value - 1] = "fulano4568";
                senha[2, (int)numUsuario.Value - 1] = "@fulano";
                ativos++;
            }
            if (numSenha.Enabled)
            {
                senha[0, (int)numSenha.Value - 1] = "Senha@123";
                senha[1, (int)numSenha.Value - 1] = "naoseiasenha";
                senha[2, (int)numSenha.Value - 1] = "12345678";
                ativos++;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < ativos; j++)
                {
                    exemplo += senha[i, j];
                    if (j == ativos - 1)
                        exemplo += "\n";
                    else
                        exemplo += separador;
                }
                if (separador == "\n")
                    exemplo += "\n";
            }

            MessageBox.Show(exemplo, "Exemplo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtDiretorio.Text = openFileDialog1.FileName;
            }
        }

        private string[] atual;
        private string categoria, servico, usuario, senha;
        internal List<Itens> itens = new List<Itens>();

        private void btnImporta_Click(object sender, EventArgs e)
        {
            if (!validacao())
                return;

            System.IO.FileInfo info = new System.IO.FileInfo(txtDiretorio.Text);
            if (info.Length < 1)
            {
                MessageBox.Show("O arquivo é pequeno demais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!System.IO.File.Exists(txtDiretorio.Text))
            {
                MessageBox.Show("O arquivo especificado não existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            System.IO.StreamReader sr = new System.IO.StreamReader(txtDiretorio.Text);

            int qtCampos = 0;
            if (numCategoria.Enabled)
                qtCampos++;
            if (numServico.Enabled)
                qtCampos++;
            if (numUsuario.Enabled)
                qtCampos++;
            if (numSenha.Enabled)
                qtCampos++;

            atual = new string[qtCampos];

            bool erros = false;

            if (rdbSepLinha.Checked)
            {
                string linha;

                while (!sr.EndOfStream)
                {
                    for (int i = 0; i < qtCampos; i++)
                    {
                        linha = "";
                        while (linha == "")
                        {
                            if (!sr.EndOfStream)
                                linha = sr.ReadLine();
                            else
                            {
                                erros = true;
                                break;
                            }
                        }

                        if (erros)
                            break;

                        atual[i] = linha;
                    }

                    addItem();
                }
            }
            else
            {
                string linha;
                string[] split;
                char separador = cbxChar.Text.ToCharArray()[0];
                while (!sr.EndOfStream)
                {
                    linha = sr.ReadLine();
                    if (linha != "")
                    {
                        split = linha.Split(separador);
                        if (split.Length == qtCampos)
                        {
                            atual = split;
                            addItem();
                        }
                        else
                            erros = true;
                    }
                }
            }

            if (itens.Count == 0)
            {
                MessageBox.Show("Não há itens válidos no arquivo. Nenhum item foi importado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (erros)
                MessageBox.Show("Houveram alguns problemas durante a leitura do arquivo, mas tentamos interpretá-lo da melhor maneira possível. Por favor, verifique se está tudo em ordem.", "Atenção - Problemas de leitura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        void addItem()
        {
            if (numCategoria.Enabled)
                categoria = atual[(int)numCategoria.Value - 1].Trim();
            else
                categoria = "";
            if (numServico.Enabled)
                servico = atual[(int)numServico.Value - 1].Trim();
            else
                servico = "";
            if (numUsuario.Enabled)
                usuario = atual[(int)numUsuario.Value - 1].Trim();
            else
                usuario = "";
            if (numSenha.Enabled)
                senha = atual[(int)numSenha.Value - 1].Trim();
            else
                senha = "";

            itens.Add(new Itens(categoria, servico, usuario, senha));
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
