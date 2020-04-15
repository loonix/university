using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_USA
{
    public partial class FormVisualiza : Form
    {
        public FormVisualiza()
        {
            InitializeComponent();
        }

        private void FormVisualiza_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }


        private void buttonAtualiza_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        void CarregaDados()
        {

            dataGridViewDados.Rows.Clear();

            int linha = 0;
            //percorrer toda a lista listPresidentes e colocar na Grid
            foreach (ClassFuncoesGlobais.RegistoUSA itemRegisdo in ClassFuncoesGlobais.listPresidentes)
            {
                //adicicionar uma nova linha à Grid
                dataGridViewDados.Rows.Add();

                dataGridViewDados.Rows[linha].Cells[0].Value = itemRegisdo.nome;
                dataGridViewDados.Rows[linha].Cells[1].Value = itemRegisdo.anoInicio;
                dataGridViewDados.Rows[linha].Cells[2].Value = itemRegisdo.anoFim;
                dataGridViewDados.Rows[linha].Cells[3].Value = itemRegisdo.partido;

                linha++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog janelaAbrir = new OpenFileDialog();
            janelaAbrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            janelaAbrir.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (janelaAbrir.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = janelaAbrir.FileName;
                StreamReader FicheiroLeitura = new StreamReader(FileName);

                //como a primeira linha é titulo
                FicheiroLeitura.ReadLine(); //avança a 1º linha
                string linha;

                //ler ate ao final do ficheiro
                while (!FicheiroLeitura.EndOfStream)
                {
                    linha = FicheiroLeitura.ReadLine();
                    //separar a linha atraves da virgula e colocar cada campo num vetor
                    string[] campos = linha.Split(',');

                    //criar um novoregisto do tipo da struct RegistoUSA
                    ClassFuncoesGlobais.RegistoUSA novoRegisto = new ClassFuncoesGlobais.RegistoUSA();
                    //atribuir valores aos campos
                    novoRegisto.nome = campos[0]; ;
                    novoRegisto.anoInicio = int.Parse(campos[1]);
                    novoRegisto.anoFim = int.Parse(campos[2]);
                    novoRegisto.partido = campos[3];
                    //adicionar o registo a List
                    ClassFuncoesGlobais.listPresidentes.Add(novoRegisto);
                }

                CarregaDados();
            
        }
        }
    }
    
}
