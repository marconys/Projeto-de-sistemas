<?php

session_start();

require_once('src/class/Cliente.php');

use Tecnoo\TecnooWeb\class\Cliente;

$postjson = filter_input_array(INPUT_POST, FILTER_DEFAULT);

try {

  if (!empty($_POST)) {


    if ($postjson['cnpj'] == "") {
      $id_tipo_cliente = 1;
    } else {
      $id_tipo_cliente = 2;
    }
    
    $contratoPadrao = 4;
  
    $cliente = new Cliente(
      $postjson['nome'],
      $postjson['cpf'],
      $postjson['telefone'],
      $postjson['cnpj'],
      $postjson['rsocial'],
      $id_tipo_cliente,
      $contratoPadrao,
      $postjson['email'],
      password_hash($postjson['senha'], PASSWORD_DEFAULT)
    );
  
    // $_cep, $_logradouro, $_numero,$_complemento,$_bairro,$_cidade, $_estado
  
    if ($cliente->createClient($postjson['cep_endereco'], $postjson['logradouro_endereco'], $postjson['num_endereco'], $postjson['complemento_endereco'], $postjson['bairro_endereco'], $postjson['cidade_endereco'], $postjson['estado_endereco']) == true){

      header("location: src/php/msg_alert_cadastro.php");
      //Cria variável global para salvar a menssagem de sucesso
      $_SESSION['msg'] = "<p style='color:green;'>Tudo Certo!!<br>Cadastrado com sucesso!<br>Use o seu e-mail e senha para efetuar login</P> ";
    }
  }
} catch (Exception $erro) {

  $_SESSION['msg'] = "<p style='color:#f00;'> Erro: Ops!! Erro ao  efetuar cadastro!</p>" . $erro->getMessage();
  
    header("location: src/php/msg_alert_cadastro.php");
}



?>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <!-- import cdn CSS Bootstrap -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous" />
  <!-- import cdn icons Bootstrap -->
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css">
  <!-- import my CSS -->
  <link rel="stylesheet" href="src/css/my_style.css" />
  <link rel="icon" type="image/x-icon" href="src/img/favicon-32x32.png">
  <title>Tecnoo</title>
</head>

