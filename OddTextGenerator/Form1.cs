using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddTextGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += new String(bs()+"\n");
        }

        private string bs()
        {
           return GetRandomString();
        }

        public static String GetRandomString()
        {
            var allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            allowedChars = WeirdChars();
            var length = 15;

            var chars = new char[length];
            var rd = new Random();

            for (var i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new String(chars);
        }

        public static String WeirdChars()
        {
            char[] charles = new char[12];

            for (int i = 0; i < 11; i++)
            {
                charles[i] = Convert.ToChar(i + 20);
            }
            return new string(charles);           
        }
    }
}
