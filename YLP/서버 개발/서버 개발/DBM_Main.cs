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
    public partial class DBM_Main : Form
    {
        public DBM_Main(ref bool form_dbmm)
        {
            InitializeComponent();
            form_dbmm = false;
        }
    }
}
