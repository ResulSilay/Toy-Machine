using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ToyMachine
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        public Toy toy;
        string path = null;

        private void Panel_Load(object sender, EventArgs e)
        {
            toy = new Toy(txt_accumlator);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            try
            {
                ClearMemory();
                toy.setData(txt_source);
                toy.Run();
            }
            catch (Exception error)
            {
                MessageBox.Show("Bilinmeyen hata : " + error.Message.ToString());
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            try
            {
                toy.setData(txt_source);
                toy.Restart();
            }
            catch
            {

            }
        }

        private void btn_step_Click(object sender, EventArgs e)
        {
            try
            {
                toy.Step();
            }
            catch
            {

            }
        }

        private void txt_source_TextChanged(object sender, EventArgs e)
        {
            if (txt_source.Lines.Length >= txt_line_number.Lines.Length || txt_source.Lines.Length <= txt_line_number.Lines.Length)
                toy.LineNumber(txt_line_number, txt_source.Lines.Length);
        }

        private void btn_menu_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void txt_menu_codes_Click(object sender, EventArgs e)
        {
            Codes codes = new Codes();
            codes.Show();
        }

        private void btn_menu_open_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                StreamReader streamReader = new StreamReader(path);
                txt_source.Text = "";
                txt_source.AppendText(streamReader.ReadToEnd());
                streamReader.Close();

                this.Text = path;
            }
        }

        private void txt_menu_save_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                DialogResult dialog = saveFileDialog1.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    StreamWriter streamWriter = new StreamWriter(path);
                    streamWriter.WriteLine(txt_source.Text);
                    streamWriter.Close();
                }
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(txt_source.Text);
                streamWriter.Close();
                MessageBox.Show("Saved.");
            }

            this.Text = path;
        }

        private void btn_menu_new_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yeni dosya oluşturulsun mu?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                path = null;
                Clear();
            }
        }

        public void Clear()
        {
            this.Text = "* Yeni Dosya";

            ClearMemory();

            txt_source.Text = "";
        }

        public void ClearMemory()
        {
            foreach (Control control in panel6.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        int status_screen = 0;
        private void btn_menu_full_Click(object sender, EventArgs e)
        {
            if (status_screen == 0)
            {
                status_screen = 1;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                status_screen = 0;
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                this.WindowState = FormWindowState.Normal;
            }
        }

        public void setTextBox(int index, object name, object value)
        {
            switch (index)
            {
                case 0:
                    {
                        txt_memory_name_0.Text = name.ToString();
                        txt_memory_value_0.Text = value.ToString();
                        break;
                    }
                case 1:
                    {
                        txt_memory_name_1.Text = name.ToString();
                        txt_memory_value_1.Text = value.ToString();
                        break;
                    }
                case 2:
                    {
                        txt_memory_name_2.Text = name.ToString();
                        txt_memory_value_2.Text = value.ToString();
                        break;
                    }
                case 3:
                    {
                        txt_memory_name_3.Text = name.ToString();
                        txt_memory_value_3.Text = value.ToString();
                        break;
                    }
                case 4:
                    {
                        txt_memory_name_4.Text = name.ToString();
                        txt_memory_value_4.Text = value.ToString();
                        break;
                    }
                case 5:
                    {
                        txt_memory_name_5.Text = name.ToString();
                        txt_memory_value_5.Text = value.ToString();
                        break;
                    }
                case 6:
                    {
                        txt_memory_name_6.Text = name.ToString();
                        txt_memory_value_6.Text = value.ToString();
                        break;
                    }
                case 7:
                    {
                        txt_memory_name_7.Text = name.ToString();
                        txt_memory_value_7.Text = value.ToString();
                        break;
                    }

                default: break;
            }
        }

        private void tumunuSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_source.SelectAll();
            txt_source.Focus();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_source.Text);
            }
            catch
            {

            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_source.Text = "";
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txt_source.AppendText(Clipboard.GetText());
            }
            catch
            {

            }
        }
    }
}