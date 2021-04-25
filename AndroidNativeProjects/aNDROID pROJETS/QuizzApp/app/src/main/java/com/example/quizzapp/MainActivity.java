package com.example.quizzapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    Button obtbcomecar;
    Button obtbpontacao;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        obtbcomecar = (Button)findViewById(R.id.buttonComecar);
        obtbcomecar.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               goToSecondActivity();
            }
        });

        obtbpontacao = (Button)findViewById(R.id.buttonPontuacao);
        obtbpontacao.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
              goToThirdActivity();
            }
        });
    }

    private void goToSecondActivity()
    {
        Intent intent = new Intent(this, Registo.class);
        startActivity(intent);
    }
    private void goToThirdActivity()
    {
        Intent intent = new Intent(this, resultado.class);
        startActivity(intent);
    }



   /* public void onbuttonComecarClick(View view) {
        if (view.getId() == R.id.buttonComecar) {
            Intent intent = new Intent(getBaseContext(), Registo.class);
            startActivity(intent);

        } else if (view.getId() == R.id.buttonPontuacao) {
            Intent intent = new Intent(getBaseContext(), Pontuacao.class);
            startActivity(intent);
        }


    }*/
}