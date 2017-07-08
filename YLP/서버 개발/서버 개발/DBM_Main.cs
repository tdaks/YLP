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
        DBManager dbm = new DBManager();
        public DBM_Main(ref bool form_dbmm)
        {
            InitializeComponent();
            form_dbmm = false;
            ViewAllCafeteria();

        }

        public void ViewAllCafeteria()
        {
            List<Cafeteria> cafes;
            cafes = dbm.ViewAllCafeteria();
            
            foreach(Cafeteria cafe in cafes)
            {
                string[] arr = new string[4] {cafe.PK, cafe.Name, cafe.PhoneNumber, cafe.Address};

                ListViewItem lvitem = new ListViewItem(arr);
                lv_Cateferia.Items.Add(lvitem);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string pk = tb_pk.Text;
            string name = tb_name.Text;
            string num = tb_number.Text;
            string address = tb_address.Text;
            string error = dbm.InsertCafeteria(pk, name, num, address);
            if(error != "")
            {
                MessageBox.Show(error);
            }

            ViewAllCafeteria();
        }

        private void btn_cafeteriaAllMenu_Click(object sender, EventArgs e)
        {
            Cafeteria cafe =  dbm.GetCafeteria(tb_cafeteriaPK.Text);
        }
    }
}
