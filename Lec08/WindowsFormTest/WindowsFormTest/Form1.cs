using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTest
{

    public abstract class user
    {
        public string userName;
        public string pw;
    }


    public class student:user
    {
        public int id = 38111;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            student Madhuka = new student();
            Madhuka.userName = "Madhuka Fernando";
            Madhuka.pw = "1234";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
