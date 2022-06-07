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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(txtBox.Text);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          listBox.Items.Remove(listBox.SelectedItems);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            txtBox.Clear();
        }
    }
}
