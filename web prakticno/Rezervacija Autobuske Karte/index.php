<!DOCTYPE HTML>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
		<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
		<title>Rezervacija Autobuske Karte</title>
		<link rel="stylesheet" type="text/css" href="style.css">
	</head>
	<body>
		<div class ="container">
			<?php 
					$servername = "localhost";
					$username = "root";
					$password = "";
					$dbname = "myDB";
					
					$dodato = array();
					
					$conn = mysqli_connect($servername, $username, $password, $dbname);
					// Check connection
					if (!$conn) 
					{
						die("Connection failed: " . mysqli_connect_error());
					}
				
					$sql = "SELECT id FROM rezervacija";
					$result = mysqli_query($conn, $sql);
					
					if (mysqli_num_rows($result) > 0) 
					{
						
						while($row = mysqli_fetch_assoc($result)) 
						{
							array_push($dodato, $row["id"]);
						}
						
					}
					$k="";
					$n = count($dodato);
					if($n>0)
					{
						for($x = 0; $x < $n; $x++) {
							$k=$k.(string)$dodato[$x]." ";
						}
					}
				$conn->close();
			?>
			<input type="hidden" id="myPhpValue" value="<?php echo $k?>" />
			<div class="header">
				<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
 
					<a class="navbar-brand" href="index.html">Rezervacija.com</a>
	  
					  
					  <ul class="navbar-nav">
						<li class="nav-item">
						  <a class="nav-link" href="index.html">Pocetna</a>
						</li>
						<li class="nav-item">
						  <a class="nav-link" href="autor.html">O Autoru</a>
						</li>
						<li class="nav-item">
						  <a class="nav-link" href="uputstvo.html">Uputstvo</a>
						</li>
					  </ul>
				</nav>
				<h1 class="naslov">Rezervacija sedista autobusa</h1>
			</div>
			<div class="content">
			
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">2</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">3</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">4</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">5</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">6</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">7</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">8</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">9</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">10</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">11</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">12</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">13</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">14</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">15</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">16</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">17</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">18</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">19</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">20</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">21</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">22</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">23</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">24</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">25</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">26</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">27</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">28</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">29</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">30</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">31</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">32</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">33</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">34</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">35</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">36</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">37</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">38</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">39</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">40</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">41</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">42</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">43</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">44</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">45</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">46</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">47</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">48</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">49</div>
					</div>
				</div>
				<div class="row">
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">50</div>
					</div>
					<div class="col">
						<img class="img-responsive" src="img/seat.png" alt="Sediste">
						<div class="centered">51</div>
					</div>
				</div>
				<form action="index.php" method="post">
				  <div class="form-group">
					<label for="text">Broj sedista :</label>
					<input type="text" class="form-control" id="br" name="br">
				  </div>
				  <div class="form-group">
					<label for="text">Ime i prezime :</label>
					<input type="text" class="form-control" id="ime" name="ime">
				  </div>
				  <div class="form-group">
					<label for="email">Email:</label>
					<textarea class="form-control"  id="email" name="email"></textarea>
				  </div>
				  <button type="submit" class="btn btn-dark">Submit</button>
				</form>
				<?php

					$servername = "localhost";
					$username = "root";
					$password = "";
					$dbname = "myDB";

					// Create connection
					$conn = new mysqli($servername, $username, $password, $dbname);

					// Check connection
					if ($conn->connect_error) 
					{
						die("Connection failed: " . $conn->connect_error);
					}
					$ime = $_POST["ime"];
					$email = $_POST["email"];
					$br = $_POST["br"];
					$sql = "INSERT INTO rezervacija (id,ime,email)
					VALUES ('".$br."', '".$ime."', '".$email."')";
					if (mysqli_query($conn, $sql)) 
					{
					echo "New record created successfully";
					} 
					else 
					{
					echo "Error: " . $sql . "<br>" . mysqli_error($conn);
					}
					
					$conn->close();
				?>
				
			
			</div>
			<div class="footer jumbotron text-center bg-dark"  >
			
				FOOTER
			
			</div>
			
		
		
		</div>
	<script type="text/javascript" src="Rezervacija.js"></script>	
	</body>
</html>