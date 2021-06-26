
 <nav class="navbar navbar-expand-lg navbar-light bg-light">
   <div class="container-fluid">
      <a class="navbar-brand" href="#">Backend::miniCMS</a>
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
            <li class="nav-item">
            <?php
               if (isset($_SESSION['login_ok']))
               {
               echo "<a class='nav-link active' aria-current='page' href='/miniCMS/admin'>Home</a>";
               }
            ?>
            
            </li>
         </ul>
         <div class="d-flex">
            <?php
               if (!isset($_SESSION['login_ok']))
               {
               echo "<a class='nav-link active' aria-current='page' href='/miniCMS/'>Back to Front End</a>";
               }
            ?>
               <?php
               if (isset($_SESSION['login_ok']))
               {
                  echo "<div class='dropdown'>";
                  echo "   <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-bs-toggle='dropdown' aria-expanded='false'>";
                  echo "<i class='fa fa-user me-2'></i>" . $_SESSION['login_user'];
                  echo "   </a>";
                  echo "   <ul class='dropdown-menu' aria-labelledby='navbarDropdown'>";
                  echo "      <li><a class='dropdown-item' href='/miniCMS'><i class='fa fa-eye me-2'></i>FrontEnd</a></li>";
                  echo "      <li><hr class='dropdown-divider' /></li>";
                  echo "      <li><a class='dropdown-item' href='logout.php'><i class='fa fa-sign-out-alt me-2'></i>Logout</a></li>";
                  echo "   </ul>";
                  echo "</div>";
               }
               ?>
               
              
         </div>
      </div>
   </div>
</nav>
