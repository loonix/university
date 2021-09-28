inicio
    variavel inteiro a , b , acopy
    ler a
    ler b
    
    // Logica 1 -- variavel que ajuda a operação
    acopy <- a
    a <- b
    b <- acopy
    escrever "\nA: " , a , " - B: " , b
    // Logica 2 -- trocar com apenas 2 variaveis
    a <- a + b
    b <- a - b
    a <- a - b
    
    escrever "\nA: " , a , " - B: " , b
fim

