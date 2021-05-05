package com.example.quizzapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;

public class Perguntas extends AppCompatActivity {
    ArrayList<Pergunta> perguntas;
    int indiceAtual = 0;
    Pergunta perguntaAtual;
    Button btnProxima;
    int acertadas = 0;
    int erradas = 0;
    Button bR1;
    Button bR2;
    Button bR3;
    Button bR4;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perguntas);
        System.out.println("Perguntas - Iniciou");

        // Inicializa todos os botoes
        btnProxima = (Button) findViewById(R.id.butaoProximo);
        bR1 = (Button) findViewById(R.id.buttonRespostaA);
        bR2 = (Button) findViewById(R.id.buttonRespostaB);
        bR3 = (Button) findViewById(R.id.buttonRespostaC);
        bR4 = (Button) findViewById(R.id.buttonRespostaD);

        carregarPerguntas();
        // Inicia o questionatio no indice atual
        perguntaAtual = perguntas.get(indiceAtual);

        carregarPerguntaNaView();

        bR1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                respostaEscolhida("A");
            }
        });

        bR2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                respostaEscolhida("B");
            }
        });

        bR3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                respostaEscolhida("C");
            }
        });

        bR4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                respostaEscolhida("D");
            }
        });

        /// esconde o butao proxima
        btnProxima.setVisibility(View.INVISIBLE);

        btnProxima.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mudarPergunta();
                // esconde o butao proxima
                btnProxima.setVisibility(View.INVISIBLE);
                // ativa os butoes de respostas
                ativarButoesDeResposta(true);
            }
        });
        limparCoresDosButoes();
    }


    private void respostaEscolhida(String respostaSelecionada) {
        limparCoresDosButoes();
        switch (respostaSelecionada) {
            case "A":
                bR1.setBackgroundColor(Color.BLUE);
                if (perguntaAtual.respostaCorreta.equals(bR1.getText().toString())) {
                    bR1.setBackgroundColor(Color.GREEN);
                    acertadas += 1;
                } else {
                    bR1.setBackgroundColor(Color.RED);
                    erradas += 1;
                }
                break;
            case "B":
                bR2.setBackgroundColor(Color.BLUE);
                if (perguntaAtual.respostaCorreta.equals(bR2.getText().toString())) {
                    bR2.setBackgroundColor(Color.GREEN);
                    acertadas += 1;

                } else {
                    bR2.setBackgroundColor(Color.RED);
                    erradas += 1;
                }
                break;
            case "C":
                bR3.setBackgroundColor(Color.BLUE);
                if (perguntaAtual.respostaCorreta.equals(bR3.getText().toString())) {
                    bR3.setBackgroundColor(Color.GREEN);
                    acertadas += 1;

                } else {
                    bR3.setBackgroundColor(Color.RED);
                    erradas += 1;
                }
                break;
            case "D":
                bR4.setBackgroundColor(Color.BLUE);
                if (perguntaAtual.respostaCorreta.equals(bR4.getText().toString())) {
                    bR4.setBackgroundColor(Color.GREEN);
                    acertadas += 1;
                } else {
                    bR4.setBackgroundColor(Color.RED);
                    erradas += 1;
                }
                break;
            default:
                System.out.println("Resposta Invalida");
        }
        ativarButoesDeResposta(false);
    }

    /// desativa os botoes de resposta e mostra o butao proxima
    private void ativarButoesDeResposta(boolean opcao) {
        bR1.setEnabled(opcao);
        bR2.setEnabled(opcao);
        bR3.setEnabled(opcao);
        bR4.setEnabled(opcao);
        btnProxima.setVisibility(!opcao ? View.VISIBLE : View.INVISIBLE);
    }

    /// limpa a cor dos botoes para o default
    private void limparCoresDosButoes() {
        bR1.setBackgroundColor(Color.LTGRAY);
        bR2.setBackgroundColor(Color.LTGRAY);
        bR3.setBackgroundColor(Color.LTGRAY);
        bR4.setBackgroundColor(Color.LTGRAY);
    }

    /// carrega a pergunta selecionada para a activity
    private void carregarPerguntaNaView() {
        TextView questao = findViewById(R.id.textviewPergunta);
        questao.setText(perguntaAtual.questao);
        Button a = (Button) findViewById(R.id.buttonRespostaA);
        a.setText(perguntaAtual.resposta1);
        Button b = (Button) findViewById(R.id.buttonRespostaB);
        b.setText(perguntaAtual.resposta2);
        Button c = (Button) findViewById(R.id.buttonRespostaC);
        c.setText(perguntaAtual.resposta3);
        Button d = (Button) findViewById(R.id.buttonRespostaD);
        d.setText(perguntaAtual.resposta4);
    }

    /// muda a pergunta para a proxima
    private void mudarPergunta() {
        /// incrementa para passar para a proxima pergunta
        indiceAtual += 1;
        /// caso o indice da pergunta seja 9 entao envia os resultados para a activity `Resultados`
        /// 9 porque o index comeca em 0
        if ((indiceAtual) == 9) { finalizar(); return;}
        /// muda a pergunta para o novo index
        perguntaAtual = perguntas.get(indiceAtual);
        carregarPerguntaNaView();
        limparCoresDosButoes();
    }

    private void finalizar() {
        Intent intent = new Intent(this, Resultado.class);
        intent.putExtra("totalErradas", erradas + "");
        intent.putExtra("totalCertas", acertadas + "");
        startActivity(intent);
    }

    /// Carrega as perguntas e guarda no local storage
    private void carregarPerguntas() {
        SharedPreferences sharedPreferences = getSharedPreferences("quizzy", MODE_PRIVATE);
        Gson gson = new Gson();
        String json = sharedPreferences.getString("perguntas", null);
        Type type = new TypeToken<ArrayList<Pergunta>>() {
        }.getType();
        perguntas = gson.fromJson(json, type);
        if (perguntas == null) {
            perguntas = new ArrayList<>();
            // adiciona 10 perguntas
            perguntas.add(new Pergunta("De quem é a famosa frase “Penso, logo existo”?", "Platão", "Galileu Galilei", "Descartes", "Sócrates", "Descartes"));
            perguntas.add(new Pergunta("De onde é a invenção do chuveiro elétrico?", "França", "Austrália", "Itália", "Brasil", "Brasil"));
            perguntas.add(new Pergunta("Quantas casas decimais tem o número pi?", "Duas", "Centenas", "Infinitas", "Milhares", "Infinitas"));
            perguntas.add(new Pergunta("Atualmente, quantos elementos químicos a tabela periódica possui?", "113", "109", "108", "265", "108"));
            perguntas.add(new Pergunta("O que a palavra legend significa em português?", "Legenda", "Conto", "Legendário", "Lenda", "Lenda"));
            perguntas.add(new Pergunta("Qual o número mínimo de jogadores numa partida de futebol?", "7", "12", "13", "15", "7"));
            perguntas.add(new Pergunta("Quanto tempo a luz do Sol demora para chegar à Terra?", "12 minutos", "1 dia", "segundos", "8 minutos", "8 minutos"));
            perguntas.add(new Pergunta("Qual a nacionalidade de Che Guevara?", "Cubana", "Peruana", "Panamenha", "Argentina", "Argentina"));
            perguntas.add(new Pergunta("Em que período da pré-história o fogo foi descoberto?", "Neolítico", "Paleolítico", "Idade Média", "Jurassico", "Paleolítico"));
            perguntas.add(new Pergunta("Em qual local da Ásia o português é língua oficial?", "Índia", "Filipinas", "Moçambique", "Macau", "Macau"));
        }
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className) {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}