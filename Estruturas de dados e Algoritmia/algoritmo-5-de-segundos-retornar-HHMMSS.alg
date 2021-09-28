inicio
     // Variaveis
    variavel inteiro m , h , s , seg_rest , segundos
    
    // Dados
    ler segundos
    
    // Processamento
    h <- segundos / 3600
    seg_rest <- segundos % 3600
    m <- seg_rest / 60
    s <- seg_rest % 60
    
    // Saida
    escrever h , ":" , m , ":" , s
fim

