using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 서버_개발
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBM_Main dbmm = new DBM_Main();
            dbmm.Show();
        }
    }
}
