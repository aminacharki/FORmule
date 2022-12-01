
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FORmule
{
    public partial class Form1 : Form
    {
        MySqlConnection MySQLConnection = new MySqlConnection();
        MySqlDataAdapter MySQLAdapter = new MySqlDataAdapter();
        String MySQLChaineConnection = "server=localhost; user id=root;password= ;database=carcopos"
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttajouute_Click(object sender, EventArgs e)
        {
            buttajouute.Enabled=false;
            buttmodifier.Enabled=false;
            buttoncomfirm.Enabled=true;
        }

        private void buttmodifier_Click(object sender, EventArgs e)
        {

        }

        private void buttoncomfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonannul_Click(object sender, EventArgs e)
        {

        }
    }
}
