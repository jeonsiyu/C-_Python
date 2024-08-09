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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();

            TotalMember tm = new TotalMember();
            tm.TopLevel = false;
            panel1.Controls.Add(tm);
            tm.Show();

            NewMember nm = new NewMember();
            nm.TopLevel = false;
            panel2.Controls.Add(nm);
            nm.Show();

            OutMember om = new OutMember();
            om.TopLevel = false;
            panel3.Controls.Add(om);
            om.Show();

        }
        public TabControl TabControl => tabControl1;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
