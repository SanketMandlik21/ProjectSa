using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblEMP_ID_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpName_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
       
            MessageBox.Show("\n "+txtEMP_ID.Text +"\n "+txtEmpName.Text+"\n "+txtSalary.Text);
        }
                                          
        private void button2_Click(object sender, EventArgs e)
        {
            txtEmpName.Clear();
            txtEMP_ID.Clear();
            txtSalary.Clear();

        }
    }
}
