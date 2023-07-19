﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHistorico2
{

    
    public class CadastroProduto
    {
        public string mensagem = "insert";
        public CadastroProduto(String ide, String codigo, String nome, String Descricao,
            String DataAquisicao, String NumeroSerie, String VidaUtil, String ValorCompra,
            String Categoria, String Setor, String Inativo) { 

            Crudbd crudbd = new Crudbd();
            SqlCommand cmd = new SqlCommand();
            

            // Comando Sql (insert, update, delete) -- SqlCommand
            cmd.CommandText = "";
            // Parametros
            cmd.Parameters.AddWithValue( "", );

            // Conectar Bd -- Conexao(Instanciar a Classe)
            try
            {
                cmd.Connection = crudbd.conectar();
                // Executar comando Sql
                cmd.ExecuteReader();
                // Desconectar Bd
                crudbd.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Produto cadastrado com sucesso!";
                 

            }
            catch (Exception)
            {

                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados!";
                
            }
   

        }
    }
}
