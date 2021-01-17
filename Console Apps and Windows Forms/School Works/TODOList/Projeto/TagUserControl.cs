using System;
using System.ComponentModel;
using System.Windows.Forms;
using CamadaNegocio;

namespace Notas
{
    public partial class TagUserControl : UserControl
    {
        public TagUserControl()
        {
            InitializeComponent();
        }

        #region Propriedades

        private TagsEnum tag;

        [Category("Custom")]
        [Description("Adiciona um painel com as tags disponiveis")]
        public TagsEnum Tags
        {
            get
            {
                this.tag = TagsEnum.NaoDefinido;

                if (this.escolaCheckBox.Checked)
                {
                    this.tag |= TagsEnum.Escola;
                }
                if (this.comprasCheckBox.Checked)
                {
                    this.tag |= TagsEnum.Compras;
                }
                if (this.pagamentosCheckBox.Checked)
                {
                    this.tag |= TagsEnum.Pagamentos;
                }
                if (this.cartoesCheckBox.Checked)
                {
                    this.tag |= TagsEnum.Cartoes;
                }

                return tag;
            }
            set
            {
                this.tag = value;
                this.escolaCheckBox.Checked = ((this.tag & TagsEnum.Escola) == TagsEnum.Escola);
                this.comprasCheckBox.Checked = ((this.tag & TagsEnum.Compras) == TagsEnum.Compras);
                this.pagamentosCheckBox.Checked = ((this.tag & TagsEnum.Pagamentos) == TagsEnum.Pagamentos);
                this.cartoesCheckBox.Checked = ((this.tag & TagsEnum.Cartoes) == TagsEnum.Cartoes);

                if (this.tag == (TagsEnum.Escola | TagsEnum.Compras | TagsEnum.Pagamentos | TagsEnum.Cartoes))
                {
                    this.OnTodasAsOpcoes();
                }
            }
        }


        #endregion

        #region Eventos

        [Category("Custom")]
        [Description("Ocorre quando todas as tags forem selecionadas.")]
        public event EventHandler TodasAsOpcoes;

        public void OnTodasAsOpcoes()
        {
            if (this.TodasAsOpcoes != null)
            {
                this.TodasAsOpcoes(this, new EventArgs());
            }
        }

        private void tagCheckBox_Click(object sender, EventArgs e)
        {
            if (this.escolaCheckBox.Checked && this.comprasCheckBox.Checked && this.pagamentosCheckBox.Checked && this.cartoesCheckBox.Checked)
            {
                this.OnTodasAsOpcoes();
            }
        }

        #endregion

    }
}
