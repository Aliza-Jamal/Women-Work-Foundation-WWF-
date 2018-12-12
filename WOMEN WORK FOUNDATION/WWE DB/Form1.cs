using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WWE_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SHOW_ITEMS_Click(object sender, EventArgs e)
        {
            tables_panel.Visible = true;
            dataGridView1.Visible = true;
            BUY_NOW.Visible = true;
            String conString = "Data Source=ABASIT-PC\\SQLEXPRESS;Initial Catalog=womens_working;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT *FROM ITEMS",conn);
            try
            {
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = com;
                DataTable dbdata = new DataTable();
                sa.Fill(dbdata);
                BindingSource bd = new BindingSource();
                bd.DataSource = dbdata;
                dataGridView1.DataSource = bd;
               
                
               
                
                sa.Update(dbdata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void SHOW_MAKER_Click(object sender, EventArgs e)
        {
            tables_panel.Visible = true;
            dataGridView1.Visible = true;
            BUY_NOW.Visible = false;
            String conString = "Data Source=ABASIT-PC\\SQLEXPRESS;Initial Catalog=womens_working;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT *FROM MAKER", conn);
            try
            {
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = com;
                DataTable dbdata = new DataTable();
                sa.Fill(dbdata);
                BindingSource bd = new BindingSource();
                bd.DataSource = dbdata;
                dataGridView1.DataSource = bd;


                //dataGridView1.DataSource = bd;

                sa.Update(dbdata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SHOW_BUYER_Click(object sender, EventArgs e)
        {
            tables_panel.Visible = true;
            dataGridView1.Visible = true;
            BUY_NOW.Visible = false;
            String conString = "Data Source=ABASIT-PC\\SQLEXPRESS;Initial Catalog=womens_working;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT *FROM BUYER", conn);
            try
            {
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = com;
                DataTable dbdata = new DataTable();
                sa.Fill(dbdata);
                BindingSource bd = new BindingSource();
                bd.DataSource = dbdata;
                dataGridView1.DataSource = bd;
              
                
                //dataGridView1.DataSource = bd;

                sa.Update(dbdata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SHOW_EMP_Click(object sender, EventArgs e)
        {
            tables_panel.Visible = true;
            dataGridView1.Visible = true;
            BUY_NOW.Visible = false;

            String conString = "Data Source=ABASIT-PC\\SQLEXPRESS;Initial Catalog=womens_working;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT *FROM EMPLOYEES", conn);
            try
            {
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = com;
                DataTable dbdata = new DataTable();
                sa.Fill(dbdata);
                BindingSource bd = new BindingSource();
                bd.DataSource = dbdata;
                dataGridView1.DataSource = bd;
                
                
                //dataGridView1.DataSource = bd;

                sa.Update(dbdata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void SHIPPING_WOKERS_Click(object sender, EventArgs e)
        {
            tables_panel.Visible = true;
            dataGridView1.Visible = true;
            BUY_NOW.Visible = false;

            String conString = "Data Source=ABASIT-PC\\SQLEXPRESS;Initial Catalog=womens_working;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand com = new SqlCommand("SELECT *FROM Shipping_Workers", conn);
            try
            {
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = com;
                DataTable dbdata = new DataTable();
                sa.Fill(dbdata);
                BindingSource bd = new BindingSource();
                bd.DataSource = dbdata;
                dataGridView1.DataSource = bd;


                //dataGridView1.DataSource = bd;

                sa.Update(dbdata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BUY_NOW_Click(object sender, EventArgs e)
        {

        }
       
        
        
    }
}
