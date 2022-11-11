using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroWFSQL
{
    internal class Empregado
    {
        public string nome;
        public string funcao;
        public string dataAdimissao;
        public string salario;
        public string comissao;



        public Empregado(string nome, string funcao, string dataAdimissao, string salario, string comissao)
        {
            this.nome = nome;
            this.funcao = funcao;
            this.dataAdimissao = dataAdimissao;
            this.salario = salario;
            this.comissao = comissao;
        }

        public bool gravarEmpregado()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Empregado values (@nome, @funcao, @dataAdimissao, @salario, @comissao)";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@funcao", SqlDbType.VarChar);
            cmd.Parameters.Add("@dataAdimissao", SqlDbType.VarChar);
            cmd.Parameters.Add("@salario", SqlDbType.VarChar);
            cmd.Parameters.Add("@comissao", SqlDbType.VarChar);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = funcao;
            cmd.Parameters[2].Value = dataAdimissao;
            cmd.Parameters[3].Value = salario;
            cmd.Parameters[4].Value = comissao;


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
