using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Notas
{
    public partial class FormAdicionarNota : Form
    {
       Nota _notaAEditar = new Nota();
        public FormAdicionarNota(Nota notaAEditar = null)
        {
            InitializeComponent();
            _notaAEditar = notaAEditar;
        }

        #region Metodos
        private void carregarValores(Nota notaAEditar)
        {
            this.Text = "Editar Nota";
            this.adicionarBtn.Text = "Editar";

            this.idTextBox.Text = notaAEditar.IDNota.ToString();
            this.tituloTextBox.Text = notaAEditar.Titulo;
            this.expiraEmDatePicker.Value = notaAEditar.DataExpiracao;
            this.conteudoRichTextBox.Text = notaAEditar.Conteudo;
            this.destaqueCheckBox.Checked = notaAEditar.Destaque;
            this.tagUserControl1.Tags = notaAEditar.Tags;
        }

        private bool Gravar()
        {
            string erro = string.Empty;

            if (this.DadosValidos())
            {
                Nota nota = this.ObterNota();

                bool ok = nota.Gravar(out erro);

                if (ok)
                {
                    MessageBox.Show(Properties.Resources.MESSAGE_GRAVADO_COM_SUCESSO);
                    return true;
                }
                else
                {
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_ERRO_A_GRAVAR, erro));
                }
            }
            return false;
        }

        private bool DadosValidos()
        {
            bool ok = true;
     
            string idNota = this.idTextBox.Text;
            string titulo = this.tituloTextBox.Text;
            DateTime dataCriacao = this.dataCriacaoDatePicker.Value;
            DateTime dataExpiracao = this.expiraEmDatePicker.Value;
            string conteudo = this.conteudoRichTextBox.Text;
            TagsEnum tags = this.tagUserControl1.Tags;
            bool destaque = this.destaqueCheckBox.Checked;

            this.notaErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(titulo))
            {
                this.notaErrorProvider.SetError(this.tituloTextBox, Properties.Resources.MESSAGE_TITULO_INVALIDO);
                ok = false;
            }
            if (dataCriacao > dataExpiracao)
            {
                this.notaErrorProvider.SetError(this.expiraEmDatePicker, Properties.Resources.MESSAGE_DATA_EXPIRACAO_INFERIOR_DATACRIACAO);
                this.expiraEmDatePicker.Focus();
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(conteudo))
            {
                this.notaErrorProvider.SetError(this.conteudoRichTextBox, Properties.Resources.MESSAGE_CONTEUDO_INVALIDO);
                ok = false;
            }

            return ok;
        }

        private Nota ObterNota()
        {
            Nota nota = new Nota();

            nota.IDNota = this.idTextBox.Text;
            nota.Titulo = this.tituloTextBox.Text;
            nota.DataCriacao = this.dataCriacaoDatePicker.Value;
            nota.DataExpiracao = this.expiraEmDatePicker.Value;
            nota.Conteudo = this.conteudoRichTextBox.Text;
            nota.Tags = this.tagUserControl1.Tags;
            nota.Destaque = this.destaqueCheckBox.Checked;

            return nota;
        }

        private void MostrarNota(Nota nota)
        {
            if (nota == null) return;

            this.idTextBox.Text = nota.IDNota;
            this.tituloTextBox.Text = nota.Titulo;
            this.dataCriacaoDatePicker.Value = nota.DataCriacao;
            this.expiraEmDatePicker.Value = nota.DataExpiracao;
            this.conteudoRichTextBox.Text = nota.Conteudo;
            this.tagUserControl1.Tags = nota.Tags;
            this.destaqueCheckBox.Checked = nota.Destaque;
        }


        private void Limpar()
        {
            Nota nota = new Nota();
            nota.Nova();
            this.MostrarNota(nota);
        }

        private void AbrirGerirNotas()
        {
            using (GerirNotas gerirNotasForm = new GerirNotas())
            {
                gerirNotasForm.ShowDialog();
            }
            this.Close();

        }


        #endregion

        #region Eventos
        private void FormAdicionarNota_Load(object sender, EventArgs e)
        {
            this.Limpar();
            if (_notaAEditar != null) carregarValores(_notaAEditar);
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            var gravado = this.Gravar();
            if (gravado)
            {
                // atualiza a datagrid do form principal
                FormMain formMain = (FormMain)Application.OpenForms["FormMain"];
                formMain.CarregarGrelha();

                // atualiza a datagrid do form gerir notas
                GerirNotas gerirNotasForm = (GerirNotas)Application.OpenForms["GerirNotas"];
                gerirNotasForm.CarregarGrelha();
            }
            this.Close();
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
