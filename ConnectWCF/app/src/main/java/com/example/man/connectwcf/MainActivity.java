package com.example.man.connectwcf;

import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import org.ksoap2.serialization.SoapObject;
import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.xmlpull.v1.XmlPullParserException;
import  java.io.IOException;
import org.ksoap2.transport.HttpTransportSE;



public class MainActivity extends AppCompatActivity {
    Button mButton;
    EditText mEdit_debugConsole;
    BackgroundTask task;
    ConnectServer cs = new ConnectServer();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        mButton = (Button)findViewById(R.id.button);
        mEdit_debugConsole = (EditText)findViewById(R.id.editText);

        View.OnClickListener btnListener = new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                task = new BackgroundTask();
                task.execute();
            }
        };
        mButton.setOnClickListener(btnListener);
    }

    public class BackgroundTask extends AsyncTask<Void, Void, String>
    {
        protected  void onPostExecute(String result) {
            super.onPostExecute(result);
            mEdit_debugConsole.setText(result);
        }

        @Override
        protected String doInBackground(Void... params) {
            SoapObject request = new SoapObject(cs.GetNamespace(), cs.GetMethodName());
            //request.addProperty("value", "5");
            SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
            envelope.setOutputSoapObject(request);
            envelope.dotNet = true;

            HttpTransportSE androidHttpTransport = new HttpTransportSE(cs.GetURL());
            try
            {
                androidHttpTransport.call(cs.GetSoapAction(), envelope);
                String result = envelope.getResponse().toString();
                return result;

            } catch (Exception e)
            {
                e.printStackTrace();
                return e.getLocalizedMessage();
            }
        }
    }
}
