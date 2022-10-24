using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR2_Kyrylenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            // Encoder
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);

            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            textBox_C.Text = strC;

            //Binary
            string str_Binary_P = Convert.ToString(Convert.ToInt64(strP, 16), 2);
            string str_Binary_Key = Convert.ToString(Convert.ToInt64(strKey, 16), 2);
            string str_Binary_C = Convert.ToString(Convert.ToInt64(strC, 16), 2);
            label_Binary_P.Text = str_Binary_P;
            label_Binary_Key.Text = str_Binary_Key;
            label_Binary_C.Text = str_Binary_C;

            //Decimal
            string str_Decimal_P = Convert.ToString(Convert.ToInt64(strP, 16), 10);
            string str_Decimal_Key = Convert.ToString(Convert.ToInt64(strKey, 16), 10);
            string str_Decimal_C = Convert.ToString(Convert.ToInt64(strC, 16), 10);
            label_Decimal_P.Text = str_Decimal_P;
            label_Decimal_Key.Text = str_Decimal_Key;
            label_Decimal_C.Text = str_Decimal_C;

            //Octal
            string str_Octal_P = Convert.ToString(Convert.ToInt64(strP, 16), 8);
            string str_Octal_Key = Convert.ToString(Convert.ToInt64(strKey, 16), 8);
            string str_Octal_C = Convert.ToString(Convert.ToInt64(strC, 16), 8);
            label_Octal_P.Text = str_Octal_P;
            label_Octal_Key.Text = str_Octal_Key;
            label_Octal_C.Text = str_Octal_C;

            // Decoder
            textBox_P2.Text = textBox_P.Text;
            textBox_Key2.Text = textBox_Key.Text;
            textBox_C2.Text = textBox_C.Text;

        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
            textBox_P2.Text = "";
            textBox_Key2.Text = "";
            textBox_C2.Text = "";

            label_Binary_P.Text = "";
            label_Binary_Key.Text = "";
            label_Binary_C.Text = "";

            label_Octal_P.Text = "";
            label_Octal_Key.Text = "";
            label_Octal_C.Text = "";

            label_Decimal_P.Text = "";
            label_Decimal_Key.Text = "";
            label_Decimal_C.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
