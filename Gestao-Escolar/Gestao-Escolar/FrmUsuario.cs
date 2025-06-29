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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        ClasseEntidade clsE = new ClasseEntidade();
        ClasseEntidade clsN = new ClasseEntidade();

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsN.N_listar_usuario();
            comboBox1.DisplayMember = "tipo_nome";
            comboBox1.ValueMember = "id_tipo";
        }
        void CRUD (string accão) 
        {
            clsE.codigo = textBox1.Text;
            clsE.nome = textBox3.Text;
            clsE.usuario = textBox2.Text;
            clsE.id_usuario = comboBox1.SelectedValue.ToString();
            clsE.accão = accão;
        }

    }
}
