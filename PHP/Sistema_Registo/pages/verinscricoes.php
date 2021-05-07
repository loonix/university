<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
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
        echo "<table class='table'>";
        echo "<tr><th>Nome</th><th>Email</th><th>Telefone</th></tr>";
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
        echo "</table>";
        ?>
    </div>
    <?php include "../includes/footer.inc.php"; ?>
</body>

</html>