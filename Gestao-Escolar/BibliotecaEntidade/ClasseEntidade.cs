using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidade
{
    public class ClasseEntidade
    {
        public String usuario { get; set; }
        public String senha { get; set; }
        public String nome { get; set; }
        public String codigo { get; set; }
        public String tipo { get; set; }
        public String accão { get; set; }
        public String id_usuario { get; set; }
        public object N_listar_usuario()
        {
            throw new NotImplementedException();
        }
    }
}
