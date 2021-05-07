<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-
beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-
eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <title>PHP :: Inscrição</title>
    <script>
    function validar(form) {
        console.log("Função...");
        var temErro = false;
        var sErro = "";
        if (form.nome.value == "") {
            sErro += "Deve introduzir um nome!\n"
            temErro = true;
        }
        if (form.email.value.indexOf('@', 0) == -1) {
            sErro += "Deve introduzir um email válido!\n"
            temErro = true;
            if (temErro == true) {
                alert(sErro);
                return false;
            } else {
                return true;
            }
        }
    }
    </script>
</head>

<body>
    <?php include "../includes/menu.inc.php"; ?>
    <div class="container">
        <h1>Inscrição</h1>
        <form action="registo.php" onsubmit="return validar(this);" method="post" name="FormInscricao">
            <div class="form-floating mb-3">
                <input type="text" class="formcontrol" id="nome" name="nome" placeholder="Introduza nome">
  
            </div>
            <div class="form-floating mb-3">
                <input type="text" class="formcontrol" id="telefone" name="telefone" placeholder="Introduza telefone">
             
            </div>
            <div class="form-floating mb-3">
                <input type="email" class="formcontrol" id="email" name="email" placeholder="Introduza email">
                
            </div>
            <input class="btn btnsuccess" type="submit" name="Enviar" value="Inscrever" />
            <input class="btn btn-warning" type="reset" name="Limpar" value="Limpar" />
            <a class="btn btn-primary" href="verinscricoes.php">Ver Inscrições</a>
        </form>
    </div>
    <?php include "../includes/footer.inc.php"; ?>
</body>

</html>