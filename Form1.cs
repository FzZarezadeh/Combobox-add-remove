using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            lbltime.Text = dateTimePicker1.Value.ToLongTimeString();
            lbldate.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "\n";
            }
            else
            {
                MessageBox.Show("Please write text in box", "Empty textbox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Text = "\n";
            }
            else
            {
                MessageBox.Show("Please select one item", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
