package com.example.mythirdapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private RadioGroup rgGender;
    private ImageView imgFemale, imgMale;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        imgFemale = findViewById(R.id.imgFemale);
        imgMale = findViewById(R.id.imgMale);
        rgGender = findViewById(R.id.rdbGender);
        rgGender.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {

                switch (checkedId) {
                    case R.id.rbtFemale:

                        imgFemale.setVisibility(View.VISIBLE);

                        imgMale.setVisibility(View.INVISIBLE);

                        Toast.makeText(MainActivity.this, "Female", Toast.LENGTH_LONG).show();
                        break;

                    case R.id.rdbMale:
                        imgFemale.setVisibility(View.INVISIBLE);
                        imgMale.setVisibility(View.VISIBLE);
                        Toast.makeText(MainActivity.this, "Male", Toast.LENGTH_LONG).show();
                        break;
                    default:
                        break;

                }

            }
        });
    }


    public void onRegisterBtnClick(View view) {
        EditText edtTxtFirstName = findViewById(R.id.edtTxtFirstName);
        EditText edtTxtLastName = findViewById(R.id.edtTxtLastName);
        EditText edtTxtEmail = findViewById(R.id.edtTxteMail);

        TextView txtFirstName = findViewById(R.id.txtFirstName);
        TextView txtLastName = findViewById(R.id.txtLastName);
        TextView txtEmail = findViewById(R.id.txtEmail);

        txtFirstName.setText("First Name: " + edtTxtFirstName.getText());
        txtLastName.setText("Last Name: " + edtTxtLastName.getText());
        txtEmail.setText("Email: " + edtTxtEmail.getText());


    }

    public void onClearBtnClick(View view) {
        EditText edtTxtFirstName = findViewById(R.id.edtTxtFirstName);
        EditText edtTxtLastName = findViewById(R.id.edtTxtLastName);
        EditText edtTxtEmail = findViewById(R.id.edtTxteMail);

        TextView txtFirstName = findViewById(R.id.txtFirstName);
        TextView txtLastName = findViewById(R.id.txtLastName);
        TextView txtEmail = findViewById(R.id.txtEmail);

        edtTxtFirstName.setText("");
        edtTxtFirstName.setHint(R.string.edtTxtFirstName);
        edtTxtLastName.setText("");
        edtTxtLastName.setHint(R.string.edtTxtLastName);
        edtTxtEmail.setText("");
        edtTxtEmail.setHint(R.string.edtTxtEmail);

        txtFirstName.setText("");
        txtFirstName.setHint(R.string.txtFirstName);
        txtLastName.setText("");
        txtLastName.setHint(R.string.txtLastName);
        txtEmail.setText("");
        txtEmail.setHint(R.string.txtEmail);


    }
}

