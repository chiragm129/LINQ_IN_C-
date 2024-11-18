using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_to_sql_WFA
{
    public partial class Form1 : Form
    {
        StudentDBDataContext db;
        List<Student> std_list;
        int index_no = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    StudentDBDataContext db = new StudentDBDataContext();
            //    //dataGridView1.DataSource = db.Students;
            //    Table<Student> std_tbl = db.Students;
            //    dataGridView1.DataSource = std_tbl;//same view

            db = new StudentDBDataContext();
            std_list = db.Students.ToList();
            DisplayData();

        }

        private void DisplayData()
        {
            IDtextBox.Text = std_list[index_no].Id.ToString();
            NAMEtextBox.Text = std_list[index_no].name;
            GENDERtextBox.Text = std_list[index_no].gender;
            AGEtextBox.Text = std_list[index_no].age.ToString();
            CLASStextBox.Text = std_list[index_no].standard.ToString();

        }

        private void NEXTbutton_Click(object sender, EventArgs e)
        {
            if (index_no < std_list.Count() - 1)
            {
                index_no++;
                DisplayData();
            }
            else
            {
                MessageBox.Show("this is last record");
            }

        }

        private void PREVIOUSbutton_Click(object sender, EventArgs e)
        {
            if (index_no > 0)
            {
                index_no--;
                DisplayData();
            }
            else
            {
                MessageBox.Show("this is first record");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
