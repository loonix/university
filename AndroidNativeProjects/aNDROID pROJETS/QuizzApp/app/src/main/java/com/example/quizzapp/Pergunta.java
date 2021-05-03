package com.example.quizzapp;

import java.util.UUID;

public class Pergunta {
    public String id;
    public String questao;
    public String resposta1;
    public String resposta2;
    public String resposta3;
    public String resposta4;
    public String respostaCorreta;

    public Pergunta( String questao, String resposta1, String resposta2, String resposta3, String resposta4, String respostaCorreta) {
        this.id = UUID.randomUUID().toString();
        this.questao = questao;
        this.resposta1 = resposta1;
        this.resposta2 = resposta2;
        this.resposta3 = resposta3;
        this.resposta4 = resposta4;
        this.respostaCorreta = respostaCorreta;
    }
}
