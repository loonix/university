using System;
using System.Diagnostics;

namespace Geometria
{
    [DebuggerDisplay("{DebugMessage}")]
    public class Triangulo : IFiguraGeometrica
    {
        public Triangulo(int altura, int valorBase)
        {
            this.Altura = altura;
            this.Base = valorBase;
        }

        public int Altura { get; set; }
        public int Base { get; set; }

        public float Area()
        {
            return this.Base * this.Altura / 2;
        }

        public string DebugMessage
        {
            get
            {
                string mensagem = string.Format("Triangulo de base {0} e area = {1}", this.Base.ToString(), this.Area().ToString());
                return mensagem;
            }
        }

        public float Perimetro()
        {
            float lado = (float)Math.Sqrt(this.Altura ^ 2 + (this.Base / 2) ^ 2);
            return (this.Base +  lado * 2);
        }

        public override string ToString()
        {
            string mensagem = string.Format("Triangulo de base {0} e area = {1}", this.Base.ToString(), this.Area().ToString());
            return mensagem;
        }
    }
}
