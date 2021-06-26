<?php
 function connectDatabase(){
 include "configBD.php";
 $conexao = mysqli_connect($servidor, $utilizador, $password, $basedados);

 if(!$conexao) {
 die('Não foi possivel estabelecer uma conexão com o gestor de Base de Dados MySQL: ' .mysql_error());
 exit;
 }
 return $conexao;
 }
?>