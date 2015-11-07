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
    public partial class Principal : Form
    {
        public Principal()
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

        private void Principal_Load(object sender, EventArgs e)
        {
            /* dica de código:
             * vê se tem alguma senha no codex
             * se não tiver, pergunta se quer por senha (messagebox)
             * se sim, chama o form Inserir como dialog
             * se alguma senha for inserida, dialogresult será ok
             * e carrega as senhas no principal
             */
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
