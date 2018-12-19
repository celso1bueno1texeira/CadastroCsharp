using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
	public partial class login : Form   
	{
        SqlConnection sqlconn = null;
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Celso\Source\Repos\login\login\systemDB\Empire.mdf;Integrated Security=True;Connect Timeout=30";
        private string strSql = string.Empty;
        internal void Dialog()
        {
            throw new NotImplementedException();
        }

       

        public bool logado = false;

		public login()
		{
			InitializeComponent();
		}

        public void logar()
        {
            sqlconn = new SqlConnection(strConn);

            string login, pwd;

            try
            {
                login = txtlogin.Text;
                pwd = txtsenha.Text;

                strSql = "SELECT COUNT(id) FROM usuario WHERE login = @usuario AND senha = @senha";
                SqlCommand cmd = new SqlCommand(strSql,sqlconn);


                cmd.Parameters.Add("@usuario",SqlDbType.VarChar).Value =  login;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = pwd;

                sqlconn.Open();

                int v = (int)cmd.ExecuteScalar();

                if( v > 0)
                {
                    
                    logado = true;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Erro ao logar... ");
                    logado = false;
                }
               

            }
            catch(Exception Erro)
            {
                MessageBox.Show(Erro+"Login não realizado!!!");
            }

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnentrar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
