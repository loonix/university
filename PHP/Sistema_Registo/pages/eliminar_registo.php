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

// Eliminar registo
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $id = $_POST['id_registo'];
    $sql = "DELETE FROM inscricoes WHERE id = $id";
    $result = mysqli_query($conn, $sql);
    //volta para a pagina verinscricoes
    header("Location:verinscricoes.php");
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
    <div class="container">
        <h1>Inscrição :: Eliminar</h1>
        <form action="eliminar_registo.php" method="post">

            <input type="hidden" name="id_registo" value="<?php echo $id; ?>">
            <div class="form-group" style="position: relative;">
                <label for="nome" class="form-label mt-4">Nome:</label>
                <input readonly type="nome" class="form-control" id="nome" name="nome" placeholder="Introduza nome" data-focused="true" value="<?php echo $row[1]; ?>">
            </div>

            <div class="form-group" style="position: relative;">
                <label for="telefone" class="form-label mt-4">Telefone:</label>
                <input readonly type="tel" class="form-control" id="telefone" name="telefone" minlength="9" maxlength="14" placeholder="Introduza telefone" value="<?php echo $row[3]; ?>">
            </div>

            <div class="form-group" style="position: relative;">
                <label for="email" class="form-label mt-4">Email:</label>
                <input readonly type="email" class="form-control" id="email" name="email" placeholder="email@exemplo.com" value="<?php echo $row[2]; ?>">
            </div>

            <div class="gap-4 mt-3">
                <input class="btn btn-outline-danger" type="submit" name="Eliminar" value="Eliminar" />
                <a class="btn btn-outline-light" href="verinscricoes.php">Ver Inscrições</a>
            </div>
        </form>
    </div>
    <?php include "../includes/footer.inc.php"; ?>
</body>

</html>