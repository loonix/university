using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Arraylist
{
    public partial class Form1 : Form
    {

        struct Registo
        {
            public int numero;
            public string nome;
            public double nota;
        }

        Registo[] VecEstudantes = new Registo[0]; // Array sem dimensao

        // Declaracao de um arraylist
        ArrayList arraylistEstudantes = new ArrayList(); // Exemplo arraylist

        // Declaracao de um list do tipo da estrutura
        List<Registo> listEstudantes = new List<Registo>();
        private IEnumerable<object> registoEstudante;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adicionaRegBtn_Click(object sender, EventArgs e)
        {
            bool temErro = false;
            if (textBoxNumero.Text == "")
            {
                labelErro1.Visible = true;
                temErro = true;
            }
            if (textBoxNome.Text == "")
            {
                labelErro2.Visible = true;
                temErro = true;
            }
            if (textBoxNota.Text == "")
            {
                labelErro3.Visible = true;
                temErro = true;
            }

            if (!temErro)
            {
                // Criar registo e preencher os campos com os valores do textBox
                //Registo registoEstudante = new Registo();
                //registoEstudante.numero = int.Parse(textBoxNumero.Text);
                //registoEstudante.nome = textBoxNome.Text;
                //registoEstudante.nota = int.Parse(textBoxNota.Text);

                Registo registoEstudante = new Registo
                {
                    numero = int.Parse(textBoxNumero.Text),
                    nome = textBoxNome.Text,
                    nota = int.Parse(textBoxNota.Text)
                };

                // Adicionar o registo a colecao de dados (ArrayList e List)
                arraylistEstudantes.Add(registoEstudante);
                listEstudantes.Add(registoEstudante);

                textBoxNumero.Clear();
                textBoxNome.Clear();
                textBoxNota.Clear();
                textBoxNumero.Focus();
                labelErro1.Visible = false;
                labelErro2.Visible = false;
                labelErro3.Visible = false;

            }
        }

        private void atualizaListaBtn_Click(object sender, EventArgs e)
        {
            foreach (Registo reg in arraylistEstudantes)
            {
                string item = reg.numero + " - " + reg.nome + " - " + reg.nota;
                if (!(estudanteArrayList.Items.Contains(item)))
                {
                    estudanteArrayList.Items.Add(item);

                }
            }
        }
    }
}
