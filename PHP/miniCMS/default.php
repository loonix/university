<?php
 include "bd/ligacaoBD.php";
 $conn = connectDatabase();
 //Pesquisa registo
 $sql = "SELECT pagina, texto FROM conteudos WHERE pagina = 'home'";
 $resultado = mysqli_query($conn, $sql);

 $row = mysqli_fetch_assoc($resultado);
?>
<!DOCTYPE html>
<html>
<head>
 <?php include "includes/header.inc.php"; ?>
  <title>minCMS</title>
</head>
<body>
 <?php include "includes/menu.inc.php"; ?>
 <main role="main">
 <div class="container m-5">
 <div class="jumbotron">
 <h1 class="display-4">miniCMS</h1>
 </div>
 <?php echo $row["texto"]; ?>

 </div>
 </main>
 <?php include "includes/footer.inc.php"; ?>
 <!-- Optional JavaScript -->
 <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>