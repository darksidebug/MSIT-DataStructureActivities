using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LsitsActivity
{
    public partial class Form1 : Form
    {
        LinkedList<string> links = new LinkedList<string>();
        List<string> lists = new List<string>();
        //ArrayList arrLists = new ArrayList();
        
        private int i = 1, a = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void initLinkList()
        {
            links.AddLast(txtItem.Text);
        }

        private void initArrayList()
        {
            lists.Add(txtItem.Text);
        }

        private void displayLinkResult()
        {
            gunaDataGridView1.Rows.Clear();

            foreach (var listItem in links)
            {
                gunaDataGridView1.Rows.Add(i, listItem);
                i++;
            }

            lblAdditionalInfoTxt.Text = "Item(s) count is " + links.Count;
            i = 1;
        }

        private void displayArrayResult()
        {
            gunaDataGridView1.Rows.Clear();

            foreach (var listItem in lists)
            {
                gunaDataGridView1.Rows.Add(i, listItem);
                i++;
            }

            lblAdditionalInfoTxt.Text = "Item(s) count is " + lists.Count;
            i = 1;
        }

        private void findInLink(string node)
        {
            gunaDataGridView1.Rows.Clear();

            for (int b = 0; b < countLinkItems(); b++)
            {
                gunaDataGridView1.Rows.Add(b + 1, node);
            }

            lblAdditionalInfoTxt.Text = "Find item(s) count is " + countLinkItems();
        }

        private void findInArray(string item)
        {
            gunaDataGridView1.Rows.Clear();

            for (int b = 0; b < countArrayItems(); b++)
            {
                gunaDataGridView1.Rows.Add(b + 1, item);
            }

            lblAdditionalInfoTxt.Text = "Find item(s) count is " + countArrayItems();
        }

        private int countLinkItems()
        {
            return links.Count(size => size == txtItem.Text);
        }

        private int countArrayItems()
        {
            return lists.Count(size => size == txtItem.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gunaButton1.Enabled = false;
            gunaButton2.Enabled = false;
            gunaButton3.Enabled = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaRadioButton2.Checked)
                {
                    LinkedListNode<string> node = links.Find(txtItem.Text);
                    links.AddAfter(node, txtItem.Text + "-" + a++);
                    this.displayLinkResult();
                }

                if (lists.Contains(txtItem.Text))
                {
                    lists.Add(txtItem.Text + "-" + a++);
                    this.displayArrayResult();
                }
            }
            catch (Exception)
            {}
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaRadioButton2.Checked)
                {
                    this.initLinkList();
                    this.displayLinkResult();
                }

                this.initArrayList();
                this.displayArrayResult();

                a = 1;
            }
            catch (Exception)
            {}
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaRadioButton2.Checked)
                {
                    LinkedListNode<string> node = links.Find(txtItem.Text);
                    this.findInLink(node.Value.ToString());
                }

                if (lists.Contains(txtItem.Text))
                {
                    this.findInArray(txtItem.Text);
                }

                a = 1;
            }
            catch (Exception)
            {}
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked)
            {
                gunaLabel2.Text = "Array-Based Lists";

                gunaButton1.Enabled = true;
                gunaButton2.Enabled = true;
                gunaButton3.Enabled = true;
            }
        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaRadioButton2.Checked)
            {
                gunaLabel2.Text = "Link Lists";

                gunaButton1.Enabled = true;
                gunaButton2.Enabled = true;
                gunaButton3.Enabled = true;
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.gunaDataGridView1.Rows.Clear();
        }
    }
}
