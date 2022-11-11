<?php
    //inclui conexão com o banco de dados
    include('../connection/conn.php');
    //Inclui variável de ambiente
    include('../php/config_global.php');

    $query_chamados = "SELECT u.id_cliente,
    u.id_cliente,
    u.nome_cliente,
    u.cpf_cliente,
    u.telefone_cliente,
    u.cnpj_cliente,
    u.razao_social_cliente,
    u.id_tipo_cliente,
    u.id_contrato_cliente,
    u.email_cliente,
    u.senha_cliente,
    n.id_contrato,
    n.nome_contrato
    FROM tbcliente u INNER JOIN tbcontratos n ON u.id_cliente = n.id_contrato";

    //Prepara a query
    $result_descarte = $conn->prepare($query_chamados);
    //Executa a query
    $result_descarte->execute();
    //Retorna uma matriz associativa e atribui a variável $row 
    $row = $result_descarte->fetch(PDO::FETCH_ASSOC);
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
        <title><?php echo TECNOO; ?>&nbsp; Listar Descartes</title>
    </head>

    <body class="bgMain">
        <?php include('menu_adm.php');?>
        

        <main class="container pt-5">

        <div class="container alert alert-primary p-4 rounded my-4">
            <a href="index.php" class="text-decoration-none">
                <h1 class="text-dark">
                <i class="bi bi-arrow-left-square-fill"></i>
                    Clientes
                </h1>
            </a>
        </div>
            <!-- Início da tabela -->
            <table class="table table-dark table-hover">
                <!-- Início do cabeçalho da tabela pessoa fisica -->
                <thead>
                    <tr>
                        <th>ID:</th>
                        <th>ID contrato:</th>
                        <th>Cpf Cliente:</th> 
                        <th>Nome cliente:</th>
                        <th>Email:</th>
                        <th>Cnpj cliente:</th>
                        <th>ID Tipo cliente:</th>
                        <th class="largButton">
                            <a href="novo_descarte_cliente.php" class="btn largButton btn-primary btn">
                                <span><i class="bi bi-plus-square-fill"></i> Adicionar</span>


                            </a>
                        </th>
                    </tr>
                </thead>
                <!-- Fim do cabeçalho da tabela -->
                <?php if ($row == 0) {
                    echo "<div class='alert alert-danger mt-5 p-2 rounded' role='alert'>
                    <h1><span><i class='bi bi-emoji-frown'></i> Não existe usuário cadastrado!!</span></h1>
                </div>";
                }else {?>
                <!-- Início corpo da tabela -->
                <tbody>
                    <!-- Abri estrutura de repetição -->
                    <?php do { ?>
                        <tr>
                            <!-- Início ID -->
                            <td>
                                <?php echo $row['id_cliente']; ?>
                            </td>
                            <!-- Fim ID -->
                            <!-- Início id contrato -->
                            <td>
                                <?php echo $row['id_contrato_cliente']; ?>
                            </td>
                            <!-- Fim id contrato -->
                            <!-- Início cpf -->
                            <td>
                                <?php echo $row['cpf_cliente']; ?>
                            </td>
                            <!-- Fim cpf -->
                            <!-- Início nome cliente -->
                            <td>
                                <?php echo $row['nome_cliente']; ?>
                            </td>
                            <!-- Fim nome cliente -->
                            <!-- Início Email -->
                            <td>
                                <?php echo $row['email_cliente']; ?>
                            </td>
                            <!-- Fim Email -->
                            <!-- Início cnpj -->
                            <td>
                                <?php echo $row['cnpj_cliente']; ?>
                            </td>
                            <!-- Fim cnpj -->
                            <!-- Início tipo cliente -->
                            <td>
                                <?php echo $row['id_tipo_cliente']; ?>
                            </td>
                            <!-- Fim tipo cliente -->
                            <!-- Início Botões -->
                            <td>
                                <!-- Início botão excluir -->
                                <button class="btn btn-danger largButton delete mt-2" role="button" data-nome="<?php echo $row['nome_cliente']; ?>" data-id="<?php echo $row['id_cliente']; ?>" data-bs-toggle="modal" data-bs-target="#myModal">
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
                        <p>Deseja realmente <strong> Desligar </strong> o cliente?</p>
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