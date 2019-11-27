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
    public partial class Form2 : Form
    {
        int[,,] map = new int[400, 400, 10];
        public SerialDebugger.Form1 fm1;
        public Form2()
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
                    if (i == j + 1) { b.BackColor = Color.Black; b.Enabled = false; }

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
    }
}
