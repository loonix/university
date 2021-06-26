<?php
 //Inicia sessao
 session_start();
 $error ="";
 if($_SERVER["REQUEST_METHOD"] == "POST") {
 include "../bd/ligacaoBD.php";
 $conn = connectDatabase();

 //Retirar caracteres especiais
 //NUL (ASCII 0), \n, \r, \, ', ", and Control-Z.
 $campoUsername = mysqli_real_escape_string($conn, $_POST['username']);
 $campoPassword = mysqli_real_escape_string($conn, $_POST['password']);

 $campoPassword = md5($campoPassword); //Codifica a passoword com MD5

 $sql = "SELECT * FROM admins WHERE UserName = '$campoUsername' AND Codigo = '$campoPassword'";

 $numRegistos=0;

if ($resultado = mysqli_query($conn, $sql))
{
    $numRegistos = mysqli_num_rows($resultado);
}

if($numRegistos == 1) {
    $_SESSION['login_ok'] = "true";
    $_SESSION['login_user'] = $campoUsername;
    header("location: default.php");
} else {
    $error = "Username e/ou Password errado!";
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


    <div class="login">
        <div class="container">
            <div class="login-row" class="row justify-content-center align-items-center">
                <div class="login-column" class="col-md-6">
                    <div class="login-box" class="col-md-12">
                        <form class="login-form" class="form" action="" method="post" name="loginForm">
                            <h3 class="text-center">Login</h3>
                            <div class="form-group">
                                <label for="username" class="form-label mt-4">Username:</label><br>
                                <input type="text" name="username" id="username" class="form-control" required>
                            </div>
                            <div class="form-group">
                                <label for="password" class="form-label mt-4">Password:</label><br>
                                <input type="text" name="password" id="password" class="form-control" type="submit" required>
                            </div>
                            <div class="d-grid">
                                <input class="btn btn-outline-success mt-4" type="submit" value="Entrar"/><br />
                                <div style="font-size:11px; color:#cc0000; margin-top:10px"><?php echo $error; ?></div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
   
    <?php include "../includes/footer.inc.php"; ?>
   </body>
   </html>



