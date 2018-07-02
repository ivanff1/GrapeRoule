package com.example.user.graperoule;

import android.content.DialogInterface;
import android.graphics.Color;
import android.media.Image;
import android.os.Build;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AlertDialog;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.NumberPicker;

public class GameActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

    int last = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.addDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);

        final NumberPicker np = findViewById(R.id.numberPicker);
        final ImageButton black = (ImageButton) findViewById(R.id.black);
        final EditText amount = (EditText) findViewById(R.id.amount);
        final ImageButton red = (ImageButton) findViewById(R.id.red);
        final Button bet = (Button) findViewById(R.id.bet);
        final Button even = (Button) findViewById(R.id.even);
        final Button odd = (Button) findViewById(R.id.odd);

        np.setMinValue(0);
        np.setMaxValue(36);
        np.setOnValueChangedListener(new NumberPicker.OnValueChangeListener() {
            @Override
            public void onValueChange(NumberPicker numberPicker, int i, int i1) {
                red.setAlpha(.5f);
                black.setAlpha(.5f);
                np.setAlpha(1.f);
                even.setAlpha(0.5f);
                odd.setAlpha(.5f);
                if(i % 2 == 0)
                    numberPicker.setBackgroundColor(Color.RED);
                else
                    numberPicker.setBackgroundColor(Color.BLACK);
                last = 0;
            }
        });

        red.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                red.setAlpha(1.f);
                black.setAlpha(.5f);
                np.setAlpha(.5f);
                odd.setAlpha(.5f);
                even.setAlpha(0.5f);
                last = 1;
            }
        });

        black.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                even.setAlpha(0.5f);
                black.setAlpha(1.f);
                odd.setAlpha(.5f);
                red.setAlpha(.5f);
                np.setAlpha(.5f);
                last = 2;
            }
        });
        even.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                even.setAlpha(1.f);
                black.setAlpha(.5f);
                odd.setAlpha(.5f);
                red.setAlpha(.5f);
                np.setAlpha(.5f);
                last = 3;
            }
        });
        odd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                odd.setAlpha(1.f);
                even.setAlpha(0.5f);
                black.setAlpha(.5f);
                red.setAlpha(.5f);
                np.setAlpha(.5f);
                last = 4;
            }
        });

        bet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                AlertDialog.Builder builder;
                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
                    builder = new AlertDialog.Builder(view.getContext(), android.R.style.Theme_Material_Dialog_Alert);
                } else {
                    builder = new AlertDialog.Builder(view.getContext());
                }
                String beting = "0";
                if(last == 0) beting = String.valueOf(np.getValue());
                if(last == 1) beting = "Red";
                if(last == 2) beting = "Black";
                if(last == 3) beting = "Even";
                if(last == 4) beting = "Odd";

                builder.setTitle("Bet " + amount.getText() + "$ on " + beting)
                        .setMessage("Are you sure you want to bet?")
                        .setPositiveButton(android.R.string.yes, new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int which) {
                                // continue with delete
                            }
                        })
                        .setNegativeButton(android.R.string.no, new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int which) {
                                // do nothing
                            }
                        })
                        .setIcon(android.R.drawable.ic_dialog_alert)
                        .show();
            }
        });
    }

    @Override
    public void onBackPressed() {
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.game, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

//        if (id == R.id.nav_camera) {
//            // Handle the camera action
//        } else if (id == R.id.nav_gallery) {
//
//        } else if (id == R.id.nav_slideshow) {
//
//        } else if (id == R.id.nav_manage) {
//
//        } else if (id == R.id.nav_share) {
//
//        } else if (id == R.id.nav_send) {
//
//        }

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }
}
