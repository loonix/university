<?php
include "../bd/ligacaoBD.php";
$conn = connectDatabase();

// Pesquisa registo
if ($_SERVER["REQUEST_METHOD"] == "GET") {
    if (isset($_GET["id"])) {
        $id = $_GET["id"];
        $sql = "SELECT * FROM inscricoes WHERE id = $id";
        $result = mysqli_query($conn, $sql);
        if (mysqli_num_rows($result) > 0) {
            $row = mysqli_fetch_row($result);
        }
    }
}

// Alterar registo
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (isset($_POST["nome"])) {
        $id = $_POST['id_registo'];
        $nome = $_POST["nome"];
        $email = $_POST["email"];
        $telefone = $_POST["telefone"];
        $sql = "UPDATE inscricoes SET Nome='$nome', Email='$email', Telefone='$telefone' WHERE id = $id";
        $result = mysqli_query($conn, $sql);
        //volta para a pagina verinscricoes
        header("Location:verinscricoes.php");
    }
}
?>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <?php include "../includes/header.php"; ?>

    <title>Alterar</title>
</head>

<body>
    <?php include "../includes/menu.inc.php"; ?>
    <div class="container center">
        <h1>Alteração</h1>
        <div class="row">
            <div class="col-sm-8">
                <form action="alterar_registo.php" method="post">
                    <input type="hidden" name="id_registo" value="<?php echo $id; ?>">
                    <div class="form-group" style="position: relative;">
                        <label for="nome" class="form-label mt-4">Nome:</label>
                        <input type="text" class="form-control" id="nome" name="nome" placeholder="Introduza nome" data-focused="true" value="<?php echo $row[1]; ?>">
                    </div>

                    <div class="form-group" style="position: relative;">
                        <label for="telefone" class="form-label mt-4">Telefone:</label>
                        <input type="tel" class="form-control" id="telefone" name="telefone" minlength="9" maxlength="14" placeholder="Introduza telefone" value="<?php echo $row[3]; ?>">
                    </div>

                    <div class="form-group" style="position: relative;">
                        <label for="email" class="form-label mt-4">Email:</label>
                        <input type="email" class="form-control" id="email" name="email" placeholder="email@exemplo.com" value="<?php echo $row[2]; ?>">
                    </div>

                    <div class="gap-4 mt-3">
                        <input class="btn btn-outline-primary" type="submit" name="Alterar" value="Alterar" />
                        <a class="btn btn-outline-light" href="verinscricoes.php">Ver Inscrições</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <?php include "../includes/footer.inc.php"; ?>
</body>

</html>