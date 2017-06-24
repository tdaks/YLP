package com.example.man.connectwcf;

/**
 * Created by man on 2017-06-22.
 */

public class ConnectServer {
    private String namespace = "http://tempuri.org/";
    private String methodName = "HelloWorld";
    private String soapAction = "http://tempuri.org/IService1/HelloWorld";
    private final String URL = "http://192.168.0.16/YLP/Service1.svc";

    public String GetNamespace(){return namespace;}
    public String GetMethodName() {return methodName;}
    public String GetSoapAction() {return soapAction;}
    public String GetURL() {return URL;}
}
