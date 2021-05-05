package com.example.quizzapp;

import java.util.UUID;

public class Utilizador {
        public String id;
        public String utilizador;
        public String password;
        public String email;
        public int pontuacao;

        public Utilizador( String utilizador, String password, String email, int pontuacao) {
            this.id = UUID.randomUUID().toString();
            this.utilizador = utilizador;
            this.password = password;
            this.email = email;
            this.pontuacao = pontuacao;
        }

        public int compareTo(Utilizador user)
        {
            return(pontuacao - user.pontuacao);
        }
}
