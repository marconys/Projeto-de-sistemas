<?php
//inclui conexão com o banco de dados    
require_once('../connection/conn.php');
//Inclui variável de ambiente
include('../php/config_global.php');

// $query_descarte = "SELECT * FROM tbcontrato";

//     //Prepara a query
//     $result_descarte = $conn->prepare($query_descarte);
//     //Executa a query
//     $result_descarte->execute();
//     //Retorna uma matriz associativa e atribui a variável $row 
//     $row = $result_descarte->fetch(PDO::FETCH_ASSOC);
//     //var_dump($row);

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!-- import cdn CSS Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous" />
    <!-- import cdn icons Bootstrap -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css">
    <!-- import my CSS -->
    <link rel="stylesheet" href="../css/my_style.css" />
    <!-- icone navegador -->
    <link rel="icon" type="image/x-icon" href="../img/favicon-32x32.png">
    <title><?php echo TECNOO; ?>&nbsp; Lista Hardware Solidário</title>
</head>

<body class="bgMain-interno">

    <?php include('menu_adm.php'); ?>

    <main class="container pt-5">

        <div class="container alert alert-primary p-4 rounded my-4">
            <a href="index.php" class="text-decoration-none">
                <h1 class="text-dark">
                <i class="bi bi-arrow-left-square-fill"></i>
                    Contratos
                </h1>
            </a>
        </div>
            <!-- Início da tabela -->
            <table class="table table-dark table-hover">
                <!-- Início do cabeçalho da tabela -->
                <thead>
                    <tr>
                        <th>ID:</th>
                    
                        <th class="largButton">
                            <a href="listar_contratos.php" class="btn largButton btn-warning btn">
                                <span><i class="bi bi-arrow-clockwise"></i> Atualizar</span>
                            </a>
                        </th>
                    </tr>
                </thead>
                <!-- Fim do cabeçalho da tabela -->
                <?php if ($row == 0) {
                    echo "<div class='alert alert-danger mt-5 p-2 rounded' role='alert'>
                    <h1><span><i class='bi bi-emoji-frown'></i> Não há nenhum cliente com contrato ainda!</span></h1>
                </div>";
                }else {?>
                <!-- Início corpo da tabela -->
                <tbody>
                    <!-- Abri estrutura de repetição -->
                    <?php do { ?>
                        <tr>

                            

                            <!-- Início Botões -->
                            <td>
                                <!-- Início botão analisar -->
                                <a href="mostrar_chamado.php?id_chamado=<?php echo $row['id_chamado']; ?>" class="btn largButton btn-warning btn mt-2">
                                    <span><i class="bi bi-list-task">&nbsp;</i>Analisar</span>
                                </a>
                                <!-- Fim botão analisar -->
                                <!-- Início botão excluir -->
                                <button class="btn btn-danger largButton delete mt-2" role="button" data-nome="<?php echo $row['protocolo_chamado']; ?>" data-id="<?php echo $row['id_chamado']; ?>" data-bs-toggle="modal" data-bs-target="#myModal">
                                    <span class=""><i class="bi bi-x-circle-fill">&nbsp;</i>Cancelar</span>
                                </button>
                                <!-- Fim botão excluir -->
                            </td>
                            <!-- Fim Botões -->
                        </tr>
                </tbody>
                <!-- Fim corpo da tabela -->
            <?php  } while ($row = $result_descarte->fetch(PDO::FETCH_ASSOC));} ?>
            </table>
            <!-- Fim da tabela --> 

        </main>


    <footer class=" container pt-5 my-5">
        <div class=" pt-5 my-5">
            <?php include('footer_adm.php'); ?>
        </div>
    </footer>

</body>

</html>