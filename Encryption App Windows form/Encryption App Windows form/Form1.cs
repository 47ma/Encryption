using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_App_Windows_form
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 10)
            {
                string Key = textBox1.Text;
                string Message = textBox2.Text;
                string Encryption = null;   
                for (int i = 0; i < Message.Length; i++)
                {
                    for (int j = 0; j < Key.Length; j++)
                    {
                        if (Message[i] == Key[j])
                            Encryption += (j).ToString() ;    
                    }
                }
                textBox3.Text = Encryption;
            }
            else
            {
                MessageBox.Show("Error key must be 10 digits");
            }
        }
            private void Encryption_Load(object sender, EventArgs e)
            {

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digits");
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digits");
            }
        }
    }
    }
