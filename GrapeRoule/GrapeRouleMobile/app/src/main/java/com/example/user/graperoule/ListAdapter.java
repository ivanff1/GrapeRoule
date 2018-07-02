package com.example.user.graperoule;

import android.content.ClipData;
import android.content.Context;
import android.content.Intent;
import android.content.res.Resources;
import android.support.design.widget.Snackbar;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import java.io.BufferedWriter;
import java.io.OutputStreamWriter;
import java.net.Socket;
import java.util.List;

public class ListAdapter extends ArrayAdapter<Room> {

    public ListAdapter(Context context, int textViewResourceId) {
        super(context, textViewResourceId);
    }

    public ListAdapter(Context context, int resource, List<Room> items) {
        super(context, resource, items);
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        View v = convertView;

        if (v == null) {
            LayoutInflater vi;
            vi = LayoutInflater.from(getContext());
            v = vi.inflate(R.layout.rooms, null);
        }

        final Room p = getItem(position);

        if (p != null) {
            TextView label = (TextView) v.findViewById(R.id.label);
            TextView price = (TextView) v.findViewById(R.id.price);
            ImageView img = (ImageView) v.findViewById(R.id.stakes);
            Button btn = (Button) v.findViewById(R.id.playBtn);

            label.setText(p.roomName);
            price.setText(p.price);
            img.setImageResource(p.imgId);
            btn.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    Intent intent = new Intent(view.getContext(), GameActivity.class);
                    view.getContext().startActivity(intent);
                }
            });

        }

        return v;
    }

}