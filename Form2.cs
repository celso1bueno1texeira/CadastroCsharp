using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        
        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void AddUser_Click(object sender, EventArgs e)
        {
            CadUsuario cad = new CadUsuario();
            cad.Show();
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            UserEdit user = new UserEdit();
            user.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

        }       

        private void btndeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
