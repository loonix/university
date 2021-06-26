<?php
 include "../bd/ligacaoBD.php";
 $conn = connectDatabase();
 //Pesquisa registo
 if ($_SERVER["REQUEST_METHOD"] == "GET") {
    if (isset($_GET["pag"])){
        $pag = $_GET["pag"];
        $sql = "SELECT id, pagina, titulo, texto FROM Conteudos WHERE pagina = '$pag'";
        $resultado = mysqli_query($conn, $sql);
        $row = mysqli_fetch_assoc($resultado);
    }
 }
?>

<!DOCTYPE html>
<html>
<head>
    <?php include "../includes/header.inc.php"; ?>
    <title><?php $echo["titulo"]; ?></title>
</head>
<body>
    <?php include "../includes/menu.inc.php"; ?>
    <main role="main">
        <div class="container m-5">
            <?php
            echo "<h1>" .$row["titulo"]. "</h1>";
            if (isset($_SESSION['login_ok']))
            {
                echo "<a href='../admin/alterar_pagina.php?id=".$row['id']."'><i class='fa fa-edit me-1'></i>Editar</a>";
            }
            echo "<br/>";
            echo $row["texto"];
            ?>
        </div>
    </main>

    <?php include "../includes/footer.inc.php"; ?>
</body></html>
