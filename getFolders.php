<?php 
	session_start();
	if (isset($_SESSION["useremail"])==false) {
		header("Location:index.php");
	}
	$useremail = $_SESSION["useremail"];


	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbname = "mydrive";

	$folderdata= array();
	// Create connection
	$conn = new mysqli($servername, $username, $password,$dbname);
	// Check connection
	if ($conn->connect_error)
	{
	    die("Connection failed: " . $conn->connect_error);
	}
	else {
		if($_REQUEST["folder"]==null){
	        $sql = "SELECT FolderId, FolderName FROM folder_details where Email='$useremail' and ParentFolderId is null";
	    }
	    else{    
	    	$pfid=$_REQUEST["folder"];
	        $sql = "SELECT FolderId, FolderName FROM folder_details where Email='$useremail' and ParentFolderId=$pfid";
	    }
	    $result = $conn->query($sql);
        if ($result->num_rows > 0) {
            while($row = $result->fetch_assoc())
        	{
        		$folderdata[]=array(
        			'FolderId' => $row["FolderId"],
        			'FolderName' => $row["FolderName"]
        		);
        	}
        }
	$conn->close();
	print_r(json_encode($folderdata));
	}


?>