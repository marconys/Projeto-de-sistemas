<?php

namespace Tecnoo\TecnooWeb\class;

require_once('Sql.php');

use Tecnoo\TecnooWeb\class\Sql;

class Cliente
{
    private int $Id_cliente;
    private string $Nome_cliente;
    private string $Cpf_cliente;
    private string $Telefone_cliente;
    private string $Cnpj_cliente;
    private string $Razao_social_cliente;
    private int $Id_tipo_cliente;
    private int $Id_contrato_cliente;
    private string $Email_cliente;
    private string $Senha_cliente;



    public function __construct(string $Nome_cliente = "", string $Cpf_cliente = "", string $Telefone_cliente = "", string $Cnpj_cliente = "", ?string $Razao_social_cliente = "", int $Id_tipo_cliente = 0, int $Id_contrato_cliente = 0, string $Email_cliente = "", string $Senha_cliente = "")
    {
        $this->Nome_cliente = $Nome_cliente;
        $this->Cpf_cliente = $Cpf_cliente;
        $this->Telefone_cliente = $Telefone_cliente;
        $this->Cnpj_cliente = $Cnpj_cliente;
        $this->Razao_social_cliente = $Razao_social_cliente;
        $this->Id_tipo_cliente = $Id_tipo_cliente;
        $this->Id_contrato_cliente = $Id_contrato_cliente;
        $this->Email_cliente = $Email_cliente;
        $this->Senha_cliente = $Senha_cliente;
    }

    //Métodos de acesso da class (Getters and Setters)
    //Getters and Setters $Id_cliente;
    public function setId_Cli($Id_cliente)
    {
        $this->Id_cliente = $Id_cliente;
    }

    public function getId_Cli()
    {
        return $this->Id_cliente;
    }

    //Getters and Setters $nome_cliente;
    public function setNome_Cli($Nome_cliente)
    {
        $this->Nome_cliente = $Nome_cliente;
    }

    public function getNome_Cli()
    {
        return $this->Nome_cliente;
    }

    //Getters and Setters $Cpf_cliente;
    public function setCpf_Cli($Cpf_cliente)
    {
        $this->Cpf_cliente = $Cpf_cliente;
    }

    public function getCpf_Cli()
    {
        return $this->Cpf_cliente;
    }

    //Getters and Setters $Telefone_cliente;
    public function setTelefone_Cli($Telefone_cliente)
    {
        $this->Telefone_cliente = $Telefone_cliente;
    }

    public function getTelefone_Cli()
    {
        return $this->Telefone_cliente;
    }

    //Getters and Setters $Cnpj_cliente;
    public function setCnpj_Cli($Cnpj_cliente)
    {
        $this->Cnpj_cliente = $Cnpj_cliente;
    }

    public function getCnpj_Cli()
    {
        return $this->Cnpj_cliente;
    }

    //Getters and Setters $Razao_social_cliente;
    public function setRsocial_Cli($Razao_social_cliente)
    {
        $this->Cnpj_clRazao_social_clienteiente = $Razao_social_cliente;
    }

    public function getRsocial_Cli()
    {
        return $this->Razao_social_cliente;
    }

    //Getters and Setters $Id_tipo_cliente;
    public function setId_tipo_Cli($Id_tipo_cliente)
    {
        $this->Id_tipo_cliente = $Id_tipo_cliente;
    }

    public function getId_tipo_Cli()
    {
        return $this->Id_tipo_cliente;
    }

    //Getters and Setters $Id_contrato_cliente;
    public function setId_contrato_Cli($Id_contrato_cliente)
    {
        $this->Id_contrato_cliente = $Id_contrato_cliente;
    }

    public function getId_contrato_Cli()
    {
        return $this->Id_contrato_cliente;
    }

    //Getters and Setters $Email_cliente;
    public function setEmail_Cli($Email_cliente)
    {
        $this->Email_cliente = $Email_cliente;
    }

    public function getEmail_Cli()
    {
        return $this->Email_cliente;
    }

    //Getters and Setters $Senha_cliente;
    public function setSenha_Cli($Senha_cliente)
    {
        $this->Cnpj_cliente = $Senha_cliente;
    }

    public function getSenha_Cli()
    {
        return $this->Senha_cliente;
    }

    //Getters and Setters $endereco;

    public function getEndereco_Cli()
    {
        return $this->endereco;
    }

    public function setEndereco_Cli($endereco)
    {
        return $this->endereco = $endereco;
    }

    public function setData_Cli($dados)
    {




        $this->setId_Cli($dados['id_cliente']);
        $this->setNome_Cli($dados['nome_cliente']);
        $this->setCpf_Cli($dados['cpf_cliente']);
        $this->setTelefone_Cli($dados['telefone_cliente']);
        $this->setCnpj_Cli($dados['cnpj_cliente']);
        $this->setRsocial_Cli($dados['razao_social_cliente']);
        $this->setId_tipo_Cli($dados['id_tipo_cliente']);
        $this->setId_contrato_Cli($dados['id_contrato_cliente']);
        $this->setEmail_Cli($dados['email_cliente']);
        $this->setSenha_Cli(password_hash($dados['senha_cliente'], PASSWORD_DEFAULT));
    }

    public function createClient($_cep, $_logradouro, $_numero, $_complemento, $_bairro, $_cidade, $_estado)
    {
        $sql = new Sql();
        $res = $sql->select(
            "CALL sp_cliente_insert(:nome, :cpf_cliente, :telefone_cliente, :cnpj_cliente, :razao_social_cliente,
        :id_tipo, :id_contrato, :email_cliente, :senha_cliente)",
            array(
                ":nome" => $this->getNome_Cli(),
                ":cpf_cliente" => $this->getCpf_Cli(),
                ":telefone_cliente" => $this->getTelefone_Cli(),
                ":cnpj_cliente" => $this->getCnpj_Cli(),
                ":razao_social_cliente" => $this->getRsocial_Cli(),
                ":id_tipo" => $this->getId_tipo_Cli(),
                ":id_contrato" =>$this->getId_contrato_Cli(),
                ":email_cliente" => $this->getEmail_Cli(),
                ":senha_cliente" => $this->getSenha_Cli()

            ));

        if (count($res) > 0) {
            $this->setData_Cli($res[0]);


            //    Funcionalidade para inserir o endereço com o id criado
            $resEndereco = $sql->select(
                "CALL sp_endereco_insert(:id_cliente_endereco, :cep_endereco, :logradouro_endereco, :num_endereco, :complemento_endereco,
            :bairro_endereco, :cidade_endereco, :estado_endereco)",
                array(
                    ":id_cliente_endereco" => $this->getId_Cli(),
                    ":cep_endereco" => $_cep,
                    ":logradouro_endereco" => $_logradouro,
                    ":num_endereco" => $_numero,
                    ":complemento_endereco" => $_complemento,
                    ":bairro_endereco" => $_bairro,
                    ":cidade_endereco" => $_cidade,
                    ":estado_endereco" => $_estado

                )
            );

            if (count($resEndereco)) {
            }

            return true;
        }

        return false;
    }

    public function login($login, $senha)
    {
        $sql = new Sql();

        $res = $sql->select(
            "SELECT * FROM tbcliente WHERE email_cliente = :login_cliente",
            array(":login_cliente" => $login)
        );

        if (count($res) > 0 && password_verify($senha, $res[0]['senha_cliente'])) {
            $this->setData_Cli($res[0]);
            return true;
        }
        return false;
    }
}
