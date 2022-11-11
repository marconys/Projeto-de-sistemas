<?php

session_start();

require_once('Usuario.php');
require_once('Cliente.php');

use Tecnoo\TecnooWeb\class\Cliente;
use Tecnoo\TecnooWeb\class\Usuario;
// inicia verificação do login do usuário adm
if ($_POST) {
    // verifica login e senha recebidos
    $login_usuario = addslashes($_POST['login']);
    $senha_usuario = addslashes($_POST['senha']);

    //Verifica login e senha recebidos do cliente
    $login_cliente = $_POST['login'];
    $senha_cliente = $_POST['senha'];
    $nivel = "";

    $user = new Usuario();
    $client = new Cliente();

    if ($user->login($login_usuario, $senha_usuario) == true) {

        $dados = array(
            'id_us'    => $user->getId_User(),
            'nome_us'  => $user->getNome_User(),
            'login_us' => $user->getLogin_user(),
            'id_nivel_us' => $user->getId_nivel_User()
        );

        if (count($dados) > 0) {
            $_SESSION['id_us'] = $user->getId_User();
            $_SESSION['nome_us'] = $user->getNome_User();
            $_SESSION['id_nivel_us'] = $user->getId_nivel_User();

            if ($_SESSION['id_nivel_us'] != 4) {

                echo "<script>window.open('../adm/index.php','_self')</script>";
            } else {
                header('Location: ../pages/invasor.php');
                //Cria variável global para salvar a menssagem de erro
                $_SESSION['msg'] = "<p style='color:#f00;'> Acesso negado!! Usuário sem permissão!</p>";
            }
        }
    } else if ($client->login($login_cliente, $senha_cliente) == true) {

        $dados = array(
            'id_cl'    => $client->getId_Cli(),
            'nome_cl'  => $client->getNome_Cli(),
            'email_cl' => $client->getEmail_Cli(),
            'id_cli_contrato' => $client->getId_contrato_Cli()
        );
        if (count($dados) > 0) {
            $_SESSION['id_cl'] = $client->getId_Cli();
            $_SESSION['nome_cl'] = $client->getNome_Cli();
            //Verifica o id contrato
            if ($client->getId_contrato_Cli() == 1) {
                $nivel = "Diamante";
                $_SESSION['id_cli_contrato'] = $nivel;
            }else if ($client->getId_contrato_Cli() == 2) {
                $nivel = "Ouro";
                $_SESSION['id_cli_contrato'] = $nivel;
            }else if ($client->getId_contrato_Cli() == 3) {
                $nivel = "Prata";
                $_SESSION['id_cli_contrato'] = $nivel;
            }else{
                $nivel = "Sem Contrato";
                $_SESSION['id_cli_contrato'] = $nivel;
            }
            echo "<script>window.open('../client/index.php','_self')</script>";
        }
    } else {
        header('Location: ../pages/invasor.php');
        //Cria variável global para salvar a menssagem de erro
        $_SESSION['msg'] = "<p style='color:#f00;'> Ops!! Usuario ou Senha incorretos!</p>";
    }
}
