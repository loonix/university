inicio
    variavel inteiro ano
    variavel inteiro resto4
    variavel inteiro resto100
    variavel inteiro resto400
    escrever "Introduza um ano: "
    ler ano
    
    resto4 <- ano % 4
    resto100 <- ano % 100
    
    se ( resto4 = 0 ) entao// divisivel por 4
        se ( resto100 =/= 0 ) entao// nao divisivel por 100
            escrever ano , " e bissexto"
        senao
            resto400 <- ano % 400
            se ( resto400 = 0 ) entao
                escrever ano , " e bissexto"
            senao
                escrever ano , " nao e bissexto"
            fimse
        fimse
    senao
        escrever ano , " nao e bissexto"
    fimse

fim

