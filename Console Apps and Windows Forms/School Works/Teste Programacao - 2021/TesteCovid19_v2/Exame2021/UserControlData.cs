using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exame2019
{
    public partial class UserControlData : UserControl
    {
        public UserControlData()
        {
            InitializeComponent();
        }

        #region Propriedades
        private string texto1;

        [Category("Custom")]
        [Description("texto1")]
        public string Texto1
        {
            get
            {
                this.texto1 = texto1Label.Text;
                return texto1;
            }
            set { this.texto1 = value; }
        }
        private string texto2;

        [Category("Custom")]
        [Description("texto2")]
        public string Texto2
        {
            get
            {
                this.texto2 = texto1Label.Text;
                return texto2;
            }
            set { this.texto1 = value; }
        }

        #endregion
        #region Metodos
        public string ObterInformacao()
        {
            return Texto1 + "," + Texto2;
        }
        #endregion

        #region Eventos
        public void AcaoDuploClick(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
