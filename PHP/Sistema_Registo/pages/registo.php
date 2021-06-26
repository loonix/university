<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <?php include "../includes/header.php"; ?>

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
        echo "<a class='btn btn-outline-light' href='verinscricoes.php'>Ver Inscrições</a>";
        header("Location:verinscricoes.php");
    } else {
        echo "<h3>Impossivel registar</h3>";
    }
    echo "</div>";
    include "../includes/footer.inc.php";
    ?>
</body>

</html>