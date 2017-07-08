package com.example.fyl;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * Created by HJW on 2017-05-27.
 */

public class listActivity extends Activity {

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.list_activity);

//        Intent intent=new Intent(this.getIntent());
//        String s=intent.getStringExtra("tag"); 지우지마셈

        initList();

    }
    public void initList(){
        CommunicateWCF comWCF = new CommunicateWCF();

        ArrayList<Cafeteria> items = new ArrayList<Cafeteria>();
        items = comWCF.GetCafeterias();

        ListView lvSurround = (ListView)findViewById(R.id.lv_surround);

        ArrayList<ListActivityItem> ylpData=new ArrayList<>();

//        for(int i=0; i<items.size(); i++) {
        ListActivityItem ylpItem = new ListActivityItem("헤헤", "테스트", R.drawable.ic_home_black_24dp);

        ylpData.add(ylpItem);
//        }

        ListViewAdapter ylpAdapter = new ListViewAdapter(this,R.layout.list_activity_item,ylpData);
        lvSurround.setAdapter(ylpAdapter);
    }
}
