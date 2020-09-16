using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "BOJE";
            // 
            // button1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23,218);
            this.numericUpDown1.Size = new System.Drawing.Size(90, 49);
            this.button1.Location = new System.Drawing.Point(23, 28);
            this.button1.Size = new System.Drawing.Size(90, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crvena";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 83);
            this.button2.Size = new System.Drawing.Size(90, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Moja boja";
            this.button2.UseVisualStyleBackColor = true;
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(23,138);
            this.button3.Size = new System.Drawing.Size(90, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "Nasumicne boje";
            this.button3.UseVisualStyleBackColor = true;
   
        }
        int a=500;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            a = int.Parse(numericUpDown1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(24, 213,58);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            else timer1.Start();
        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = a;
            BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Brzina menjanja\nboje";
        }
    }
}
