<?php
session_start();
//inclui conexão com o banco de dados
include('../connection/conn.php');
//Inclui variável de ambiente
include('../php/config_global.php');

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
    <title><?php echo TECNOO; ?>&nbsp; Social</title>
</head>

<body class="backgv-social">
    <header>
        <!-- Inicio do navbar -->
        <nav class="navbar fixed-top navbar-expand-lg bg-dark">
            <!-- Inicio container -->
            <div class="container-fluid">
                <a class="navbar-brand" href="#">
                    <h1 class="text-light">
                        TecNoo
                        <span><i class="bi bi-tools"></i></span>
                    </h1>
                </a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <!-- Inicio menu -->
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link active text-light" aria-current="page" href="../../index.php">
                                <span><i class="bi bi-house-door-fill"></i></span>
                                Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-light" href="../index.php#contato">Contato</a>
                        </li>
                        <!-- Inicio do dropdown -->
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle text-light" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Serviços
                            </a>
                            <ul class="dropdown-menu">
                                <li><a class="dropdown-item" href="../index.php#planos">Planos</a></li>
                                <li>
                                    <hr class="dropdown-divider" />
                                </li>
                                <li><a class="dropdown-item" href="pages/blog.php">Blog</a></li>
                            </ul>
                        </li>
                        <!-- Fim do dropdown -->
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
    <main class="container mt-5 text-center pt-5">
        <div class="card mt-5 alert bg-light bg-opacity-75" style="max-width: 100vw;">
            <div class="row g-0">
                <div class="col-md-4 my-auto">
                    <img src="../img/img-donate.png" class="img-fluid rounded-start my-auto" alt="donate">
                </div>
                <div class="col-md-8">
                    <div class="card-body">
                        <h1>Descarte Solidário</h1>
                        <br>
                        <h4>Criado com o objetivo de ajudar as pessoas que não conseguem ter algum tipo de hardware para diversos fins,
                            como estudos, jogos e etc...
                            Temos em mente que hoje em dia tudo com relação a atualidade e evolução envolve algum tipo de hardware, e queremos levar
                            essas tecnologias para todos.
                            <br>
                            Abaixo encontra-se um botão caso queira nos ajudar com esse projeto, com doações de hardwares, como
                            cases, placas mães, cabos, monitores, mouses e etc...
                            <br>
                            Caso não esteja funcionando, não há problema, apenas informar no formulario clicando no botão abaixo.
                        </h4>
                        <a href="#"><button class="align-self-center btn btn-dark mb-3 mt-5" data-bs-toggle="modal" data-bs-target="#login">Contribuir</button></a>
                    </div>
                </div>
            </div>
        </div>

    </main>


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
                    <form action="../php/login_processa.php" method="post" name="form_login" id="form_login" class="form-control alert">

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
                            <form action="../php/cadastro_processa.php" method="post" name="form_cadastro" id="form_cadastro" enctype="multipart/form-data" class="form-control container bgMain  border border-light">
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
                                <!-- Inicio input nome, cpf e telefone -->
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
                                <!-- Inicio input nome, cpf e telefone -->
                                
                                <!-- Inicio div oculta -->
                                <div id="oculta" class="esconder text-start">
                                    <!-- Inicio inputs cnpj e razão social -->
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
                                    <!-- fim inputs cnpj e razão social -->
                                </div>
                                <!-- Fim div oculta -->

                                <!-- Inicio input email e senha -->
                                <div class="row text-start">
                                    <!-- Inicio input email -->
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
                                    <!-- Fim input senha -->
                                </div>
                                <!-- Fim input email e senha -->

                                <!-- Inicio inputs cep, logradouro e número -->
                                <div class="row text-start">
                                    <!-- Inicio inputs cep -->
                                    <div class="col-sm-4">
                                        <label class="text-light" for="cep_endereco"><strong>Cep</strong></label>
                                        <input type="text" class="form-control" name="cep_endereco" id="cep_endereco" placeholder="00000-000" required />
                                    </div>
                                    <!-- Fim input cep -->
                                    <!-- Inicio input Logradouro -->
                                    <div class="col-sm-6">
                                        <label class="text-light" for="logradouro_endereco"><strong>Logradouro</strong></label>
                                        <input type="text" class="form-control" name="logradouro_endereco" id="logradouro_endereco" maxlength="16" required />
                                    </div>
                                    <!-- fim input Logradouro -->
                                    <!-- Inicio input num_endereco -->
                                    <div class="col-sm-2">
                                        <label class="text-light" for="logradouro_endereco"><strong>Numero</strong></label>
                                        <input type="text" class="form-control" name="num_endereco" id="num_endereco" maxlength="16" required />
                                    </div>
                                    <!-- fim input num_endereco -->
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

                                <!-- Inicio botão cadastrar -->
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

    <!-- Script para função mostar_esconder javascript -->
    <script src="../js/mostrar_esconder.js"></script>

    <!-- Link arquivos Bootstrap js -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</body>

</html>