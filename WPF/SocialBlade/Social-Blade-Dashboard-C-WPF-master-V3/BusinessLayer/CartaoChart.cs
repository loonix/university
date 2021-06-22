using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class CartaoChart
    {
        public CartaoChart()
        {

            this.cardValue = string.Empty;
            this.cardText = string.Empty;
            ;


        }

        public CartaoChart(string cardText, string cardValue)
            : this()
        {
            this.cardValue = cardValue;
            this.cardText = cardText;
            


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



    }
}
