using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Classes
{
    public class NotaFiscal
    {
        public int notaFiscal_idCliente;
        public int notaFiscal_idProduto;
        public string quantidade;
        public string valorTotal;

        public NotaFiscal(int notaFiscal_idCliente, int notaFiscal_idProduto, string quantidade, string valorTotal)
        {
            this.notaFiscal_idCliente = notaFiscal_idCliente;
            this.notaFiscal_idProduto = notaFiscal_idProduto;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }

        public bool cadastrarNotaFiscal()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into NotaFiscal values (@notaFiscal_idCliente, @notaFiscal_idProduto, @quantidade, @valorTotal)";
            cmd.Parameters.Add("@notaFiscal_idCliente", SqlDbType.Int);
            cmd.Parameters.Add("@notaFiscal_idProduto", SqlDbType.Int);
            cmd.Parameters.Add("@quantidade", SqlDbType.VarChar);
            cmd.Parameters.Add("@valorTotal", SqlDbType.VarChar);

            cmd.Parameters[0].Value = notaFiscal_idCliente;
            cmd.Parameters[1].Value = notaFiscal_idProduto;
            cmd.Parameters[2].Value = quantidade;
            cmd.Parameters[3].Value = valorTotal;

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



    }
}
