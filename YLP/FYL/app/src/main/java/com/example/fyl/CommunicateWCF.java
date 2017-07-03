package com.example.fyl;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import java.util.ArrayList;

/**
 * Created by man on 2017-06-29.
 */

public class CommunicateWCF {
    InnerWCFUnit iu;

    public CommunicateWCF()
    {
        iu = new InnerWCFUnit();
    }

    public String HelloWorld(){
        SoapObject request = new SoapObject(iu.GetNamespace(), iu.GetMethodName());
        //request.addProperty("value", "5");
        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        envelope.setOutputSoapObject(request);
        envelope.dotNet = true;

        HttpTransportSE androidHttpTransport = new HttpTransportSE(iu.GetURL());
        try
        {
            androidHttpTransport.call(iu.GetISoapAction(), envelope);
            String result = envelope.getResponse().toString();
            return result;

        } catch (Exception e)
        {
            e.printStackTrace();
            return e.getLocalizedMessage();
        }
    }

    public String GetCafeteria(){
        SoapObject request = new SoapObject(iu.GetNamespace(), iu.GetMethodCafeterias());
        //request.addProperty("value", "5");
        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        envelope.setOutputSoapObject(request);
        envelope.dotNet = true;

        HttpTransportSE androidHttpTransport = new HttpTransportSE(iu.GetURL());
        try
        {
            ArrayList<Cafeteria> cafes = new ArrayList<Cafeteria>();
            androidHttpTransport.call(iu.GetSoapActionCafeterias(), envelope);
            String result;
            //result = envelope.getResponse().toString();
            //GetSoapActionCafeteria
            //SoapObject so = (SoapObject) envelope.getResponse();
            //result = "Name:"+so.getProperty("Name").toString();
            //result += " Menu:"+so.getProperty("Menu").toString();
            //result += " Address:"+so.getProperty("Address").toString();
            SoapObject so = (SoapObject) envelope.getResponse();
            result = so.getProperty(0).toString(); // 2개 중 1개 뜸
            for(int i = 0; i < so.getPropertyCount(); ++i)
            {
                Object obj = so.getProperty(i);
                if(obj instanceof SoapObject)
                {
                    SoapObject cafeteriaSoapObject = (SoapObject) obj;

                    String cafeName = cafeteriaSoapObject.getProperty("Name").toString();
                    String cafeAddress = cafeteriaSoapObject.getProperty("Address").toString();
                    String cafeMenu = cafeteriaSoapObject.getProperty("Menu").toString();
                    Cafeteria cafe = new Cafeteria(cafeName, cafeMenu, cafeAddress);
                    cafes.add(cafe);
                }
                /*
                참조변수가 참조하고 있는 인스턴스의 실제 타입을 알아보기 위해 instanceof 연산자를 사용합니다.
                주로 조건문에 사용되며, instanceof의 왼쪽에는 참조변수를 오른쪽에는 타입(클래스명)이 피연산자로 위치합니다.
                그리고 연산의 결과로 boolean값인 true, false 중의 하나를 반환 합니다.
                instanceof를 이용한 연산결과로 true를 얻었다는 것은 참조변수가 검사한 타입으로 형변환이 가능하다는 것을 뜻합니다.
                */
            }
            result = "";
            for(int i = 0; i < cafes.size(); ++i)
            {
                result += cafes.get(i).name + " " + cafes.get(i).address + " " + cafes.get(i).menu + "  ";

            }

            return result;
        } catch (Exception e)
        {
            e.printStackTrace();
            return e.getLocalizedMessage();
        }
    }
}
