package com.example.fyl;

/**
 * Created by man on 2017-06-29.
 */

public class InnerWCFUnit {
    private String namespace = "http://tempuri.org/";
    //private final String URL = "http://192.168.219.101:13269/wcf/Service1.svc"; // 내부망
    private final String URL = "http://182.228.83.39:13269/wcf/Service1.svc"; // 외부망

    private String methodName = "HelloWorld";
    private String methodCafeteria = "GetCafeteria";
    private String methodCafeterias = "GetCafeterias";

    private String IsoapAction = "http://tempuri.org/IService1/GetCafeteria";
    private String soapActionGetCafeteria = "http://tempuri.org/IService1/GetCafeteria";
    private String soapActionGetCafeterias = "http://tempuri.org/IService1/GetCafeterias";

    public String GetNamespace(){return namespace;}
    public String GetURL() {return URL;}

    public String GetMethodName() {return methodName;}
    public String GetMethodCafeteria() {return methodCafeteria;}
    public String GetMethodCafeterias() {return methodCafeterias;}

    public String GetISoapAction() {return IsoapAction;}
    public String GetSoapActionCafeteria() {return soapActionGetCafeteria;}
    public String GetSoapActionCafeterias() {return soapActionGetCafeterias;}
}
