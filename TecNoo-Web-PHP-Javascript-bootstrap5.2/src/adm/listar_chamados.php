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
    n.telefone_cliente
    FROM tbchamados u INNER JOIN tbcliente n ON u.id_cliente_chamado = n.id_cliente";

    //Prepara a query
    $result_chamados = $conn->prepare($query_chamados);
    //Executa a query
    $result_chamados->execute();
    //Retorna uma matriz associativa e atribui a variável $row 
    $row = $result_chamados->fetch(PDO::FETCH_ASSOC);
    //var_dump($row);


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
        <title><?php echo TECNOO; ?>&nbsp; Listar Chamados</title>
    </head>

    <body class="bgMain-interno">
        <?php include('menu_adm.php');?>
        

        <main class="container pt-5">

        <div class="container alert alert-primary p-4 rounded my-4">
            <a href="index.php" class="text-decoration-none">
                <h1 class="text-dark">
                <i class="bi bi-arrow-left-square-fill"></i>
                    Chamados
                </h1>
            </a>
        </div>
            <!-- Início da tabela -->
            <table class="table table-dark table-hover">
                <!-- Início do cabeçalho da tabela -->
                <thead>
                    <tr>
                        <th class="foto_erro">FOTO:</th>
                        <th>ID:</th>
                        <th>Nome cliente:</th>
                        <th>Telefone:</th>
                        <th>Protocolo:</th>
                        <th>Descrição:</th>
                        <th>Data De Abertura:</th>
                        <th>Status Do Chamado:</th>
                        <th class="largButton">
                            <a href="add_usuario.php" class="btn largButton btn-primary btn">
                                <span><i class="bi bi-plus-square-fill">&nbsp;</i>Adicionar</span>


                            </a>
                        </th>
                    </tr>
                </thead>
                <!-- Fim do cabeçalho da tabela -->
                <?php if ($row == 0) {
                    echo "<div class='alert alert-danger mt-5 p-2 rounded' role='alert'>
                    <h1><span><i class='bi bi-emoji-frown'></i> Não existe chamado cadastrado!!</span></h1>
                </div>";
                }else {?>
                <!-- Início corpo da tabela -->
                <tbody>
                    <!-- Abri estrutura de repetição -->
                    <?php do { ?>
                        <tr>
                            <!-- Início foto -->
                            <td>
                                <img src="../img/foto_chamado_cliente/<?php echo $row['foto_erro_chamado'];?>" alt="" width="100px">
                            </td>
                            <!-- Fim foto -->
                            <!-- Início ID -->
                            <td>
                                <?php echo $row['id_chamado']; ?>
                            </td>
                            <!-- Fim ID -->
                            <!-- Início nome cliente -->
                            <td>
                                <?php echo $row['nome_cliente']; ?>
                            </td>
                            <!-- Fim nome cliente -->
                            <!-- Início telefone cliente -->
                            <td>
                                <?php echo $row['telefone_cliente']; ?>
                            </td>
                            <!-- Fim telefone cliente -->
                            
                            <!-- Início Nome -->
                            <td>
                                <?php echo $row['protocolo_chamado']; ?>
                            </td>
                            <!-- Fim Nome -->
                            <!-- Início E-mail -->
                            <td>
                                <?php echo $row['descri_chamado']; ?>
                            </td>
                            <!-- Fim E-mail -->
                            <!-- Início Login -->
                            <td>
                                <?php echo $row['data_abertura_chamado']; ?>
                            </td>

                            
                            <!-- Fim Login -->
                            <!-- Início Nível -->
                            <td>
                                <?php 
                                if ($row['status_chamado'] == 'aguardando Equipamento') {
                                    echo ("<span><i class='bi bi-briefcase-fill'></i></span>");

                                }else if($row['status_chamado'] == 'Em Analise'){
                                    echo ("<span><i class='bi bi-headset'></i></span>");

                                }else if($row['status_chamado'] == 'Finalizado'){
                                    echo ("<span><i class='bi bi-screwdriver'></i></span>");
                                }else if($row['status_chamado'] == 'Cancelado'){
                                    echo ("<span><i class='bi bi-screwdriver'></i></span>");
                                }
                                else{
                                    echo ("<span><i class='text-danger bi bi-person-x-fill'></i></span>");
                                }
                                ?>
                                <?php echo $row['status_chamado']; ?>
                            </td>
                            <!-- Início Nível -->
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
            <?php  } while ($row = $result_chamados->fetch(PDO::FETCH_ASSOC));} ?>
            </table>
            <!-- Fim da tabela -->

            <footer class=" container pt-5 my-5">
        <div class=" pt-5 my-5">
            <?php include('footer_adm.php'); ?>
        </div>
    </footer>

        </main>

        <!-- Início Modal -->
        <div id="myModal" class="modal fade" tabindex="-1">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title text-danger">Atenção!</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <p>Deseja realmente <strong> cancelar </strong> o chamado?</p>
                        <h3><span class="text-danger nome"></span></h3>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Cancelar</button>
                        <a href="#" type="button" class="btn btn-danger delete-yes">Confirmar</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- Fim Modal -->


        <!-- Link arquivos Bootstrap js -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
        <!-- Links para incluir popper -->
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-oBqDVmMz9ATKxIep9tiCxS/Z9fNfEXiDAYTujMAeBAsjFuCZSmKbSSUnQlmh/jp3" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.min.js" integrity="sha384-IDwe1+LCz02ROU9k972gdyvl+AESN10+x7tBKgc9I5HFtuNz0wWnPclzo6p9vxnk" crossorigin="anonymous"></script>
        <!-- Link para incluir ajax/jquery -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>

        <!-- Script para o modal -->
        <script type="text/javascript">
            $('.delete').on('click', function() {
                //Busca o valor do atributo data-nome
                var nome = $(this).data('nome');
                //Busca o valor do atributo data-id
                var id = $(this).data('id');
                //Insere o nome do item na confirmação do modal
                $('span.nome').text(nome);
                //Envia o id através do link do butão confirmar
                $('a.delete-yes').attr('href', 'excluir_usuario.php?id_usuario =' + id);
                console.log(id);
                //Abre o Modal
                $('#myModal').modal('show');

            });
        </script>
    </body>

    </html>