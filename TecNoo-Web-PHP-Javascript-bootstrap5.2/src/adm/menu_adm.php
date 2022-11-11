<?php 
session_start(); 

?>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!-- import cdn CSS Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous" />
    <!-- import cdn icons Bootstrap -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css">
    <!-- import my CSS -->
    <link rel="stylesheet" href="../css/my_style.css" />
    <title><?php echo TECNOO; ?>&nbsp; Listar Área Administrativa</title>
</head>

<body>

    <!-- Inicio do header -->
    <header>
        <!-- Inicio do navbar -->
        <nav class="navbar fixed-top navbar-expand-lg bg-dark">
            <!-- Inicio container -->
            <div class="container">
                <a class="navbar-brand" href="#">
                    <h1 class="text-light">
                        TecNoo
                        <i class="bi bi-tools"></i>
                    </h1>
                </a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <!-- Inicio menu -->
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <p class="text-light mx-auto my-auto">Olá &nbsp; <?php echo $_SESSION['nome_us'];?></p>
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link active text-light " aria-current="page" href="index.php">
                                <span><i class="bi bi-house-door-fill"></i></span>
                                Home</a>
                        </li>
                        <!-- Inicio do dropdown -->
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle text-light" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Admin
                            </a>
                            <ul class="dropdown-menu">
                                <li><a class="dropdown-item" href="listar_chamados.php">Chamados</a></li>
                                <li><a class="dropdown-item" href="listar_hard.php">Hard Solidário</a></li>
                                <li><a class="dropdown-item" href="listar_usuarios.php">Usuários</a></li>
                                <li>
                                    <hr class="dropdown-divider" />
                                </li>
                                <li><a class="dropdown-item" href="listar_contratos.php">Contratos</a></li>
                            </ul>
                        </li>
                        <!-- Fim do dropdown -->
                        <li class="nav-item">
                            <a href="../php/logout.php" class="nav-link text-light">Logout
                                <span><i class="bi bi-box-arrow-right"></i></span>
                            </a>
                        </li>
                    </ul>
                </div>
                <!-- Final do menu -->
            </div>
            <!-- Final do container -->
        </nav>
        <!-- Final do navbar -->
    </header>
    <!-- Fim do header -->

    <!-- Link arquivos Bootstrap js -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
    <!-- Links para incluir popper -->
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-oBqDVmMz9ATKxIep9tiCxS/Z9fNfEXiDAYTujMAeBAsjFuCZSmKbSSUnQlmh/jp3" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.min.js" integrity="sha384-IDwe1+LCz02ROU9k972gdyvl+AESN10+x7tBKgc9I5HFtuNz0wWnPclzo6p9vxnk" crossorigin="anonymous"></script>
</body>

</html>