package com.example.mysecondapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private Button btnConfirmar;
    private Button btnLimpar;
    private EditText edit_message;
    private TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnLimpar = findViewById(R.id.btnLimpar );
        btnConfirmar = findViewById(R.id.btnConfirmar );
        edit_message = findViewById(R.id.edit_message );
        textView = findViewById(R.id.textView );


     btnLimpar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            edit_message.setText("");
            //edit_message.setText(getText(R.string.edit_message));
            edit_message.setHint(R.string.edit_message);

        }
      });
     btnConfirmar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {

            textView.setText(edit_message.getText());
       }
     });

    }
}