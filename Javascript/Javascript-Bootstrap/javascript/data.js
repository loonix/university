function DataCorrente() {
    var DataCompleta = new Date();
    var Dia;
    var DiaSemana;
    var DiaSemanaExtenso;
    var Mes;
    var MesExtenso;
    var Ano;
    document.write(DataCompleta + "<br/>");
    DiaSemana = DataCompleta.getDay(); /*Dia semana em numerico -> 0-domingo...*/
    if (DiaSemana == 0) DiaSemanaExtenso = 'domingo';
    if (DiaSemana == 1) DiaSemanaExtenso = 'segunda-feira';
    if (DiaSemana == 2) DiaSemanaExtenso = 'terça-feira';
    if (DiaSemana == 3) DiaSemanaExtenso = 'quarta-feira';
    if (DiaSemana == 4) DiaSemanaExtenso = 'quinta-feira';
    if (DiaSemana == 5) DiaSemanaExtenso = 'sexta-feira';
    if (DiaSemana == 6) DiaSemanaExtenso = 'sabádo';

    Dia = DataCompleta.getDate();
    Mes = DataCompleta.getMonth(); /*Mes em numerico -> 0-janeiro...*/
    if (Mes == 0) {
        MesExtenso = 'janeiro';
    }
    if (Mes == 1) MesExtenso = 'fevereiro';
    if (Mes == 2) MesExtenso = 'março';
    if (Mes == 3) MesExtenso = 'abril';
    if (Mes == 4) MesExtenso = 'maio';
    if (Mes == 5) MesExtenso = 'junho';
    if (Mes == 6) MesExtenso = 'julho';
    if (Mes == 7) MesExtenso = 'agosto';
    if (Mes == 8) MesExtenso = 'setembro';
    if (Mes == 9) MesExtenso = 'outubro';
    if (Mes == 10) MesExtenso = 'novembro';
    if (Mes == 11) MesExtenso = 'dezembro';

    Ano = DataCompleta.getFullYear();

    document.write(DiaSemanaExtenso + ", " + Dia + ", de " + MesExtenso + " de " + Ano +
        "<br />");

}

function DataCorrente2() {
    var DataCompleta = new Date();
    var Dia;
    var DiaSemana;
    var DiaSemanaExtenso;
    var Mes;
    var MesExtenso;
    var Ano;
    /*declarar um array com os dias da semana por extenso */
    var arrayDiasSemana = new Array("domingo", "segunda-feira", "terça-feira", "quartafeira",
        "quinta-feira", "sexta-feira", "sabádo");
    DiaSemana = DataCompleta.getDay(); /*Dia semana em numerico -> 0-domingo...*/

    DiaSemanaExtenso = arrayDiasSemana[DiaSemana];
    var arrayMeses = new Array("janeiro", "fevereiro", "março", "abril",
        "maio", "junho", "julho", "agosto",
        "setembro", "outubro", "novembro", "dezembro");
    Dia = DataCompleta.getDate();
    Mes = DataCompleta.getMonth(); /*Mes em numerico -> 0-janeiro...*/
    MesExtenso = arrayMeses[Mes];
    Ano = DataCompleta.getFullYear();
    document.write(DiaSemanaExtenso + ", " + Dia + ", de " + MesExtenso + " de " + Ano);
}

function MostraHora() {
    var DataCompleta = new Date();
    var hora;
    var minutos;
    var segundos;
    hora = DataCompleta.getHours();
    minutos = DataCompleta.getMinutes();
    segundos = DataCompleta.getSeconds();
    if (hora < 10) hora = "0" + hora;
    if (minutos < 10) minutos = "0" + minutos;
    if (segundos < 10) seg = "0" + segundos;
    document.write("Página gerada às: " + hora + ":" + minutos + ":" + segundos)
}

function AtualizaHora() {
    var DataCompleta = new Date();
    var hora;
    var minutos;
    var segundos;
    var horaFormatada;
    hora = DataCompleta.getHours();
    minutos = DataCompleta.getMinutes();
    segundos = DataCompleta.getSeconds();
    if (hora < 10) hora = "0" + hora;
    if (minutos < 10) minutos = "0" + minutos;
    if (segundos < 10) seg = "0" + segundos;
    horaFormatada = hora + ":" + minutos + ":" + segundos;
    document.getElementById("Hora").innerHTML = horaFormatada;
}
window.onload = function () {
    setInterval(AtualizaHora, 1000);
}