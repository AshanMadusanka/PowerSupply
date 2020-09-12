namespace DigitalBenchPowerInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.voltageL = new System.Windows.Forms.Label();
            this.currentL = new System.Windows.Forms.Label();
            this.frequencyL = new System.Windows.Forms.Label();
            this.votL = new System.Windows.Forms.Label();
            this.curL = new System.Windows.Forms.Label();
            this.freL = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cntBtn = new System.Windows.Forms.Button();
            this.disCnt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.circularPro = new CircularProgressBar.CircularProgressBar();
            this.circularPro2 = new CircularProgressBar.CircularProgressBar();
            this.circularPro3 = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // voltageL
            // 
            this.voltageL.AutoSize = true;
            this.voltageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageL.Location = new System.Drawing.Point(185, 31);
            this.voltageL.Name = "voltageL";
            this.voltageL.Size = new System.Drawing.Size(113, 31);
            this.voltageL.TabIndex = 0;
            this.voltageL.Text = "Voltage";
            // 
            // currentL
            // 
            this.currentL.AutoSize = true;
            this.currentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentL.Location = new System.Drawing.Point(697, 31);
            this.currentL.Name = "currentL";
            this.currentL.Size = new System.Drawing.Size(112, 31);
            this.currentL.TabIndex = 1;
            this.currentL.Text = "Current";
            // 
            // frequencyL
            // 
            this.frequencyL.AutoSize = true;
            this.frequencyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyL.Location = new System.Drawing.Point(1135, 31);
            this.frequencyL.Name = "frequencyL";
            this.frequencyL.Size = new System.Drawing.Size(152, 31);
            this.frequencyL.TabIndex = 2;
            this.frequencyL.Text = "Frequency";
            // 
            // votL
            // 
            this.votL.AutoSize = true;
            this.votL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.votL.Location = new System.Drawing.Point(352, 126);
            this.votL.Name = "votL";
            this.votL.Size = new System.Drawing.Size(23, 25);
            this.votL.TabIndex = 3;
            this.votL.Text = "1";
            this.votL.Click += new System.EventHandler(this.VotL_Click);
            // 
            // curL
            // 
            this.curL.AutoSize = true;
            this.curL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.curL.Location = new System.Drawing.Point(711, 127);
            this.curL.Name = "curL";
            this.curL.Size = new System.Drawing.Size(23, 25);
            this.curL.TabIndex = 4;
            this.curL.Text = "1";
            // 
            // freL
            // 
            this.freL.AutoSize = true;
            this.freL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.freL.Location = new System.Drawing.Point(1179, 127);
            this.freL.Name = "freL";
            this.freL.Size = new System.Drawing.Size(23, 25);
            this.freL.TabIndex = 5;
            this.freL.Text = "1";
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(66, 661);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(121, 21);
            this.portBox.TabIndex = 6;
            // 
            // cntBtn
            // 
            this.cntBtn.Location = new System.Drawing.Point(294, 655);
            this.cntBtn.Name = "cntBtn";
            this.cntBtn.Size = new System.Drawing.Size(93, 30);
            this.cntBtn.TabIndex = 7;
            this.cntBtn.Text = "Connect";
            this.cntBtn.UseVisualStyleBackColor = true;
            this.cntBtn.Click += new System.EventHandler(this.CntBtn_Click);
            // 
            // disCnt
            // 
            this.disCnt.Location = new System.Drawing.Point(442, 655);
            this.disCnt.Name = "disCnt";
            this.disCnt.Size = new System.Drawing.Size(93, 30);
            this.disCnt.TabIndex = 8;
            this.disCnt.Text = "Disconnect";
            this.disCnt.UseVisualStyleBackColor = true;
            this.disCnt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(716, 613);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 72);
            this.textBox1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // circularPro
            // 
            this.circularPro.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularPro.AnimationSpeed = 500;
            this.circularPro.BackColor = System.Drawing.Color.Transparent;
            this.circularPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularPro.InnerColor = System.Drawing.Color.White;
            this.circularPro.InnerMargin = 2;
            this.circularPro.InnerWidth = -1;
            this.circularPro.Location = new System.Drawing.Point(81, 126);
            this.circularPro.MarqueeAnimationSpeed = 1000;
            this.circularPro.Name = "circularPro";
            this.circularPro.OuterColor = System.Drawing.Color.DarkGray;
            this.circularPro.OuterMargin = -25;
            this.circularPro.OuterWidth = 26;
            this.circularPro.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularPro.ProgressWidth = 25;
            this.circularPro.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularPro.Size = new System.Drawing.Size(320, 320);
            this.circularPro.StartAngle = 90;
            this.circularPro.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPro.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularPro.SubscriptText = "";
            this.circularPro.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPro.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularPro.SuperscriptText = "V";
            this.circularPro.TabIndex = 11;
            this.circularPro.Text = "0";
            this.circularPro.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // circularPro2
            // 
            this.circularPro2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularPro2.AnimationSpeed = 500;
            this.circularPro2.BackColor = System.Drawing.Color.Transparent;
            this.circularPro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularPro2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularPro2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularPro2.InnerMargin = 2;
            this.circularPro2.InnerWidth = -1;
            this.circularPro2.Location = new System.Drawing.Point(593, 126);
            this.circularPro2.MarqueeAnimationSpeed = 1000;
            this.circularPro2.Name = "circularPro2";
            this.circularPro2.OuterColor = System.Drawing.Color.DarkGray;
            this.circularPro2.OuterMargin = -25;
            this.circularPro2.OuterWidth = 26;
            this.circularPro2.ProgressColor = System.Drawing.Color.Blue;
            this.circularPro2.ProgressWidth = 25;
            this.circularPro2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularPro2.Size = new System.Drawing.Size(320, 320);
            this.circularPro2.StartAngle = 90;
            this.circularPro2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPro2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularPro2.SubscriptText = "";
            this.circularPro2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPro2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularPro2.SuperscriptText = "A";
            this.circularPro2.TabIndex = 12;
            this.circularPro2.Text = "0";
            this.circularPro2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // circularPro3
            // 
            this.circularPro3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularPro3.AnimationSpeed = 500;
            this.circularPro3.BackColor = System.Drawing.Color.Transparent;
            this.circularPro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularPro3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularPro3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularPro3.InnerMargin = 2;
            this.circularPro3.InnerWidth = -1;
            this.circularPro3.Location = new System.Drawing.Point(1041, 126);
            this.circularPro3.MarqueeAnimationSpeed = 1000;
            this.circularPro3.Name = "circularPro3";
            this.circularPro3.OuterColor = System.Drawing.Color.DarkGray;
            this.circularPro3.OuterMargin = -25;
            this.circularPro3.OuterWidth = 26;
            this.circularPro3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.circularPro3.ProgressWidth = 25;
            this.circularPro3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularPro3.Size = new System.Drawing.Size(320, 320);
            this.circularPro3.StartAngle = 90;
            this.circularPro3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPro3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularPro3.SubscriptText = "";
            this.circularPro3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularPro3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularPro3.SuperscriptText = "Hz";
            this.circularPro3.TabIndex = 13;
            this.circularPro3.Text = "0";
            this.circularPro3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1453, 821);
            this.Controls.Add(this.circularPro3);
            this.Controls.Add(this.circularPro2);
            this.Controls.Add(this.circularPro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.disCnt);
            this.Controls.Add(this.cntBtn);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.freL);
            this.Controls.Add(this.curL);
            this.Controls.Add(this.votL);
            this.Controls.Add(this.frequencyL);
            this.Controls.Add(this.currentL);
            this.Controls.Add(this.voltageL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label voltageL;
        private System.Windows.Forms.Label currentL;
        private System.Windows.Forms.Label frequencyL;
        private System.Windows.Forms.Label curL;
        private System.Windows.Forms.Label freL;
        private System.Windows.Forms.ComboBox portBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button cntBtn;
        private System.Windows.Forms.Button disCnt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label votL;
        private System.Windows.Forms.Button button1;
        private CircularProgressBar.CircularProgressBar circularPro;
        private CircularProgressBar.CircularProgressBar circularPro2;
        private CircularProgressBar.CircularProgressBar circularPro3;
    }
}

