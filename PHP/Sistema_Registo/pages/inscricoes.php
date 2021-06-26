<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <?php include "../includes/header.php"; ?>

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
        <div class="row">
            <div class="col-sm-8">
                <form action="registo.php" onsubmit="return validar(this);" method="post" name="FormInscricao">

                    <div class="form-group" style="position: relative;">
                        <label for="nome" class="form-label mt-4">Nome:</label>
                        <input type="text" class="form-control" id="nome" name="nome" placeholder="Introduza nome" data-focused="true">
                    </div>

                    <div class="form-group" style="position: relative;">
                        <label for="telefone" class="form-label mt-4">Telefone:</label>
                        <input type="tel" class="form-control" id="telefone" name="telefone" minlength="9" maxlength="14" placeholder="Introduza telefone">
                    </div>

                    <div class="form-group" style="position: relative;">
                        <label for="email" class="form-label mt-4">Email:</label>
                        <input type="email" class="form-control" id="email" name="email" placeholder="email@exemplo.com">
                    </div>

                    <div class="gap-4 mt-3">
                        <input class="btn btn-outline-primary" type="submit" name="Enviar" value="Inscrever" />
                        <input class="btn btn-outline-warning" type="reset" name="Limpar" value="Limpar" />
                        <a class="btn btn-outline-light" href="verinscricoes.php">Ver Inscrições</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <?php include "../includes/footer.inc.php"; ?>
</body>

</html>