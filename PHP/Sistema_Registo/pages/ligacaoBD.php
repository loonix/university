
<?php 
function connectDatabase(){ 
$servidor="localhost"; 
$utilizador="root";
$password=""; 
$basedados="bd_inscricoes";
$conexao = mysqli_connect($servidor, $utilizador, $password, $basedados); 
if(!$conexao) { 
    die('Não foi possível estabelecer uma conexão com o gestor de Base de Dados MySQL: ' .mysql_error(null)); 
    exit;
    } 
return  $conexao; 
} ?>