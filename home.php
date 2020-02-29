<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>HOME</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <link rel="icon" href="card-folder.png"/>

    <link rel="stylesheet" href="bootstrap.min.css">
    <script src="jquery-3.4.1.min.js"></script>
    <script src="bootstrap.min.js"></script>
    <link rel='stylesheet' type='text/css' media='screen' href='home.css'>

</head>
<body>
    <?php 
        session_start();
    if (isset($_SESSION["useremail"])==false){
        header("Location:index.php");
    }
    if (isset($_REQUEST["logout"]))
    {
        echo "sdfsd";
        // remove all session variables
        session_unset();

// destroy the session
        session_destroy();
        header("Location:index.php");
    }
    ?>

<div class="row">
    <nav class="navbar p-0 pr-3 navbar-expand-md bg-dark navbar-dark shadow-sm col-12">
        <a href="home.php" class="navbar-brand">
            <img src="brandIcon.png" width="75" alt="" class="d-inline-block align-middle mr-1 ml-4">
            <span class="text-uppercase font-weight-bold" id="logo-txt">My Drive</span>
        </a>
        <button type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation" class="navbar-toggler"><span class="navbar-toggler-icon"></span></button>
        <div id="navbarSupportedContent" class="text-center collapse navbar-collapse">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item mt-1 active"><a href="#" class="nav-link"><?php echo $_SESSION["username"]; ?></a></li>
                <li class="nav-item mt-1"><a href="#" class="nav-link">Settings</a></li>
                <li class="nav-item header4"><form action="home.php" method="post"><button class="bg-dark border-0 " type="submit"  name="logout"><a href="home.php" class="nav-link">
                        <div class="image-wrap">
                            <img src="logout.png" title="Logout">
                        </div>
                    </a>
                    </button>
                    </form>
                </li>
            </ul>
        </div>
    </nav>
</div>

<div class="container-fluid">

    <div class="row folder-structure d-flex">
        <span class="my-auto"> <a href="home.php">&rArr; Home</a> </span>
    </div>

    <div class="row d-flex flex-sm-wrap mt-2">
        <button data-toggle="modal" data-target="#myModal" id="addnew" class="addnew btn py-2 ml-auto mr-3 mb-2">Add New Folder<span class="font-weight-bold plussign"> +</span> </button>
    </div>
    <div class="row d-flex flex-sm-wrap mt-2">
        
    </div>
    <div class="row d-flex flex-sm-wrap my-2" id="foldersCards">
        
    </div>
</div>


<!-- Modal -->
<div id="myModal" class="modal fade bg" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content bg-dark text-white">
        <form>
          <div class="modal-header">
            <h3 class="modal-title">Add New Folder </h3>
            <button type="button" class="close" data-dismiss="modal">&times;</button>
          </div>
          <div class="modal-body">
            <span class="d-inline">Parent Folder:&ensp;</span>
              <span class="d-inline pb-1" id="modalPfolder"> Home</span>
              <br>
              Folder Name:
            <input class="w-100" type="text" id= "newfoldername" name="newFolderName">
          </div>
          <div class="modal-footer">
            <button type="submit" id="createNewFolder" class="btn btn-success" data-dismiss="modal">Create</button>
            <button type="button" class="btn btn-primary" data-dismiss="modal">Close</button>
          </div>
        </form>
    </div>

  </div>
</div>
<script src="home.js"></script>
</body>
</html>