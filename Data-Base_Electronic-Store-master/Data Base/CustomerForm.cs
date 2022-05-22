using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Base
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Year Three\First Smester\Data Base\Last\Nu Electronics.mdf;Integrated Security=True;Connect Timeout=30");

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //population
        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CusDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void panal1_Paint(object sender, EventArgs e)
        {
            populate();
        }
        //Gride
        private void CusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CusID.Text = CusDGV.SelectedRows[0].Cells[0].Value.ToString();
            CusName.Text = CusDGV.SelectedRows[0].Cells[1].Value.ToString();
            CusAge.Text = CusDGV.SelectedRows[0].Cells[2].Value.ToString();
            CusPass.Text = CusDGV.SelectedRows[0].Cells[3].Value.ToString();
            CusPhone.Text = CusDGV.SelectedRows[0].Cells[4].Value.ToString();
            CusSpec.Text = CusDGV.SelectedRows[0].Cells[5].Value.ToString();

        }
        //add
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CustomerTable Values('" + CusID.Text + "', '" + CusName.Text + "', '" + CusAge.Text + "', '" + CusPass.Text + "', '" + CusPhone.Text + "', '" + CusSpec.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully");

                Con.Close();
                populate();
                Con.Close();
                populate();
                Con.Close();
                populate();

                CusID.Text = "";
                CusName.Text = "";
                CusAge.Text = "";
                CusPass.Text = "";
                CusPhone.Text = "";
                CusSpec.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //delete
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (CusID.Text == "")
                {
                    MessageBox.Show("Select The Customer to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CustomerTable where CustomerId=" + CusID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    Con.Close();
                    populate();
                    Con.Close();
                    populate();

                    CusID.Text = "";
                    CusName.Text = "";
                    CusAge.Text = "";
                    CusPass.Text = "";
                    CusPhone.Text = "";
                    CusSpec.Text = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Update
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (CusID.Text == "" || CusName.Text == "" || CusAge.Text == "" || CusPass.Text == "" || CusPhone.Text == "" || CusSpec.Text == "")
                {
                    MessageBox.Show("Missing Informtion");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTable set CustomerName='" + CusName.Text + "',CustomerAge='" + CusAge.Text + "',CustomerPassord='" + CusPass.Text + "',CustomerPhone='" + CusPhone.Text + "',CustomerSpeces='" + CusSpec.Text + "'where CustomerId=" + CusID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer  Successfully Updated");
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
            CategoryForm Cat = new CategoryForm();
            Cat.Show();
            this.Hide();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
