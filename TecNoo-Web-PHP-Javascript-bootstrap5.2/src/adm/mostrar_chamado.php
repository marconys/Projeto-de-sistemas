<?php
    //inclui conexão com o banco de dados
    include('../connection/conn.php');
    //Inclui variável de ambiente
    include('../php/config_global.php');

    $query_chamados = "SELECT u.id_chamado,
    u.protocolo_chamado,
    u.descri_chamado,
    u.titulo_chamado,
    u.data_abertura_chamado,
    u.data_limite_chamado,
    u.status_chamado,
    u.foto_erro_chamado,
    n.nome_cliente,
    n.telefone_cliente,
    u.id_cliente_chamado,
    u.prioridade_chamado,
    u.local_atend_chamado
    FROM tbchamados u INNER JOIN tbcliente n ON u.id_cliente_chamado = n.id_cliente";

    //Prepara a query
    $result_chamados = $conn->prepare($query_chamados);
    //Executa a query
    $result_chamados->execute();
    //Retorna uma matriz associativa e atribui a variável $row 
    $row = $result_chamados->fetch(PDO::FETCH_ASSOC);
    //var_dump($row);

    if ($_POST) {
 
        //Receber os dados do formulário
        //organizar os campos na mesma ordem
        $id_chamado = $_POST['id_chamado'];
    
    
        //Campo do form para filtar o registro
        $id_filtro = $_POST['id_chamado'];
    
        //Consulta(query) Sql para inserção dos dados
        $query = "update tbchamados
         set status_chamado = '" . $id_chamado . "'                         
          where id_chamado = " . $id_filtro . ";";
    
        $resultado = $conn->query($query);
    
    }
    
    //Consulta para recuperar dados do filtro da chamada da página...
    $id_alterar = $_GET['id_chamado'];
    $query_busca = "select * from tbchamados where id_chamado = " . $id_alterar;
    $lista = $conn->query($query_busca);
    $row = $lista->fetch(PDO::FETCH_ASSOC);
    $totalLinhas = $lista->num_rows;



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
    <title><?php echo TECNOO; ?>&nbsp; Novo chamado</title>
</head>

<body class="bgMain">

    <main class="container pt-5">

    <?php include('menu_adm.php')?>

        <div class="container alert alert-primary p-4 rounded my-4">
            <a href="listar_chamados.php" class="text-decoration-none">
                <h1 class="text-dark">
                <i class="bi bi-arrow-left-square-fill"></i>
                    Chamado Cliente
                </h1>
            </a>
        </div>

        <div class="col-md-6 offset-md-3">
            <form class="form-group alert alert-warning" action="novo_chamado_cliente.php" method="post" enctype="multipart/form-data">
                <div class=" form-control form-group bg-secondary">
                    
                    
                    <!-- Fnicio id chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">ID Chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['id_chamado']?>" readonly>
                    </div>
                    <!-- Fim id chamado -->
                    <!-- Fnicio cliente chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">ID Cliente Chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['id_cliente_chamado']?>" readonly>
                    </div>
                    <!-- Fim cliente chamado -->
                    <!-- Fnicio protocolo chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Protocolo Chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['protocolo_chamado']?>" readonly>
                    </div>
                    <!-- Fim protocolo chamado -->
                    <!-- Fnicio titulo chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Título do Problema:</label>
                        <input type="text" class="form-control" value="<?php echo $row['titulo_chamado']?>" readonly>
                    </div>
                    <!-- Fim titulo chamado -->
                    <!-- Inicio descrição chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Descrição Chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['descri_chamado']?>" readonly>
                    </div>
                    <!-- Fim descrição chamado -->
                    <!-- Inicio data abertura chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Data abertura chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['data_abertura_chamado']?>" readonly>
                    </div>
                    <!-- Fim data abertura chamado -->
                    <!-- Inicio data limite chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Data limite Chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['data_limite_chamado']?>" readonly>
                    </div>
                    <!-- Fim data limite chamado -->
                    <!-- Inicio status chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Status Chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['status_chamado']?>">
                    </div>
                    <!-- Fim status chamado -->
                    <!-- Inicio prioridade chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Prioridade Chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['prioridade_chamado']?>" readonly>
                    </div>
                    <!-- Fim prioridade chamado -->
                    <!-- Inicio local atend chamado -->
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Local atendimento chamado:</label>
                        <input type="text" class="form-control" value="<?php echo $row['local_atend_chamado']?>" readonly>
                    </div>
                    <!-- Fim local atend chamado -->
                    <br>
                    <!-- Início foto -->
                    <div>
                        <label class="h5">Foto erro chamado:</label><br>
                        <img class="border border-dark" src="../img/fotos_de_tudo/<?php echo $row['foto_erro_chamado'];?>" alt="" width="200px">
                    </div>
                    <!-- Fim foto -->

                    <div class="form-group ">
                        <input class="form-control btn btn-warning mt-2" type="submit" value="Alterar" id="enviar" name="enviar">
                    </div>
                </div>
            </form>
        </div>

        <footer class=" container pt-5 my-5">
        <div class=" pt-5 my-5">
            <?php include('footer_adm.php'); ?>
        </div>
    </footer>

    </main>



    <!-- Link arquivos Bootstrap js -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>

</body>

</html>