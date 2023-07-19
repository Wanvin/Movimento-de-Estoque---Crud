using System.Data.SqlClient;

namespace ProjetoHistorico2
{
    public class Crudbd
    {
       
        SqlConnection con = new SqlConnection();

        // Construtor

        public Crudbd()
        {
            con.ConnectionString = "@Data Source=DESKTOP-2ABJD5F\\SQL2022;Initial Catalog=Crud;Persist Security Info=True;User ID=sa;Password=senha";
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
