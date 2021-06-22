
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Cartao
    {
        public Cartao()
        {

            this.cardValue = string.Empty;
            this.cardText = string.Empty;
            this.cardIcon = MaterialDesignThemes.Wpf.PackIconKind.Gamepad;


        }

        public Cartao(string cardText, string cardValue, MaterialDesignThemes.Wpf.PackIconKind packIcon)
            :this()
        {
            this.cardValue = cardValue;
            this.cardText = cardText;
            this.cardIcon = packIcon;


        }

        private string cardValue;

        public string CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        private string cardText;

        public string CardText
        {
            get { return cardText; }
            set { cardText = value; }
        }


        private MaterialDesignThemes.Wpf.PackIconKind cardIcon;

        public MaterialDesignThemes.Wpf.PackIconKind CardIcon
        {
            get { return cardIcon; }
            set { cardIcon = value; }
        }

    }
}
