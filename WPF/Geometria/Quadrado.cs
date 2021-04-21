using System.Diagnostics;

namespace Geometria
{
    [DebuggerDisplay("{DebugMessage}")]
    public class Quadrado : IFiguraGeometrica
    {
        public Quadrado()
        {

        }
        public Quadrado(int lado)
        {
            this.Lado = lado;
        }

        public int Lado { get; set; }

        public string DebugMessage
        {
            get
            {
                string mensagem = string.Format("Quadrado de lado {0} e area = {1}", this.Lado.ToString(), this.Area().ToString());
                return mensagem;
            }
        }

        public float Area()
        {
            return this.Lado * this.Lado;
        }

        public float Perimetro()
        {
            return this.Lado * 4;
        }

        public override string ToString()
        {
            string mensagem = string.Format("Quadrado de lado {0} e area = {1}", this.Lado.ToString(), this.Area().ToString());
            return mensagem;
        }
    }
}
