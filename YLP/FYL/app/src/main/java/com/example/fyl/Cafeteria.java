package com.example.fyl;

import java.util.ArrayList;

/**
 * Created by Sungman on 2017-07-03.
 */

public class Cafeteria {
    String primaryKey;
    String name;
    String phoneNumber;
    String address;
    String menu;
    ArrayList<String> menuCollection;

    public Cafeteria()    {  menuCollection = new ArrayList<String>();  }
    public Cafeteria(String name, String address, String menu)
    {
        this.name = name;
        this.menu = menu;
        this.address = address;
        menuCollection = new ArrayList<String>();
    }
    public Cafeteria(String pk, String name, String phoneNumber, String address, String menu)
    {
        this.primaryKey = pk;
        this.name = name;
        this.menu = menu;
        this.address = address;
        this.phoneNumber = phoneNumber;
    }

    public String GetName()
    {
        return name;
    }
    public String GetPrimaryKey()
    {
        return primaryKey;
    }
    public String GetPhoneNumber()
    {
        return phoneNumber;
    }
    public String GetAddress()
    {
        return address;
    }
    public String GetMenu()
    {
        return menu;
    }
}
