<?php 
// A sessão será iniciada a cada página diferente
// determinar o nível de acesso, se necessário
session_name('TecNoo');
if (!isset($_SESSION)){
session_start();
}

// verifica se há usuario logado na sessão
// identifica o usuário
if(!isset($_SESSION['login'])){
// se não exixtir, destruímos a sessão por segurança
header("location: login_processa.php");
exit;
}

$name_of_session = session_name();
// verifica o nome da sessão
if(!isset($_SESSION['name_of_session']) OR ($_SESSION['name_of_session']!=$name_of_session)){
// se não existir, destruímos a sessão por segurança
session_destroy();
header("location: login_processa.php");
exit;
}

// verificar se o login é válido
if(!isset($_SESSION['login'])){
// se não existir, destruímos a sessão por segurança
session_destroy();
header("location: login_processa.php");
exit;
}
?>