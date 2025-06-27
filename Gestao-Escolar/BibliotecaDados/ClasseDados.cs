using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidade;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaDados
{
    public class ClasseDados
    {
        SqlConnection con = new SqlConnection(ConfigurationManeger.ConnectionString["sql"].ConnectionString);
        public DataTable DLogin(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logar",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.user);
            cmd.Parameters.AddWithValue("@senha", obje.passe);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
