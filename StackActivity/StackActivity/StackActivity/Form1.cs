using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackActivity
{
    public partial class Form1 : Form
    {
        Stack<string> stack = new Stack<string>();
       
        private int i = 1, a = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.initStacks(txtItem.Text);
            this.displayStackResult();
        }

        private void initStacks(string item)
        {
            stack.Push(item);
            gunaLabel3.Text = "`Push` inserts an object at the top collection"; 
        }

        private void displayLinkResult()
        {
            gunaDataGridView1.Rows.Clear();

            foreach (var listItem in stack)
            {
                gunaDataGridView1.Rows.Add(i, listItem);
                i++;
            }

            lblAdditionalInfoTxt.Text = "Item(s) count is " + stack.Count;
            i = 1;
        }

        private void displayStackResult()
        {
            gunaDataGridView1.Rows.Clear();

            foreach (var listItem in stack)
            {
                gunaDataGridView1.Rows.Add(i, listItem);
                i++;
            }

            lblAdditionalInfoTxt.Text = "Item(s) count is " + stack.Count;
            i = 1;
        }

        private int countLinkItems()
        {
            return stack.Count(size => size == txtItem.Text);
        }

        private int countArrayItems()
        {
            return stack.Count(size => size == txtItem.Text);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Clear();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaLabel3.Text = "`Peek` returns only the top object collection.";
            gunaLabel4.Text = "Item peek from collection " + stack.Peek();
            this.displayStackResult();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            
            gunaLabel3.Text = "`Pop` removes and returns at the top object collection.";
            gunaLabel4.Text = "Item remove from collection " + stack.Pop();
            this.displayStackResult();
        }
    }
}
