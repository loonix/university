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
    include "../includes/menu_admin.inc.php";
    include "../bd/ligacaoBD.php";
    $conn = connectDatabase();
    $pagina = $_POST["Pagina"];
    $titulo = $_POST["Titulo"];
    $texto = $_POST["Texto"];
    $autor = $_POST["Autor"];
    $sql = "INSERT INTO Conteudos (Pagina, Titulo, Texto, Autor) VALUES ('$pagina', '$titulo', '$texto', '$autor')";
    echo "<div class='container'>";
    if (mysqli_query($conn, $sql) === TRUE) {
        header("Location:default.php");
    } else {
        echo "<h3>Impossivel registar</h3>";
        echo "<a class='btn btn-outline-light' href='default.php'>Ver todas as paginas</a>";
    }
    echo "</div>";
    include "../includes/footer.inc.php";
    ?>
</body>

</html>