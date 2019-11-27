using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Collections;
using Drawer;

namespace SerialDebugger
{
   
   
    public partial class Form1 : Form
    {
        List<DisplayData> d = new List<DisplayData>();
        Hashtable hasharrange = new Hashtable();
       public SerialPort serialPort;


        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //注册点击事件
            foreach (Control item in this.Controls)
            {
               item.KeyDown += Form1_KeyDown;
                item.KeyUp += (a, b) => { if (b.KeyCode == Keys.Up || b.KeyCode == Keys.Down || b.KeyCode == Keys.Left || b.KeyCode == Keys.Right) serialPort.WriteLine("fwd(0,0)"); };
            }
            
           
        }
   

      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
            }
            catch (Exception)
            {

                return;
            }
            toolStripStatusLabel1.Text = "断开成功";
        }
        #region 记忆读取
        void Hasharrange_Save()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in hasharrange.Keys)
            {
                sb.Append((string)item + ":" + (string)hasharrange[item] + "\n");
            }
            File.WriteAllText("arrange.tXt", sb.ToString());
        }
        void Hasharrange_Init()
        {
            FileStream fs;
            if (!File.Exists("arrange.txt"))
            {
                fs = File.Create("arrange.txt");
                fs.Close();
            }
            string[] arrange = File.ReadAllLines("arrange.txt");
            for (int i = 0; i < arrange.Length; i++)
            {
                if (arrange[i].Trim() == "") break;
                string[] s = arrange[i].Split(':');
                hasharrange.Add(s[0], s[1]);
            }

        }
        string Hasharrange_Get(string s)
        {
            if (hasharrange.ContainsKey(s)) return  hasharrange[s].ToString();
            return "";
        }
        void Hasharrange_Apply()
        {
            comboBox1.Text = Hasharrange_Get("COM");
            textBox5.Text = Hasharrange_Get("Arm1");
            textBox4.Text = Hasharrange_Get("Arm2");

        }
        void Hasharrange_SaveChange(string s1 ,string s2)
        {
            hasharrange[s1] = s2;
            Hasharrange_Save();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //hasharrange["COM"] = comboBox1.Text;
            //Hasharrange_Save();
            if (serialPort!=null)
            {
                if (serialPort.IsOpen)
                {
                    button2_Click(null, null);
                }
            }
            Hasharrange_SaveChange("COM", comboBox1.Text);
            if (comboBox1.Text == "") return;
            serialPort = new SerialPort(comboBox1.Text);
            try
            {
                serialPort.Open();
                serialPort.BaudRate = 9600;
                serialPort.DataReceived += SerialPort_DataReceived;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "连接失败"+ex.Message;
                return;
            }
            toolStripStatusLabel1.Text = "连接成功";
        }
        
        void UpadateData(string name,string value)
        {
            bool founded = false;
            d.ForEach(i =>
            {
                if (i.Name == name)
                {
                    i.Value = value;
                    //i.SetDisText( $"{name}: {value}");
                    founded = true;
                   
                }
            });

            if (!founded)
            {
                d.Add(new DisplayData() { Name = name, Value = value, DisplayText = $"{name}: {value}" });
            }
           if(enablelog) File.AppendAllText(name + ".txt", name+":"+value + "\n");
            
            listBox1.DataSource = null;
            listBox1.DataSource = d;
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serialPort.BytesToRead>0)
                {

               
                string command = serialPort.ReadLine();
                string commandname = command.Substring(0, command.LastIndexOf('('));
                string[] parameters = command.Substring(command.LastIndexOf('(') + 1, command.LastIndexOf(')') - command.LastIndexOf('(') - 1).Split(',');
                switch (commandname)
                {
                    case "SetWatch":
                        UpadateData(parameters[0], parameters[1]);
                        break;
                    default:
                        break;
                }
                }
            }
            catch (Exception)
            {

                
            }
        }
       




        private void Form1_Load(object sender, EventArgs e)
        {
         //   openFileDialog1.ShowDialog();
            comboBox1.DataSource = SerialPort.GetPortNames();

            Hasharrange_Init();
            Hasharrange_Apply();
            foreach (var item in groupBox4.Controls)
            {
                if (!(item is Button))
                {
                    continue;
                }
                Button btn = (Button)item;
                int id = Convert.ToInt32(btn.Text[btn.Text.Length - 1].ToString());
                btn.Tag = id;
                btn.Click += (a, b) =>
                {
                    int cnt =(int) ((Button)a).Tag;
                    //MessageBox.Show($"fuction{cnt.ToString()}(100,100)");
                  serialPort.WriteLine($"fuction{cnt.ToString()}(100,100)");
                };

            }




            //listBox1.DisplayMember = "DisplayText";

            //listBox1.ValueMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort == null) return;
            if (serialPort.IsOpen == false) return;
            serialPort.WriteLine(textBox1.Text);
         //serialPort.
        }
        int i;
        private bool enablelog;

      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            enablelog = checkBox1.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("Forward(100,100)");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) serialPort.WriteLine("fwd(-100,100)");

            if (e.KeyCode == Keys.Right) serialPort.WriteLine("fwd(100,-100)");
            if(e.KeyCode==Keys.Up) serialPort.WriteLine("fwd(100,100)");
            if (e.KeyCode == Keys.Down) serialPort.WriteLine("fwd(-100,-100)");
            if (e.KeyCode == Keys.Control) serialPort.WriteLine("fwd(0,0)");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
          //  serialPort.WriteLine($"fwd({Convert.ToInt32(textBox2.Text).ToString()},{Convert.ToInt32(textBox3.Text).ToString()})");
            serialPort.WriteLine($"bmpspeed({Convert.ToInt32(textBox2.Text).ToString()},{Convert.ToInt32(textBox3.Text).ToString()})");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  serialPort.WriteLine($"fuckt({Convert.ToInt32(textBox4.Text).ToString()}，2)");
            serialPort.WriteLine($"amg2({textBox4.Text},{textBox4.Text})");
            Hasharrange_SaveChange("Arm2", textBox4.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"glfwd(0,0)");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"sspeed({textBox9.Text},{textBox11.Text})");
            System.Threading.Thread.Sleep(300);
            serialPort.WriteLine($"gtm({textBox9.Text},{textBox10.Text})");
         
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"gllft(0,0)");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"setz(1,1)");

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                Hasharrange_SaveChange("Arm1", textBox5.Text);
                serialPort.WriteLine($"amg1({Convert.ToInt32(textBox5.Text).ToString()},2)");
               
            }
            catch (Exception)
            {

              
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            d.Clear();
            listBox1.DataSource = null;
            listBox1.DataSource = d;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Up)
            {

            textBox5.Text = (int.Parse(textBox5.Text) + 1).ToString();
            button10_Click(null, null);

            }
            if (e.KeyCode == Keys.Down)
            {

                textBox5.Text = (int.Parse(textBox5.Text) - 1).ToString();
                button10_Click(null, null);

            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
                button5_Click(null, null);
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox4.Text = (int.Parse(textBox4.Text) - 1).ToString();
                button5_Click(null, null);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_2(object sender, EventArgs e)
        {

            serialPort.WriteLine($"getball(0,0)");
        }

        private void button13_Click(object sender, EventArgs e)
        {

            serialPort.WriteLine($"exmaze(0,0)");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("getball2(0,0)");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("glrt(0,0)");
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"sspeed({textBox9.Text},{textBox11.Text})");
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            serialPort.WriteLine($"glrt(0,0)");
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

           Form2 f = new   Drawer.Form2();
            f.fm1 = this;
            f.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"abt({textBox6.Text},1)");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"relat({textBox6.Text},1)");
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox9.Text = 150.ToString();
                textBox11.Text = 150.ToString();
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox9.Text = (-150).ToString();
                textBox11.Text = (-150).ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox9.Text = (-150).ToString();
                textBox11.Text = (150).ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox9.Text = (150).ToString();
                textBox11.Text = (-150).ToString();
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            serialPort.WriteLine($"zxx({textBox7.Text},1)");
            textBox1.Text += $"Outer_GoPointByX({textBox7.Text}, 1);\n";
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            serialPort.WriteLine($"yxx({textBox7.Text},1)");
            textBox1.Text += $"Outer_GoPointByX({textBox7.Text}, 2);\n";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"zxy({textBox7.Text},1)");
            textBox1.Text += $"Outer_GoPointByY({textBox7.Text}, 1);\n";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine($"yxy({textBox7.Text},1)");
            textBox1.Text += $"Outer_GoPointByY({textBox7.Text}, 2);\n";
        }
    }

    class DisplayData
    {
        public string DisplayText { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
     
}
