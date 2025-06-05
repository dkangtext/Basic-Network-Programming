using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Chuong2Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            company Vendor = new company();
            company Buyer = new company();
            lineItem Goods = new lineItem();
            purchaseOrder po = new purchaseOrder();
            Vendor.name = "Acme Inc.";
            Buyer.name = "Wiley E. Coyote";
            Goods.description = "anti-RoadRunner cannon";
            Goods.quantity = 1;
            Goods.cost = 599.99;
            po.items = new lineItem[1];
            po.items[0] = Goods;
            po.buyer = Buyer;
            po.vendor = Vendor;
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = File.Create("..\\po.xml");
            sf.Serialize(fs, po);
            fs.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = File.OpenRead("..\\po.xml");
            purchaseOrder po = (purchaseOrder)sf.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Customer is " + po.buyer.name + 
                "\nVendor is " + po.vendor.name + ", phone is " + po.vendor.phone +
                "\nItem is " + po.items[0].description + " has quantity " +
                po.items[0].quantity.ToString() + ", has cost " + po.items[0].cost.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            company Vendor = new company();
            company Buyer = new company();
            lineItem Goods = new lineItem();
            purchaseOrder po = new purchaseOrder();
            Vendor.name = "Microsoft Inc.";
            Buyer.name = "Bill Gate";
            Goods.description = "anti-RoadRunner cannon";
            Goods.quantity = 1;
            Goods.cost = 599.99;
            po.items = new lineItem[1];
            po.items[0] = Goods;
            po.buyer = Buyer;
            po.vendor = Vendor;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Create("..\\po_bin.txt");
            bf.Serialize(fs, po);
            fs.Close();
            MessageBox.Show("Serialize succesful!", "Info");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenRead("..\\po_bin.txt");
            purchaseOrder po = (purchaseOrder)bf.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Customer is " + po.buyer.name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            company Vendor = new company();
            company Buyer = new company();
            lineItem Goods = new lineItem();
            purchaseOrder po = new purchaseOrder();
            Vendor.name = "Microsoft Inc.";
            Buyer.name = "Paul Allen";
            Goods.description = "Microsoft Office 2010";
            Goods.quantity = 5;
            Goods.cost = 1500;
            po.items = new lineItem[1];
            po.items[0] = Goods;
            po.buyer = Buyer;
            po.vendor = Vendor; 
            XmlSerializer xs = new XmlSerializer(po.GetType());
            FileStream fs = File.Create("..\\po1.xml");
            xs.Serialize(fs, po);
            fs.Close(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            purchaseOrder po = new purchaseOrder();
            XmlSerializer xs = new XmlSerializer(po.GetType());
            FileStream fs = File.OpenRead("..\\po1.xml");
            po = (purchaseOrder)xs.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Customer is " + po.buyer.name +
                "\nVendor is " + po.vendor.name + ", phone is " + po.vendor.phone +
                "\nItem is " + po.items[0].description + " has quantity " +
                po.items[0].quantity.ToString() + ", has cost " + po.items[0].cost.ToString());
        }
    }

    public enum purchaseOrderStates
    {
        ISSUED,
        DELIVERED,
        INVOICED,
        PAID
    }
    [Serializable()]
    public class company
    {
        public string name;
        public string address;
        public string phone;
    }
    [Serializable()]
    public class lineItem
    {
        public string description;
        public int quantity;
        public double cost;
    }
    [Serializable()]
    public class purchaseOrder
    {
        private purchaseOrderStates _purchaseOrderStatus;
        private DateTime _issuanceDate;
        private DateTime _deliveryDate;
        private DateTime _invoiceDate;
        private DateTime _paymentDate;
        public company buyer;
        public company vendor;
        public string reference;
        public lineItem[] items;

        public purchaseOrder()
        {
            _purchaseOrderStatus = purchaseOrderStates.ISSUED;
            _issuanceDate = DateTime.Now;
        }
        public void recordDelivery()
        {
            if (_purchaseOrderStatus == purchaseOrderStates.ISSUED)
            {
                _purchaseOrderStatus = purchaseOrderStates.DELIVERED;
                _deliveryDate = DateTime.Now;
            }
        }
        public void recordInvoice()
        {
            if (_purchaseOrderStatus == purchaseOrderStates.DELIVERED)
            {
                _purchaseOrderStatus = purchaseOrderStates.INVOICED;
                _invoiceDate = DateTime.Now;
            }
        }
        public void recordPayment()
        {
            if (_purchaseOrderStatus == purchaseOrderStates.INVOICED)
            {
                _purchaseOrderStatus = purchaseOrderStates.PAID;
                _paymentDate = DateTime.Now;
            }
        }
    }

}
