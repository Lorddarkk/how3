using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static string servidor = @"VM-ESTUDO";
        public static string banco = "ControleDeEstoque";
        public static string usuario = "sa";
        public static string senha = "bill+1212";
        public static String StringDeConexao
        {
            get 
            {
                return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }
        }
    }
}
