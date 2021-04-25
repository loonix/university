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

public class Registo extends AppCompatActivity {
    ArrayList<Utilizador> utilizadores;
    Button obtbCriaRegisto, obtbEntrar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registo);
        carregarDados();
        obtbCriaRegisto = (Button) findViewById(R.id.buttonnovoRegisto);
        obtbEntrar = (Button) findViewById(R.id.buttonEntrar);

    }

    private void salvarDados() {
        SharedPreferences sharedPreferences = getSharedPreferences("quizzy", MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        Gson gson = new Gson();
        String json = gson.toJson(utilizadores);
        editor.putString("utilizadores", json);
        editor.apply();
    }

    private void carregarDados() {
        SharedPreferences sharedPreferences = getSharedPreferences("quizzy", MODE_PRIVATE);
        Gson gson = new Gson();
        String json = sharedPreferences.getString("utilizadores", null);
        Type type = new TypeToken<ArrayList<Utilizador>>() {}.getType();
        utilizadores = gson.fromJson(json, type);
        if (utilizadores == null) {
            utilizadores = new ArrayList<>();
            // adiciona utilizador por defeito
            utilizadores.add(new Utilizador("admin","admin","admin@quiz.com","560"));
        }
    }
    //obtbCriaRegisto = (Button)findViewById(R.id.buttonnovoRegisto);


    /* obtbCriaRegisto.setOnClickListener (new View.OnClickListener() {
         @Override
         public void onClick(View v) {
             goToSecondActivity();
         }
     });

     obtbEntrar.setOnClickListener (new View.OnClickListener() {
         @Override
         public void onClick(View v) {
             goToThirdActivity();
         }
     });
 }
 private void goToSecondActivity()
 {
     Intent intent = new Intent(this, criarConta.class);
     startActivity(intent);

 }
 private void goToThirdActivity()
 {
     Intent intent = new Intent(this, resultado.class);
     startActivity(intent);

 }*/
    public void onbuttonRegistarClick(View view) {
        if (view.getId() == R.id.buttonnovoRegisto) {
            Intent intent = new Intent(getBaseContext(), criarConta.class);
            startActivity(intent);

        } else if (view.getId() == R.id.buttonEntrar) {
            Intent intent = new Intent(getBaseContext(), Perguntas.class);
            startActivity(intent);
        }


    }

}
