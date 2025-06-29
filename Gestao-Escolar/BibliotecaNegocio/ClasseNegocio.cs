using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDados;
using BibliotecaEntidade;

namespace BibliotecaNegocio
{
    public class ClasseNegocio
    {
        ClasseDados clsdados = new ClasseDados();

        public string senha { get; set; }
        public string usuario { get; set; }

        public DataTable N_Login(ClasseEntidade obje) 
        {
            return clsdados.DLogin(obje);
        }
        public DataTable N_Buscarusuario(ClasseEntidade obje)
        {
            return clsdados.D_buscarUsuario(obje);
        }
        public DataTable N_listar_usuario(ClasseEntidade obje)
        {
            return clsdados.D_ListarUsuario(obje);
        }
        public String N_ProcUsuario(ClasseEntidade obje)
        {
            return clsdados.D_ProcUsuario(obje);
        }
    }
}
