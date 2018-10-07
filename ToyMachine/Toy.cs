using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ToyMachine.Tools;

namespace ToyMachine
{
    public class Toy
    {
        //Çalışma Mantığı
        //Komutların regex kullanılarak: dizide; komut, etiketler ve adresler olarak ayrıştırılması.
        //komut, adres ve kullanıcı tarafından tanımlanan etiketlerin tespit edilmesi. 
        //ayrıştırma ile bellek hücrelerine ilgili etiketlemeler ile kayıt edilen verilerin, ilgili degerlerinin komutlara göre akümülatör üzerinden işlem yapılması.
        //Akümülatör değerlerine göre ilgili komutların işlem çağrılarının gerçekleşmesi (hesaplanması), memory'e kayıt edilmesi veya çıktı olarak basılması gibi komutlar icra ettirilir.

        int program_counter = 0;
        Object accumulator = null;
        int[] MEMORY = new int[10000];
        string command_line = "";
        string[] commands = { "stop", "get", "print", "store", "load", "add", "sub", "mod", "mul", "square", "cubic", "div", "goto", "ifpos", "ifzero", "ifneg", "init","oct","bin","and","or" };

        int varindex = 0;
        Dictionary<object, int> VAR = new Dictionary<object, int>();
        RichTextBox txtDATA;
        Input input = new Input();
        TextBox txtAccumlator;
        Input inputDialog = new Input();

        public Toy(TextBox txtAccumlator)
        {
            this.txtAccumlator = txtAccumlator;
            foreach(string item in commands)
            {
                command_line += item + "|";
            }

            command_line = command_line.Substring(0, command_line.Length - 1);
        }

        public void setData(RichTextBox txtDATA)
        {
            this.txtDATA = txtDATA;
        }

        int LIMIT = 10000;
        public void Run()
        {
            Load();
            int index = 0;
            program_counter = 0;
            while (program_counter >= 0)
            {
                Build();
                if (++index > LIMIT)
                {
                    MessageBox.Show("Limit aşıldı.");
                    break;
                }
            }
        }

        public void Restart()
        {
            Load();
            Display();
        }

        public void Step()
        {
            if (accumulator == null)
                Restart();
            else if (program_counter >= 0)
                Build();
            else
                getForm().txt_step_command.Text = "İleri bir adım mevcut değil.";
        }

        List<String> listCode = new List<string>();
        List<String> label = new List<string>();
        List<String> ADR = new List<string>();
        public void Load()
        {
            getForm().ClearMemory();
            inputDialog.txt_value.Text = "0";
            txtDATA.Text = txtDATA.Text.ToLower();

            listCode.Clear();
            label.Clear();
            ADR.Clear();

            for (int i = 0; i < txtDATA.Lines.Length; i++)
            {
                label.Add(getLAB(txtDATA.Lines[i]));
                if (Regex.IsMatch(label[i],command_line))
                    MessageBox.Show("Uyarı : '"+label[i]+"', komut dışı tanımlamalar ve tanımlanan bellek adresleri rezerve edilmiş komutlar olamaz.\nDikkat : Komutları ' ' (bosluk) bırakarak yazınız.");

                listCode.Add(getOP(txtDATA.Lines[i]));


                if (label[i]=="" && listCode[i]!="" && !Regex.IsMatch(listCode[i], command_line))
                    MessageBox.Show("Uyarı : "+listCode[i]+" böyle bir komut bulunamadı.");

                ADR.Add(getADR(txtDATA.Lines[i]));
                setMemory(i, 0);

                if (getCode(listCode[i], commands[16]))
                    setMemory(i, ADR[i]);

                if (Regex.IsMatch(listCode[i], @"^-?[0-9]+"))
                {
                    setMemory(i, ADR[i]);
                }
            }

            getForm().txt_console.Text = "";
            getForm().txt_accumlator.Text = "";
            accumulator = 0;
            varindex = 0;
            program_counter = 0;
        }

