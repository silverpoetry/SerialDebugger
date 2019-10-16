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
namespace SerialDebugger
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
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
        private void button4_Click(object sender, EventArgs e)
        {
             
            UpadateData($"123", $"1231{++i}");
            UpadateData($"123{++i}", $"1231{++i}");
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
