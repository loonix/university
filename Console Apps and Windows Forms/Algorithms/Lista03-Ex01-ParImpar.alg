// Ler um numero e escrever se o numero e par ou impar
inicio
    variavel inteiro numero
    variavel real quociente
    variavel inteiro resto
    variavel inteiro resto2
    
    escrever "Introduza numero: "
    ler numero
    
    quociente <- numero / 2
    resto <- numero % 2//resto da divisao por dois
    // outra forma de criar resto
    resto2 <- numero - ( quociente * 2 )
    
    se ( resto = 0 ) entao
        escrever "Par"
    senao
        escrever "Impar"
    fimse
fim

