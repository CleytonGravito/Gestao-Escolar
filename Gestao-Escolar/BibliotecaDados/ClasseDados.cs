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
        public DataTable D_buscarUsuario(ClasseEntidade obje) 
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_usuario", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", obje.usuario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_ListarUsuario(ClasseEntidade obje) // Verificar se der erro
        {
            SqlCommand cmd = new SqlCommand("sp_listar_usuario", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_ProcUsuario(ClasseEntidade obje)
        {
            String accão = "";
            SqlCommand cmd = new SqlCommand("procedimento_usuario",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_usuario", obje.id_usuario);
            cmd.Parameters.AddWithValue("@nome", obje.nome);
            cmd.Parameters.AddWithValue("@nome_usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@id_tipo", obje.tipo);
            cmd.Parameters.Add("@accão", SqlDbType.VarChar, 50).Value=obje.accão;
            cmd.Parameters["accão"].Direction = ParameterDirection.InputOutput;
            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            accão = cmd.Parameters["@accão"].Value.ToString();
            return accão;
        }
    }
}
