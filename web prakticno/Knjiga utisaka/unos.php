<?php
	$ime = $_POST["ime"];
	$email = $_POST["email"];
	$komentar = $_POST["komentar"];
	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbname = "knjiga utisaka";
	$conn = new mysqli($servername, $username, $password, $dbname);
	if ($conn->connect_error) {
		  die("Neuspešna konekcija: " . $conn->connect_error);
	} 
	$datum=date('Y-m-d H:i:s');
	$sql = "INSERT INTO Utisak (Ime, Email, Komentar,Datum) VALUES ('$ime', '$email', '$komentar', '$datum')";
	if ($conn->query($sql) === TRUE) {
		echo "New record created successfully";
	} else {
		echo "Error: " . $sql . "<br>" . $conn->error;
	}
	$conn->close();
	header("Location: index.html"); 
	exit();
?>