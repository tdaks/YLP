using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 서버_개발
{
    class Cafeteria
    {
        public string Name
        {
            get;
            set;
        }
        public string PK
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string TodayMenu
        {
            get;
            set;
        }
        public List<String> MenuList
        {
            get;
            set;
        }
        public Cafeteria(string pk, string name, string number, string address)
        {
            PK = pk;
            Name = name;
            PhoneNumber = number;
            Address = address;
        }
        public Cafeteria(string pk, string name, string number, string address, string todayMenu)
        {
            PK = pk;
            Name = name;
            PhoneNumber = number;
            Address = address;
            TodayMenu = todayMenu;
        }
        public Cafeteria(string pk, List<string> menuList)
        {
            PK = pk;
            MenuList = menuList;
        }
    }
}
