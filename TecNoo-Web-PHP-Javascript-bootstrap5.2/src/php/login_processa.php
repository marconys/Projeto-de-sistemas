<?php
session_start();
//Inicia conexão com o banco de dados
include('../connection/conn.php');

// inicia verificação do login do usuário adm
if ($_POST) {

    // verifica login e senha recebidos
    $login_usuario = addslashes($_POST['login']);
    $senha_usuario = addslashes($_POST['senha']);


    $verificaUser = "SELECT * FROM tbusuarios WHERE login_usuario = '$login_usuario'";
    //Prepara a query e atribui a variável $result_session
    $result_session = $conn->prepare($verificaUser);
    //Executa a query
    $result_session->execute();
    //Retorna uma matriz associativa e atribui a variável $row 
    $row = $result_session->fetch(PDO::FETCH_ASSOC);
    // se a sessão não exixtir, iniciamos uma sessão
    if (!isset($_SESSION)) {
        $session_old = session_name("TecNoo");
        session_start();
        $session_name_new = session_name(); // recupera o nome atual
    }
    if ($row != null && password_verify($senha_usuario, $row['senha_usuario'])) {
        $_SESSION['login'] = $login_usuario;
        $_SESSION['nivel_usuario'] = $row['nivel_usuario'];
        $_SESSION['id_nivel_usuario'] = $row['id_nivel_usuario'];
        $_SESSION['id_usuario'] = $row['id_usuario'];
        $_SESSION['session_name'] = session_name();
        echo "<script>window.open('../adm/index.php','_self')</script>";

        // inicia verificação do login do usuário cliente
    } else if ($_POST) {

        //Verifica login e senha recebidos do cliente

        $login_cliente = $_POST['login'];
        $senha_cliente = $_POST['senha'];

        $verificaUser = "SELECT * FROM tbcliente WHERE email_cliente = '$login_cliente'";
        //Prepara a query e atribui a variável $result_session
        $result_session = $conn->prepare($verificaUser);
        //Executa a query
        $result_session->execute();
        //Retorna uma matriz associativa e atribui a variável $row 
        $row = $result_session->fetch(PDO::FETCH_ASSOC);

        // se a sessão não exixtir, iniciamos uma sessão
        if (!isset($_SESSION)) {
            $session_old = session_name("TecNoo");
            session_start();
            $session_name_new = session_name(); // recupera o nome atual
        }
        if ($row != null && password_verify($senha_cliente, $row['senha_cliente'])) {
            $_SESSION['login'] = $login_cliente;
            $_SESSION['id_tipo_cliente'] = $row['id_tipo_cliente'];
            $_SESSION['id_cliente'] = $row['id_cliente'];
            $_SESSION['session_name'] = session_name();
            echo "<script>window.open('../client/index.php','_self')</script>";
            
        

        } else {
            echo "<script>window.open('invasor.php','_self')</script>";
        }
    }
}
