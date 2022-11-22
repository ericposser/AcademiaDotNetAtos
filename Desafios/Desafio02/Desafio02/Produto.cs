using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Classes
{
    internal class Produto
    {
        public int idProduto;
        public string nomeProduto;
        public float preco;


        public Produto(int idProduto, string nomeProduto, float preco)
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.preco = preco;

        }

        public bool cadastrarProduto()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Produto values (@nomeProduto, @preco)";
            cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
            cmd.Parameters.Add("@preco", SqlDbType.Float);

            cmd.Parameters[0].Value = nomeProduto;
            cmd.Parameters[1].Value = preco;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }

        public bool removerProduto()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Produto where idProduto = @idProduto";
            command.Parameters.Add("@idProduto", SqlDbType.Int);
            command.Parameters[0].Value = idProduto;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

    }
}
