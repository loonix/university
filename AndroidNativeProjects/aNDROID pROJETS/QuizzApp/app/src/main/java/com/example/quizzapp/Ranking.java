package com.example.quizzapp;

import androidx.annotation.RequiresApi;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Build;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

import static java.util.Comparator.comparing;

public class Ranking extends AppCompatActivity {
    List<Utilizador> utilizadores = new ArrayList<Utilizador>();;
    TextView top1;
    TextView top2;
    TextView top3;
    TextView top4;
    TextView top5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ranking);
        System.out.println("resultado - Iniciou");

        // inicia as textviews
        top1 = (TextView) findViewById(R.id.textView1Lugar);
        top2 = (TextView) findViewById(R.id.textView2Lugar);
        top3 = (TextView) findViewById(R.id.textView3Lugar);
        top4 = (TextView) findViewById(R.id.textView4Lugar);
        top5 = (TextView) findViewById(R.id.textView5Lugar);

        carregarDados();
        ordenarPontuacoes();
        carregarRankings();
    }

    @SuppressLint("SetTextI18n")
    /// Carrega a tabela de rankings
    private void carregarRankings() {
        top1.setText(utilizadores.get(0).utilizador + " - " + utilizadores.get(0).pontuacao);
        top2.setText(utilizadores.get(1).utilizador + " - " + utilizadores.get(1).pontuacao);
        top3.setText(utilizadores.get(2).utilizador + " - " + utilizadores.get(2).pontuacao);
        top4.setText(utilizadores.get(3).utilizador + " - " + utilizadores.get(3).pontuacao);
        top5.setText(utilizadores.get(4).utilizador + " - " + utilizadores.get(4).pontuacao);
    }

    /// ordena da pontuacao maior para a mais pequena
    private void ordenarPontuacoes() {
        Collections.sort(utilizadores, new Comparator<Utilizador>(){
            public int compare(Utilizador u1, Utilizador u2){
                if(u1.pontuacao == u2.pontuacao)
                    return 0;
                return u1.pontuacao > u2.pontuacao ? -1 : 1;
            }
        });
    }

    /// carrega todos os utilizadores
    private void carregarDados() {
        SharedPreferences sharedPreferences = getSharedPreferences("quizzy", MODE_PRIVATE);
        Gson gson = new Gson();
        String json = sharedPreferences.getString("utilizadores", null);
        Type type = new TypeToken<ArrayList<Utilizador>>() {
        }.getType();
        utilizadores = gson.fromJson(json, type);
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className)
    {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}