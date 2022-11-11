<?php 

namespace Tecnoo\TecnooWeb\class;

// definindo padrão de zona GMT (Timezone) -03:00
date_default_timezone_set('America/Sao_Paulo');

// inicia o carregamento de classes do projeto

spl_autoload_register(
    function (string $nomeCompletoDaClasse)
    {
        $caminhoCompleto = str_replace('Tecnoo\\TecnooWeb', 'src', $nomeCompletoDaClasse);
        $caminhoArquivo  = str_replace('\\', DIRECTORY_SEPARATOR, $caminhoCompleto);
        $caminhoArquivo .= '.php';
        if (file_exists($caminhoArquivo)) {
            require_once $caminhoArquivo;
        }
    });

?>
?>