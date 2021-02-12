using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Euro2020
{
    public partial class FormEuro2020 : Form
    {
        public FormEuro2020()
        {
            InitializeComponent();
        }

        private void FormEuro2020_Load(object sender, EventArgs e)
        {
            textBoxnumeroestadio.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttoninserir_Click(object sender, EventArgs e)
        {
            //validar Dados

            if (textBoxnumeroestadio.Text == "" || textBoxnomeestadio.Text == "")
            {
                MessageBox.Show("Deve Introduzir o Numero e Nome de Estádio", "Euro 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return; //aborta execução
            }

            //Procurar se o numero de estadio existe na coleçõa
            bool flag = false;
            foreach (Classfuncoesglobais.registoEstadio itemestadio in Classfuncoesglobais.listaEstadios)
            {
                if (itemestadio.numeroestadio == int.Parse(textBoxnumeroestadio.Text))
                {
                    MessageBox.Show("Numero de Estadio já inserido", "Euro 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    //
                    //ou..return; //aborta execução
                }
            }

            if (flag == false) //estadio ainda não existe...
            {
                //se campos numericos estão vazios "" colocamos a zero
                if (textBoxcapacidade.Text == "") textBoxcapacidade.Text = "0";
                if (textBoxtotaljogos.Text == "") textBoxtotaljogos.Text = "0";
                if (textBoxtotalassistencias.Text == "") textBoxtotalassistencias.Text = "0";

                Random aleatorio = new Random();
                int valor = aleatorio.Next(1, 5); // nº aleatorio entre 1 e 4

                string estado = "";
                switch (valor)
                {
                    case 1:
                        estado = "Mau";
                        break;
                    case 2:
                        estado = "Razoavel";
                        break;
                    case 3:
                        estado = "Bom";
                        break;
                    case 4:
                        estado = "Muito Bom";
                        break;
                }

                //
                //1. Criar um objeto do tipo da estrutura
                //
                //Inserir novo registo na lista
                //Classfuncoesglobais.registoEstadio novoestadio = new Classfuncoesglobais.registoEstadio();
                //novoestadio.numeroestadio = int.Parse(textBoxnumeroestadio.Text);
                //novoestadio.nomeestadio = textBoxnomeestadio.Text;
                //novoestadio.nomepais = textBoxpais.Text;
                //novoestadio.nomecidade = textBoxcidade.Text;
                //novoestadio.capacidade = int.Parse(textBoxcapacidade.Text);
                //novoestadio.totaljogos = int.Parse(textBoxtotaljogos.Text);
                //novoestadio.totalassistencia = int.Parse(textBoxtotaljogos.Text);
                //novoestadio.campoestado = textBoxnomeestadio.Text;

                // ou
                Classfuncoesglobais.registoEstadio novoestadio = new Classfuncoesglobais.registoEstadio
                {
                    numeroestadio = int.Parse(textBoxnumeroestadio.Text),
                    nomeestadio = textBoxnomeestadio.Text,
                    nomepais = textBoxpais.Text,
                    nomecidade = textBoxcidade.Text,
                    capacidade = int.Parse(textBoxcapacidade.Text),
                    totaljogos = int.Parse(textBoxtotaljogos.Text),
                    totalassistencia = int.Parse(textBoxtotalassistencias.Text),
                    campoestado = estado
                };

                //
                //2. inserir o registo (novoestadio) na coleção de dados (listaEstadios)
                // 
                Classfuncoesglobais.listaEstadios.Add(novoestadio);

                PreencheGrid();

                LimpaCampos();

                textBoxnumeroestadio.Focus();

            }// if EstadioExiste

        }// buttoninserir_Click


        private void buttonlimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }


        private void textBoxnumeroestadio_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxnumeroestadio.Text, out int resultado) == false)
            {

                textBoxnumeroestadio.Text = "";
            }
        }

        private void textBoxnumeroestadio_Leave(object sender, EventArgs e)
        {

            if (textBoxnumeroestadio.Text == "")
            {
                return; //aborta
            }


            //Procurar se o numero de estadio existe na coleção
            //Percorrer toda a coleção listaEstadios
            bool flag = false;
            foreach (Classfuncoesglobais.registoEstadio itemestadio in Classfuncoesglobais.listaEstadios)
            {
                if (itemestadio.numeroestadio == int.Parse(textBoxnumeroestadio.Text))
                {
                    textBoxnomeestadio.Text = itemestadio.nomeestadio;
                    textBoxpais.Text = itemestadio.nomepais;
                    textBoxcidade.Text = itemestadio.nomecidade;
                    textBoxcapacidade.Text = itemestadio.capacidade.ToString();
                    textBoxtotaljogos.Text = itemestadio.totaljogos.ToString();
                    textBoxtotalassistencias.Text = itemestadio.totalassistencia.ToString();
                    buttonalterar.Enabled = true;
                    buttoneliminar.Enabled = true;
                    buttoninserir.Enabled = false;
                    flag = true;
                }
            }

            if (flag == false)
            {
                string numero = textBoxnumeroestadio.Text;

                LimpaCampos();

                textBoxnumeroestadio.Text = numero;
            }


        }

        //
        // FUNÇÔES 
        //
        void LimpaCampos()
        {
            //textBoxnumeroestadio.Clear();
            //textBoxnomeestadio.Clear();
            //textBoxpais.Clear();
            //textBoxcidade.Clear();
            //textBoxcapacidade.Clear();
            //textBoxtotaljogos.Clear();
            //textBoxtotalassistencias.Clear();
            //textBoxnumeroestadio.Focus();
            //ou...

            //percorre todos os controlos (objetos, labels, textbox, list, grid, etc..) no form
            foreach (Control ObjNoForm in Controls)
            {
                if (ObjNoForm is TextBox)
                {
                    ObjNoForm.Text = "";
                }
            }

            buttonalterar.Enabled = false;
            buttoneliminar.Enabled = false;
            buttoninserir.Enabled = true;

        }// LimpaCampos

        void PreencheGrid()
        {
            dataGridViewDados.Rows.Clear();
            //percorrer toda a listaEstadios e colocar os registos na DataGridView
            //foreach (Classfuncoesglobais.registoEstadio itemestadio in Classfuncoesglobais.listaEstadios)
            int linha = 0;
            foreach (var itemEstadios in Classfuncoesglobais.listaEstadios)
            {
                //MessageBox.Show(itemEstadios.nomeestadio);
                dataGridViewDados.Rows.Add();
                dataGridViewDados.Rows[linha].Cells[0].Value = itemEstadios.numeroestadio;
                dataGridViewDados.Rows[linha].Cells[1].Value = itemEstadios.nomeestadio;
                dataGridViewDados.Rows[linha].Cells[2].Value = itemEstadios.nomepais;
                dataGridViewDados.Rows[linha].Cells[3].Value = itemEstadios.nomecidade;
                dataGridViewDados.Rows[linha].Cells[4].Value = itemEstadios.capacidade;
                dataGridViewDados.Rows[linha].Cells[5].Value = itemEstadios.totaljogos;
                dataGridViewDados.Rows[linha].Cells[6].Value = itemEstadios.totalassistencia;
                dataGridViewDados.Rows[linha].Cells[7].Value = itemEstadios.campoestado;

                linha++; //linha = linha + 1;
            }

        }// PreencheGrid


        private void buttonsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {

            Classfuncoesglobais.registoEstadio RegistoParaRemover = new Classfuncoesglobais.registoEstadio();

            //encontrar o registo do estadio
            foreach (var itemEstadio in Classfuncoesglobais.listaEstadios)
            {

                if (itemEstadio.numeroestadio == int.Parse(textBoxnumeroestadio.Text))
                {
                    //encontrou o registo
                    RegistoParaRemover = itemEstadio;
                    break; //termina ciclo
                }

            }

            //remover registo
            Classfuncoesglobais.listaEstadios.Remove(RegistoParaRemover);

            PreencheGrid();
            LimpaCampos();

            textBoxnumeroestadio.Focus();

        }

        private void buttonalterar_Click(object sender, EventArgs e)
        {
            Classfuncoesglobais.registoEstadio RegistoParaAlterar = new Classfuncoesglobais.registoEstadio();
            // encontrar o registo do estadio
            for (int i = 0; i < Classfuncoesglobais.listaEstadios.Count; i++)
            {
                RegistoParaAlterar = Classfuncoesglobais.listaEstadios[i];

                if (RegistoParaAlterar.numeroestadio == int.Parse(textBoxnumeroestadio.Text))
                {
                    //encontrou o registo
                    //Alterar os campos de acordo com o textboxs
                    RegistoParaAlterar.nomeestadio = textBoxnomeestadio.Text;
                    RegistoParaAlterar.nomecidade = textBoxcidade.Text;
                    RegistoParaAlterar.nomepais = textBoxpais.Text;
                    RegistoParaAlterar.capacidade = int.Parse(textBoxcapacidade.Text);
                    RegistoParaAlterar.totalassistencia = int.Parse(textBoxtotalassistencias.Text);
                    RegistoParaAlterar.totaljogos = int.Parse(textBoxtotaljogos.Text);
                    
                    //Atualizar as listaEstadios
                    Classfuncoesglobais.listaEstadios[i] = RegistoParaAlterar;

                    break; //termina ciclo
                }
            }

            PreencheGrid();
            LimpaCampos();

            textBoxnumeroestadio.Focus();


        }
    }// Form
}// namespace

