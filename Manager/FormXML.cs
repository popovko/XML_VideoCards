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
using System.Xml.Xsl;
using System.IO;

namespace XMLlab3
{
    public partial class FormXML : Form
    {
        int thsVC=0;

        public StringBuilder DataBase { get; private set; }

        public FormXML()
        {
            InitializeComponent();
        }

        private void FormXML_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvw.Items.Clear();
            if (rbDOM.Checked)
            {
                    List<string> l = new List<string>();
                    l = DOM.ParseDOM(cbxName.Text, cbxChip.Text, cbxMemory.Text, cbxType.Text, cbxPhoto.Text, cbxPrice.Text);
                    for (int i = 0; i < l.Count(); i++)
                    {
                        lvw.Items.Add('\n'.ToString());
                        lvw.Items.Add(l[i], 0);
                    }
            }
            if (rbLinq.Checked)
            {
                    List<string> l = new List<string>();
                    l = LINQ.ParseLinqToXML(cbxName.Text, cbxChip.Text, cbxMemory.Text,cbxType.Text,cbxPrice.Text,cbxPhoto.Text);
                    for (int i = 0; i < l.Count(); i++)
                    {
                        lvw.Items.Add('\n'.ToString());
                        lvw.Items.Add(l[i], 0);
                    }
            }
            if (rbSAX.Checked)
            {
                string l = SAX.ParseSAX(cbxName.Text, cbxChip.Text, cbxMemory.Text, cbxType.Text, cbxPhoto.Text, cbxPrice.Text, thsVC);
                thsVC++;
                lvw.Items.Clear();
                lvw.Items.Add(l);
            }
        }

        private void btnToHTML_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"D:\Прога\C#\XML(lab3)\Manager\XmlToHtml.xsl");
            string fXML = @"D:\Прога\C#\XML(lab3)\Manager\XMLD.xml";
            string fHtml = @"D:\Прога\C#\XML(lab3)\Manager\Html.html";
            xct.Transform(fXML, fHtml);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            thsVC = 0;
            lvw.Items.Clear();
        }
    }
}
