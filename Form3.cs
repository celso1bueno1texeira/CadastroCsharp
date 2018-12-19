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
    public partial class CadUsuario : Form
    {
        SqlConnection sqlconn = null;
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Celso\Source\Repos\login\login\systemDB\Empire.mdf;Integrated Security=True;Connect Timeout=30";
        private string strSql = string.Empty;
      

        public CadUsuario()
        {
            InitializeComponent();
        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {
            
        } 
        
        public void salvar_dados()
        {
            sqlconn = new SqlConnection(strConn);

            string login;

            sqlconn.Open();
            try
            {
                login = txtlogin.Text;
               

                strSql = "SELECT COUNT(login) FROM usuario WHERE login = @usuario";
                SqlCommand cmd = new SqlCommand(strSql, sqlconn);


                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = login;



                
                int v = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                if (v == 0)
                {
                       
                        SqlCommand comm = new SqlCommand("INSERT INTO usuario (login,senha)" + "VALUES (@nome,@senha)");
                        comm.Parameters.AddWithValue("@nome", txtlogin.Text);
                        comm.Parameters.AddWithValue("@senha", txtsenha.Text);
                        


                    MessageBox.Show("Cadastrado com sucesso!!!");
                    
                    
                }
                else
                {
                    MessageBox.Show("Usuário já existe!!!");
                  
                }

              
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro + "Usuário não cadastrado!!!");
            }
           

        }
    

        private void button1_Click_1(object sender, EventArgs e)
        {
           salvar_dados();
            Close();
            
        }

        private void CadUsuario_Load_1(object sender, EventArgs e)
        {

        }
    }
        
}
