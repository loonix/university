/*
 * JS externo
 */
function EscreveDadosExterno() {
    document.write("<p>Texto escrito através da função escreveDados() do ficheiro JS externo < /p>")
}
/*
função tabuada que recebe um numero e escreve a tabuada desse numero
*/
function tabuada(numero) {
    //Exemplo: 5 x 1 = 5
    //document.write(numero + " x 1 = " + numero * 1)
    //document.write(numero + " x 2 = " + numero * 2)
    //usar um ciclo for
    for (i = 1; i <= 10; i++) {
        document.write(numero + " x " + i + " = " + numero * i + "<br />");
    }
}

function tabuadaFormatada(numero) {
    var stringTabuada = "";
    for (i = 1; i <= 10; i++) {
        stringTabuada = stringTabuada + numero + " x " + i + " = " + numero * i + "<br />";
        //stringTabuada += numero + " x " + i + " = " + numero * i + "<br />";

    }
    return stringTabuada;
}