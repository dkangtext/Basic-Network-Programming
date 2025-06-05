﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Chuong2Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnRead_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            fs.Close();
            MessageBox.Show("There are " + lineCount + " lines in " + ofd.FileName);
        }
    }
}
