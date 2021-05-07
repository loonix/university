<?php
include "../bd/ligacaoBD.php";
$conn = connectDatabase();
//Pesquisa registo
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
//Eliminar registo
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
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-
beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-
eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-
beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-
JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <title>Alterar</title>
</head>

<body>
    <?php include "../includes/menu.inc.php"; ?>
    <div class="container">
        <h1>Inscrição :: Eliminar</h1>
        <form action="eliminar_registo.php" method="post">
            <!-- campo invisivel-->
            <input type="hidden" name="id_registo" value="<?php echo $id; ?>">
            <div class="form-floating mb-3">
                <input type="text" class="formcontrol" id="nome" name="nome" readonly value="<?php echo $row[1]; ?>" placeholder="Introduza nome">
             
            </div>
            <div class="form-floating mb-3">
                <input type="text" class="formcontrol" id="telefone" name="telefone" readonly value="<?php echo $row[3]; ?>" placehold er="Introduza telefone">
            
            </div>
            <div class="form-floating mb-3">
                <input type="email" class="formcontrol" id="email" name="email" readonly value="<?php echo $row[2]; ?>" placeholder="Introduza email">
              
            </div>
            <input class="btn btnsuccess" type="submit" name="Eliminar" value="Eliminar" />
            <a class="btn btn-primary" href="verInscricoes.php">Ver Inscricoes</a>
        </form>
    </div>
    <?php include "../includes/footer.inc.php"; ?>
</body>

</html>