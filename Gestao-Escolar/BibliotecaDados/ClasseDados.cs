using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidade;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BibliotecaDados
{
    public class ClasseDados
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable DLogin(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logar",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@senha", obje.senha);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
