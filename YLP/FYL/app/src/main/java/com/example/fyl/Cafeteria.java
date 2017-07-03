package com.example.fyl;

import java.util.ArrayList;

/**
 * Created by Sungman on 2017-07-03.
 */

public class Cafeteria {
    String name;
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
}
