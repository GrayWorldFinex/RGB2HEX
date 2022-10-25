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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertToHex hex_conv = new ConvertToHex();
            hex_conv.ConvertHex(35, 122, 122); //I don't Know how to Convert Byte to String, I'm Sorry :D
            if (File.Exists(@"C:\Windows\Hex.txt"))
            {
                Process.Start("notepad", @"C:\Windows\Hex.txt");
            }
            else
            {
                MessageBox.Show("Please Try Run This Program as Administrator!!!");
                Environment.Exit(312);
            }
        }
    }
}
