using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data_Base
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Year Three\First Smester\Data Base\Last\Nu Electronics.mdf;Integrated Security=True;Connect Timeout=30");
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTable Values('" + CatidTb.Text + "', '" + CatNameTb.Text + "', '" + CatDesTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");

                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatidTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDesTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatidTb.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTable where CategoryId=" + CatidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatidTb.Text == "" || CatNameTb.Text == "" || CatDesTb.Text == "")
                {
                    MessageBox.Show("Missing Informtion");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTable set Category_Name='" + CatNameTb.Text + "',Category_Description='" + CatDesTb.Text + "'where CategoryId=" + CatidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category  Successfully Updated");
                    Con.Close();
                    populate();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botton2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerForm Cus = new CustomerForm();
            Cus.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
