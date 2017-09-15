using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsumirAPITesteEstagio.DB
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DB_TESTEAPI;Data Source=METROMAN\SQLEXPRESS");
        public SqlConnection conectarDB()
        {
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex.Message);
            }
            return con;
        }  
        public SqlConnection desconectarDB()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex.Message);
            }
            return con;
        }    
    }
}
