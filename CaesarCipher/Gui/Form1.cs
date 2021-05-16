using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            
            string plaintext= plainText.Text;
            int key  = int.Parse(Key.Text);

            string ciphertext = symmetric.Enkripto(plaintext, key);

            cipherText.Text = ciphertext;
            cipherText2.Text = ciphertext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int key = random.Next(26);
            Key.Text = Convert.ToString(key);
        }
    }
}
