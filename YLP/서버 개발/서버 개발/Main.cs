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
        bool form_dbmm = true;
        bool form_conectMobile = true;
        public Main()
        {
            InitializeComponent();            
        }

        private void btn_DBManager_Click(object sender, EventArgs e)
        {
            if (form_dbmm)
            {
                DBM_Main dbmm = new DBM_Main(ref form_dbmm);
                dbmm.Show();
            }
        }
    }
}
