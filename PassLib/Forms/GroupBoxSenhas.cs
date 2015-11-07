using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassLib
{
    public partial class GroupBoxSenhas : UserControl, IEquatable<GroupBoxSenhas>
    {
        public GroupBoxSenhas()
        {
            InitializeComponent();
        }

        private bool hidden = false;
        internal int controlIndex;

        private void btnOlho_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                btnOlho.Image = Properties.Resources.opened;
                txtSenha.UseSystemPasswordChar = false;
                hidden = false;
            }
            else
            {
                btnOlho.Image = Properties.Resources.closed;
                txtSenha.UseSystemPasswordChar = true;
                hidden = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Inserir.remover(controlIndex);
        }

        public bool Equals(GroupBoxSenhas other)
        {
            return (this.txtSenha.Text == other.txtSenha.Text &&
                    this.cbxServico.SelectedText == other.cbxServico.SelectedText &&
                    this.cbxUsuario.Text == other.cbxUsuario.Text &&
                    this.cbxCategoria.SelectedText == other.cbxCategoria.SelectedText);
        }

        private void GroupBoxSenhas_Load(object sender, EventArgs e)
        {
            cbxCategoria.Focus();
            cbxCategoria.Items.AddRange(ComboBoxes.categorias.ToArray());
            cbxServico.Items.AddRange(ComboBoxes.servicos.ToArray());
            cbxUsuario.Items.AddRange(ComboBoxes.usuarios.ToArray());
        }

        private void cbxCategoria_Leave(object sender, EventArgs e)
        {
            if (cbxCategoria.Text != "")
                ComboBoxes.atualizaCombos(ComboBoxes.Campo.categoria);
            else
            {
                cbxCategoria.ForeColor = Color.DimGray;
                cbxCategoria.Text = "Sem categoria";
                cbxCategoria.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                cbxCategoria.SelectionLength = 0;
            }
        }

        private void cbxServico_Leave(object sender, EventArgs e)
        {
            if (cbxServico.Text != "")
                ComboBoxes.atualizaCombos(ComboBoxes.Campo.servico);
        }

        private void cbxUsuario_Leave(object sender, EventArgs e)
        {
            if (cbxUsuario.Text != "")
                ComboBoxes.atualizaCombos(ComboBoxes.Campo.usuario);
        }

        private void cbxCategoria_Enter(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Sem categoria")
            {
                cbxCategoria.ForeColor = Color.Black;
                cbxCategoria.Text = "";
                cbxCategoria.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }

    class ComboBoxes
    {
        public static List<string> categorias = new List<string>();
        public static List<string> servicos = new List<string>();
        public static List<string> usuarios = new List<string>();

        internal enum Campo
        {
            categoria,
            servico,
            usuario,
            todos
        }
                
        internal static void atualizaCombos(Campo field)
        {
            switch (field) {
                case Campo.categoria:
                    categorias.Clear();
                    foreach (GroupBoxSenhas grp in Inserir.grupos)
                    {
                        if (!categorias.Contains(grp.cbxCategoria.Text))
                            categorias.Add(grp.cbxCategoria.Text);
                    }
                    categorias.Sort((x, y) => string.Compare(x, y));
                    string[] aCategorias = categorias.ToArray();
                    foreach (GroupBoxSenhas grp in Inserir.grupos)
                    {
                        grp.cbxCategoria.Items.Clear();
                        grp.cbxCategoria.Items.AddRange(aCategorias);
                    }
                    break;
                case Campo.servico:
                    servicos.Clear();
                    foreach (GroupBoxSenhas grp in Inserir.grupos)
                    {
                        if (!servicos.Contains(grp.cbxServico.Text))
                            servicos.Add(grp.cbxServico.Text);
                    }
                    servicos.Sort((x, y) => string.Compare(x, y));
                    string[] aServicos = servicos.ToArray();
                    foreach (GroupBoxSenhas grp in Inserir.grupos)
                    {
                        grp.cbxServico.Items.Clear();
                        grp.cbxServico.Items.AddRange(aServicos);
                    }
                    break;
                case Campo.usuario:
                    usuarios.Clear();
                    foreach (GroupBoxSenhas grp in Inserir.grupos)
                    {
                        if (!usuarios.Contains(grp.cbxUsuario.Text))
                            usuarios.Add(grp.cbxUsuario.Text);
                    }
                    usuarios.Sort((x, y) => string.Compare(x, y));
                    string[] aUsuarios = usuarios.ToArray();
                    foreach (GroupBoxSenhas grp in Inserir.grupos)
                    {
                        grp.cbxUsuario.Items.Clear();
                        grp.cbxUsuario.Items.AddRange(aUsuarios);
                    }
                    break;
                case Campo.todos:
                    atualizaCombos(Campo.categoria);
                    atualizaCombos(Campo.servico);
                    atualizaCombos(Campo.usuario);
                    break;
            }
        }
    }
}
