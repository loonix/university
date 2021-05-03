package com.example.quizzapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Main extends AppCompatActivity {
    Button obtbcomecar;
    Button obtbpontacao;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        System.out.println("MainActivity - Iniciou");


        obtbcomecar = (Button)findViewById(R.id.buttonComecar);
        obtbcomecar.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               accessScreen(Perguntas.class);
            }
        });

        obtbpontacao = (Button)findViewById(R.id.buttonPontuacao);
        obtbpontacao.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
              accessScreen(Ranking.class);
            }
        });
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className)
    {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}