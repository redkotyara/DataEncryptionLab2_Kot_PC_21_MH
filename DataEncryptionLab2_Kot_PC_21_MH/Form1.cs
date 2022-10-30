using System;
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
            textBox1.Text = textBox_C.Text = Convert.ToString(integerC, 2);

            DrawNumberInAllFormats(label7, label8, label9, integerP);
            DrawNumberInAllFormats(label10, label11, label12, integerKey);
            DrawNumberInAllFormats(label13, label14, label15, integerC);

            var decryptedPNumber = integerC ^ integerKey;
            textBox3.Text = Convert.ToString(decryptedPNumber, 2);
            textBox2.Text = textBox_Key.Text;

            DrawNumberInAllFormats(label16, label17, label18, decryptedPNumber);
            DrawNumberInAllFormats(label19, label20, label21, integerKey);
            DrawNumberInAllFormats(label22, label23, label24, integerC);
        }

        private int ReturnBinaryNumber(TextBox textBox) => Convert.ToInt32(textBox.Text, 2);

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_C.Text = textBox_Key.Text = textBox_P.Text = "";

            label7.Text = label8.Text = label9.Text = "";
            label10.Text = label11.Text = label12.Text = "";
            label13.Text = label14.Text = label15.Text = "";

            textBox1.Text = textBox2.Text = textBox3.Text = "";

            label16.Text = label17.Text = label18.Text = "";
            label19.Text = label20.Text = label21.Text = "";
            label22.Text = label23.Text = label24.Text = "";
        }

        private void DrawNumberInAllFormats(Label decimalLabel, Label binaryLabel, Label hexLabel, int binaryNumber)
        {
            binaryLabel.Text = Convert.ToString(binaryNumber, 2);
            hexLabel.Text = Convert.ToString(binaryNumber, 16).ToUpper();
            decimalLabel.Text = Convert.ToString(binaryNumber, 10);
        }
    }
}
