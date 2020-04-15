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
    public partial class FormPresidentes : Form
    {
        public FormPresidentes()
        {
            InitializeComponent();
        }

        private void FormPresidentes_Load(object sender, EventArgs e)
        {

            //preencher os anos de 1789-até ao ano atual + 4
            for (int ano = 1789; ano <= DateTime.Today.Year + 4; ano++)
            {
                comboBoxAnoInicio.Items.Add(ano);
                comboBoxAnoFim.Items.Add(ano);
            }

        }

        private void buttonAdiciona_Click(object sender, EventArgs e)
        {

            //1º
            //Criar um novo registo do tipo RegistoUSA
            ClassFuncoesGlobais.RegistoUSA novoRegisto = new ClassFuncoesGlobais.RegistoUSA
            {
                //preencher os campos
                nome = textBoxNome.Text,
                anoInicio = int.Parse(comboBoxAnoInicio.Text),
                anoFim = int.Parse(comboBoxAnoFim.Text),
                partido = comboBoxPartido.Text
            };

            //ou..
            //ClassFuncoesGlobais.RegistoUSA novoRegisto = new ClassFuncoesGlobais.RegistoUSA();
            //preencher os campos
            //novoRegisto.nome = textBoxNome.Text;
            //novoRegisto.anoInicio = int.Parse(comboBoxAnoInicio.Text);
            //novoRegisto.anoFim = int.Parse(comboBoxAnoFim.Text);
            //novoRegisto.partido = comboBoxPartido.Text;


            //2º
            //adicionar registo à list
            ClassFuncoesGlobais.listPresidentes.Add(novoRegisto);


            //limpar controlos
            textBoxNome.Clear();
            comboBoxAnoInicio.SelectedIndex = -1; //retirar qq seleção
            comboBoxAnoFim.SelectedIndex = -1;
            comboBoxPartido.SelectedIndex = -1;

            textBoxNome.Focus();
                                 
        }

        private void buttonGuardarFicheiro_Click(object sender, EventArgs e)
        {

            SaveFileDialog janelaGuardar = new SaveFileDialog();

            janelaGuardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            janelaGuardar.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";


            if (janelaGuardar.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = janelaGuardar.FileName;

                StreamWriter FicheiroEscrita = new StreamWriter(FileName);
                FicheiroEscrita.WriteLine("Presidente, Ano inicio, Ano fim, Partido");
                for (int i = 0; i < ClassFuncoesGlobais.listPresidentes.Count; i++)
                {
                    //criar um novoregisto do tipo da struct RegistoUSA
                    ClassFuncoesGlobais.RegistoUSA novoRegisto = new ClassFuncoesGlobais.RegistoUSA();
                    novoRegisto = (ClassFuncoesGlobais.RegistoUSA)ClassFuncoesGlobais.listPresidentes[i];
                    FicheiroEscrita.WriteLine(novoRegisto.nome + ", " +
                    novoRegisto.anoInicio + ", " + novoRegisto.anoFim + ", " + novoRegisto.partido);
                }
                FicheiroEscrita.Close();
            }
        }

        private void buttonAbrirFicheiro_Click(object sender, EventArgs e)
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
            }
        }

        private void buttonVisualiza_Click(object sender, EventArgs e)
        {

            FormVisualiza novoForm = new FormVisualiza();
            novoForm.MdiParent = this.MdiParent;
            novoForm.Show();

        }
    }
}
