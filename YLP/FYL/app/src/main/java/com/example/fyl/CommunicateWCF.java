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

    //식당 하나의 정보 가져오는 것. 추 후  식당의 상세 정보 보기 에서 사용 예정
    //아직은 KSOAP2 사용법 익히는 용도.
    public Cafeteria GetCafeteria(String primaryKey){
        SoapObject request = new SoapObject(iu.GetNamespace(), iu.GetMethodCafeteria());
        request.addProperty("primaryKey", primaryKey);
        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        envelope.setOutputSoapObject(request);
        envelope.dotNet = true;

        HttpTransportSE androidHttpTransport = new HttpTransportSE(iu.GetURL());
        Cafeteria result = null;
        try
        {
            androidHttpTransport.call(iu.GetSoapActionCafeteria(), envelope);

            //result = envelope.getResponse().toString();
            //GetSoapActionCafeteria
            //SoapObject so = (SoapObject) envelope.getResponse();
            //result = "Name:"+so.getProperty("Name").toString();
            //result += " Menu:"+so.getProperty("Menu").toString();
            //result += " Address:"+so.getProperty("Address").toString();
            SoapObject so = (SoapObject) envelope.getResponse();
            //result = so.getProperty(0).toString(); // 2개 중 1개 뜸
            ArrayList<String> menuList = new ArrayList<String>();
            String pk = so.getProperty("PK").toString();
            for(int i = 0; i < so.getPropertyCount(); ++i)
            {
                Object obj = so.getProperty(i);

                if(obj instanceof SoapObject)
                {
                    SoapObject cafeteriaSoapObject = (SoapObject) obj;

                    for(int j = 0; j < cafeteriaSoapObject.getPropertyCount(); ++j)
                    {
                        String menu = cafeteriaSoapObject.getProperty(j).toString();
                        menuList.add(menu);
                    }
                }
            }
            result = new Cafeteria(pk, menuList);
        } catch (Exception e)
        {
            e.printStackTrace();
        }
        return result;
    }

    //가디, 구디 버튼 눌렀을 때에 식당들의 정보 가져오는 부분.
    public ArrayList<Cafeteria> GetCafeterias(){
        SoapObject request = new SoapObject(iu.GetNamespace(), iu.GetMethodCafeterias());

        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        envelope.setOutputSoapObject(request);
        envelope.dotNet = true;

        HttpTransportSE androidHttpTransport = new HttpTransportSE(iu.GetURL());
        try
        {
            ArrayList<Cafeteria> cafes = new ArrayList<Cafeteria>();
            androidHttpTransport.call(iu.GetSoapActionCafeterias(), envelope);
            SoapObject so = (SoapObject) envelope.getResponse();
            for(int i = 0; i < so.getPropertyCount(); ++i)
            {
                Object obj = so.getProperty(i);
                if(obj instanceof SoapObject)
                {
                    SoapObject cafeteriaSoapObject = (SoapObject) obj;

                    String cafePK = cafeteriaSoapObject.getProperty("PK").toString();
                    String cafeName = cafeteriaSoapObject.getProperty("Name").toString();
                    String cafePhoneNumber = cafeteriaSoapObject.getProperty("PhoneNumber").toString();
                    String cafeAddress = cafeteriaSoapObject.getProperty("Address").toString();
                    String cafeMenu = cafeteriaSoapObject.getProperty("Menu").toString();
                    Cafeteria cafe = new Cafeteria(cafePK, cafeName, cafePhoneNumber, cafeAddress, cafeMenu);
                    cafes.add(cafe);
                }
            }
            return cafes;
        } catch (Exception e)
        {
            e.printStackTrace();
            return null;
        }
    }
}
