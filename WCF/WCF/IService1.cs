using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드 및 config 파일에서 인터페이스 이름 "IService1"을 변경할 수 있습니다.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: 여기에 서비스 작업을 추가합니다.
        [OperationContract]
        string HelloWorld();

        [OperationContract]
        Cafeteria GetCafeteria(string primaryKey);

        [OperationContract]
        List<Cafeteria> GetCafeterias();
    }


    // 아래 샘플에 나타낸 것처럼 데이터 계약을 사용하여 복합 형식을 서비스 작업에 추가합니다.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Cafeteria
    {
        string pk;
        string name;
        string phoneNumber;
        string address;
        string menu;
        List<string> menuList;
        [DataMember]
        public string PK
        {
            get { return pk; }
            set { pk = value; }
        }
        [DataMember]
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Menu
        {
            get { return menu; }
            set { menu = value; }
        }
        [DataMember]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        /// <summary>
        /// ///////////////////////////////////////
        /// </summary>
        [DataMember]
        public List<string> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }

        public Cafeteria() { }
        public Cafeteria(string pk, string name, string number, string address, string menu)
        {
            this.pk = pk;
            this.name = name;
            this.PhoneNumber = number;
            this.address = address;
            this.menu = menu;
        }

        public Cafeteria(string pk, string name, string number, string address)
        {
            this.pk = pk;
            this.name = name;
            this.PhoneNumber = number;
            this.address = address;
        }

        public Cafeteria(string pk, List<string> menuList)
        {
            this.pk = pk;
            this.menuList = menuList;
        }
    }
}
