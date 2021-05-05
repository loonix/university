package com.example.quizzapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;

public class Perguntas extends AppCompatActivity {
    ArrayList<Pergunta> perguntas;
    int indiceAtual = 0;
    Pergunta perguntaAtual;
    Button btnProximo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perguntas);
        System.out.println("Perguntas - Iniciou");
        carregarPerguntas();
        perguntaAtual = perguntas.get(indiceAtual);
        carregarPerguntaNaView();

        btnProximo = (Button)findViewById(R.id.butaoProximo);
        btnProximo.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int totalPerguntas = perguntas.size();
                if (indiceAtual == totalPerguntas) {
                    Intent intent = new Intent(Perguntas.this, Resultado.class);
                    intent.putExtra("totalErradas", 9);
                    intent.putExtra("totalCertas", 1);
                    startActivity(intent);
                    return;
                } else {
                    mudarPergunta();
                }
            }
        });

    }

    private void carregarPerguntaNaView() {
       TextView questao = findViewById(R.id.textviewPergunta);
        questao.setText(perguntaAtual.questao);
        Button a = (Button)findViewById(R.id.buttonRespostaA);
        a.setText(perguntaAtual.resposta1);
        Button b = (Button)findViewById(R.id.buttonRespostaB);
        b.setText(perguntaAtual.resposta2);
        Button c = (Button)findViewById(R.id.buttonRespostaC);
        c.setText(perguntaAtual.resposta3);
        Button d = (Button)findViewById(R.id.buttonRespostaD);
        d.setText(perguntaAtual.resposta4);
    }

    /// muda a pergunta para a proxima
    private void mudarPergunta() {
        indiceAtual += 1;
        perguntaAtual = perguntas.get(indiceAtual);
        carregarPerguntaNaView();
    }

    /// Carrega as perguntas
    private void carregarPerguntas() {
        SharedPreferences sharedPreferences = getSharedPreferences("quizzy", MODE_PRIVATE);
        Gson gson = new Gson();
        String json = sharedPreferences.getString("perguntas", null);
        Type type = new TypeToken<ArrayList<Pergunta>>() {}.getType();
        perguntas = gson.fromJson(json, type);
        if (perguntas == null) {
            perguntas = new ArrayList<>();
            // adiciona 10 perguntas
            perguntas.add(new Pergunta("De quem é a famosa frase “Penso, logo existo”?","Platão","Galileu Galilei","Descartes","Sócrates","Descartes"));
            perguntas.add(new Pergunta("De onde é a invenção do chuveiro elétrico?","França","Austrália","Itália","Brasil","Brasil"));
            perguntas.add(new Pergunta("Quantas casas decimais tem o número pi?","Duas","Centenas","Infinitas","Milhares","Infinitas"));
            perguntas.add(new Pergunta("Atualmente, quantos elementos químicos a tabela periódica possui?","113","109","108","265","108"));
            perguntas.add(new Pergunta("O que a palavra legend significa em português?","Legenda","Conto","Legendário","Lenda","Lenda"));
            perguntas.add(new Pergunta("Qual o número mínimo de jogadores numa partida de futebol?","7","12","13","15","7"));
            perguntas.add(new Pergunta("Quanto tempo a luz do Sol demora para chegar à Terra?","12 minutos","1 dia","segundos","8 minutos","8 minutos"));
            perguntas.add(new Pergunta("Qual a nacionalidade de Che Guevara?","Cubana","Peruana","Panamenha","Argentina","Argentina"));
            perguntas.add(new Pergunta("Em que período da pré-história o fogo foi descoberto?","Neolítico","Paleolítico","Idade Média","Jurassico","Paleolítico"));
            perguntas.add(new Pergunta("Em qual local da Ásia o português é língua oficial?","Índia","Filipinas","Moçambique","Macau","Macau"));
        }
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className)
    {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}