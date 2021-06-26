<?php
include "../bd/ligacaoBD.php";
$conn = connectDatabase();
// Eliminar registo
    $id = $_GET["id"];
    $sql = "DELETE FROM Conteudos WHERE id = $id";
    $result = mysqli_query($conn, $sql);
    header("Location:default.php");
?>