        string code = "";
        public void Build()
        {
            if (program_counter < 0)
                return;

            if (!(listCode.Count > program_counter))
            {
                program_counter = -1;
                return;
            }

            if (Regex.IsMatch(label[program_counter], @"^#") || Regex.IsMatch(listCode[program_counter], @"^#"))
                return;

            code = listCode[program_counter];

            if (getCode(code, commands[0]))
            {
                Output("Mesaj : Durduruldu.");
                program_counter = -2;
            }
            else if (getCode(code, commands[1]))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    accumulator = Convert.ToInt32(inputDialog.txt_value.Text);
                    if (accumulator == null || accumulator == "")
                        program_counter = -2;
                }
            }
            else if (getCode(code, commands[2]))
            {
                Output("Akümülatör : "+accumulator.ToString());
            }
            else if (getCode(code, commands[3]))
            {
                setMemory(ADR[program_counter], accumulator);
            }
            else if (getCode(code, commands[4]))
            {
                accumulator = getValue(ADR[program_counter]);
            }
            else if (getCode(code, commands[5]))
            {
                accumulator = Convert.ToInt32(accumulator) + Convert.ToInt32(getValue(ADR[program_counter]));
            }
            else if (getCode(code, commands[6]))
            {
                accumulator = Convert.ToInt32(accumulator) - Convert.ToInt32(getValue(ADR[program_counter]));
            }
            else if (getCode(code, commands[7]))
            {
                accumulator = Convert.ToInt32(accumulator) % Convert.ToInt32(getValue(ADR[program_counter]));
            }
            else if (getCode(code, commands[8]))
            {
                accumulator = Convert.ToInt32(accumulator) * Convert.ToInt32(getValue(ADR[program_counter]));
            }
            else if (getCode(code, commands[9]))
            {
                accumulator = Convert.ToInt32(accumulator) * Convert.ToInt32(accumulator);
            }
            else if (getCode(code, commands[10]))
            {
                accumulator = Convert.ToInt32(accumulator) * Convert.ToInt32(accumulator) * Convert.ToInt32(accumulator);
            }
            else if (getCode(code, commands[11]))
            {
                int denom = Convert.ToInt32(getValue(ADR[program_counter]));
                if (denom == 0)
                {
                    Output("Mesaj : Sonuç 0, program sonlandirildi.");
                    program_counter = -2;
                }
                accumulator = Convert.ToInt32(accumulator) / denom;
            }
            else if (getCode(code, commands[12]))
            {
                program_counter = findLAB(ADR[program_counter]) - 1;
            }
            else if (getCode(code, commands[13]))
            {
                if (Convert.ToInt32(accumulator) >= 0)
                    program_counter = findLAB(ADR[program_counter]) - 1;
            }
            else if (getCode(code, commands[14]))
            {
                if (Convert.ToInt32(accumulator) == 0)
                    program_counter = findLAB(ADR[program_counter]) - 1;
            }
            else if (getCode(code, commands[15]))
            {
                if (Convert.ToInt32(accumulator) < 0)
                    program_counter = findLAB(ADR[program_counter]) - 1;
            }
            else if (getCode(code, commands[16]))
            {
                Output("Mesaj : Veri yürütülme durduruldu.");
                program_counter = -2;
            }
            //Eklenen komutlar. (oct, bin, and, or)
            else if (getCode(code, commands[17]))
            {
                accumulator = Convert.ToString(Convert.ToInt32(accumulator), 8);
            }
            else if (getCode(code, commands[18]))
            {
                accumulator = Convert.ToString(Convert.ToInt32(accumulator), 2);
            }
            else if (getCode(code, commands[19]))
            {
                accumulator = Convert.ToInt32(accumulator) & Convert.ToInt32(getValue(ADR[program_counter]));
            }
            else if (getCode(code, commands[20]))
            {
                accumulator = Convert.ToInt32(accumulator) | Convert.ToInt32(getValue(ADR[program_counter]));
            }
            else if (code != "")
            {
                program_counter = -2;
            }

            program_counter++;
            Display();
        }

        void Display()
        {
            try
            {
                getForm().txt_step_command.Text = program_counter >= 0 ? ((program_counter + 1) + ":" + label[program_counter] + " " + listCode[program_counter] + " " + ADR[program_counter]) : "";
            }
            catch { }
            finally
            {
                getForm().txt_accumlator.Text = accumulator.ToString();
            }
        }

        void setMemory(object name, object value)
        {
            object i = null;
            object temp = name;
            
            if (!Regex.IsMatch(name.ToString(), @"^[0-9]+$"))
            {
                temp = findLAB(name);
                try
                {
                    i = VAR[name];
                }
                catch { }

                //Output("VAR:" + i);

                if (i == null && varindex < 8)//yazaç sayısı 8 adet 0-7
                    i = VAR[name] = varindex++;
                if (i != null)
                {
                    getForm().setTextBox(Convert.ToInt16(i), name, value);
                }
            }

            //Output("Name:" + temp + "\nValue:" + value);
            MEMORY[Convert.ToInt32(temp)] = Convert.ToInt32(value);
        }

        object getValue(string data)
        {
            //Output("getValue:" + data);
            if (Regex.IsMatch(data, @"^-?[0-9]+"))
                return data;

            int index_lab = findLAB(data);
            return MEMORY[index_lab];
        }

        int findLAB(object name)
        {
            var i = 0;
            for (i = 0; i < txtDATA.Lines.Length; i++)
            {
                if (label[i] == name.ToString())
                    return i;
            }

            //Output("findLab --> " + name);
            return -1;
        }

        string getLAB(string name)
        { 
            string temp = Regex.Replace(name, @" +.*", "");
            //Output("*getLAB --> " + temp+"-");
            return temp;
        }

        string getOP(string data)
        {
            var op = "";
            op = Regex.Replace(data, @"^[_a-zA-Z]\S*", "");
            op = Regex.Replace(op, @"^[ ]+", "");
            op = Regex.Replace(op, @" +.*", "");

            return op.ToLower();
        }

        string getADR(string data)
        {
            var address = "";
            address = Regex.Replace(data, @"^[_a-zA-Z]\S*", "");
            address = Regex.Replace(address, @"^\s*[_a-zA-Z]\S*", "");
            address = Regex.Replace(address, @"^[_]\\S*", "");
            address = Regex.Replace(address, @"^ +", "");
            address = Regex.Replace(address, @" +.*", "");

            return address.ToLower();
        }

        string temp = "";
        void Output(string data)
        {
            temp += data + "\r\n";
            getForm().txt_console.AppendText(temp);
        }

        bool getCode(string code, string cmd)
        {
            if (code == cmd)
            {
                return true;
            }
            else
                return false;
        }

        public void LineNumber(RichTextBox txt, int line)
        {
            txt.Clear();
            for (int i = 1; i <= line; i++)
                txt.AppendText("  " + i.ToString("") + "\n");
        }

        public Panel getForm()
        {
            return (Panel)Application.OpenForms["Panel"];
        }
    }
}