using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Base
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Year Three\First Smester\Data Base\Last\Nu Electronics.mdf;Integrated Security=True;Connect Timeout=30");
        //population function
        void populate()
        {
            Con.Open();
            string query = "select ProductName, ProductQuantity,ProductPrice from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdGDV1.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void CusAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ProdGDV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
