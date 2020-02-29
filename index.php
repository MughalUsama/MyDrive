<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>My Drive</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <link rel="icon" href="card-folder.png"/>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="bootstrap.min.css">
    <!-- jQuery library -->
    <script src="jquery-3.4.1.min.js"></script>
    <!-- Latest compiled JavaScript -->
    <script src="bootstrap.min.js"></script> 
    <link rel='stylesheet' type='text/css' media='screen' href='index.css'>

</head>
<body>
<?php
session_start();
    if (isset($_SESSION["useremail"])){
        header("Location:home.php");
    }
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "mydrive";

$emailExists=false;
$wrongCredentials=false;
$signedup=false;
// Create connection
$conn = new mysqli($servername, $username, $password,$dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
else {
    if (isset($_REQUEST["btnlogin"]) == true) {
        $uemail = $_REQUEST["loginEmail"];
        $upass = $_REQUEST["loginPassword"];
        $sql = "SELECT Email, Username FROM user_details where Email='$uemail' and Password='$upass'";
        $result = $conn->query($sql);
        if ($result->num_rows > 0) {
            $row = $result->fetch_assoc();
            $_SESSION["username"]=$row["Username"];
            $_SESSION["useremail"]=$uemail;
            $_SESSION["currentfolder"]=null;
            header("Location: home.php");
        } else {
            $_SESSION["useremail"]=null;
            $wrongCredentials=true;
        }
    }
    if (isset($_REQUEST["btnsignup"]) == true) {
        $user_name = $_REQUEST["username"];
        $signupemail = $_REQUEST["signupEmail"];
        $signupPass = $_REQUEST["signupPassword"];
        $sql1 = "INSERT INTO user_details (Email, Password, Username)VALUES ('$signupemail', '$signupPass' , '$user_name')";
        if ($conn->query($sql1) === TRUE) {
            $signedup=true;
        } else {
            $emailExists=true;
        }
    }
$conn->close();
}
?>
    <div class="row">
        <nav class="navbar p-1 pr-3 navbar-expand-sm bg-dark navbar-dark shadow-sm col-12">
            <a href="index.php" class="navbar-brand">
                <!-- Logo Image -->
                <img src="brandIcon.png" width="75" alt="" class="d-inline-block align-middle mr-1 ml-4">
                <!-- Logo Text -->
                <span class="text-uppercase font-weight-bold" id="logo-txt">My Drive</span>
            </a>
            <div id="navbarSupportedContent" class="ml-auto">
                <ul class="navbar-nav ml-auto">
                    <li id="nav-signup" class="nav-item mt-1 active"><h6 class="d-inline text-white">Not registered? Let's</h6><h5 class="nav-link d-inline" id="nav-signup">Sign Up</h5></li>
                    <li id="nav-login" class="nav-item mt-1 active" "><h6 class="d-inline text-white">Already registered? Let's</h6><h5 class="nav-link d-inline">Log In</h5></li>
                </ul>
            </div>
        </nav>
    </div>

    <div class="row flex-md-nowrap flex-sm-wrap justify-content-end mt-2">
        <div class="col-md-7 ml-5 mr-sm-4 mr-md-0 " >
            <div class="card text-white bg-dark mb-3">
                <h2 class="card-header p-3">Hey There!</h2>
                <div class="card-body">
                    <h1 class="card-title p-2">Welcome To My Drive!</h1>
                    <h5 class="card-text p-2 pb-5">My Drive is a place to upload and save your files in an ordered way. You can create folders and subfolders and organize your files in your desired way.</h5>
                    <?php 
                        if ($signedup==true) {
                    ?>
                            <h4 id='signedupmsg' class="text-success text-center">You have successfully Signed Up! Let's Login!</h4>
                    <?php
                        }
                    ?>
                </div>
            </div>
        </div>
        <form id="loginform" method="post" action="index.php" class="mr-5 myform p-5 col-md-4 ml-md-0 ">
            <h1 class="text-center loginhead">Login</h1>
            <div class="form-group p-2">
                <label for="loginEmail">Email address</label>
                <input type="email" class="form-control" name="loginEmail" id="loginEmail"  placeholder="Enter your email" required>
            </div>
            <div class="form-group p-2">
                <label for="loginPassword">Password</label>
                <input type="password" class="form-control" name="loginPassword" id="loginPassword" placeholder="Enter Your Password" minlength="8" maxlength="20" required>
            </div>
            <?php
            if($wrongCredentials==true)
            {
                ?>
                <p class="text-center text-danger">Wrong Credentials</p>
                <?php
            }
            ?>
            <div class="text-center p-2">
            <button type="submit" name="btnlogin" class="btn btn-lg btn-primary">Login!</button>
            </div>
        </form>




        <!-- Signup form-->
        <form id="signupform" method="post" action="index.php" class="mr-5 myform px-3 pt-2 pb-2 col-md-4 ml-md-0">
            <h1 class="text-center loginhead">Signup</h1>
            <div class="form-group px-2 pt-0">
                <label for="username">Your Name</label>
                <input type="text" class="form-control" name="username" id="username"  placeholder="Enter your fullname" required>
            </div>
            <div class="form-group px-2 pt-1">
                <label for="signupEmail">Email address</label>
                <input type="email" class="form-control" name="signupEmail" id="signupEmail"  placeholder="Enter your email" required>
            </div>
            <div class="form-group px-2 pt-1">
                <label for="signupPassword">Password</label>
                <input type="password" class="form-control" name="signupPassword" id="signupPassword" placeholder="Enter Your Password" minlength="8" maxlength="20" required>
            </div>
            <div class="form-group px-2 pt-1">
                <label for="confirmPassword">Confirm Password</label>
                <input type="password" class="form-control" name="confirmPassword" id="confirmPassword" placeholder="Confirm Your Password" minlength="8" maxlength="20" required>
            </div>
            <?php
                if ($emailExists==true){
                    ?>
                    <p id="email-error" class="text-center text-danger">Email Already in Use</p>
            <?php
                }
            ?>
                    <p id="pass-error" class="text-center text-danger">Password does not match</p>

            <div class="text-center">
                <button type="submit" name="btnsignup" class="btn btn-lg btn-primary">Signup!</button>
            </div>
        </form>
    </div>
</body>
<script src="index.js"></script>
</html>