
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
    if (isset($_FILES['foto_erro_chamado'])) {
        $img_usuario = $_FILES['foto_erro_chamado'];
        $pasta_img = "../img/foto_chamado_cliente/";
        $nome_img = $img_usuario['name'];

        //gera um nome aletório e único para a imagem
        $novoNomeImg = uniqid();

        //verifica e coverte a extensão se maiúsculo para minúsculo
        $extensao = strtolower(pathinfo($nome_img, PATHINFO_EXTENSION));

        $novoNomeImgExtensao = $novoNomeImg . "." . $extensao;
        
        //move o arquivo para a pasta do servidor
        move_uploaded_file($img_usuario['tmp_name'], $pasta_img . $novoNomeImgExtensao);
    }

    //QUERY PARA INSERIR NOVO CHAMADO
    $query_chamados = "INSERT INTO tbchamados (titulo_chamado, prioridade_chamado, descri_chamado, data_abertura_chamado, local_atend_chamado, foto_erro_chamado, protocolo_chamado, id_cliente_chamado, data_limite_chamado, status_chamado) 
    VALUES(:titulo_chamado, :prioridade_chamado, :descri_chamado, :data_abertura_chamado, :local_atend_chamado, :foto_erro_chamado, :protocolo_chamado, :id_cliente_chamado, :data_limite_chamado, :status_chamado)";
    
    $cad_chamados = $conn->prepare($query_chamados);

    //Verifica tipo de atendimento e atribui valor ao status_chamado
    if ($dados['local_atend_chamado'] == "Presencial") {
        $status = "Aguardando visita";        
        $data_limite = date('Y-m-d H:i:s', strtotime(' + 3 hours'));

    }else if($dados['local_atend_chamado'] == "Remoto"){
        $status = "Aguardando contato";
        $data_limite = date('Y-m-d H:i:s', strtotime(' + 2 hours'));
    }else{
        $status = "Aguardando equipamento";
        $data_limite = date('Y-m-d H:i:s', strtotime(' + 72 hours'));
    }

    //Verifica o atual estado do equipamento e atribui valor ao prioridade_chamado
    if ($dados['prioridade_chamado'] == "baixa") {
        $prioridade = "Baixa";

    }else if($dados['prioridade_chamado'] == "media"){
        $prioridade = "Media";
    }else{
        $prioridade = "Alta";   
     }

     $protocolo = uniqid();

    $cad_chamados->bindParam(':titulo_chamado', $dados['titulo_chamado'], PDO::PARAM_STR);
    $cad_chamados->bindParam(':prioridade_chamado', $prioridade, PDO::PARAM_STR);
    $cad_chamados->bindParam(':descri_chamado', $dados['descri_chamado'], PDO::PARAM_STR);
    $cad_chamados->bindParam(':data_abertura_chamado', $data_hora, PDO::PARAM_STR);
    $cad_chamados->bindParam(':local_atend_chamado', $dados['local_atend_chamado'], PDO::PARAM_STR);
    $cad_chamados->bindParam(':foto_erro_chamado', $novoNomeImgExtensao, PDO::PARAM_STR);
    $cad_chamados->bindParam(':protocolo_chamado', $protocolo, PDO::PARAM_STR);
    $cad_chamados->bindParam(':id_cliente_chamado', $id_logado, PDO::PARAM_INT);
    $cad_chamados->bindParam(':data_limite_chamado', $data_limite, PDO::PARAM_STR);
    $cad_chamados->bindParam(':status_chamado', $status, PDO::PARAM_STR);
         

    if ($cad_chamados->execute()) {
        header("location: msg_alert_cliente.php");
        //Cria variável global para salvar a menssagem de sucesso
        $_SESSION['msg'] = "<p style='color:green;'>Tudo Certo!!<br>Chamado cadastrado com sucesso!</P> ";
    } else {
        //Cria variável global para salvar a menssagem de erro
        $_SESSION['msg'] = "<p style='color:#f00;'> Erro: Ops!! Erro ao abrir chamado!</p>";

        header("location: msg_alert_cliente.php");
    }

}




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

    <main class="">

    

        <div class="container alert alert-primary p-4 rounded my-4">
            <a href="index.php" class="text-decoration-none">
                <h1 class="text-dark">
                <i class="bi bi-arrow-left-square-fill"></i>
                    Novo Chamado
                </h1>
            </a>
        </div>

        <div class="col-md-6 offset-md-3">
            <form class="form-group alert alert-success" action="novo_chamado_cliente.php" method="post" enctype="multipart/form-data">
                <div class=" form-control form-group bg-secondary">
                    <div class="form-group">
                        <label class="h5" for="titulo_chamado">Título do Problema:</label>
                        <input type="text" class="form-control" name="titulo_chamado" id="titulo_chamado" maxlength="30">
                    </div>

                    <div class="form-group">
                        <label class="h5 mt-2" for="prioridade_chamado">Qual o atual estado do seu equipamento?</label><br>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="prioridade_chamado" id="prioridade_chamado" value="baixa">
                            <label class="form-check-label" for="estado-hardware">Funcionando</label>
                        </div>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="prioridade_chamado" id="prioridade_chamado" value="media">
                            <label class="form-check-label" for="estado-hardware">Funcionando Parcialmente</label>
                        </div>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="prioridade_chamado" id="prioridade_chamado" value="alta">
                            <label class="form-check-label" for="estado-hardware">Não funciona</label>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="h5 mt-2" for="descri_chamado">Descrição do Problema:</label><br>
                        <textarea class="form-control" name="descri_chamado" id="descri_chamado" rows="5" maxlength="500"></textarea>
                    </div>

                    <div class="form-group">
                        <label class="h5 mt-2" for="local_atend_chamado">Como deseja ser atendido?</label><br>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="local_atend_chamado" id="local_atend_chamado" value="Presencial">
                            <label class="form-check-label" for="local_atend_chamado">No domicílio</label>
                        </div>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="local_atend_chamado" id="local_atend_chamado" value="Laboratorio">
                            <label class="form-check-label" for="local_atend_chamado">No laboratório</label>
                        </div>
                        <div class="form-check form-check-inline">
                            <input class="form-check-input" type="radio" name="local_atend_chamado" id="local_atend_chamado" value="Remoto">
                            <label class="form-check-label" for="local_atend_chamado">Remoto</label>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="h5 mt-2" for="foto_erro_chamado">Anexo:</label><br>
                        <img src="" alt="" name="foto" id="foto" class="img-responsive">
                        <input class="form-control" type="file" id="foto_erro_chamado" name="foto_erro_chamado" accept="image/*">
                    </div>

                    <div class="form-group">
                        <input class="form-control btn btn-primary mt-2" type="submit" value="Enviar" id="enviar" name="enviar">
                    </div>
                </div>
            </form>
        </div>

        <footer class=" container pt-5 my-5">
        <div class=" pt-5 my-5">
            <?php include('footer_cliente.php'); ?>
        </div>
    </footer>

    </main>



    <!-- Link arquivos Bootstrap js -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>

</body>

</html>