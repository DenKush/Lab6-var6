using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__5.Вариант_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Мама мыла раму");
            listBox1.Items.Add("Привет, мир");
            listBox1.Items.Add("Томский политехнический университет");
            listBox1.Items.Add("Visual C#");
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder str1=new StringBuilder("");
            StringBuilder str2 = new StringBuilder("");
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            for(int i=0; i<str.Length;i++)
            {
                if (i % 2 == 1)
                    str1.Append(str[i]);
                else
                    str2.Append(str[i]);
            }
            label1.Text = str1.ToString();
            label2.Text = str2.ToString();
        }
    }
}
