package com.example.quizzapp;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class Resultado extends AppCompatActivity {
//    TextView erradas;
//    TextView certas;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado);
        System.out.println("resultado - Iniciou");

        Bundle b = getIntent().getExtras();
        int totalErradas =  b.getInt("totalErradas");
        int totalCertas = b.getInt("totalCertas");

        TextView erradas =  (TextView) findViewById(R.id.textViewperguntasErradas);
        TextView certas = (TextView) findViewById(R.id.textViewCertas);

        erradas.setText(totalErradas.getText().toString());
        certas.setText(totalCertas.getText().toString());

    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className)
    {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}