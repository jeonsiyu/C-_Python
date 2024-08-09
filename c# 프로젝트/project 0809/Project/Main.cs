using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {

        private Member member;
        private Question question;
        private Notice notice;
        private Home home;
        private bool isMemberVisible = false;
        private bool isQuestionVisible = false;
        private bool isNoticeVisible = false;
        private bool isHomeVisible = true;
        public Main()
        {
            InitializeComponent();

            button1.Click += new EventHandler(button1_Click);
            home = new Home();
            button2.Click += new EventHandler(button2_Click);
            member = new Member();
            button3.Click += new EventHandler(button3_Click);
            question = new Question();
            button4.Click += new EventHandler(button4_Click);
            notice = new Notice();

            label_Welcome_Create();
            InitEvent();

            button_Logout.Click += new EventHandler(button_Logout_Click);

            // 로그인 후 main화면에 바로 home폼 표시 
            Panel homepanel = home.Panel;
            homepanel.Location = new System.Drawing.Point(231, 75);
            homepanel.Size = new System.Drawing.Size(1100, 700);
            if (!this.Controls.Contains(homepanel))
            {
                this.Controls.Add(homepanel);
            }
            homepanel.Visible = true;
            isHomeVisible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabControl memberTabControl = member.TabControl;
            TabControl questionTabControl = question.TabControl;
            TabControl noticeTabControl = notice.TabControl;
            Panel homepanel = home.Panel;

            if (isHomeVisible)
            {
                homepanel.Visible = false;
            }
            else
            {
                // Question TabControl 숨기기
                if (this.Controls.Contains(questionTabControl))
                {
                    questionTabControl.Visible = false;
                    isQuestionVisible = false;
                }

                // Notice TabControl 숨기기
                if (this.Controls.Contains(noticeTabControl))
                {
                    noticeTabControl.Visible = false;
                    isNoticeVisible = false;
                }

                // Member TabControl 숨기기
                if (this.Controls.Contains(memberTabControl))
                {
                    memberTabControl.Visible = false;
                    isMemberVisible = false;
                }

                homepanel.Visible = true;
            }
            isHomeVisible = !isHomeVisible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            TabControl memberTabControl = member.TabControl;
            TabControl questionTabControl = question.TabControl;
            TabControl noticeTabControl = notice.TabControl;
            Panel homepanel = home.Panel;

            memberTabControl.Location = new System.Drawing.Point(231, 75); // 원하는 위치로 설정
            memberTabControl.Size = new System.Drawing.Size(1100, 700);

            if (!isMemberVisible)
            {
                // Question TabControl 숨기기
                if (this.Controls.Contains(questionTabControl))
                {
                   //  tableLayoutPanel_Home
                    questionTabControl.Visible = false;
                    isQuestionVisible = false;
                }

                // Notice TabControl 숨기기
                if (this.Controls.Contains(noticeTabControl))
                {
                    noticeTabControl.Visible = false;
                    isNoticeVisible = false;
                }

                // home Panel 숨기기
                if (this.Controls.Contains(homepanel))
                {
                    homepanel.Visible = false;
                    isNoticeVisible = false;
                }

                // Member TabControl 표시
                if (!this.Controls.Contains(memberTabControl))
                {
                    this.Controls.Add(memberTabControl);
                }
                memberTabControl.Visible = true;
            }
            else
            {
                // Member TabControl 숨기기
                memberTabControl.Visible = false;
            }
            isMemberVisible = !isMemberVisible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabControl memberTabControl = member.TabControl;
            TabControl questionTabControl = question.TabControl;
            TabControl noticeTabControl = notice.TabControl;
            Panel homepanel = home.Panel;

            questionTabControl.Location = new System.Drawing.Point(231, 75);
            questionTabControl.Size = new System.Drawing.Size(1100, 700);

            if (!isQuestionVisible)
            {
                // Member TabControl 숨기기
                if (this.Controls.Contains(memberTabControl))
                {
                    memberTabControl.Visible = false;
                    isMemberVisible = false;
                }

                // Notice TabControl 숨기기
                if (this.Controls.Contains(noticeTabControl))
                {
                    noticeTabControl.Visible = false;
                    isNoticeVisible = false;
                }

                // home Panel 숨기기
                if (this.Controls.Contains(homepanel))
                {
                    homepanel.Visible = false;
                    isNoticeVisible = false;
                }

                // Question TabControl 표시
                if (!this.Controls.Contains(questionTabControl))
                {
                    this.Controls.Add(questionTabControl);
                }
                questionTabControl.Visible = true;
            }
            else
            {
                // Question TabControl 숨기기
                questionTabControl.Visible = false;
            }
            isQuestionVisible = !isQuestionVisible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabControl memberTabControl = member.TabControl;
            TabControl questionTabControl = question.TabControl;
            TabControl noticeTabControl = notice.TabControl;
            Panel homepanel = home.Panel;

            noticeTabControl.Location = new System.Drawing.Point(231, 75);
            noticeTabControl.Size = new System.Drawing.Size(1100, 700);

            if (!isNoticeVisible)
            {
                // Member TabControl 숨기기
                if (this.Controls.Contains(memberTabControl))
                {
                    memberTabControl.Visible = false;
                    isMemberVisible = false;
                }

                // Question TabControl 숨기기
                if (this.Controls.Contains(questionTabControl))
                {
                    questionTabControl.Visible = false;
                    isQuestionVisible = false;
                }

                // home Panel 숨기기
                if (this.Controls.Contains(homepanel))
                {
                    homepanel.Visible = false;
                    isNoticeVisible = false;
                }

                // Notice TabControl 표시
                if (!this.Controls.Contains(noticeTabControl))
                {
                    this.Controls.Add(noticeTabControl);
                }
                noticeTabControl.Visible = true;
            }
            else
            {
                // Notice TabControl 숨기기
                noticeTabControl.Visible = false;
            }
            isNoticeVisible = !isNoticeVisible;
        }

        private void InitEvent()
        {
            // panel 그라데이션 이벤트 선언
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Gradient);
            this.panel_Main_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Gradient);

            // Resize 이벤트 등록
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        private void Form_Gradient(object sender, PaintEventArgs e)
        {

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle,
                                        System.Drawing.Color.White,
                                        System.Drawing.Color.White, 0, false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);

        }

        private void Panel_Gradient(object sender, PaintEventArgs e)
        {
            Color stsarColor = System.Drawing.ColorTranslator.FromHtml("#9ecfe6");
            Color MiddlieColor = System.Drawing.ColorTranslator.FromHtml("#969fe5");
            Color EndColor = System.Drawing.ColorTranslator.FromHtml("#d76ddb");
            //Color.FromArgb(0, 0, 0);

            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 2 / 6f, 1 };
            cb.Colors = new[] { stsarColor, MiddlieColor, EndColor };

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle,
                            System.Drawing.Color.White,
                            System.Drawing.Color.White, 0, false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);

            br.InterpolationColors = cb;
            br.RotateTransform(45);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // 폼을 다시 그리도록 요청 -> 현재 컨트롤을 다시 그리도록 요청하는 메서드
        }

        private void label_Welcome_Create()
        {
            // 저장된 데이터를 가져와서 환영하기(?)          
            label_Welcome.Text = $"{DataManager.loginedAdmin.manager_name}님 환영합니다!";
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            DataManager.loginedAdmin = null;
            Close();

        }
    }
}
