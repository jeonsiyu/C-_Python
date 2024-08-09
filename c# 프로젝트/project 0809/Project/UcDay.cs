using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UcDay : UserControl
    {

        string _day;
        string date;
        string weekday;
        Label todayLabel;
        public string Date => date;


        // 더블 클릭했을 때 이벤트
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 236, 243); // 색상 변경

            // MemoForm을 UcDay 인스턴스를 전달하며 생성
            MemoForm memoForm = new MemoForm(this);
            memoForm.ShowDialog();

            this.BackColor = Color.White; // 원래 색상으로 되돌리기
        }

        public UcDay(string day)
        {
            InitializeComponent();
            _day = day; // 전달된 날짜를 저장
            label1.Text = day; // 레이블에 날자표시
                               // checkBox1.Hide(); // 체크박스 숨기기
            date = calender._month + "/" + _day + "/" + calender._year;

            panel1.DoubleClick += panel1_DoubleClick;

            // 오늘 날짜와 비교하여 색상 설정
            SetColorForToday();

        }
    

            private void SetColorForToday()
        {
            DateTime currentDate = DateTime.Today; // 오늘 날짜
            DateTime thisDate;

            // date 문자열을 DateTime으로 변환
            if (DateTime.TryParse(date, out thisDate))
            {
                // 오늘 날짜와 비교
                if (thisDate.Date == currentDate)
                {
                    panel1.BackColor = Color.FromArgb(255, 133, 139); // 오늘 날짜의 색상
                    if (todayLabel == null) // 레이블이 아직 생성되지 않은 경우
                    {
                        todayLabel = new Label();
                        todayLabel.Text = "오늘";
                        todayLabel.AutoSize = true; // 자동 크기 조정
                        todayLabel.ForeColor = Color.White; // 색상 설정
                        todayLabel.Location = new Point(50, 10); // 위치 조정 (x, y 좌표)
                        todayLabel.Font = new Font("Arial", 8, FontStyle.Bold); // 글꼴 설정 (글꼴, 크기, 스타일)
                        panel1.Controls.Add(todayLabel); // panel1에 레이블 추가
                    }
                }
            }
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date); //date 문자열을 DateTime으로 변환
                weekday = day.ToString("dddd", new CultureInfo("ko-KR")); // 요일을 한글 문자열로 가져옴 (예: sun,mon, ... )
                if (weekday == "일요일")
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
            } catch(Exception) { }
        }


        private void UcDay_Load(object sender, EventArgs e)
        {
            sundays();
        }

    }
}
