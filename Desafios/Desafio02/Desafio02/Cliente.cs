using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Classes
{
    internal class Cliente
    {
        public int idCliente;
        public string nomeCliente;
        public string telefone;

        public Cliente()
        {
        }

        public Cliente(int idCliente,string nomeCliente, string telefone)
        {
            this.idCliente = idCliente;
            this.nomeCliente = nomeCliente;
            this.telefone = telefone;
        }

        public bool cadastrarCliente()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Cliente values (@nomeCliente, @telefone)";
            cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

            cmd.Parameters[0].Value = nomeCliente;
            cmd.Parameters[1].Value = telefone;

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

        public bool removerCliente()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Cliente where idCliente = @idCliente";
            command.Parameters.Add("@idCliente", SqlDbType.Int);
            command.Parameters[0].Value = idCliente;

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
