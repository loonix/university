
 <nav class="navbar navbar-expand-lg navbar-light bg-light">
   <div class="container-fluid">
      <a class="navbar-brand" href="#">miniCMS</a>
      <button
         class="navbar-toggler"
         type="button"
         data-bs-toggle="collapse"
         data-bs-target="#navbarSupportedContent"
         aria-controls="navbarSupportedContent"
         aria-expanded="false"
         aria-label="Toggle navigation"
      >
         <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
         <ul class="navbar-nav me-auto mb-2 mb-lg-0">
           
         <?php
            $s="localhost";
            $u="root";
            $p="";
            $b="miniCMS";
            $c = mysqli_connect($s, $u, $p, $b);
            if(!$c) {
            die('Não foi possivel estabelecer uma conexão com o gestor de Base de Dados MySQL: ' .mysql_error());
            exit;
            }
            $sqlQ = "SELECT * FROM Conteudos";
            $rs = mysqli_query($c, $sqlQ);
            while ($rr = mysqli_fetch_row($rs)) {
                echo "<li class='nav-item'>";
                echo "    <a class='nav-link' href='/miniCMS/pages/pagina.php?pag=$rr[1]''>$rr[2]</a>";
                echo "</li>";
            }
        ?>
         </ul>
         <div class="d-flex">
               <a class="nav-link active" aria-current="page" href="/miniCMS/admin">Admin</a>
         </div>
      </div>
   </div>
</nav>