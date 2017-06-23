package com.example.fyl;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.support.annotation.Nullable;

/**
 * Created by 재우 on 2017-05-27.
 */

public class SplashActivity extends Activity {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.splash_activity);

        Handler hd = new Handler();
        hd.postDelayed(new splashhandler() , 1000); // 1초

    }

    private class splashhandler implements Runnable{
        public void run() {
            finish();
        }
    }

}
