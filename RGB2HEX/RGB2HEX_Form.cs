using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorHelper;

namespace RGB2HEX
{
    public partial class RGB2HEX_Form : Form
    {
        public RGB2HEX_Form()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"C:\RGB2HEX");
        }
        public byte ConvertToByte(string text)
        {
            return Convert.ToByte(text); //Converting to Byte :D
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertToHex hex_conv = new ConvertToHex();
            hex_conv.ConvertHex(ConvertToByte(textBox1.Text), ConvertToByte(textBox2.Text), ConvertToByte(textBox3.Text)); //Converting To Byte, and Finally getting Hex Color :D
            if (File.Exists(@"C:\RGB2HEX\Hex.txt"))
            {
                Process.Start("notepad", @"C:\RGB2HEX\Hex.txt");
            }
            else
            {
                MessageBox.Show("Please Try Run This Program as Administrator!!!");
                Environment.Exit(312);
            }
        }
    }
}
