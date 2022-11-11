<?php 
session_start();
//inclui conexão com o banco de dados
include('../connection/conn.php');
//Inclui variável de ambiente
include('../php/config_global.php');

//Atribui os campos recebidos a variável $dados
$dados = filter_input_array(INPUT_POST, FILTER_DEFAULT);

//busca o id do cliente logado
$id_logado = $_SESSION['id_cl'];

//Define um fuso horário padrão
date_default_timezone_set('America/Sao_Paulo');
//captura a data atual com um fuso horário padrão
$date = new DateTime(); //data agora
$date->setTimezone(new DateTimeZone('America/Sao_Paulo'));
$data_hora = $date->format("Y-m-d h:i:s"); //data agora formatado


if ($_POST) {

    //Verifica se há envio de arquivo de foto
    if (isset($_FILES['foto'])) {
        $img_usuario = $_FILES['foto'];
        $pasta_img = "../img/foto_descarte_cliente/";
        $nome_img = $img_usuario['name'];

        //gera um nome aletório e único para a imagem
        $novoNomeImg = uniqid();

        //verifica e coverte a extensão se maiúsculo para minúsculo
        $extensao = strtolower(pathinfo($nome_img, PATHINFO_EXTENSION));

        $novoNomeImgExtensao = $novoNomeImg . "." . $extensao;
        
        //move o arquivo para a pasta do servidor
        move_uploaded_file($img_usuario['tmp_name'], $pasta_img . $novoNomeImgExtensao);
    }

    
// Gera protocolo
    $protocolo = uniqid();

    $status = "Aguardando Analise";

    $data_retirada = date('Y-m-d H:i:s', strtotime(' + 72 hours'));

    //QUERY PARA INSERIR NOVO CHAMADO
    $query_descarte = "INSERT INTO tbdescarte (protocolo_descarte, nome_hard_chamado, descri_descarte, data_abertura_descarte, foto_hard_descarte, id_cliente_descarte,  data_retirada_descarte, prazo_retirada_descarte, status_descarte) 
    VALUES(:protocolo_descarte, :nome_hard_chamado, :descri_descarte, :data_abertura_descarte, :foto_hard_descarte, :id_cliente_descarte, :data_retirada_descarte, :prazo_retirada_descarte, :status_descarte)";
    
    $cad_descarte = $conn->prepare($query_descarte);

    $cad_descarte->bindParam(':protocolo_descarte', $protocolo, PDO::PARAM_STR);
    $cad_descarte->bindParam(':nome_hard_chamado', $dados['nome-hardware'], PDO::PARAM_STR);
    $cad_descarte->bindParam(':descri_descarte', $dados['descricao'], PDO::PARAM_STR);
    $cad_descarte->bindParam(':data_abertura_descarte', $data_hora, PDO::PARAM_STR);
    $cad_descarte->bindParam(':foto_hard_descarte', $novoNomeImgExtensao, PDO::PARAM_STR);
    $cad_descarte->bindParam(':id_cliente_descarte', $id_logado, PDO::PARAM_INT);
    $cad_descarte->bindParam(':data_retirada_descarte', $data_retirada, PDO::PARAM_STR);
    $cad_descarte->bindParam(':prazo_retirada_descarte', $data_retirada, PDO::PARAM_STR);
    $cad_descarte->bindParam(':status_descarte', $status, PDO::PARAM_STR);
         

    if ($cad_descarte->execute()) {
        header("location: msg_alert_descarte.php");
        //Cria variável global para salvar a menssagem de sucesso
        $_SESSION['msg'] = "<p style='color:green;'>Tudo Certo!!<br>Descarte cadastrado com sucesso!</P> ";
    } else {
        //Cria variável global para salvar a menssagem de erro
        $_SESSION['msg'] = "<p style='color:#f00;'> Erro: Ops!! Erro ao cadastrar o Descarte!</p>";

        header("location: msg_alert_descarte.php");
    }


}




?>

<!DOCTYPE html>
<html lang="pt-BR">

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
    <title>Descarte</title>
</head>

<body class="bgMain-interno">

    <main class="contaimer">

        <div class="container alert alert-success p-4 rounded my-4">
            <a href="index.php" class="text-decoration-none">
            <h1 class="text-dark">
                <i class="bi bi-arrow-left-square-fill"></i>
                    Hardware Solidário
                </h1>
            </a>
        </div>

        <div class="col-md-6 offset-md-3">
            <form class="form-control alert alert-success" action="novo_descarte_cliente.php" method="post" enctype="multipart/form-data">
                <div class=" form-control form-group  bg-secondary">
                    <!-- input -->
                        <label class="h5" for="nome-hardware">Qual Hardware deseja descartar?</label>
                        <input type="text" class="form-control" name="nome-hardware" id="nome-hardware" maxlength="30">
                    

                    <div class="form-group">
                    <label class="h5 mt-2" for="nome-hardware">Qual o atual estado desse hardware?</label><br>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="estado-hardware" id="funcok" value="0">
                            <label class="form-check-label" for="estado-hardware">Funcionando</label>
                        </div>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="estado-hardware" id="funcparcial" value="1">
                            <label class="form-check-label" for="estado-hardware">Funcionando Parcialmente</label>
                        </div>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="estado-hardware" id="naofunc" value="2">
                            <label class="form-check-label" for="estado-hardware">Não funciona</label>
                        </div>
                    </div>

                    <div class="form-group">
                    <label class="h5 mt-2" for="descricao">Descrição:</label><br>
                    <textarea class="form-control" name="descricao" id="descricao" rows="5" maxlength="500"></textarea>
                    </div>

                    <div class="form-group">
                    <label class="h5 mt-2" for="nome-hardware">Foto do Hardware:</label><br>
                    <input class="form-control" type="file" id="foto" name="foto">
                    </div>

                    <div class="form-group">
                    <input class="form-control btn btn-primary mt-2" type="submit" value="Enviar" id="enviar" name="enviar">
                    </div>
                </div>
            </form>
        </div>

    </main>



    <!-- Link arquivos Bootstrap js -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>

</body>

</html>