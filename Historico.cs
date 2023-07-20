﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHistorico2
{

    
    public class Historico
    {
        public string mensagem = "insert";
        public bool Inserir(Guid ide, Guid equipamento_ide, String funcionario, DateOnly data_movimento,
                DateOnly data_alteracao, String setor, int status, bool devolver, bool devolvido)
        {

            ide = Guid.NewGuid();
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();


            // Comando Sql (insert, update, delete) -- SqlCommand
            cmd.CommandText = "inset into Historico(ide, equipamento_ide, funcionario, data_movimento, data_alteracao, setor, status, devolver, devolvido) " +
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
                this.mensagem = "Produto cadastrado com sucesso!";
                return true;


            }
            catch (Exception)
            {

                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados!";
                return false;
            }
            return false;
        }

        public DataTable Select(int codigo)
        {



            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            

            // Comando Sql (insert, update, delete) -- SqlCommand
            cmd.CommandText = "Select * from Equipamento e where e.Codigo = @codigo)";
            // Parametros
            cmd.Parameters.AddWithValue("@codigo", codigo);



            // Conectar Bd -- Conexao(Instanciar a Classe)
            try
            {
                cmd.Connection = conexao.conectar();
                // Executar comando Sql
                cmd.ExecuteReader();
                DataTable Equipamento = new DataTable();
                Equipamento.Load(cmd.ExecuteReader());



                // Desconectar Bd
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Produto Encontrado!";

                return Equipamento;


            }
            catch (Exception)
            {

                this.mensagem = "Produto não encontrado!";
                
            }
            return null;


        }
        
    }
}
