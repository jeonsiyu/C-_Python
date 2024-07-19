using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0719_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

      
          myButton.Text = "코드에서 변경!";
          myButton.Width = 100;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                Point point = new Point();
                point.X = 13;
                point.Y = 100 + 13 + (23 + 3) * i; 
                button.Location = point;
                button.Text = "동적 생성" + (i + 1) + "번째";
            }




        }

    }
}
