package professor.marcomaddo.appbancodedadosmeusclientes.view;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;

import java.util.List;

import professor.marcomaddo.appbancodedadosmeusclientes.controller.ClienteORMController;
import professor.marcomaddo.appbancodedadosmeusclientes.database.AppDataBase;
import professor.marcomaddo.appbancodedadosmeusclientes.model.Cliente;
import professor.marcomaddo.appbancodedadosmeusclientes.R;
import professor.marcomaddo.appbancodedadosmeusclientes.model.ClienteORM;

public class MainActivity extends AppCompatActivity {

    ClienteORMController clienteORMController;

    List<ClienteORM> listaDeClientes;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        clienteORMController = new ClienteORMController();

      /*  ClienteORM orm;

        for (int i = 2; i < 35; i++) {

            orm = new ClienteORM();

            orm.setId(i);
            orm.setNome("Nome Cliente "+i);
            orm.setIdade(2*i);
            orm.setPreco(100*i);
            orm.setSalario(25*i);
            orm.setDataCadastro("20/01/2021");
            orm.setHoraCadastro("20:20");
            orm.setAtivo(true);

            clienteORMController.insert(orm);


        }*/


        listaDeClientes = clienteORMController.listar();

        for (ClienteORM obj : listaDeClientes) {

            Log.d("db_log", "onCreate: " + obj.getId() + " " + obj.getNome());

        }


    }
}