using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToyMachine
{
    public partial class Codes : Form
    {
        public Codes()
        {
            InitializeComponent();
        }

        public Panel getForm()
        {
            Panel pnl = (Panel)Application.OpenForms["Panel"];
            pnl.txt_source.Text = "";
            return pnl;
        }

        private void Codes_Load(object sender, EventArgs e)
        {

        }

        private void btn_example_1_Click(object sender, EventArgs e)
        {
            getForm().txt_source.AppendText(btn_example_1.AccessibleDescription);
        }

        private void btn_example_2_Click(object sender, EventArgs e)
        {
            getForm().txt_source.AppendText(btn_example_2.AccessibleDescription);
        }

        private void btn_example_3_Click(object sender, EventArgs e)
        {
            getForm().txt_source.AppendText(btn_example_3.AccessibleDescription);
        }

        private void btn_example_4_Click(object sender, EventArgs e)
        {
            getForm().txt_source.AppendText(btn_example_4.AccessibleDescription);
        }

        private void btn_example_5_Click(object sender, EventArgs e)
        {
            getForm().txt_source.AppendText(btn_example_5.AccessibleDescription);
        }

        private void btn_example_6_Click(object sender, EventArgs e)
        {
            getForm().txt_source.AppendText("");
        }

        private void btn_source_content_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cs.princeton.edu/courses/archive/fall09/cos109/");
            Process.Start("http://toy.ecylmz.com/toy.js");
        }
    }
}