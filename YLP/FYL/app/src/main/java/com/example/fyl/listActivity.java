package com.example.fyl;

import android.app.Activity;
import android.content.Intent;
import android.os.AsyncTask;
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

    BackgroundTask backgroundTask;
    ArrayList<Cafeteria> cafeterias;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.list_activity);

//        Intent intent=new Intent(this.getIntent());
//        String s=intent.getStringExtra("tag"); 지우지마셈

        ArrayList<Cafeteria> cafeteriasInformation = new ArrayList<Cafeteria>();

        backgroundTask = new BackgroundTask();
        backgroundTask.execute();

    }

    public class BackgroundTask extends AsyncTask<String, Void, ArrayList<Cafeteria>>
    {
        @Override
        protected void onPostExecute(ArrayList<Cafeteria> cafes) {
            super.onPostExecute(cafes);
            InitList(cafes);
        }

        @Override
        protected ArrayList<Cafeteria> doInBackground(String... params) {
            //처음 켜질 때 말고, 다른 창(하나의 구내식당 상세보기 페이지)을 갔다가 돌아오는 경우는,
            //다시 접속하여 불러오는 데이터와 시간 낭비보다
            //리스트들을 기억해뒀다가 불러오는게 더 좋을듯
            CommunicateWCF cw = new CommunicateWCF();
            ArrayList<Cafeteria> result;
            result = cw.GetCafeterias();
            return result;
        }
    }

    public void InitList(ArrayList<Cafeteria> cafes){
        ListView lvSurround = (ListView)findViewById(R.id.lv_surround);

        ArrayList<ListActivityItem> ylpData=new ArrayList<>();

        String strMenu = "";

        for (Cafeteria cafeteria:cafes) {
            String[] cafeteriaValue = cafeteria.GetMenu().split("\\^\\^");
            strMenu = cafeteriaValue[0];
            ListActivityItem ylpItem = new ListActivityItem(cafeteria.GetName(), "메뉴 : " + strMenu, R.drawable.ic_home_black_24dp);
            ylpData.add(ylpItem);
        }

        ListViewAdapter ylpAdapter = new ListViewAdapter(this,R.layout.list_activity_item,ylpData);
        lvSurround.setAdapter(ylpAdapter);
    }



}
