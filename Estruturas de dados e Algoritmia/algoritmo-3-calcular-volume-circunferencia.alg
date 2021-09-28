// 3. Calcular o volume de uma circonferência dado o seu raio.
// v = 4 / 3PI.r^3
inicio
    // declaração de variaveis
    variavel real raio, volume
    constante real pi <- 3.1415
    // leitura de dados
    escrever "Introduza o raio: "
    ler raio
    
    // processamento
    volume <- 4 / 3 * pi * raio ^ 3
    escrever "O volume da circunferência com raio de ", raio, " é: ", volume
    
    // saida de informação
fim

