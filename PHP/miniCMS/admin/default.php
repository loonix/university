<?php

 session_start();
 //Verificar variavel de sessão, criada caso faça Login
 if (isset($_SESSION['login_ok']) == false)
 {
 header("location: login.php");
 }
 $login_ok = $_SESSION['login_ok'];
 if ($login_ok == "false")
 {
 header("location: login.php");
 }
?>
<!DOCTYPE html>
<html>
<head>
 <?php include "../includes/header.inc.php"; ?>
 <title>minCMS :: backoffice</title>
</head>
<body>
 <?php include "../includes/menu_admin.inc.php"; ?>
 <main role="main">
 <div class="container m-5">
     <div class="col-sm-12">
     <div class="row">
        <div class="col-sm-8">
            <h1>Páginas</h1>
        </div>
        <div class="col-sm-4">
            <a class="btn btn-outline-success m-2" href="criar_pagina.php">Criar</a>
        </div>
    </div>
    <div class="row">
        <table class='table  table-hover'>
            <thead>
                <tr>
                    <th>Página</th>
                    <th>Criador</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
                <?php
                    include "../bd/ligacaoBD.php";
                    $conn = connectDatabase();
                    $sql = "SELECT * FROM Conteudos";
                    $result = mysqli_query($conn, $sql);
                    while ($row = mysqli_fetch_row($result)) {
                    echo "<tr>";
                    echo "<td> $row[1]</td>";
                    echo "<td> $row[4]</td>";
                    echo "<td>";
                    echo "<a href='alterar_pagina.php?id=$row[0]'><i class='fa fa-edit me-1'></i>Editar</a>";
                    echo "<a class='ms-3' href='remover_pagina.php?id=$row[0]'><i class='fa fa-trash me-1'></i>Remover</a>";
                    echo "</td>";
                    echo "</tr>";
                    }
                ?>
            </tbody>
        </table>
    </div>
    </div>
 </div>
 </main>

 <?php include "../includes/footer.inc.php"; ?>
</body>
</html>