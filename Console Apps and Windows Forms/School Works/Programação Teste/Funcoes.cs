4.	Na class library ”CamadaNegocios.Funcoes”.
4.1.	Crie uma função static “ObterNome” que devolva uma string com o resultado da formatação de um texto dado como argumento. 
        Ex: Argumento texto = “António Jorge Costa”, a função deve retornar “Costa, António”.
4.2.	Utilize a função “FormatarNome” da classe ”CamadaNegocios.Funcoes” no Form ”FormConsultaAdvogado”, de forma a mostrar no label “autorLabel” o resultado da função.




 public class Funcoes
    {
		//4.2
        public static string FormatarNome(string valor)
        {
            string resultado = string.Empty;
            string[] palavras;

            valor = valor.Trim();

            palavras = valor.Split(' ');
            if (palavras.Length >= 2)
            {
                resultado = palavras[0];
                resultado += ", ";
                resultado += palavras[palavras.Length - 1];
            }
            else
            {
                resultado = valor;
            }
            return resultado;
        }

        //[4.1]
        public static string ObterNome(string valor)
        {
            string resultado = string.Empty;
            string[] palavras;

            valor = valor.Trim();

            palavras = valor.Split(' ');
            if (palavras.Length >= 2)
            {
                resultado += palavras[palavras.Length - 1];
                resultado += ", ";
                resultado = palavras[0];
            }
            else
            {
                resultado = valor;
            }
            return resultado;
        }

    }
	
	//[4.2]
        private void exemplificarFuncaoButton_Click(object sender, EventArgs e)
        {
            string texto = this.autorLabel.Text;
            string resultado = CamadaNegocio.Funcoes.FormatarNome(texto);
            this.autorLabel.Text = resultado;
        }
       
	
	