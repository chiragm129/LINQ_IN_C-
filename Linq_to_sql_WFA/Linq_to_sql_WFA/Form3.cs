using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_to_sql_WFA
{
    public partial class Form3 : Form
    {
        StudentDBDataContext db;
        public Form3()
        {
            InitializeComponent();
        }

        private void NEXTbutton_TextChanged(object sender, EventArgs e)
        {

        }

        private void PREVIOUSbutton_Click(object sender, EventArgs e)
        {

        }

        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            db = new StudentDBDataContext();
            db.spInsertStudent(NAMEtextBox.Text,GENDERtextBox.Text,int.Parse(AGEtextBox.Text),int.Parse(CLASStextBox.Text));
            MessageBox.Show("Data has been inserted successfully");
        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
