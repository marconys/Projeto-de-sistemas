<?php 
session_start();
//inclui conexão com o banco de dados
//include('../connection/conn.php');
include('../class/Sql.php');
//Inclui variável de ambiente
include('../php/config_global.php');

require_once('../class/Usuario.php');

    use Tecnoo\TecnooWeb\class\Usuario;

//captura o ID que veio na url e atribui a variável $id_user
$id_user = filter_input(INPUT_GET, 'id_usuario', FILTER_SANITIZE_NUMBER_INT);


//Instancia um objeto a partir da classe Usuario
$del_usuarios = new Usuario();

//Verifica se s query foi executada e o usuário excluido;
if($del_usuarios->delete($id_user)){
    header("location: msg_alert_usuario.php");
    //Cria variável global para salvar a menssagem de sucesso
    $_SESSION['msg'] = "<p style='color:green;'>Tudo Certo!!<br>Usuário excluido com sucesso!</P> ";
}else{
//Cria variável global para salvar a menssagem de erro
$_SESSION['msg'] = "<p style='color:#f00;'> Erro: Ops!! Erro, não foi possível exluir usuário!</p>";

header("location: msg_alert_usuario.php");
}

?>
