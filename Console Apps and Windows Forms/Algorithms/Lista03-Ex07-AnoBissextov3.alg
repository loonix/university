inicio
    variavel inteiro ano
    variavel inteiro resto4
    variavel inteiro resto100
    variavel inteiro resto400
    escrever "Introduza um ano: "
    ler ano
    
    resto4 <- ano % 4
    resto100 <- ano % 100
    resto400 <- ano % 400
    
    se (resto4 = 0 e resto100 =/= 0) ou (resto400 = 0 ) entao// divisivel por 4 e nao divisivel por 100 ou 400 = 0
        escrever ano , " e bissexto"
    senao
        escrever ano , " nao e bissexto"
    fimse
fim

