using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoHistorico2
{
    public class Conexao
    {
       
        SqlConnection con = new SqlConnection();

        // Construtor

        public Conexao()
        {
            con.ConnectionString = "Server = DESKTOP - 2ABJD5F; Database = Crud; User Id = sa ; Password = senha;";
            
        }

        //Método de conexão bd
        public SqlConnection conectar()
        {

            if (con.State == System.Data.ConnectionState.Closed)
            { 
                con.Open(); 
            }

            return con;
        }

        //Método para desconectar bd 

        public void desconectar()
        {

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }



    }
}
