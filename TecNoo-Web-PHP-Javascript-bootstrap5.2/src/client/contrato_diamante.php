<?php
session_start();
//inclui conexão com o banco de dados
include('../connection/conn.php');
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
    <title><?php echo TECNOO; ?>&nbsp; Social</title>
</head>

<body class="bgMain-interno">
    
    <main class="container">
    <div class="container alert alert-secondary p-4 rounded my-4">
            <a href="novo_contrato_cliente.php" class="text-decoration-none">
            <h1 class="text-dark">
                <i class="bi bi-arrow-left-square-fill"></i>
                    Contrato
                </h1>
            </a>
        </div>
        <div class="card mt-5 alert bg-info bg-opacity-50" style="max-width: 100vw;">
            <div class="row g-0">
                <div class="">
                    <div class="card-body text-center">
                        <h1>Contrato Diamante</h1>
                        <br>
                        <h4><strong>Após contratar o plano Diamante você terá Suporte 24Hrs por telefone/app e web e 6 visitas técnicas gratuitas por contrato.</strong>
                        O nosso plano diamante e o melhor plano da nossa empresa, oferecendo suporte 24horas por telefone, app e pela web e também oferecendo 6 visitas técnicas gratuitas por contrato.
                        
                        </h4>
                        <a download="" href="../pdfs/Contrato de prestação de serviço Diamante TecNoo.pdf"><button class="align-self-center btn btn-dark mb-3 mt-5">Contratar</button></a>
                    </div>
                </div>
            </div>
        </div>
    </main>

    <!-- Link arquivos Bootstrap js -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</body>

</html>