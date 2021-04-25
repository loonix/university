package com.example.quizzapp;

import java.util.UUID;

public class Utilizador {
        private String id;
        private String utilizador;
        private String password;
        private  String email;
        private  String pontuacao;

        public Utilizador( String utilizador, String password, String email, String pontuacao) {
            this.id = UUID.randomUUID().toString();
            this.utilizador = utilizador;
            this.password = password;
            this.email = email;
            this.pontuacao = pontuacao;
        }
}
