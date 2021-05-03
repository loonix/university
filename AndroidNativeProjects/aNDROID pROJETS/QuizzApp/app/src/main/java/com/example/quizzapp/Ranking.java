package com.example.quizzapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;

public class Ranking extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ranking);
        System.out.println("resultado - Iniciou");

    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className)
    {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}