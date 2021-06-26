<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <?php include "../includes/header.php"; ?>

    <title>Ver Inscricoes</title>
</head>

<body>
    <?php include "../includes/menu.inc.php"; ?>
    <div class="container">
        <?php
        include "../bd/ligacaoBD.php";
        $conn = connectDatabase();
        $sql = "SELECT * FROM inscricoes";
        $result = mysqli_query($conn, $sql);
        echo "<h1>Lista Inscrições</h1>";
        echo "<table class='table table-hover table-striped'>";
        echo "<thead><tr><th>Nome</th><th>Email</th><th>Telefone</th><th></th></tr></thead>";
        echo "<tbody>";
        while ($row = mysqli_fetch_row($result)) {
            echo "<tr>";
            echo "<td> $row[1]</td>";
            echo "<td> $row[2]</td>";
            echo "<td> $row[3]</td>";
            echo "<td>";
            echo "<a href='alterar_registo.php?id=$row[0]'>Alterar</a> | ";
            echo "<a href='eliminar_registo.php?id=$row[0]'>Eliminar</a>";
            echo "</td>";
            echo "</tr>";
        }
        echo "</tbody>";

        echo "</table>";
        ?>
    </div>
    <?php include "../includes/footer.inc.php"; ?>
</body>

</html>