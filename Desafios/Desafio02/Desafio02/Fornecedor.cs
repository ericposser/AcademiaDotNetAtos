using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Classes
{
    internal class Fornecedor
    {
        public int idFornecedor;
        public string nomeFornecedor;

        public Fornecedor(int idFornecedor, string nomeFornecedor)
        {
            this.idFornecedor = idFornecedor;
            this.nomeFornecedor = nomeFornecedor;
        }

        public bool cadastrarFornecedor()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Fornecedor values (@nomeFornecedor)";
            cmd.Parameters.Add("@nomeFornecedor", SqlDbType.VarChar);

            cmd.Parameters[0].Value = nomeFornecedor;


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

        public bool removerFornecedor()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Fornecedor where idFornecedor = @idFornecedor";
            command.Parameters.Add("@idFornecedor", SqlDbType.Int);
            command.Parameters[0].Value = idFornecedor;

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
