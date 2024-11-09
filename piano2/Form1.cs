using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piano2
{
    public partial class Form1 : Form
    {
        const int maxX = 800, maxY = 380, minX = 240, minY = 30;
        int count = 0;
        int[] arrbee = new int[49]
                     {5,3,3,4,2,2,1,2,3,4,5,5,5,
                      5,3,3,4,2,2,1,3,5,5,3,
                      2,2,2,2,2,3,4,3,3,3,3,3,4,5,
                      5,3,3,4,2,2,1,3,5,5,1};
        int[] arrstar = new int[42]
                     {1,1,5,5,6,6,5,4,4,3,3,2,2,1,
                      5,5,4,4,3,3,2,5,5,4,4,3,3,2,
                      1,1,5,5,6,6,5,4,4,3,3,2,2,1 };
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPaint_Click(object sender, EventArgs e)
        {
            //draw(5, 3);
        }
        void draw(int[] arr ,int max)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
           
            for (int i = 0; i < 8; i++)
            {
                g.DrawLine(new Pen(Color.Black),minX,minY+i*50,maxX,minY+i*50);
                g.DrawLine(new Pen(Color.Black), minX + i * ((800-240) / 7), minY, minX + i * ((800-240) / 7), maxY);
            }

            //g.FillRectangle(new SolidBrush(Color.Black), 120 + (x-1) * (675 - 120) / 7, 30+(y-1)*40, (675 - 120) / 7, 40);

            for (int i = 0,j=count; i<7; i++)
            {
                if (j>max-1) {  }
                else
                {
                    if (j+i>max-1)
                    {
                        break;
                    }
                    g.FillRectangle(new SolidBrush(Color.Black), minX + ((arr[j + i]) - 1) * (800 - 240) / 7, minY + Math.Abs(i-6) * 50, (800 - 240) / 7, 50);                                   
                }                    
            }
            if (count==max)
            {
                MessageBox.Show("恭喜你完成了演奏");
                count = 0;
            }            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            count = 0;
            richTextBox1.Text = "";
            if (comboBox1.Text=="小蜜蜂")
            {
                draw(arrbee,49);
            }
            else if (comboBox1.Text=="小星星")
            {
                draw(arrstar, 42);
            }
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btnDo_Click(sender,e);
                    break;
                case Keys.D2:
                    btnRe_Click(sender, e);
                    break;
                case Keys.D3:
                    btnMi_Click(sender,e);
                    break;
                case Keys.D4:
                    btnFe_Click(sender, e);
                    break;
                case Keys.D5:
                    btnSo_Click(sender,e);
                    break;
                case Keys.D6:
                    btnLa_Click(sender, e);
                    break;
                case Keys.D7:
                    btnSi_Click(sender,e);
                    break;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            Console.Beep(262,500);
            richTextBox1.Text += "Do";
            if (comboBox1.Text=="小蜜蜂")
            {
                if (arrbee[count]==1)
                {
                    count++;
                    draw(arrbee, 49);
                }
            }
            else if (comboBox1.Text=="小星星")                
            {
                if (arrstar[count]==1)
                {
                    count++;
                    draw(arrstar,42);
                }
            }
        }
        private void btnRe_Click(object sender, EventArgs e)
        {
            Console.Beep(294, 500);
            richTextBox1.Text += "Re";
            if (comboBox1.Text == "小蜜蜂")
            {
                if (arrbee[count] == 2)
                {
                    count++;
                    draw(arrbee, 49);
                }
            }
            else if (comboBox1.Text == "小星星")
            {
                if (arrstar[count] == 2)
                {
                    count++;
                    draw(arrstar, 42);
                }
            }
        }
        private void btnMi_Click(object sender, EventArgs e)
        {
            Console.Beep(330, 500);
            richTextBox1.Text += "Mi";
            if (comboBox1.Text == "小蜜蜂")
            {
                if (arrbee[count] == 3)
                {
                    count++;
                    draw(arrbee, 49);
                }
            }
            else if (comboBox1.Text == "小星星")
            {
                if (arrstar[count] == 3)
                {
                    count++;
                    draw(arrstar, 42);
                }
            }
        }
        private void btnFe_Click(object sender, EventArgs e)
        {
            Console.Beep(349, 500);
            richTextBox1.Text += "Fa";
            if (comboBox1.Text == "小蜜蜂")
            {
                if (arrbee[count] == 4)
                {
                    count++;
                    draw(arrbee, 49);
                }
            }
            else if (comboBox1.Text == "小星星")
            {
                if (arrstar[count] == 4)
                {
                    count++;
                    draw(arrstar, 42);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnSo_Click(object sender, EventArgs e)
        {
            Console.Beep(392, 500);
            richTextBox1.Text += "So";
            if (comboBox1.Text == "小蜜蜂")
            {
                if (arrbee[count] == 5)
                {
                    count++;
                    draw(arrbee, 49);
                }
            }
            else if (comboBox1.Text == "小星星")
            {
                if (arrstar[count] == 5)
                {
                    count++;
                    draw(arrstar, 42);
                }
            }
        }
        private void btnLa_Click(object sender, EventArgs e)
        {
            Console.Beep(440, 500);
            richTextBox1.Text += "La";
            if (comboBox1.Text == "小蜜蜂")
            {
                if (arrbee[count] == 6)
                {
                    count++;
                    draw(arrbee, 49);
                }
            }
            else if (comboBox1.Text == "小星星")
            {
                if (arrstar[count] == 6)
                {
                    count++;
                    draw(arrstar, 42);
                }
            }
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            Console.Beep(494, 500);
            richTextBox1.Text += "Si";
            if (comboBox1.Text == "小蜜蜂")
            {
                if (arrbee[count] == 7)
                {
                    count++;
                    draw(arrbee, 49);
                }
            }
            else if (comboBox1.Text == "小星星")
            {
                if (arrstar[count] == 7)
                {
                    count++;
                    draw(arrstar, 42);
                }
            }
        }

    }
}
