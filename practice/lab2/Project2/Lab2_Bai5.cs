using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Lab2_Bai5 : Form
    {
        public Lab2_Bai5()
        {
            InitializeComponent();
        }


        static private string lastPath = "";

        private void btBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbd.SelectedPath;
                LSV(fbd.SelectedPath);
                lastPath = fbd.SelectedPath;
            }
        }

        private void LSV(string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                listView1.Items.Clear();
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                            new ListViewItem.ListViewSubItem(item, dir.CreationTime.ToString()),
                            new ListViewItem.ListViewSubItem(item, "Folder"),
                            new ListViewItem.ListViewSubItem(item, "")
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }

                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                            new ListViewItem.ListViewSubItem(item, file.CreationTime.ToString()),
                            new ListViewItem.ListViewSubItem(item, file.Extension),
                            new ListViewItem.ListViewSubItem(item, file.Length.ToString())
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing the directory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            if (lastPath == null)
            {
                string currentFolderPath = tbPath.Text;
                DirectoryInfo currentDirectory = new DirectoryInfo(currentFolderPath);
                DirectoryInfo parentDirectory = currentDirectory.Parent;
                if (parentDirectory != null)
                {
                    tbPath.Text = parentDirectory.FullName;
                    LSV(parentDirectory.FullName);
                    lastPath = parentDirectory.FullName;
                }
                else
                {
                    MessageBox.Show("This folder does not have a parent directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbPath.Text = lastPath;
                LSV(lastPath);
                lastPath = null;
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
