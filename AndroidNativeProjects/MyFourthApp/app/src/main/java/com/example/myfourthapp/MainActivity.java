package com.example.myfourthapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioGroup;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    public void onClearBtnClick(View view) {

        Toast.makeText(MainActivity.this, "Botão clicado", Toast.LENGTH_SHORT).show();
        Intent intent = new Intent(this, DisplayActivity.class);
        startActivity(intent);

    }


}