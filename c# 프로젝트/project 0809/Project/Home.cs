using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadCalenderForm();

        }

        public Panel Panel => tableLayoutPanel_Home;

        private void button1_Click(object sender, EventArgs e)
        {
            calender calender = new calender();
            calender.Show();
        }

        private void LoadCalenderForm()
        {
            ConfigureScrollPanel(); // 스크롤 패널 설정 추가
            calender CalenderForm = new calender(); // 일반 폼 생성
            //CalenderForm.Show();
            CalenderForm.TopLevel = false; // TopLevel을 false로 설정
            CalenderForm.FormBorderStyle = FormBorderStyle.None; // 테두리 제거
            CalenderForm.Dock = DockStyle.None; // Dock을 None으로 설정하여 크기를 조정할 수 있도록 함
            panel9.Dock = DockStyle.None;
            //panel9.BackColor = Color.Black;
            panel9.Controls.Clear(); // 패널에 있는 기존 컨트롤 제거
            panel9.Controls.Add(CalenderForm); // 폼을 패널에 추가
            CalenderForm.Show(); // 폼 표시

            // 패널 크기에 맞게 폼 크기 조정
            AdjustFormAndControlsSize(CalenderForm, panel9.ClientSize);
        }

        private void ConfigureScrollPanel()
        {
            panel9.AutoScroll = true; // 스크롤 가능하도록 설정
            panel9.VerticalScroll.Enabled = true; // 수직 스크롤 허용

        }

        private void AdjustFormAndControlsSize(Form form, Size panelSize)
        {
            // 기본 폼 크기 (설계 시에 설정한 크기)
            //1100, 895 
            Size baseSize = new Size(1250,650); // 설계 시 폼의 기준 크기 Size(1250,650)
            float widthFactor = (float)panelSize.Width / baseSize.Width;
            float heightFactor = (float)panelSize.Height / baseSize.Height;
            float scaleFactor = Math.Min(widthFactor, heightFactor); // 비율을 사용하여 축소

            // 폼 크기 조정
            form.Size = new Size((int)(baseSize.Width * widthFactor), (int)(baseSize.Height * heightFactor));

            // 각 컨트롤의 크기 및 위치 조정
            foreach (Control control in form.Controls)
            {
                control.Width = (int)(control.Width * widthFactor)+80;
                control.Height = (int)(control.Height * heightFactor);
                control.Left = (int)(control.Left * widthFactor) +32; // 건들지 않아도됌
                control.Top = (int)(control.Top * heightFactor)-45;
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * scaleFactor);
            }
        }
    }
  
}
