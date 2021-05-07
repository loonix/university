<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-
beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-
eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-
beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-
JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <title>Registo</title>
</head>

<body>
    <?php
    include "../includes/menu.inc.php";
    include "../bd/ligacaoBD.php";
    $conn = connectDatabase();
    $nome = $_POST["nome"];
    $email = $_POST["email"];
    $telefone = $_POST["telefone"];
    $sql = "INSERT INTO inscricoes (Nome, Email, Telefone) VALUES ('$nome', '$email',
'$telefone')";
    echo "<div class='container'>";
    //if($conn->query($sql) == TRUE) { //estilo objeto
    if (mysqli_query($conn, $sql) === TRUE) {
        echo "<br/><br/><h3>Inscrição efectuada! </h3><br /><br />";
    } else {
        echo "<h3>Impossivel registar</h3>";
    }
    echo "</div>";
    include "../includes/footer.inc.php";
    ?>
</body>

</html>