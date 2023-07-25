using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHistorico2
{


    public class Historico
    {
 
        public bool Inserir(Guid ide, Guid equipamento_ide, String funcionario, DateTime data_movimento,
              DateTime data_alteracao, String setor, int status, bool devolver, bool devolvido)

        {



            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            status = 0;
            data_alteracao = DateTime.Now;

            // Comando Sql (insert, update, delete) -- SqlCommand
            cmd.CommandText = "insert into Historico(ide, equipamento_ide, funcionario, data_movimento, data_alteracao, setor, status, devolver, devolvido) " +
                "values(@ide, @equipamento_ide, @funcionario, @data_movimento, @data_alteracao, @setor, @status, @devolver, @devolvido)";
            // Parametros
            cmd.Parameters.AddWithValue("@ide", ide);
            cmd.Parameters.AddWithValue("@equipamento_ide", equipamento_ide);
            cmd.Parameters.AddWithValue("@funcionario", funcionario);
            cmd.Parameters.AddWithValue("@data_movimento", data_movimento);
            cmd.Parameters.AddWithValue("@data_alteracao", data_alteracao);
            cmd.Parameters.AddWithValue("@setor", setor);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@devolver", devolver);
            cmd.Parameters.AddWithValue("@devolvido", devolvido);


            // Conectar Bd -- Conexao(Instanciar a Classe)
            try
            {
                cmd.Connection = conexao.conectar();
                // Executar comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar Bd
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso

                return true;


            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public DataTable Select(int codigo)
        {



            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);


            // Comando Sql (insert, update, delete) -- SqlCommand
            cmd.CommandText = "Select h.* from Historico h left join Equipamento e on e.Ide = h.Equipamento_Ide where e.Codigo = @codigo and h.Status != -1";
            // Parametros
            cmd.Parameters.AddWithValue("@codigo", codigo);



            // Conectar Bd -- Conexao(Instanciar a Classe)
            try
            {

               
                cmd.Connection = conexao.conectar();
                // Executar comando Sql
               
                DataTable Equipamento = new DataTable();
                
                sqa.Fill(Equipamento);




                // Desconectar Bd
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                return Equipamento;


            }
            catch (Exception)
            {

            }
            return null;

        }


        public Guid SelectIde(int codigo)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            // Comando Sql para selecionar o ID do equipamento com base no código
            cmd.CommandText = "Select e.Ide, e.Nome from Equipamento e where e.Codigo = @codigo";

            // Parametros
            cmd.Parameters.AddWithValue("@codigo", codigo);

            
            try
            {
                cmd.Connection = conexao.conectar();
                // Executar comando Sql e pegar resultado (ID do equipamento)
                var resultado = cmd.ExecuteScalar();

                // Verificar se o resultado não é nulo e se pode ser convertido para Guid
                if (resultado != null && resultado != DBNull.Value && Guid.TryParse(resultado.ToString(), out Guid equipamentoIde))
                {
                    
                    conexao.desconectar();
                    return equipamentoIde;
                }
            }
            catch (Exception)
            {
               
            }

            return Guid.Empty;
        }


        public bool Update(Guid ide, Guid equipamento_ide, DateTime data_alteracao, bool devolver, bool devolvido)

        {



            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            data_alteracao = DateTime.Now;


            // Comando Sql (insert, update, delete) -- SqlCommand
            cmd.CommandText = "Update Historico Set Data_Alteracao = @data_alteracao, Devolver = @devolver, Devolvido = @devolvido Where Ide = @ide";

            // Parametros
            cmd.Parameters.AddWithValue("@ide", ide);
            cmd.Parameters.AddWithValue("@data_alteracao", data_alteracao);
            cmd.Parameters.AddWithValue("@devolver", devolver);
            cmd.Parameters.AddWithValue("@devolvido", devolvido);



            // Conectar Bd -- Conexao(Instanciar a Classe)
            try
            {
                cmd.Connection = conexao.conectar();
                // Executar comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar Bd
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso

                return true;


            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }


        public bool Delete(Guid ide)

        {



            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();


            // Comando Sql (insert, update, delete) -- SqlCommand
            cmd.CommandText = "Update Historico Set Status = -1 Where Ide = @ide";

            // Parametros
            cmd.Parameters.AddWithValue("@ide", ide);



            // Conectar Bd -- Conexao(Instanciar a Classe)
            try
            {
                cmd.Connection = conexao.conectar();
                // Executar comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar Bd
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso

                return true;


            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }


    }
    
}








