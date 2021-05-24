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
using System.Configuration;


namespace Crud_operation
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        //consecutive save button
        public void button1_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Crud_operation.Properties.Settings.itpmCRUDConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string sqlquery = " insert into consecutivetable values (@sesID,@lecture1,@lecture2,@subject_code,@subject_name,@groupID,@tag,@NoOfStudents,@duration) ";
                    SqlCommand sqlconm = new SqlCommand(sqlquery, sqlconn);
                    sqlconm.Parameters.AddWithValue("@sesID", dr.Cells[1].Value);
                    sqlconm.Parameters.AddWithValue("@lecture1", dr.Cells[2].Value);
                    sqlconm.Parameters.AddWithValue("@lecture2", dr.Cells[3].Value);
                    sqlconm.Parameters.AddWithValue("@subject_code", dr.Cells[4].Value);
                    sqlconm.Parameters.AddWithValue("@subject_name", dr.Cells[5].Value);
                    sqlconm.Parameters.AddWithValue("@groupID", dr.Cells[6].Value);
                    sqlconm.Parameters.AddWithValue("@tag", dr.Cells[7].Value);
                    sqlconm.Parameters.AddWithValue("@NoOfStudents", dr.Cells[8].Value);
                    sqlconm.Parameters.AddWithValue("@duration", dr.Cells[9].Value);

                    sqlconn.Open();
                    sqlconm.ExecuteNonQuery();
                    sqlconn.Close();
                    DataShow_consecutivetable();

                }

            }
            MessageBox.Show("data added to consecutive table", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //showing consecutive table
        private void DataShow_consecutivetable()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R9GQG21K\SQLEXPRESS;Initial Catalog=itpmCRUD;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM consecutivetable", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewConsecutive.DataSource = dt;
            con.Close();

        }

        //showing parallel table
        private void DataShow_paralleltable()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R9GQG21K\SQLEXPRESS;Initial Catalog=itpmCRUD;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM paralleltable", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewparallel.DataSource = dt;
            con.Close();

        }


        //session table in consecutive session
        private void sessiontable_reteive_consecutive()
        {
            // TODO: This line of code loads data into the 'itpmCRUDDataSet.sessiontable' table. You can move, or remove it, as needed.
            this.sessiontableTableAdapter.Fill(this.itpmCRUDDataSet.sessiontable);
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);

            DataShow_consecutivetable();
        }

        //session table in parallel session
        private void sessiontable_reteive_parallel()
        {
            // TODO: This line of code loads data into the 'itpmCRUDDataSet.sessiontable' table. You can move, or remove it, as needed.
            this.sessiontableTableAdapter.Fill(this.itpmCRUDDataSet.sessiontable);
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView_sespar.Columns.Insert(0, chkbox);

            DataShow_paralleltable();
        }




        private void Form5_Load(object sender, EventArgs e)
        {

            sessiontable_reteive_consecutive();
            sessiontable_reteive_parallel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewsession_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewsession_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //parallel save button
        private void button3_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Crud_operation.Properties.Settings.itpmCRUDConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string sqlquery = " insert into paralleltable values (@sesID,@lecture1,@lecture2,@subject_code,@subject_name,@groupID,@tag,@NoOfStudents,@duration) ";
                    SqlCommand sqlconm = new SqlCommand(sqlquery, sqlconn);
                    sqlconm.Parameters.AddWithValue("@sesID", dr.Cells[1].Value);
                    sqlconm.Parameters.AddWithValue("@lecture1", dr.Cells[2].Value);
                    sqlconm.Parameters.AddWithValue("@lecture2", dr.Cells[3].Value);
                    sqlconm.Parameters.AddWithValue("@subject_code", dr.Cells[4].Value);
                    sqlconm.Parameters.AddWithValue("@subject_name", dr.Cells[5].Value);
                    sqlconm.Parameters.AddWithValue("@groupID", dr.Cells[6].Value);
                    sqlconm.Parameters.AddWithValue("@tag", dr.Cells[7].Value);
                    sqlconm.Parameters.AddWithValue("@NoOfStudents", dr.Cells[8].Value);
                    sqlconm.Parameters.AddWithValue("@duration", dr.Cells[9].Value);

                    sqlconn.Open();
                    sqlconm.ExecuteNonQuery();
                    sqlconn.Close();
                    DataShow_paralleltable();
                }
            }
        }
    }
}
