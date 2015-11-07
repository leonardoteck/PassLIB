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
    public partial class Inserir : Form
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

        List<Itens> senhas;
        static internal List<GroupBoxSenhas> grupos;
        static internal FlowLayoutPanel painel;
        private GroupBoxSenhas groupBoxSenhas1;

        public Inserir()
        {
            // <!-- MIL TRETAS COM O PAINEL -->
            painel = new FlowLayoutPanel();
            painel.SuspendLayout();
            painel.AutoScroll = true;
            painel.FlowDirection = FlowDirection.TopDown;
            painel.Location = new Point(97, 35);
            painel.Name = "painel";
            painel.Size = new Size(295, 252);
            painel.TabIndex = 17;
            painel.WrapContents = false;
            painel.BackColor = Color.Transparent;
            painel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.Controls.Add(painel);
            painel.ResumeLayout(false);
            painel.MouseDown += Form1_MouseDown;
            painel.MouseMove += Form1_MouseMove;
            groupBoxSenhas1 = new GroupBoxSenhas();
            groupBoxSenhas1.BackColor = Color.Transparent;
            groupBoxSenhas1.Location = new Point(3, 3);
            groupBoxSenhas1.Name = "groupBoxSenhas1";
            groupBoxSenhas1.Size = new Size(266, 143);
            groupBoxSenhas1.TabIndex = 0;
            painel.Controls.Add(groupBoxSenhas1);
            painel.AutoScroll = true;
            // <!-- -->
            InitializeComponent();
            
            senhas = new List<Itens>();
            grupos = new List<GroupBoxSenhas>();
        }

        private void Inserir_Load(object sender, EventArgs e)
        {
            grupos.Add(groupBoxSenhas1);
            groupBoxSenhas1.controlIndex = 0;
        }

        private void Inserir_Shown(object sender, EventArgs e)
        {
            grupos[0].cbxCategoria.Focus();
        }
        
        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            grupos.Add(new GroupBoxSenhas());
            grupos[grupos.Count - 1].boxSenha1.Text = "Senha " + grupos.Count;
            grupos[grupos.Count - 1].controlIndex = grupos.Count - 1;
            painel.Controls.Add(grupos[grupos.Count - 1]);
            painel.ScrollControlIntoView(painel.Controls[painel.Controls.Count - 1]);
        }

        static internal void remover(int controlIndex)
        {
            painel.Controls.Remove(grupos[controlIndex]);
            grupos.Remove(grupos[controlIndex]);
            for(int i = controlIndex; i < grupos.Count; i++)
            {
                grupos[i].boxSenha1.Text = "Senha " + (i + 1);
            }
            ComboBoxes.atualizaCombos(ComboBoxes.Campo.todos);
        }

        private int posicaoClicada;
        private int posicaoMovimento;
        int posTrava = -1;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            posicaoMovimento = posicaoClicada = MousePosition.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (MousePosition.Y != posicaoMovimento)
            {
                if(posTrava != -1)
                {
                    if (Cursor.Position.Y - posTrava > 0){
                        resize();
                        posTrava = -1;
                    }
                    else
                        Cursor.Position = new Point(Cursor.Position.X, posTrava);
                }
                else
                {
                    resize();
                }
            }
        }

        void resize()
        {
            posicaoMovimento = MousePosition.Y;
            int add = MousePosition.Y - posicaoClicada;
            posicaoClicada = MousePosition.Y;
            if (this.Height + add > 270)
            {
                this.Height += add;
                this.Refresh();
            }
            else
            {
                this.Height = 270;
                posTrava = this.Location.Y + 257;
            }
        }

        private bool vazio()
        {
            foreach (GroupBoxSenhas grp in grupos)
            {
                if (grp.txtSenha.Text != "" || grp.cbxUsuario.Text != "" || grp.cbxServico.Text != "")
                {
                    return false;
                }
            }
            return true;
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            if (vazio())
            {
                MessageBox.Show("Digite ao menos um login e senha para inserir.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grupos[0].cbxServico.Focus();
                return;
            }
            for (int i = 0; i < grupos.Count; i++)
            {
                if ((grupos[i].txtSenha.Text != "" || grupos[i].cbxUsuario.Text != "") && grupos[i].cbxServico.Text == "")
                {
                    MessageBox.Show("Por favor, especifique o serviço ao qual se refere cada senha.\nExemplo: Google, Facebook, etc.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    grupos[i].cbxServico.Focus();
                    return;
                }
                else
                {
                    if (grupos[i].txtSenha.Text != "" || grupos[i].cbxUsuario.Text != "")
                    {
                        senhas.Add(new Itens(grupos[i].cbxCategoria.Text.Trim(), grupos[i].cbxServico.Text.Trim(),
                                    grupos[i].cbxUsuario.Text.Trim(), grupos[i].txtSenha.Text.Trim()));
                    }
                }
                if (i > 0)
                    for (int j = 0; j < i; j++)
                        if (grupos[i].Equals(grupos[j]))
                        {
                            MessageBox.Show("A senha " + (j + 1) + " é igual a senha " + (i + 1) + ". Por favor, altere ou exclua uma delas.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            grupos[i].cbxUsuario.Focus();
                            return;
                        }
            }

            senhas.Sort((x, y) => string.Compare(x.Servico, y.Servico));

            Arquivo.EscreveItens(senhas);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            ComboBoxes.categorias.Clear();
            ComboBoxes.servicos.Clear();
            ComboBoxes.usuarios.Clear();
            groupBoxSenhas1 = new GroupBoxSenhas();
            painel.Controls.Clear();
            painel.Controls.Add(groupBoxSenhas1);
            grupos.Clear();
            grupos.Add(groupBoxSenhas1);
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (txtAtual.Text == "")
                MessageBox.Show("Digite o número de uma senha para ir até ela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int num = Convert.ToInt32(txtAtual.Text);
                if (num < 1 || num > grupos.Count)
                    MessageBox.Show("A senha procurada não existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    painel.ScrollControlIntoView(painel.Controls[num - 1]);
                    grupos[num - 1].cbxCategoria.Focus();
                }
            }

        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            if (!vazio())
            {
                DialogResult resultado = MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                    this.Close();
            } 
            else
                this.Close();
        }

        private void btnDoArquivo_Click(object sender, EventArgs e)
        {
            InserirDoArquivo frm = new InserirDoArquivo();
            frm.ShowDialog();

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                while (grupos.Count > 0)
                {
                    if (grupos[grupos.Count - 1].cbxCategoria.Text == "Sem categoria" &&
                        grupos[grupos.Count - 1].cbxServico.Text == "" &&
                        grupos[grupos.Count - 1].cbxUsuario.Text == "" &&
                        grupos[grupos.Count - 1].txtSenha.Text == "")
                    {
                        painel.Controls.Remove(grupos[grupos.Count - 1]);
                        grupos.Remove(grupos[grupos.Count - 1]);
                    }
                    else
                    {
                        break;
                    }
                    
                }

                GroupBoxSenhas[] groupBoxes = new GroupBoxSenhas[frm.itens.Count];
                int cont = grupos.Count + 1;
                for (int i = 0; i < groupBoxes.Length; i++)
                {
                    groupBoxes[i] = new GroupBoxSenhas();
                    groupBoxes[i].boxSenha1.Text = "Senha " + cont;
                    groupBoxes[i].controlIndex = cont - 1;
                    groupBoxes[i].cbxCategoria.Text = frm.itens[i].Categoria;
                    groupBoxes[i].cbxServico.Text = frm.itens[i].Servico;
                    groupBoxes[i].cbxUsuario.Text = frm.itens[i].Usuario;
                    groupBoxes[i].txtSenha.Text = frm.itens[i].Senha;
                    cont++;
                }
                grupos.AddRange(groupBoxes);
                painel.Controls.AddRange(groupBoxes);
                painel.ScrollControlIntoView(painel.Controls[painel.Controls.Count - 1]);
                ComboBoxes.atualizaCombos(ComboBoxes.Campo.todos);
            }
        }
    }
}
