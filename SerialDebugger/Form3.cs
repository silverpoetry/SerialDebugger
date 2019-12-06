using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form3 : Form
    {
        Point carpos = new Point(0,0);

        Button[,,] btns =new Button[10,10,5];
        int[,,] map = new int[400, 400, 10];
        public SerialDebugger.Form1 fm1;
        public Form3()
        {
            InitializeComponent();
        }
        Button creategao()
        {
            Button btn = new Button();


            btn.Size = new System.Drawing.Size(10, 80);


            btn.UseVisualStyleBackColor = true;
            btn.BackColor = Color.White;
            return btn;
        }
        Button creatchang()
        {
            Button btn = new Button();
            btn.BackColor = Color.White;

            btn.Name = "button2";
            btn.Size = new System.Drawing.Size(80, 10);
            btn.TabIndex = 1;

            btn.UseVisualStyleBackColor = true;
            return btn;

        }

        void createmap()
        {
            StringBuilder s = new StringBuilder(" ");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    for (int k = 0; k <= 3; k++)
                    {
                        if (map[i, j, k] == -1)
                        {
                            s.AppendLine($"Graph[{i.ToString()}][{j.ToString()}][{k.ToString()}]=-1;");
                        }
                    }
                }
            }
            Clipboard.SetText(s.ToString());
            textBox1.Text = s.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //生成竖着的
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Button b = creategao();
                    b.Top = i * 100 - 40;
                    b.Left = j * 100 + 45;
                    b.Tag = new Point(i, j);
                    Point p = (Point)b.Tag;
                    if (i == j + 1) { b.BackColor = Color.Black; b.Enabled = false; }
                    btns[6 - p.Y, 7 - p.X, 3] =b;
                    btns[7 - p.Y, 7 - p.X, 1] = b;
                    b.Click += (a, f) =>
                    {

                        Button theb = ((Button)a);
                        Point pp = (Point)theb.Tag;
                        if (((Button)a).BackColor == Color.White)
                        {

                            ((Button)a).BackColor = Color.Black;
                            map[6 - pp.Y, 7 - pp.X, 3] = -1;
                            map[7 - pp.Y, 7 - pp.X, 1] = -1;
                        }
                        else
                        {
                            ((Button)a).BackColor = Color.White;
                            map[6 - pp.Y, 7 - pp.X, 3] = 0;
                            map[7 - pp.Y, 7 - pp.X, 1] = 0;
                        }
                        createmap();
                    };
                    this.Controls.Add(b);

                }

            }
            //生成横着的着的
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Button b = creatchang();
                    b.Top = i * 100 + 45;
                    b.Left = j * 100 - 40;
                    b.Tag = new Point(i, j);
                    if (i == j) { b.BackColor = Color.Black; b.Enabled = false; }
                    Point p = (Point)b.Tag;
                    //if (i == j + 1) { b.BackColor = Color.Black; b.Enabled = false; }
                    btns[7 - p.Y, 6 - p.X, 0] = b;
                    btns[7 - p.Y, 7 - p.X, 2] = b;
                    b.Click += (a, f) =>
                    {
                        createmap();
                        Button theb = ((Button)a);
                        Point pp = (Point)theb.Tag;
                        if (((Button)a).BackColor == Color.White)
                        {

                            ((Button)a).BackColor = Color.Black;
                            map[7 - pp.Y, 6 - pp.X, 0] = -1;
                            map[7 - pp.Y, 7 - pp.X, 2] = -1;
                        }
                        else
                        {
                            ((Button)a).BackColor = Color.White;
                            map[7 - pp.Y, 6 - pp.X, 0] = 0;
                            map[7 - pp.Y, 7 - pp.X, 2] = 0;
                        }
                        createmap();
                    };
                    this.Controls.Add(b);
                }

            }

            fm1.OnMessageReceive += MsgReceive;
        }
        public void MsgReceive(string command)
        {
            string commandname = command.Substring(0, command.LastIndexOf('('));
            string[] parameters = command.Substring(command.LastIndexOf('(') + 1, command.LastIndexOf(')') - command.LastIndexOf('(') - 1).Split(',');
            if (commandname=="stpos")
            {
                carpos.X = 6-int.Parse( parameters[0]);
                carpos.Y = 6-int.Parse(parameters[1]);
                button13.Left = 88 + carpos.X*100;
                button13.Top = 88 + carpos.Y*100;
            }
            else if (commandname == "stob")
            {
                int x = int.Parse(parameters[0]); ;
                int y = int.Parse(parameters[1]);
                int dir = int.Parse(parameters[2]);
                btns[x, y, dir].BackColor = Color.Black;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    for (int k = 0; k <= 3; k++)
                    {
                        if (map[i, j, k] == -1)
                        {
                            fm1.serialPort.WriteLine($"setpoint({i.ToString()},{j.ToString()})");
                            fm1.serialPort.WriteLine($"setdir({k.ToString()},{k.ToString()})");
                            System.Threading.Thread.Sleep(300);
                            s.AppendLine($"Graph[{i.ToString()}][{j.ToString()}][{k.ToString()}]=-1;");
                        }
                    }
                }
            }
            MessageBox.Show("Finished!");
            textBox1.Text = s.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fm1.serialPort.WriteLine($"grinit(1,1)");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            fm1.serialPort.WriteLine($"grclear(1,1)");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm1.OnMessageReceive -= MsgReceive;
        }
    }
}
