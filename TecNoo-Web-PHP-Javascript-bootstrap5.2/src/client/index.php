<?php
//Inclui o sistema de autenticação
//include('../php/acesso.php');
//Inclui variável de ambiente
include('../php/config_global.php');
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <!-- import cdn CSS Bootstrap -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous" />
  <!-- import cdn icons Bootstrap -->
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css">
  <!-- import my CSS -->
  <link rel="stylesheet" href="../css/my_style.css" />
  <link rel="icon" type="image/x-icon" href="../img/favicon-32x32.png">
  <title><?php echo TECNOO; ?>&nbsp; Área do Cliente</title>
</head>

<body class="bgMain">

  <?php
  include('menu_cliente.php');
  include('menu_options_cliente.php');
  include('footer_cliente.php');
  ?>

</body>

</html>