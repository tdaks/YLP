package com.example.fyl;

import android.app.Activity;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.widget.TextView;

/**
 * Created by HJW on 2017-05-27.
 */

public class listActivity extends Activity {

    CommunicateWCF communicateWcfUnit;
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.list_activity);

        Intent intent=new Intent(this.getIntent());
        String s=intent.getStringExtra("tag");

        TextView tv_test = (TextView)findViewById(R.id.tv_test);
        tv_test.setText(s);
    }
    public class BackgroundTask extends AsyncTask<Void, Void, String>
    {
        protected  void onPostExecute(String result) {
            super.onPostExecute(result);

        }

        @Override
        protected String doInBackground(Void... params) {
            communicateWcfUnit = new CommunicateWCF();
            return communicateWcfUnit.HelloWorld();
        }
    }
}
