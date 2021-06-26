<?php
 session_start();
 if (isset($_SESSION['login_ok']) == false)
 {
 header("location: login.php");
 }
 $login_ok = $_SESSION['login_ok'];
 if ($login_ok == "false")
 {
 header("location: login.php");
 }
 include "../bd/ligacaoBD.php";
 $conn = connectDatabase();
 //Pesquisa registo
 if ($_SERVER["REQUEST_METHOD"] == "GET") {
    if (isset($_GET["id"])){
    $id = $_GET["id"];
   
    $sql = "SELECT * FROM Conteudos WHERE id = $id";
    $result = mysqli_query($conn, $sql);
   
    if (mysqli_num_rows($result) > 0) {
    $row = mysqli_fetch_row($result);
    }
    }
    }
    //Alterar registo
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (isset($_POST["Titulo"])){
    $id = $_POST['id_registo'];
    $titulo = $_POST["Titulo"];
    $texto = $_POST["Texto"];
    $autor = $_POST["Autor"];
    $sql = "UPDATE Conteudos SET Titulo='$titulo', Texto='$texto', Autor='$autor'
    WHERE id = $id";
    $result = mysqli_query($conn, $sql);
   
    //volta para a pagina editar
    header("Location:editar.php");
    }
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
 <h1>Criar nova página</h1>
 <form action="nova_pagina.php" onsubmit="return validar(this);" method="post">
    <div style="width:100%;">
        <div class="form-group">
            <label for="Pagina">Pagina:</label>
            <input class="form-control" type="text" name="Pagina" size="50" value="" placeholder="Nome da página..." />
        </div>
        <div class="form-group">
            <label for="Titulo">Titulo:</label>
            <input class="form-control" type="text" name="Titulo" size="10" maxlength="9" value="" placeholder="Introduza titulo..." />
        </div>
        <div class="form-group">
            <label for="Texto">Texto:</label>
            <textarea class="form-control" rows="10" name="Texto" id="editor"></textarea>
        </div>
        <div class="form-group">
            <label for="Autor">Autor:</label>
            <input class="form-control" type="text" name="Autor" size="50" value="" placeholder="Introduza autor..." />
        </div>
            <input class="btn btn-outline-success mt-2" type="submit" name="Alterar" value="Criar" />
    </div>
 </form>
 </main>

 <?php include "../includes/footer.inc.php"; ?>
</body>

<script>
    function validar(form) {
        console.log("Função...");
        var temErro = false;
        var sErro = "";
        if (form.nome.value == "") {
            sErro += "Deve introduzir um nome!\n"
            temErro = true;
        }
        if (form.email.value.indexOf('@', 0) == -1) {
            sErro += "Deve introduzir um email válido!\n"
            temErro = true;
            if (temErro == true) {
                alert(sErro);
                return false;
            } else {
                return true;
            }
        }
    }
</script>

<script src="https://cdn.ckeditor.com/ckeditor5/28.0.0/classic/ckeditor.js"></script>
<script>
    ClassicEditor
        .create( document.querySelector( '#editor' ) )
        .catch( error => {
            console.error( error );
        } );
</script>
</html>