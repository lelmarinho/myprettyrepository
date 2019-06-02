using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeticiaeHenrique
{
    public partial class Form1 : Form
    {
        int soma=0;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            if (comboBox1.Text == "Professores")
            {
                groupBox2.Visible = false;
                groupBox1.Visible = true;
            }
            if (comboBox1.Text == "Professoras")
            {
                groupBox2.Visible = true;
                
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
           if(textBox1.Text!="")
            {
                soma +=int.Parse(textBox1.Text);
                a = int.Parse(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Digite algum valor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count!=0)
            {
                soma -=a;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Não é possível remover itens inexistentes ou não selecionados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count==3)
            {
                
                label2.Text = soma.ToString();
            }
            else
            {
                MessageBox.Show("Selecione somente 3 itens", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                listBox2.Items.Add(checkBox1.Text);
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked)
            {
                listBox2.Items.Add(checkBox2.Text);
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked)
            {
                listBox2.Items.Add(checkBox3.Text);
                checkBox3.Enabled = false;
                checkBox3.Checked = false;
            }
            if (checkBox4.Checked)
            {
                listBox2.Items.Add(checkBox4.Text);
                checkBox4.Enabled = false;
                checkBox4.Checked = false;
            }
            if (checkBox5.Checked)
            {
                listBox2.Items.Add(checkBox5.Text);
                checkBox5.Enabled = false;
                checkBox5.Checked = false;
            }
            if (checkBox6.Checked)
            {
                listBox2.Items.Add(checkBox6.Text);
                checkBox6.Enabled = false;
                checkBox6.Checked = false;
            }

        }
    }
}
