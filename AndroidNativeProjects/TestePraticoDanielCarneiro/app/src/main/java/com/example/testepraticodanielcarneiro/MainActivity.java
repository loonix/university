package com.example.testepraticodanielcarneiro;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    public TextView txtNome;
    public Button registoBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtNome = (TextView) findViewById(R.id.txtNome);
        registoBtn = (Button) findViewById(R.id.btnRegisto);

        registoBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                accessScreen( ActivityB.class, txtNome.getText().toString());
            }
        });
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className, String text) {
        Intent intent = new Intent(this, className);
        intent.putExtra("nome", text);
        startActivity(intent);
    }
}