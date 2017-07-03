using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드, svc 및 config 파일에서 클래스 이름 "Service1"을 변경할 수 있습니다.
    // 참고: 이 서비스를 테스트하기 위해 WCF 테스트 클라이언트를 시작하려면 솔루션 탐색기에서Service1.svc나 Service1.svc.cs를 선택하고 디버깅을 시작하십시오.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string HelloWorld()
        {
            return "Hello Man";
        }

        public string GetCafeteria()
        {
            Cafeteria c = new Cafeteria();
            c.Name = "cafe";
            c.Menu = "밥^^국^^반찬";
            c.Address = "구로";

            return Serializer.Serialize(c);
        }

        public List<Cafeteria> GetCafeterias()
        {
            Cafeteria c1 = new Cafeteria();
            c1.Name = "cafe";
            c1.Menu = "밥^^국^^반찬";
            c1.Address = "구로";
            Cafeteria c2 = new Cafeteria();
            c2.Name = "cafe2";
            c2.Menu = "밥2^^국2^^반찬2";
            c2.Address = "가산";

            List<Cafeteria> cafes = new List<Cafeteria>();
            cafes.Add(c1);
            cafes.Add(c2);

            return cafes;
        }
    }
}
