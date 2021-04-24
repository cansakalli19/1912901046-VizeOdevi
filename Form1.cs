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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
        
    
}
