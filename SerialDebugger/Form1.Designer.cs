namespace SerialDebugger
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MPU = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MPU.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 666);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 664);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "断开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 42;
            this.listBox1.Location = new System.Drawing.Point(22, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(665, 592);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 851);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1578, 36);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "asdasd asdasv ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 31);
            this.toolStripStatusLabel1.Text = "准备就绪";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(693, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1164, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "发送";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(583, 668);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 28);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "记录日志";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 35);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "150";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(284, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 35);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "150";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "左轮";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "右轮";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 49);
            this.button4.TabIndex = 16;
            this.button4.Text = "动！";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(453, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 49);
            this.button5.TabIndex = 21;
            this.button5.Text = "动！";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "2号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "1号";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(338, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 35);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "0";
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 35);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "0";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(712, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 111);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "舵机";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(169, 35);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 49);
            this.button10.TabIndex = 22;
            this.button10.Text = "动！";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(712, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电机";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // MPU
            // 
            this.MPU.Controls.Add(this.button26);
            this.MPU.Controls.Add(this.button25);
            this.MPU.Controls.Add(this.button6);
            this.MPU.Controls.Add(this.textBox6);
            this.MPU.Location = new System.Drawing.Point(712, 328);
            this.MPU.Name = "MPU";
            this.MPU.Size = new System.Drawing.Size(598, 111);
            this.MPU.TabIndex = 23;
            this.MPU.TabStop = false;
            this.MPU.Text = "姿态";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(436, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 49);
            this.button6.TabIndex = 21;
            this.button6.Text = "z轴置零";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(25, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 35);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "90";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(712, 461);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 51);
            this.button7.TabIndex = 24;
            this.button7.Text = "巡线前进";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(996, 498);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 51);
            this.button8.TabIndex = 25;
            this.button8.Text = "Go";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(888, 426);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 35);
            this.textBox9.TabIndex = 26;
            this.textBox9.Text = "150";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1148, 473);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 37);
            this.button9.TabIndex = 27;
            this.button9.Text = "左转";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(888, 508);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 35);
            this.textBox10.TabIndex = 28;
            this.textBox10.Text = "200";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(551, 553);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(136, 51);
            this.button12.TabIndex = 30;
            this.button12.Text = "清除";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1328, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(175, 105);
            this.button11.TabIndex = 31;
            this.button11.Text = "getball";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_2);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1328, 335);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(175, 105);
            this.button13.TabIndex = 32;
            this.button13.Text = "exmaze";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1328, 203);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(175, 105);
            this.button14.TabIndex = 33;
            this.button14.Text = "getball2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1328, 461);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(175, 79);
            this.button15.TabIndex = 34;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(888, 467);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 35);
            this.textBox11.TabIndex = 35;
            this.textBox11.Text = "150";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(996, 441);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(97, 51);
            this.button16.TabIndex = 36;
            this.button16.Text = "Setspeed";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1328, 12);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(129, 37);
            this.button17.TabIndex = 37;
            this.button17.Text = "左转";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 22);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(132, 57);
            this.button20.TabIndex = 40;
            this.button20.Text = "收集物资0";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(150, 22);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(132, 57);
            this.button21.TabIndex = 41;
            this.button21.Text = "迷宫探测1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(302, 22);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(132, 57);
            this.button22.TabIndex = 42;
            this.button22.Text = "X前行2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(452, 22);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(132, 57);
            this.button23.TabIndex = 43;
            this.button23.Text = "Y前行3";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(599, 22);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(132, 57);
            this.button24.TabIndex = 44;
            this.button24.Text = "接受信号4";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button24);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.button23);
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Location = new System.Drawing.Point(22, 721);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(938, 127);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(757, 22);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(132, 57);
            this.button19.TabIndex = 45;
            this.button19.Text = "救人5";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(693, 588);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(597, 51);
            this.button18.TabIndex = 46;
            this.button18.Text = "绘图";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(130, 30);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(130, 49);
            this.button25.TabIndex = 22;
            this.button25.Text = "相对转角度";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(284, 25);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(109, 49);
            this.button26.TabIndex = 23;
            this.button26.Text = "绝对转";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 887);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.MPU);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MPU.ResumeLayout(false);
            this.MPU.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox MPU;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
    }
}

