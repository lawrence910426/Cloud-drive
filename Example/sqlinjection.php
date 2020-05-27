<html>
    <h1>Panqiao Senior High School Student Login System</h1>
    <h3>The system is not vulnerable to any kind of sql injection attack.</h3>

    <form>
        <input name="account" type="text" placeholder="Input your account here"/>
        <input name="password" type="text" placeholder="Input your password here"/>
        <input type="submit" />
    </form>
</html>

<?php

$servername = "127.0.0.1";
$username = "lawrence910426";
$password = "2rjurrru";
$dbname = "fishing";
@$account2 = $_GET["account"];
@$password2 = $_GET["password"];

if($account2 == null && $password2 == null) {
    
} else {
    // Create connection
    $conn = new mysqli($servername, $username, $password, $dbname);
    // Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }
    $sql = "SELECT * FROM `users` WHERE `account` = '$account2' AND `password` = '$password2'";

    if ($conn->query($sql)->num_rows > 0) {
        echo "You hacked it! The ssh password is 2rjurrru. Please don't hack the server. <br>";
    } else {
        echo "Access denied. No corresponding account and password found. <br>";
    }
    $conn->close();
}


?>