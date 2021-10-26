package com.example.testepraticodanielcarneiro;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.RadioGroup;
import android.widget.TextView;

public class ActivityB extends AppCompatActivity {
    public Button okBtn;
    public TextView txtMsg1;
    public RadioGroup radioGroup;
    public ImageView image;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_b);
        radioGroup = findViewById(R.id.radioGroup);
        image = findViewById(R.id.imageView2);
        txtMsg1 = findViewById(R.id.txtMsg1);
        image.setVisibility(View.INVISIBLE);

        String texto = getIntent().getStringExtra("nome");
        txtMsg1.setText("Ola " + texto.toString());

        radioGroup.setOnCheckedChangeListener(new
        RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                switch (checkedId){
                    case R.id.rdbslb:
                        image.setImageResource(R.drawable.slb);
                        image.setVisibility(View.VISIBLE);
                        break;
                    case R.id.rdbfcp:
                        image.setImageResource(R.drawable.fcp);
                        image.setVisibility(View.VISIBLE);
                        break;
                    case R.id.rdbscp:
                        image.setImageResource(R.drawable.scp);
                        image.setVisibility(View.VISIBLE);
                        break;
                    default:
                        break;
                }
            }
        });

        okBtn = (Button) findViewById(R.id.btnOK);

        okBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                accessScreen(MainActivity.class);
            }
        });
    }

    /// acede a activity passada na [className]
    private void accessScreen(Class className) {
        Intent intent = new Intent(this, className);
        startActivity(intent);
    }
}