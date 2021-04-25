using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;


namespace _1912901046_VizeOdevi
{
    public partial class Form1 : Form
    {
        string xmllink = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";

      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = true;
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument veriler = new XmlDocument();
            veriler.Load(xmllink);
            XmlElement root = veriler.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");


            foreach (XmlNode node in nodes)
            {
                string bolge = node["Bolge"].InnerText;
                string ili= node["ili"].InnerText;
                string durum= node["Durum"].InnerText;
                string maksimumsicaklik= node["Mak"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = bolge;
                row.Cells[1].Value = ili;
                row.Cells[2].Value = maksimumsicaklik;
                row.Cells[3].Value = durum;
                dataGridView1.Rows.Add(row);

           

            }

        }

        void textyaz(String veriler)
        {

            string dosya_yolu = @"D:\MAKÜ\NTP\1912901046 - VizeOdevi\bin\Debug\veri.txt";
            string[] satirler = System.IO.File.ReadAllLines(dosya_yolu, Encoding.GetEncoding("windows-1254"));
            foreach (string c in satirler)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();


        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
        
    
}
