using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToyMachine.Tools
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_value.Text.Length>0)
            {
                txt_value.Focus();
                DialogResult = DialogResult.OK;
            }
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        public Panel getForm()
        {
            return (Panel)Application.OpenForms["Panel"];
        }
    }
}
