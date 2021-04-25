package com.danbru.quizzy;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

public class Login extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        SharedPreferences pref = getApplicationContext().getSharedPreferences("MyPref", 0); // 0 - for private mode
        SharedPreferences.Editor editor = pref.edit();
        editor.putString("username", "admin");
        editor.putString("password", "pass");

        String user = pref.getString("username", "");
        String pass = pref.getString("password", "");
        Log.e("USERNAME", user);
        Log.e("PASSWORD", pass);
        editor.apply(); // commit changes

        class Utilizador {
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


//          SharedPreferences.Editor editor = pref.edit();

        ArrayList<Utilizador> utilizador = new ArrayList<Utilizador>();
        utilizador.add(new Utilizador("admin","admin","admin@quiz.com","560"));
        Gson gson = new Gson();
        String json = gson.toJson(utilizador);
        editor.putString("login", json);
        editor.commit();


            List<Utilizador> arrayItems;
            String serializedObject = pref.getString("login", null);
            if (serializedObject != null) {
                Gson gson1 = new Gson();
                Type type = new TypeToken<List<Utilizador>>(){}.getType();
                arrayItems = gson1.fromJson(serializedObject, type);
                System.out.println(arrayItems);
            }


//        ArrayList<Utilizador> utilizador = new ArrayList<Utilizador>();
//        utilizador.add(new Utilizador("admin","admin","admin@quiz.com","560"));

//
//        JSONArray jsArray = new JSONArray(utilizador);
//
//        System.out.println(jsArray);


//        JsonArray jsonArray1 = new Gson().toJsonTree(strArray).getAsJsonArray();


//        Gson gson = new Gson();
//        String json = gson.toJson(utilizador);
//
//
//        Log.e("JSARRAY", json);
//
//        class User {
//            String name;
//            int age;
//            public User(String name, int age) {
//                this.name = name;
//                this.age = age;
//            }
//        }

//        String json="{'login':[{'id':'1','utilizador':'admin','password':'admin'}]}";

        JSONObject jsonResponse;
        try {
            ArrayList<String> temp = new ArrayList<String>();
            jsonResponse = new JSONObject(json);
            JSONArray movies = jsonResponse.getJSONArray("login");
            Toast.makeText(this, "Json: "+temp, Toast.LENGTH_LONG).show();
        } catch (JSONException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }

//        String json="{'login':[{'id':'1','utilizador':'admin','password':['JackPrescott']}]}";
//
//        try {
//            ArrayList<String> temp = new ArrayList<String>();
//            jsonResponse = new JSONObject(json);
//            JSONArray movies = jsonResponse.getJSONArray("login");
//            for(int i=0;i<movies.length();i++){
//                JSONObject movie = movies.getJSONObject(i);
//                JSONArray characters = movie.getJSONArray("characters");
//                for(int j=0;j<characters.length();j++){
//                    temp.add(characters.getString(j));
//                }
//            }
//            Toast.makeText(this, "Json: "+temp, Toast.LENGTH_LONG).show();
//        } catch (JSONException e) {
//            // TODO Auto-generated catch block
//            e.printStackTrace();
//        }

    }

    void login() {
        EditText username;
        EditText password;
        Button login;

//        username = findViewById(R.id.username);
//        password = findViewById(R.id.password);
//
//        if (username == null) {
//            mensagemToast("Introduza o utilizador");
//            return;
//        }
//        if (password == null) {
//            mensagemToast("Introduza a password");
//            return;
//        }
    }

    void mensagemToast(String mensagem) {
        Toast t = Toast.makeText(this, mensagem, Toast.LENGTH_SHORT);
        t.show();
    }
}