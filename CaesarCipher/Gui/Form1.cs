using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SymmetricAlgorithm symmetric = new SymmetricAlgorithm();

        private void button2_Click(object sender, EventArgs e)
        {
            string ciphertext = cipherText2.Text;
            string plaintext = symmetric.Dekripto(ciphertext);
            plainText2.Text = plaintext;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            Regex regex = new Regex("^[0-9]*$");


            if (Key.Text == string.Empty && plainText.Text == string.Empty)
            {
                MessageBox.Show("Enter plaintext and key!");
            }
            else if (plainText.Text == string.Empty)
            {
                MessageBox.Show("Please enterplain text!");
            }
            else if (Key.Text == string.Empty || !regex.IsMatch(Key.Text))
            {
                MessageBox.Show("Key is empty or has invalid value!");
            }
            else
            {
                string plaintext = plainText.Text;

                int key = int.Parse(Key.Text);

                string ciphertext = symmetric.Enkripto(plaintext, key);

                cipherText.Text = ciphertext;
                cipherText2.Text = ciphertext;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int key = random.Next(26);
            Key.Text = Convert.ToString(key);
        }

        private void Key_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
