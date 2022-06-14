using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateFo_Click(object sender, EventArgs e)
        {
            string path = @"G:\\Test\\";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Folder Are Alredy Exists");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Folder is Created");
            }
        }

        private void btnCreateFi_Click(object sender, EventArgs e)
        {
            string path = @"G:\Test\sanket.txt";
            FileInfo fi = new FileInfo(path);   
            if(fi.Exists)
            {
                MessageBox.Show("File Are Alredy Exist");
            }
            else
            {
                fi.Create();
                MessageBox.Show("File is Created");

            }
        }
    }
}
