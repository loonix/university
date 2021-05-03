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

public class Login extends AppCompatActivity {
    ArrayList<Utilizador> utilizadores;
    Button obtbCriaRegisto;
    Button obtbEntrar;
    EditText username;
    EditText password;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        System.out.println("Registo - Iniciou");

        carregarDados();
        obtbCriaRegisto = (Button) findViewById(R.id.buttonRegistar);
        obtbEntrar = (Button) findViewById(R.id.buttonLogin);

        obtbEntrar = (Button)findViewById(R.id.buttonLogin);
        obtbEntrar.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                username = findViewById(R.id.utilizadorText);
                password = findViewById(R.id.passwordText);
                if(podeFazerLogin()){
                    accessScreen(Main.class);
                } else {
                    // mostrar toast
                    Toast.makeText(Login.this, "Utilizador ou password erradas, por favor verifique novamente.", Toast.LENGTH_SHORT).show();
                }

            }
        });

        obtbCriaRegisto = (Button)findViewById(R.id.buttonRegistar);
        obtbCriaRegisto.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                accessScreen(Registar.class);
            }
        });
    }

    // verifica se pode fazer o login c
    private boolean podeFazerLogin() {
        for (Utilizador user : utilizadores) {
            // no caso do utilizador e password corresponderem
            if (user.utilizador.equals(username.getText().toString()) && user.password.equals(password.getText().toString())) {
                return true;
            }
        }
        // no caso do utilizador e password nao corresponderem
        return false;
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

    public void onbuttonRegistarClick(View view) {
        if (view.getId() == R.id.buttonRegistar) {
            accessScreen(Registar.class);
        } else if (view.getId() == R.id.buttonLogin) {
            accessScreen(Perguntas.class);

        }
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className)
    {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}
