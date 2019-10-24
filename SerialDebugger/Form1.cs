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

namespace SerialDebugger
{
   
   
    public partial class Form1 : Form
    {


        Hashtable hasharrange = new Hashtable();
            public Form1()
        {
            InitializeComponent();
            foreach (Control item in this.Controls)
            {
                item.KeyDown += Form1_KeyDown;
            }
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        SerialPort serialPort;

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
        void Hasharrange_Save()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in hasharrange.Keys)
            {
                sb.Append( (string)item + ":" + (string)hasharrange[item] + "\n");
            }
            File.WriteAllText("arrange.tXt", sb.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hasharrange["COM"] = comboBox1.Text;
            Hasharrange_Save();
            
            if (comboBox1.Text == "") return;
            serialPort = new SerialPort(comboBox1.Text);
            try
            {
                serialPort.Open();
                serialPort.BaudRate = 9600;
                serialPort.DataReceived += SerialPort_DataReceived;
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "连接失败";
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
            //listBox1.DisplayMember = "Name";
            //listBox1.Items.Clear();
            // d.ForEach(i => listBox1.Items.Add(i.ToString()));
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
        List<DisplayData> d = new List<DisplayData>();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
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
            if (hasharrange.ContainsKey("COM"))
            {
                comboBox1.Text = hasharrange["COM"].ToString();
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
            if (e.KeyCode == Keys.Left) serialPort.WriteLine("fwd(-150,150)");

            if (e.KeyCode == Keys.Right) serialPort.WriteLine("fwd(150,-150)");
            if(e.KeyCode==Keys.Up) serialPort.WriteLine("fwd(150,150)");
            if (e.KeyCode == Keys.Down) serialPort.WriteLine("fwd(-150,-150)");
            if (e.KeyCode == Keys.S) serialPort.WriteLine("fwd(0,0)");

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
