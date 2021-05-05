package com.example.quizzapp;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;

public class Resultado extends AppCompatActivity {
    ArrayList<Utilizador> utilizadores;
    String utilizadorLogado;
    int pontuacao;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado);
        System.out.println("resultado - Iniciou");

        carregarDados();

        Bundle b = getIntent().getExtras();
        String totalErradas = b.getString("totalErradas");
        String totalCertas = b.getString("totalCertas");

        TextView erradas = (TextView) findViewById(R.id.textViewperguntasErradas);
        TextView certas = (TextView) findViewById(R.id.textViewCertas);

        erradas.setText(totalErradas);
        certas.setText(totalCertas);
        pontuacao = ((1000 * Integer.parseInt(totalCertas)) / Integer.parseInt(totalErradas));
        salvarResultado();
    }

    private void salvarResultado() {
        for (Utilizador user : utilizadores) {
            // no caso do utilizador e email corresponderem
            if (user.utilizador.equals(utilizadorLogado)) {
                user.pontuacao = pontuacao;
            }
        }
        salvarUtilizador();
    }

    private void salvarUtilizador() {
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
        Type type = new TypeToken<ArrayList<Utilizador>>() {
        }.getType();
        utilizadores = gson.fromJson(json, type);
        /// recebe o utilizador logado e guarda
        utilizadorLogado = sharedPreferences.getString("sessao", null);
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className) {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}