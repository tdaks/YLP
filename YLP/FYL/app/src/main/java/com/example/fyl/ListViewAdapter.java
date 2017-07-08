package com.example.fyl;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;

/**
 * Created by 재우 on 2017-07-08.
 */

public class ListViewAdapter extends BaseAdapter {

    private LayoutInflater inflater;
    private ArrayList<ListActivityItem> data;
    private int layout;
    public ListViewAdapter(Context context, int layout, ArrayList<ListActivityItem> data){
        this.inflater=(LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        this.data=data;
        this.layout=layout;
    }


    @Override
    public int getCount() {
        return data.size();
    }

    @Override
    public Object getItem(int position) {
        return data.get(position).getTitle();
    }

    @Override
    public long getItemId(int position) {
        return position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView==null){
            convertView=inflater.inflate(layout,parent,false);
        }
        ListActivityItem listviewitem=data.get(position);
        ImageView picture=(ImageView)convertView.findViewById(R.id.iv_picture);
        picture.setImageResource(listviewitem.getPicture());
        TextView title=(TextView)convertView.findViewById(R.id.tv_title);
        title.setText(listviewitem.getTitle());
        TextView menu=(TextView)convertView.findViewById(R.id.tv_menu);
        menu.setText(listviewitem.getMenu());
        return convertView;

    }
}
