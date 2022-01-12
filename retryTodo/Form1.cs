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

namespace retryTodo
{
    public partial class Form1 : Form
    {
        public List<string> todoList = new List<string>();
        public Form1()
        {
            InitializeComponent();

            string path = @"C:\Users\dawoon101\source\repos\project\file.txt";
            string[] lines = new string[] { "" };

            try
            {
                if(File.Exists(path))
                {
                    lines = File.ReadAllLines(path);
                }
                else
                {
                    File.Create(path);
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }

            foreach(string item in lines)
            {
                todoList.Add(item);
                listBox1.Items.Add(item);
            }
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            todoList.Add(todoTxtBox.Text);
            listBox1.Items.Add(todoTxtBox.Text);
            refleshFile();



        }

        private void del_Btn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
              
                todoList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                refleshFile();

                todoTxtBox.Text = "";
            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(listBox1.SelectedIndex.ToString());
        }

        private void refleshFile()
        {
            using (StreamWriter ouput = new StreamWriter("path", false))
            {
                foreach (string item in todoList)
                {
                    ouput.WriteLine(item);
                }
            }
        }

      
    }
}
