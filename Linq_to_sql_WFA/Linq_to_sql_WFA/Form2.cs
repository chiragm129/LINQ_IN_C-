﻿using System;
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
    public partial class Form2 : Form
    {
        StudentDBDataContext db;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new StudentDBDataContext();
            ISingleResult<spShowStudentsResult> obj = db.spShowStudents(null);
            dataGridView1.DataSource = obj;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("please fill the field");
            }
            else
            {
                db = new StudentDBDataContext();
                ISingleResult<spShowStudentsResult> obj = db.spShowStudents(int.Parse(textBox1.Text));
                dataGridView1.DataSource = obj;
                if(dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("no rows found");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new StudentDBDataContext();
            ISingleResult<spShowStudentsResult> obj = db.spShowStudents(null);
            dataGridView1.DataSource = obj;
        }
    }
}
