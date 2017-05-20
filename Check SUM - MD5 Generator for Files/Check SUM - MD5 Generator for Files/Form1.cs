using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Check_SUM___MD5_Generator_for_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Loading.Visible = false;
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "All Files|*.*";

            if(openDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if(!File.Exists(openDialog.FileName))
            {
                MessageBox.Show("File does not exist!");
                return;
            }

            FileName.Text = openDialog.FileName;

        }

        private void CalculateMD5_Click(object sender, EventArgs e)
        {
            Loading.Visible = true;
            string MD5 = "";
            if(File.Exists(FileName.Text))
            {
                MD5 = checkMD5(FileName.Text);
            }
            else
            {
                MD5 = "FILE DOES NOT EXIST OR NOT ACCESS!";
            }

            CheckSum.Clear();
            CheckSum.Text = MD5;
            Loading.Visible = false;
        }

        public string checkMD5(string Filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var fileStream = File.OpenRead(Filename))
                {
                    return Encoding.ASCII.GetString(md5.ComputeHash(fileStream));
                    //return Encoding.Default.GetString(md5.ComputeHash(fileStream));
                }
            }
        }

    }
}
