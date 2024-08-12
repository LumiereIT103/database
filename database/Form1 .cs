using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Markup;

namespace database
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection
            ("SERVER=LOCALHOST; DATABASE=demo; UID=root; PASSWORD=bobo;");

        //Methods only
        void viewGridData()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM resident", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        //-------------------------------------














        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void viewGrid_Click(object sender, EventArgs e)
        {

            viewGridData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void Insertbt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("insert into resident(Name,Adress,email ) value ('" + name_tx.Text + "', '" + address_tx.Text + "','" + email_tx.Text + "')", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Data Inserted");
                viewGridData();

            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }
    }
}
