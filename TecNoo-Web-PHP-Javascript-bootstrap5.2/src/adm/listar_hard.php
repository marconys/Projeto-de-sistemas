<?php
//inclui conexão com o banco de dados    
require_once('../connection/conn.php');
//Inclui variável de ambiente
include('../php/config_global.php');

$query_descarte = "SELECT * FROM tbdescarte ORDER BY data_abertura_descarte DESC";

    //Prepara a query
    $result_descarte = $conn->prepare($query_descarte);
    //Executa a query
    $result_descarte->execute();
    //Retorna uma matriz associativa e atribui a variável $row 
    $row = $result_descarte->fetch(PDO::FETCH_ASSOC);
    //var_dump($row);

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
                    Descartes
                </h1>
            </a>
        </div>
            <!-- Início da tabela -->
            <table class="table table-dark table-hover">
                <!-- Início do cabeçalho da tabela -->
                <thead>
                    <tr>
                        <th>ID:</th>
                        <th>Protocolo:</th>
                        <th>Descrição:</th>
                        <th>Nome hardware:</th>
                        <th>ID cliente:</th>
                        <th>Data de abertura:</th>
                        <th>Data de retirada:</th>
                        <th>Data prazo retirada:</th>
                        <th>Foto:</th>
                        <th>Status:</th>
                        
                        <th class="largButton">
                            <a href="listar_hard.php" class="btn largButton btn-warning btn">
                                <span><i class="bi bi-arrow-clockwise"></i> Atualizar</span>


                            </a>
                        </th>
                    </tr>
                </thead>
                <!-- Fim do cabeçalho da tabela -->
                <?php if ($row == 0) {
                    echo "<div class='alert alert-danger mt-5 p-2 rounded' role='alert'>
                    <h1><span><i class='bi bi-emoji-frown'></i> Não há nenhum hardware ainda!</span></h1>
                </div>";
                }else {?>
                <!-- Início corpo da tabela -->
                <tbody>
                    <!-- Abri estrutura de repetição -->
                    <?php do { ?>
                        <tr>
                            
                            <!-- Início ID -->
                            <td>
                                <?php echo $row['id_descarte']; ?>
                            </td>
                            <!-- Fim ID -->
                            <!-- Início protocolo -->
                            <td>
                                <?php echo $row['protocolo_descarte']; ?>
                            </td>
                            <!-- Fim protocolo -->
                            <!-- Início descricao -->
                            <td>
                                <?php echo $row['descri_descarte']; ?>
                            </td>
                            <!-- Fim descricao -->
                            <!-- Início nome -->
                            <td>
                                <?php echo $row['nome_hard_chamado']; ?>
                            </td>
                            <!-- Fim nome -->
                            <!-- Início ID cliente-->
                            <td>
                                <?php echo $row['id_cliente_descarte']; ?>
                            </td>
                            <!-- Fim ID cliente -->
                            <!-- Início data abertura descarte -->
                            <td>
                                <?php echo $row['data_abertura_descarte']; ?>
                            </td>
                            <!-- Fim data abertura descarte -->
                            <!-- Início data retirada descarte -->
                            <td>
                                <?php echo $row['data_retirada_descarte']; ?>
                            </td>
                            <!-- Fim data retirada descarte -->
                            <!-- Início prazo retirada descarte -->
                            <td>
                                <?php echo $row['prazo_retirada_descarte']; ?>
                            </td>
                            <!-- Fim prazo retirada descarte -->
                            <!-- Início foto -->
                            <td>
                                <img src="<?php echo $row['foto_hard_descarte'];?>" alt="" width="100px">
                            </td>
                            <!-- Fim foto -->
                            <!-- Início status descarte -->
                            <td>
                                <?php echo $row['status_descarte']; ?>
                            </td>
                            <!-- Fim status descarte -->
                            <!-- Fim Login -->
                            <!-- Início Botões -->
                            <td>
                                <!-- Início botão analizar -->
                                <a href="mostrar_descarte.php?id_descarte=<?php echo $row['id_descarte']; ?>" class="btn largButton btn-warning btn mt-2">
                                    <span><i class="bi bi-list-task">&nbsp;</i>Analisar</span>
                                </a>
                                <!-- Fim botão analisar -->
                                <!-- Início botão excluir -->
                                <button class="btn btn-danger largButton delete mt-2" role="button" data-nome="<?php echo $row['protocolo_descarte']; ?>" data-id="<?php echo $row['id_descarte']; ?>" data-bs-toggle="modal" data-bs-target="#myModal">
                                    <span class=""><i class="bi bi-trash-fill"></i>Excluir</span>


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