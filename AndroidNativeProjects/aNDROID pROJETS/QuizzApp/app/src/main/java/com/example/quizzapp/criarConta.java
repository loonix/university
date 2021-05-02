package com.example.quizzapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;

public class criarConta extends AppCompatActivity {
    ArrayList<Utilizador> utilizadores;
    EditText nome;
    EditText email;
    EditText password;
    EditText confirmarPassword;
    Button registarBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_criar_conta);
        System.out.println("criarConta - Iniciou");

        carregarDados();

        nome = findViewById(R.id.utilizadorText);
        email = findViewById(R.id.emailText);
        password = findViewById(R.id.passwordText);
        confirmarPassword = findViewById(R.id.confirmPasswordText);

        registarBtn = (Button) findViewById(R.id.buttonRegistar);
        registarBtn.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
//                System.out.println(username.getText());
                nome = findViewById(R.id.utilizadorText);
                email = findViewById(R.id.emailText);

                if(!confirmarPassword.getText().toString().equals(password.getText().toString())){
                    Toast.makeText(criarConta.this, "As passwords nao combinam", Toast.LENGTH_SHORT).show();
                    return;
                }
                if(podeAdicionar()){
                    adicionarUser();
                } else {
                    // mostrar toast
                    Toast.makeText(criarConta.this, "O utilizador ou email ja existe, por favor verifique novamente.", Toast.LENGTH_SHORT).show();
                }

            }
        });
    }

    // verifica se pode adicionar a nova conta
    private boolean podeAdicionar() {
        for (Utilizador user : utilizadores) {
            // no caso do utilizador e email corresponderem
            if (user.utilizador.equals(nome.getText().toString()) && user.email.equals(email.getText().toString())) {
                return false;
            }
        }
        // no caso do utilizador e email nao corresponderem
        return true;
    }

    private void accessScreen(Class className)
    {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }

    private void adicionarUser() {
        SharedPreferences sharedPreferences = getSharedPreferences("quizzy", MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        String usernameTxt = nome.getText().toString();
        String passwordTxt = email.getText().toString();
        String emailTxt = password.getText().toString();

        utilizadores.add(new Utilizador(usernameTxt,passwordTxt,emailTxt,0));
        Gson gson = new Gson();
        String json = gson.toJson(utilizadores);
        editor.putString("utilizadores", json);
        editor.apply();
        accessScreen(MainActivity.class);
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
            utilizadores.add(new Utilizador("admin","admin","admin@quiz.com",560));
        }
    }
}