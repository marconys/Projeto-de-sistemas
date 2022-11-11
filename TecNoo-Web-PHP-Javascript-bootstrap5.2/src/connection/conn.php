<?php 
//Conexão com o banco de dados
$hostname = "localhost";
$dbname = "tecnoodb";
$username = "root";
$password ="";
$charset = "utf-8";
$port = 3307;

try {
    //Conexão com prota
    //$conn = new PDO("mysql:host=$hostname;
    //port=$port;dbname=$dbname", $username, $password);
    //Conexão sem prota
    $conn = new PDO("mysql:host=localhost;port=3307;dbname=tecnoodb", "root", "");
   // echo "Conexão com o banco de dados realizada com sucesso!";
}catch(PDOException $err){
    echo "Erro ao tentar conexão com o banco de dados!" . $err->getMessage();
    die();
}

?>