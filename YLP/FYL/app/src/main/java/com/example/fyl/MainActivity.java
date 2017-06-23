package com.example.fyl;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.design.widget.BottomNavigationView;
import android.view.MenuItem;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Button;

public class MainActivity extends Activity {

    LinearLayout ll_main,ll_list;
    Button area1,area2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        startActivity(new Intent(this, SplashActivity.class));

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ll_main = (LinearLayout)findViewById(R.id.ll_main);
        area1 = (Button)findViewById(R.id.btn_area1);
        area2 = (Button)findViewById(R.id.btn_area2);

        area1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(MainActivity.this,listActivity.class);
                intent.putExtra("tag",String.valueOf(area1.getTag()));
                startActivity(intent);
            }
        });

        area2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(MainActivity.this,listActivity.class);
                intent.putExtra("tag",String.valueOf(area2.getTag()));
                startActivity(intent);
            }
        });
    }

}
