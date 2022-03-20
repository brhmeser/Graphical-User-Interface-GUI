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

namespace PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "Düğüm0")
            {
                label1.Text = "UCGEN MI ?";
                label3.Text = "SONUC";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
            }
            if (treeView1.SelectedNode.Name == "Düğüm1")
            {
                label1.Text = "KARE MI ?";
                label3.Text = "SONUC";
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (treeView1.SelectedNode.Name == "Düğüm2")
            {
                label1.Text = "KAGIT TAS MAKAS OYUNU";
                label3.Text = "SONUC";
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (treeView1.SelectedNode.Name == "Düğüm3")
            {
                label1.Text = "ALTDIZGI MI ?";
                label3.Text = "SONUC";
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (treeView1.SelectedNode.Name == "Düğüm4")
            {
                label1.Text = "ON EK VEYA ART EK MI ?";
                label3.Text = "SONUC";
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"E:/cikti.txt";

            File.Delete(fileName);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode.Name == "Düğüm0")
            {
              int a, b, c;
                
              a = int.Parse(textBox1.Text);
              b = int.Parse(textBox2.Text);
              c = int.Parse(textBox3.Text);
                if (a > 0 && b > 0 && c > 0)
                {
                    if ((a - b < c) && (a + b > c) && (a - c < b) && (a + c > b) && (b - c < a) && (b + c > a))
                {
                    label3.Text = "UCGEN";
                }
                else
                    label3.Text = "UCGEN DEGIL";
                }
                else
                    MessageBox.Show("GIRDI HATASI");
                kaydet();
            }

            if (treeView1.SelectedNode.Name == "Düğüm1")
            {
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox3.Text);
                if (a > 0 && b > 0) { 
                     if (a*a!=b)
                        label3.Text = "KARE DEGIL";
                    else
                        label3.Text = "KARE";
                }
                else
                    MessageBox.Show("GIRDI HATASI");
                kaydet();
            }

            if (treeView1.SelectedNode.Name == "Düğüm2")
            {
                // oyun verilen örnek koşmalardaki gibi türkçe karakterlere duyarlı değildir.

                if (textBox1.Text.ToLower() == "makas" & textBox3.Text.ToLower() == "tas")
                {
                    label3.Text = "YENEMEDI";
                }
                else if (textBox1.Text.ToLower() == "makas" & textBox3.Text.ToLower() == "kagit")
                {
                    label3.Text = "YENDI";
                }
                else if (textBox1.Text.ToLower() == "kagit" & textBox3.Text.ToLower() == "tas")
                {
                    label3.Text = "YENDI";
                }
                else if (textBox1.Text.ToLower() == "tas" & textBox3.Text.ToLower() == "makas")
                {
                    label3.Text = "YENDI";
                }
                else if (textBox1.Text.ToLower() == "kagit" & textBox3.Text.ToLower() == "makas")
                {
                    label3.Text = "YENEMEDI";
                }
                else if (textBox1.Text.ToLower() == "tas" & textBox3.Text.ToLower() == "kagit")
                {
                    label3.Text = "YENEMEDI";
                }
                else if (textBox1.Text.ToLower() == textBox3.Text.ToLower())
                    label3.Text = "YENEMEDI";
                kaydet();
               
            }
            if (treeView1.SelectedNode.Name == "Düğüm3")
            {
                bool dogrumu = false;
                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (i < textBox3.Text.Length - textBox1.Text.Length+1)
                    { 
                     
                        if (textBox1.Text == textBox3.Text.Substring(i, textBox1.Text.Length))
                            dogrumu = true;
                    }
                }            
                if (dogrumu)
                    label3.Text = "ALTDIZGI";
                else
                    label3.Text = "ALTDIZGI DEGIL";
                kaydet();
            }

            if (treeView1.SelectedNode.Name == "Düğüm4")
            {
                bool dogrumu = true;

                    if (textBox1.Text == textBox3.Text.Substring(textBox3.Text.Length - textBox1.Text.Length))
                    { 
                        label3.Text = "ART EK";
                          dogrumu = false;
                    }
    
                    if (textBox1.Text == textBox3.Text.Substring(0, textBox1.Text.Length)) 
                    { 
                        label3.Text = "ON EK";
                        dogrumu = false;
                    }
                    if(dogrumu)
                    label3.Text = "HICBIRI DEGIL";
                    
                kaydet();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);        
            if (sonuc == DialogResult.Yes)
            {
                
                this.Close();
                Application.Exit();
            }
        }
        void kaydet()
        {
            string fileName = @"E:/cikti.txt";
                       
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            if (treeView1.SelectedNode.Name == "Düğüm0")
            
              sw.WriteLine("" + label1.Text + " : " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
           
            else
              sw.WriteLine("" + label1.Text + " : " + textBox1.Text  + " " + textBox3.Text);
              sw.WriteLine("" + label3.Text);
              sw.Close();

        }
    }
}