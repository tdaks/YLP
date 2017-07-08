package com.example.fyl;

/**
 * Created by 재우 on 2017-07-08.
 */

public class ListActivityItem {
    private String TITLE;
    private String MENU;
    private int PICTURE;

    public String getTitle() {
        return TITLE;
    }
    public String getMenu() {
        return MENU;
    }
    public int getPicture() {
        return PICTURE;
    }

    public ListActivityItem(String TITLE, String MENU, int PICTURE){
        this.TITLE = TITLE;
        this.MENU = MENU;
        this.PICTURE = PICTURE;
    }
}
