using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEncryptionLab2_Kot_PC_21_MH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xor_Click(object sender, EventArgs e)
        {
            var integerP = ReturnBinaryNumber(textBox_P);
            var integerKey = ReturnBinaryNumber(textBox_Key);

            var integerC = integerP ^ integerKey;
            textBox_C.Text = Convert.ToString(integerC, 2);
        }

        private int ReturnBinaryNumber(TextBox textBox) => Convert.ToInt32(textBox.Text, 2);

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_C.Text = textBox_Key.Text = textBox_P.Text = "";
        }
    }
}
