<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous" />
    <link rel="stylesheet" href="../css/my_style.css" />
    <title>Tecnoo</title>
</head>

<body>
    <main class="container pt-5 my-5">
        
        <div class="alert alert-success text-center rounded" role="alert">
            <h1 class="">Área administrativa</h1>
        </div>
        <!-- Inicio row -->
        <div class="row my-3 d-flex justify-content-center">
            <!-- Inicio chamados -->
            <div class="alert bg-warning text-center bg-opacity-75 col-3 mx-1">
                <img clas="mb-2" src="../img/administrative_tools_15497.png" alt="">                
                <div class="alert bg-light text-center bg-opacity-75">
                    <h4>Chamados</h4>
                </div>
                <div class="">
                    <a href="listar_chamados.php"><button type="button" class="btn btn-light">Lista Chamados</button></a>
                </div>
            </div>
            <!-- Fim chamados -->
            <!-- Inicio descarte solidário -->
            <div class="alert bg-danger text-center bg-opacity-75 col-3 mx-1">
                <img src="../img/Motherboard_icon-icons.com_55228.png" alt="">
                <div class="alert bg-light bg-opacity-75 ">
                    <h4>Hard Solidário</h4>
                </div>
                <div class="">
                    <a href="listar_hard.php"><button type="button" class="btn btn-light">Lista Descarte</button></a>
                </div>
            </div>
            <!-- Fim descarte solidário -->
            <!-- Inicio contratos -->
            <div class="alert bg-secondary text-center bg-opacity-75 col-3 mx-1">
                <img src="../img/contract_shaking_hands_icon_205722.png" alt="">
                <div class="alert bg-light bg-opacity-75 ">
                    <h4>Contratos</h4>
                </div>
                <div class="">
                    <a href="listar_contratos.php"><button type="button" class="btn btn-light">Lista Contratos</button></a>
                </div>
            </div>
            <!-- Fim contratos --> 
                <hr>
            <!-- Inicio usuarios -->
            <div class="alert bg-success text-center bg-opacity-75 col-3 mx-1">
                <img src="../img/manager_person_man_people_2841 (1).png" alt="">
                <div class="alert bg-light bg-opacity-75 ">
                    <h4>Usuários</h4>
                </div>
                <div class="">
                    <?php if ($_SESSION['id_nivel_us'] != 1) {?>

                    <a href=""><button type="button" class="btn btn-outline-secondary" disabled>Lista Usuários</button></a>
                    <?php } else {?>    
                        <a href="listar_usuarios.php"><button type="button" class="btn btn-light">Lista Usuários</button></a>

                        <?php }?>
                </div>
            </div>
            <!-- Fim usuarios  -->
            <!-- Inicio clientes -->
            <div class="alert bg-info text-center bg-opacity-75 col-3 mx-1">
                <img src="../img/admin_user_man_22187.png" alt="">
                <div class="alert bg-light bg-opacity-75 ">
                    <h4>Clientes</h4>
                </div>
                <div class="">
                    <?php if ($_SESSION['id_nivel_us'] != 1) {?>

                    <a href=""><button type="button" class="btn btn-outline-secondary" disabled>Lista Clientes</button></a>
                    <?php } else {?>    
                        <a href="listar_clientes.php"><button type="button" class="btn btn-light">Lista Clientes</button></a>

                        <?php }?>
                </div>
            </div>
            <!-- Fim clientes  -->
        </div>
        <!-- Fim row -->
    </main>
     <!-- Link arquivos Bootstrap js -->
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</body>

</html>