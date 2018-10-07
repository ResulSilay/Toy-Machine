using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToyMachine
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (FontFamily name in FontFamily.Families)
                    cmb_font_family.Items.Add(name.Name);

                for (int i = 5; i <= 20; i++)
                    cmb_font_size.Items.Add(i.ToString());
            }
            catch
            {

            }
        }

        private void cmb_font_family_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_font_family.SelectedIndex!=0 && cmb_font_size.Text.Length>0)
            {
                Font font = new Font(cmb_font_family.SelectedItem.ToString(), Convert.ToInt32(cmb_font_size.Text));
                ((Panel)Application.OpenForms["Panel"]).txt_source.Font = font;
                ((Panel)Application.OpenForms["Panel"]).txt_line_number.Font = font;
            }
        }

        private void cmb_font_size_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_font_size.Text.Length > 0)
                {
                    Font font = new Font("Aria", Convert.ToInt32(cmb_font_size.Text));
                    ((Panel)Application.OpenForms["Panel"]).txt_source.Font = font;
                    ((Panel)Application.OpenForms["Panel"]).txt_line_number.Font = font;
                }
            }
            catch
            {

            }
        }
    }
}
