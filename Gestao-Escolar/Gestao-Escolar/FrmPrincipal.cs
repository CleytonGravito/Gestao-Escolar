using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEntidade;
using BibliotecaNegocio;

namespace Gestao_Escolar
{
    public partial class FrmPrincipal : Form
    {
        ClasseEntidade objE = new ClasseEntidade();
        ClasseNegocio objN = new ClasseNegocio();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = Login.usuario_nome;
            if (Login.id_tipo == "T0001") // Admin
            {
                pictureBox1.Enabled = true;
            }
            else if (Login.id_tipo == "T0002") // Secretaria
            {
                pictureBox6.Enabled = false;
                label10.Enabled = false;   
            }
            else if (Login.id_tipo == "T0003") // Professores
            {
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox1.Enabled = false;
                label10.Enabled = false;
                label9.Enabled = false;
                label8.Enabled = false;
                label7.Enabled = false;
            }
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldata.Text = DateTime.Now.ToString();
        }
    }
}
