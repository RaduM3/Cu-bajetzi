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

namespace FilesRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files;
        public int i;
        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(numericUpDown1.Value);
            int ic = Convert.ToInt32(numericUpDown2.Value);
            foreach (string name in files)
            {

                
                progressBar1.Value += 500 / files.Length;
               
                File.Move(name, Directory.GetParent(name).ToString() + "\\"+textBox1.Text + i + ".txt");
                i += ic;
               

            }
            progressBar1.Value = 500;
                   }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 files = Directory.GetFiles(fb.SelectedPath);
               
               

            }

        }
    }
}