<body class="bgMain">
  <!-- Inicio do header -->
  <header>
    <!-- Inicio do navbar -->
    <nav class="navbar fixed-top navbar-expand-lg bg-dark">
      <!-- Inicio container -->
      <div class="container-fluid">
        <a class="navbar-brand" href="#">
          <h1 class="text-light">
            TecNoo
            <i class="bi bi-tools"></i>
          </h1>
        </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <!-- Inicio menu -->
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
            <li class="nav-item">
              <a class="nav-link active text-light" aria-current="page" href="#">
                <span><i class="bi bi-house-door-fill"></i></span>
                Home</a>
            </li>
            <li class="nav-item">
              <a class="nav-link text-light" href="#contato">Contato</a>
            </li>
            <!-- Inicio do dropdown -->
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle text-light" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                Serviços
              </a>
              <ul class="dropdown-menu">
                <li><a class="dropdown-item" href="#planos">Planos</a></li>
                <li><a class="dropdown-item" href="#social">Social</a></li>
                <li>
                  <hr class="dropdown-divider" />
                </li>
                <li><a class="dropdown-item" href="pages/blog.php">Blog</a></li>
              </ul>
            </li>
            <!-- Fim do dropdown -->
            <li class="nav-item">
              <a href="#" class="nav-link text-light" data-bs-toggle="modal" data-bs-target="#login">Login</a>
            </li>
          </ul>
          <!-- Inicio do form buscar -->
          <form class="d-flex" role="search">
            <input class="form-control me-2" type="search" placeholder="Buscar" aria-label="Buscar" />
            <button class="btn btn-outline-success" type="submit">
              Buscar
            </button>
          </form>
          <!-- Fim do Form buscar -->
        </div>
        <!-- Final do menu -->
      </div>
      <!-- Final do container -->
    </nav>
    <!-- Final do navbar -->
  </header>
  <!-- Fim do header -->

  <!-- Inicio do main -->
  <main class="container pt-5 mt-5">

    <!-- Inicio do carousel -->
    <div id="banners" class="carousel slide my-3" data-bs-ride="true">
      <div class="carousel-indicators">
        <button type="button" data-bs-target="#banners" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#banners" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#banners" data-bs-slide-to="2" aria-label="Slide 3"></button>
      </div>
      <div class="carousel-inner rounded">
        <div class="carousel-item active">
          <img src="src/img/carrousel-1.jpg" class="d-block w-100 img-fluid" alt="..." />
        </div>
        <div class="carousel-item">
          <img src="src/img/carrousel-2.jpg" class="d-block w-100 img-fluid" alt="..." />
        </div>
        <div class="carousel-item">
          <img src="src/img/carrousel-0.jpg" class="d-block w-100 img-fluid" alt="..." />
        </div>
      </div>
      <button class="carousel-control-prev" type="button" data-bs-target="#banners" data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
      </button>
      <button class="carousel-control-next" type="button" data-bs-target="#banners" data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
      </button>
    </div>
    <!-- Fim do carousel -->

    <!-- Inicio planos -->
    <div class="container text-center mt-3 p-2">
      <!-- Inicio row -->
      <div class="row" id="planos">
        <!-- Inicio botão prata -->
        <div onmouseover="mudacorPrata()" onmouseout="voltaOriginalPrata()" class="alert bg-light bg-opacity-75 col" id="prata">
          <div class="alert bg-secondary bg-opacity-75 ">
            <h4>Prata</h4>
          </div>
          <div class="alert bg-dark text-light">
            <p>
            <h5>Suporte 24Hrs por telefone/app e web + 2 visitas gratuitas + Mão de obra grátis</h5>
            </p>
          </div>
          <div class="row">
            <a href="#" type="button" class="btn btn-outline-dark col col me-1" data-bs-toggle="modal" data-bs-target="#login">Eu Quero!</a>
            <button type="button" class="btn btn-outline-dark col col ms-1" data-bs-placement="top" data-bs-toggle="popover" data-bs-title="Associado Prata" data-bs-content="Seja um associado prata e tenha: Atendimento remoto ilimitado e mais 2 visitas gratis + mão de obra grátis.">Saiba Mais...</button>
          </div>
        </div>
        <!-- Fim botão prata -->

        <!-- Inicio botão ouro -->
        <div onmouseover="mudacorOuro()" onmouseout="voltaOriginalOuro()" class="alert bg-light bg-opacity-75 mx-2 col" id="ouro">
          <div class="alert bg-warning bg-opacity-100">
            <h4>Ouro</h4>
          </div>
          <div class="alert bg-dark text-light">
            <p>
            <h5>Suporte 24Hrs por telefone/app e web + 4 visitas gratuitas + Mão de obra grátis</h5>
            </p>
          </div>
          <div class="row">
            <a href="#" type="button" class="btn btn-outline-dark col me-1" data-bs-toggle="modal" data-bs-target="#login">Eu Quero!</a>
            <button type="button" class="btn btn-outline-dark col ms-1" data-bs-placement="top" data-bs-toggle="popover" data-bs-title="Associado Ouro" data-bs-content="Seja um associado ouro e tenha: Atendimento remoto ilimitado e mais 4 visitas gratis + mão de obra grátis.">Saiba Mais...</button>
          </div>
        </div>
        <!-- Fim botão ouro -->

        <!-- Inicio botão diamante -->
        <div onmouseover="mudacorDiamante()" onmouseout="voltaOriginalDiamante()" class="alert bg-light bg-opacity-75 col" id="diamante">
          <div class=" alert bg-info bg-opacity-100">
            <h4>Diamante</h4>
          </div>
          <div class="alert bg-dark text-light">
            <p>
            <h5>Suporte 24Hrs por telefone/app e web + 5 visitas gratuitas + mão de obra gratis</h5>
            </p>
          </div>
          <div class="row">
            <a href="#" type="button" class="btn btn-outline-dark col me-1" data-bs-toggle="modal" data-bs-target="#login">Eu Quero!</a>
            <button type="button" class="btn btn-outline-dark col ms-1" data-bs-placement="top" data-bs-toggle="popover" data-bs-title="Associado Diamante" data-bs-content="Seja um associado diamante e tenha: Atendimento remoto ilimitado e mais 5 visitas gratis + mão de obra grátis.">Saiba Mais...</button>
          </div>
        </div>
        <!-- Fim botão ouro -->
      </div>
      <!-- Fim row -->
    </div>
    <!-- Fim Planos -->

    <!-- Inicio Social -->
    <div id="social" class="container bg-secondary rounded text-center">
      <div class=" container">
        <h1>Descarte Solidário</h1>
        <a href="src/pages/social.php">
          <img src="src/img/solidario.jpg" alt="" class="d-block w-100 img-fluid mb-3 rounded">
          <button class=" btn btn-outline-dark mb-3">Saiba Mais...</button></a>
      </div>
    </div>
    <!-- Fim Social -->

    <!-- Inicio footer -->
    <footer id="contato" class="mt-3">
      <div class="card-footer text-center bg-dark rounded">
        <div class="card-body">
          <h5 class="card-title text-light pt-3">TecNoo
            <i class="bi bi-tools"></i>
          </h5>
          <address>
            <i class="text-light">Avenida Itaquera, 8266 Itaquera - São Paulo - SP - CEP 08295-000</i>
            <br>
            <span class=" text-light">
              <i class="bi-telephone-fill"></i> &nbsp; (11) 2585-9200</span>
            <br>
            <span class="text-light">
              <i class="bi bi-envelope-fill"></i>
            </span>&nbsp; <a href="mailto:contato@tecnoo.com.br?subject=contato via site&cc=marconysbatera@gmail.com">
              contato@tecnoo.com.br
            </a>
          </address>
          <div class="text-light h1">
            TecNoo
            <div class="spinner-border" style="width: 4.5rem; height: 4.5rem;">
              <i class="bi bi-tools"></i>
            </div>
          </div>
          <!-- Inicio div contato -->
          <div class="contato">
            <a href="#"><i class="bi bi-instagram text-light"></i></a>

            <a href="https://www.youtube.com/channel/UCg1l0Z8YQ_Qzw9EMIMzWXjw"><i class="bi bi-youtube text-danger"></i></a>

            <a href="#"><i class="bi bi-whatsapp text-success"></i></a>
          </div>
          <!-- Final div contato -->
        </div>
        <div class="card-footer text-muted">
          &copy; Copyright Desenvolvido por Tecnoo Ltda - 2022.
        </div>
      </div>
    </footer>
    <!-- Fim footer -->
  </main>
  <!-- Fim do main -->

  <!-- Inicio modal login -->
  <div class="modal fade" id="login" tabindex="-1" aria-labelledby="loginModalLabel" aria-hidden="true">
    <div class="modal-dialog bgMain">
      <div class="modal-content alert bgMain">
        <div class="modal-header alert bg-light ">
          <button type="button" class="btn-close bg-danger" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <!-- Inicio login -->
        <div class="mx-auto border border-light alert bgMain">
          <h1 class="text-light text-center">
            TecNoo
            <span><i class="text-center bi bi-tools"></i></span>
          </h1>
          <h1 class="text-center text-light">Login</h1>
          <!-- Inicio form login -->
          <form action="src/class/Autenticar.php" method="post" name="form_login" id="form_login" class="form-control alert">

            <div class=" form-control form-group alert bgMain  border border-light">
              <!-- Inicio input email -->
              <div class="mb-3 row">
                <label class="text-light" for="login"><strong>Email</strong></label>
                <div class="col">
                  <input type="text" class="form-control" name="login" id="login" placeholder="exemplo@email.com.br" required>
                </div>
              </div>
              <!-- Fim input email -->
              <!-- Inicio input senha -->
              <div class="mb-3 row">
                <label class="text-light" for="senha"><strong>Senha</strong></label>
                <div class="col">
                  <input type="password" class="form-control" name="senha" id="senha" required>
                </div>
              </div>
              <!-- Fim input senha -->
              <div class=" d-flex justify-content-center">
                <a class="alert btn btn-outline-dark text-light" href="#" data-bs-toggle="modal" data-bs-target="#cadastro">Cadastre-se</a>
                <a class="alert btn btn-outline-dark text-light" href="">Esqueci a senha</a>
              </div>
              <!-- Inicio botão entrar -->
              <div class="d-flex justify-content-center">
                <button type="submit" class="btn btn-info col-sm-6  d-flex justify-content-center" name="enviar" id="enviar">Entrar</button>
              </div>
              <!-- Fim botão entrar -->
            </div>
          </form>
          <!-- Fim form login -->
        </div>
      </div>
      <!-- Fim login -->
    </div>
  </div>
  <!-- Fim modal login -->

  <!-- Inicio modal cadastro -->
  <div class="modal fade" id="cadastro" tabindex="-1" aria-labelledby="cadModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-xl bgMain">
      <div class="modal-content alert bgMain">
        <div class="modal-header alert bg-light ">
          <button type="button" class="btn-close bg-danger" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <!-- Inicio cadastro -->
        <div class="mx-auto alert bg-light mt-3 bgMain container  border border-light">
          <div class="mx-auto alert bgMain modal-xl">
            <h1 class="text-light text-center">
              TecNoo
              <span><i class="text-center bi bi-tools"></i></span>
              <!-- Inicio form cadastro -->
              <form action="index.php" method="post" name="form_cadastro" id="form_cadastro" enctype="multipart/form-data" class="form-control container bgMain  border border-light">
                <!-- Inicio radio pessoa física-->
                <div class="form-check form-check-inline text-light">
                  <label for="pf" class="form-check-label">
                    <input class="form-check-input" onclick="esconderCampos()" type="radio" name="pessoa" id="pf" value="Pessoa Física" checked>
                    <strong>Pessoa Física</strong>
                  </label>
                </div>
                <!-- Fim radio pessoa física-->
                <!-- Inicio radio pessoa jurídica-->
                <div class="form-check form-check-inline text-light">
                  <label for="pf" class="form-check-label">
                    <input class="form-check-input" onclick="mostrarCampos()" type="radio" name="pessoa" id="pj" value="Pessoa Jurídica">
                    <strong>Pessoa Jurídica</strong>
                  </label>
                </div>
                <!-- Fim radio pessoa jurídica-->

                <div class="row text-start">
                  <!-- Inicio input nome -->
                  <div class="col">
                    <label class="text-light" class="" for="nome"><strong>Nome:</strong></label>
                    <input type="text" class="form-control" name="nome" id="nome" placeholder="Nome e Sobrenome" required />
                  </div>
                  <!-- Fim input nome -->
                  <!-- Inicio input cpf -->
                  <div class="col">
                    <label class="text-light" for="cpf"><strong>CPF:</strong></label>
                    <input type="text" class="form-control" name="cpf" id="cpf" maxlength="11" placeholder="CPF sem prontos e traços" required />
                  </div>
                  <!-- Fim input cpf -->
                  <!-- Inicio input telefone -->

                  <div class="col">
                    <label class="text-light" for="telefone"><strong>TELEFONE:</strong></label>
                    <input type="text" class="form-control" name="telefone" id="telefone" maxlength="14" placeholder="99 999999999" required />
                  </div>
                  <!-- Fim input telefone -->
                </div>

                <!-- Inicio div oculta -->
                <div id="oculta" class="esconder text-start">
                  <div class="row">
                    <!-- Inicio input cnpj -->
                    <div class="col-md-4">
                      <label class="text-light" for="cnpj"><strong>CNPJ:</strong></label>
                      <input type="text" class="form-control" name="cnpj" id="cnpj" maxlength="14" placeholder="CNPJ sem prontos e traços" />
                    </div>
                    <!-- Fim input cnpj -->
                    <!-- Inicio input razão social -->
                    <div class="col-md-8">
                      <label class="text-light" for="rsocial"><strong>RAZÃO SOCIAL:</strong></label>
                      <input type="text" class="form-control" name="rsocial" id="rsocial" placeholder="exemplo Ltda" />
                    </div>
                    <!-- Fim input razão social  -->
                  </div>
                </div>
                <!-- Fim div oculta -->

                <!-- Inicio inputs email e senha -->
                <div class="row text-start">
                  <!-- Inicio inputs email -->
                  <div class="col-sm-8">
                    <label class="text-light" for="email"><strong>Email</strong></label>
                    <input type="text" class="form-control" name="email" id="email" placeholder="exemplo@email.com.br" required />
                  </div>
                  <!-- Fim input email -->
                  <!-- Inicio input senha -->
                  <div class="col-sm-4">
                    <label class="text-light" for="senha"><strong>Senha</strong></label>
                    <input type="password" class="form-control" name="senha" id="senha" maxlength="16" required />
                  </div>
                  <!-- fim input senha -->
                </div>
                <!-- Fim input email e senha -->

                <!-- Inicio inputs cep, logradouro e número -->
                <div class="row text-start">
                  <!-- Inicio inputs cep -->
                  <div class="col-sm-4">
                    <label class="text-light" for="cep_endereco"><strong>Cep</strong></label>
                    <input type="text" class="form-control" name="cep_endereco" id="cep_endereco" maxlength="9" placeholder="00000-000" required />
                  </div>
                  <!-- Fim input cep -->
                  <!-- Inicio input Logradouro -->
                  <div class="col-sm-6">
                    <label class="text-light" for="logradouro_endereco"><strong>Logradouro</strong></label>
                    <input type="text" class="form-control" name="logradouro_endereco" id="logradouro_endereco" maxlength="16" required />
                  </div>
                  <!-- fim input Logradouro -->
                  <!-- Inicio input Logradouro -->
                  <div class="col-sm-2">
                    <label class="text-light" for="num_endereco"><strong>Numero</strong></label>
                    <input type="text" class="form-control" name="num_endereco" id="num_endereco" maxlength="16" required />
                  </div>
                  <!-- fim input Logradouro -->
                </div>
                <!-- Fim inputs cep, logradouro e número -->

                <!-- Inicio inputs complemento, bairo, cidade e estado -->
                <div class="row text-start">
                  <!-- Inicio inputs complemento -->
                  <div class="col-sm-2">
                    <label class="text-light" for="complemento_endereco"><strong>Complemento</strong></label>
                    <input type="text" class="form-control" name="complemento_endereco" id="complemento_endereco" placeholder="ex: Casa 01" />
                  </div>
                  <!-- Fim input complemento -->
                  <!-- Inicio input bairro -->
                  <div class="col-sm-4">
                    <label class="text-light" for="bairro_endereco"><strong>Bairro</strong></label>
                    <input type="text" class="form-control" name="bairro_endereco" id="bairro_endereco" maxlength="20" required />
                  </div>
                  <!-- fim input bairro -->
                  <!-- Inicio input cidade -->
                  <div class="col-sm-3">
                    <label class="text-light" for="cidade_endereco"><strong>Cidade</strong></label>
                    <input type="text" class="form-control" name="cidade_endereco" id="cidade_endereco" maxlength="20" required />
                  </div>
                  <!-- fim input cidade -->
                  <!-- Inicio input estado -->
                  <div class="col-sm-3">
                    <label class="text-light" for="estado_endereco"><strong>Estado</strong></label>
                    <input type="text" class="form-control" name="estado_endereco" id="estado_endereco" maxlength="20" required />
                  </div>
                  <!-- fim input estado -->
                </div>
                <!-- Fim inputs complemento, bairo, cidade e estado -->
                <!-- Inicio botão cadastrar-->
                <div class="d-flex justify-content-center mt-3">
                  <button type="submit" class="btn btn-info col-sm-6 d-flex justify-content-center " name="cadastrar" id="cadastrar">
                    Cadastrar
                  </button>
                </div>
                <!-- Fim botão cadastrar -->
              </form>
              <!-- Fim form cadastro -->
          </div>
        </div>
      </div>
      <!-- Fim cadastro -->
    </div>
  </div>
  </div>
  <!-- Fim modal cadastro -->

  <!-- Link arquivos Bootstrap js -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>

  <!-- Script para função mudar_cor_botoes.js javascript -->
  <script src="src/js/mudar_cor_botoes.js"></script>

  <!-- Script para função mostar_esconder javascript -->
  <script src="src/js/mostrar_esconder.js"></script>

  <!-- Script para função propovers -->
  <script src="src/js/propovers.js"></script>
</body>

</html>