package com.example.fyl;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

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
}
