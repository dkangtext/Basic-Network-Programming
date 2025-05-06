using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Xml.Serialization;

namespace Chuong2Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("about:blank", null, null, null);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //SQL connection
            //string szDSN = "Data Source=192.168.5.14; Initial Catalog = TestNetProg;" +
            //     "User ID=sa; Password=1234;" +
            //    "Integrated Security=True;"; //MAYAO hoac 192.168.5.14

            //Access 2003 connection
            //string szDSN = "Provider=Microsoft.JET.OLEDB.4.0;Data Source= ../../Test1.MDB" +
            //       ";Persist Security Info=False;";
            //Transaction

            //Access 2007 connection
            string szDSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Test1.mdb;"+
                "Persist Security Info=False";
            OleDbConnection DSN = new OleDbConnection(szDSN);
            XmlSerializer xs = new XmlSerializer(typeof(DataSet));
            DataSet ds = new DataSet();
            DSN.Open();
            OleDbCommand odbc = new OleDbCommand(tbSQL.Text, DSN);
            OleDbDataAdapter odda = new OleDbDataAdapter(odbc);
            odda.Fill(ds, "sql");
            TextWriter tw = new StreamWriter("..\\sql.xml");
            xs.Serialize(tw, ds);
            tw.Close();
            DSN.Close();
            webBrowser.Navigate("D:/Baitap/C-Sharp/Network Programming/Chuong2Bai5/Chuong2Bai5/bin/sql.xml", null, null, null);
        }
    }
}
