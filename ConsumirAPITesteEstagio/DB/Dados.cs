using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumirAPITesteEstagio.DB
{
    class Dados
    {
        Conexao con = new Conexao();


        public void cadDados(int id,int userid, string title, string body)
        {
            SqlCommand cmd = new SqlCommand("EXEC USP_CAD_DADOS @USERID, @ID, @TITLE, @BODY",con.conectarDB());
            cmd.Parameters.Add("@USERID", SqlDbType.Int).Value = userid;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@TITLE", SqlDbType.VarChar).Value = title;
            cmd.Parameters.Add("@BODY", SqlDbType.VarChar).Value = body;
            cmd.ExecuteNonQuery();

            con.desconectarDB();

            MessageBox.Show("Registro adicionado com sucesso!");
        }
        public DataSet consDados()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("EXEC USP_CONSU_TODOS_DADOS", con.conectarDB());
            da.Fill(ds);
            con.desconectarDB();
            return ds;
        }
    }
}
