package com.example.fyl;

/**
 * Created by man on 2017-06-29.
 */

public class InnerWCFUnit {
    private String namespace = "http://tempuri.org/";
    private String methodName = "HelloWorld";
    private String IsoapAction = "http://tempuri.org/IService1/HelloWorld";
    private final String URL = "http://121.127.155.67:34358/WcfService_HelloWorld/Service1.svc";

    public String GetNamespace(){return namespace;}
    public String GetMethodName() {return methodName;}
    public String GetISoapAction() {return IsoapAction;}
    public String GetURL() {return URL;}
}
