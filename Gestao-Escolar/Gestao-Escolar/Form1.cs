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
    public partial class Form1 : Form
    {
        ClasseNegocio clsuser = new ClasseNegocio();
        ClasseEntidade clsent = new ClasseEntidade();
        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_codigo;

        FrmPrincipal f= new FrmPrincipal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            clsuser.usuario = textBox1.Text;
            clsuser.senha = textBox2.Text;

            dt = clsuser.N_Login(clsuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bem Vindo" + dt.Rows[0][0].ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nome = dt.Rows[0][0].ToString();
                id_tipo = dt.Rows[0][1].ToString();
                usuario_geral = dt.Rows[0][2].ToString();
                usuario_codigo = dt.Rows[0][3].ToString();
                this.Hide();
                f.ShowDialog();
                Limpar();
             }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }
    }
}
