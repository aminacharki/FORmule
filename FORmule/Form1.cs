
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
         static String chaine  = "server=localhost; user id=root;password= ;database=car";
        public Form1()
        {
            InitializeComponent();
        }
        int nb;
        static MySqlConnection  cnx = new MySqlConnection(chaine);
        static MySqlCommand  cmd = new MySqlCommand();
        static MySqlDataAdapter adapter =new MySqlDataAdapter (cmd);
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttajouute_Click(object sender, EventArgs e)
        {
            nb = 1;
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into carcompos  values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            buttajouute.Enabled = false ;
            buttmodifier.Enabled = false;
            buttonsupp.Enabled = false;
            buttoncomfirm.Enabled = true;
            buttonannul.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            cnx.Close();
        }

        private void buttmodifier_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "uptade set carcompos   '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'where id " +textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            buttajouute.Enabled = false;
            buttmodifier.Enabled = false;
            buttonsupp.Enabled = false;
            buttoncomfirm.Enabled = true;
            buttonannul.Enabled = true;
            cnx.Close();
        }

        private void buttoncomfirm_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.ExecuteNonQuery();
            buttajouute.Enabled = false;
            buttmodifier.Enabled = false;
            buttonsupp.Enabled = false;
            buttoncomfirm.Enabled = true;
            buttonannul.Enabled = false;
            
            cnx.Close();
        }

        private void buttonannul_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.ExecuteNonQuery();
            buttajouute.Enabled = false;
            buttmodifier.Enabled = false;
            buttonsupp.Enabled = false;
            buttoncomfirm.Enabled = false;
            buttonannul.Enabled = false;
            cnx.Close();
        }
        
        
        private void buttonsupp_Click(object sender, EventArgs e)
        {
            nb = 2;
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from carcompos where idcar = '" + textBox1.Text +  "')";
            cmd.ExecuteNonQuery();
            buttajouute.Enabled = false;
            buttmodifier.Enabled = false;
            buttonsupp.Enabled = false;
            buttoncomfirm.Enabled = true;
            buttonannul.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            cnx.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
