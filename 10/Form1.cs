using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class college
        {
            private string officalName;
            private string officalAdress;
            private int officalGroupsCount;


            public college() { }
            public college(string name, string adress, int groupCount)
            {
                officalName = name;
                officalAdress = adress;
                officalGroupsCount = groupCount;
            }



            public virtual string getInfo()
            {
                string info;
                info = "Название: " + officalName + Environment.NewLine + "Адрес: " + officalAdress + ";  Количество групп: " + officalGroupsCount + Environment.NewLine;
                MessageBox.Show("zxc");
                return info;
            }

            public class facultet : college
            {
                protected string officalTeacher;
                public facultet() { }
                public facultet(string officalName, string officalAdress, int groupCount, string teacher)
                    : base(officalName, officalAdress, groupCount)
                {
                    officalTeacher = teacher;
                }
                public override string getInfo()
                {
                    string info;
                    info = "Название: " + officalName + Environment.NewLine + "Адрес: " + officalAdress + Environment.NewLine + "Количество групп: " + officalGroupsCount + Environment.NewLine + "Преподователь: " + officalTeacher + Environment.NewLine;
                    return info;
                }

            }
            public class cafedra : college
            {
                protected string officalTeacher;
                public cafedra() { }
                public cafedra(string officalName, string officalAdress, int groupCount, string teacher)
                    : base(officalName, officalAdress, groupCount)
                {
                    officalTeacher = teacher;
                }

                public override string getInfo()
                {
                    string info;
                    info = "Название: " + officalName + Environment.NewLine + "Адрес: " + officalAdress + Environment.NewLine + "Количество групп: " + officalGroupsCount + Environment.NewLine + "Преподователь: " + officalTeacher + Environment.NewLine;
                    return info;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                college.facultet kolledg ;
                kolledg = new college.facultet(Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToString(textBox4.Text));
                richTextBox1.Text += kolledg.getInfo() + Environment.NewLine;
            }
            else
            {
                college.cafedra kolledg;
                kolledg = new college.cafedra(Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToString(textBox4.Text));
                richTextBox1.Text += kolledg.getInfo() + Environment.NewLine;
            }
        }
    }
}
