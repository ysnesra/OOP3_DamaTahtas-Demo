using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3_DamaTahtasıDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)   //0. boyutun(satır için) en büyük alacğı değer 7'dir
            {
                for(int j = 0; j <= buttons.GetUpperBound(1); j++)  //1. boyutun(sütun için) en büyük alacğı değer 7'dir
                {
                    //buttons[i,j] konumu her seferinde değişecek ve yeni bir buton oluşacağı için newleriz
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i,j].Left = left;    //8 buton sola sıralasın (satırda)
                    buttons[i,j].Top = top;      //8 buton sıralandıktan sonra alt satıra geçmek için topu 50 artırcaz //50,100,150...
                    left += 50;

                    if((i+j)%2 == 0)
                    {
                        buttons[i,j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);  //butonu ekrana ekle
                }
                top += 50;
                left = 0;
                
            }
        }
    }
}
