<?php

namespace Tecnoo\TecnooWeb\class;

require_once('Sql.php');
require_once('interfaces/Nivel.php');

use Tecnoo\TecnooWeb\class\Sql;
use Tecnoo\TecnooWeb\class\interfaces\Nivel;


class Usuario implements Nivel
{
    private int $id_usuario;
    private string $nome_usuario;
    private string $email_usuario;
    private ?int $id_nivel_usuario;
    private string $login_usuario;
    private string $senha_usuario;
    private ?string $foto_usuario;

    public function __construct(string $nome = "", string $email = "", int $id_nivel = NULL, string $login = "", string $senha = "", ?string $foto = "")
    {
        $this->nome_usuario = $nome;
        $this->email_usuario = $email;
        $this->id_nivel_usuario = $id_nivel;
        $this->login_usuario = $login;
        $this->senha_usuario = $senha;
        $this->foto_usuario = $foto;
    }


    public function getId_User()
    {
        return $this->id_usuario;
    }

    public function setId_User($id_usuario)
    {
        return $this->id_usuario = $id_usuario;
    }

    public function getNome_User()
    {
        return $this->nome_usuario;
    }

    public function setNome_User($nome_usuario)
    {
        return $this->nome_usuario = $nome_usuario;
    }

    public function getEmail_User()
    {
        return $this->email_usuario;
    }

    public function setEmail_User($email_usuario)
    {
        return $this->email_usuario = $email_usuario;
    }

    public function getId_nivel_User()
    {
        return $this->id_nivel_usuario;
    }

    public function setId_nivel_User($id_nivel_usuario)
    {
        return $this->id_nivel_usuario = $id_nivel_usuario;
    }

    public function getLogin_user()
    {
        return $this->login_usuario;
    }

    public function setLogin_user($login_usuario)
    {
        return $this->login_usuario = $login_usuario;
    }

    public function getSenha_User()
    {
        return $this->senha_usuario;
    }

    public function setSenha_User($senha_usuario)
    {
        return $this->senha_usuario = $senha_usuario;
    }

    public function getFoto_User()
    {
        return $this->foto_usuario;
    }

    public function setFoto_User($foto_usuario)
    {
        return $this->foto_usuario = $foto_usuario;
    }

    public function loadById($_id)
    {
        $sql = new Sql();
        $results = $sql->select("SELECT * FROM tbusuarios WHERE id_usuario = :id", array(':id' => $_id));
        if (count($results) > 0) {
            $this->setData_User($results[0]);
        }
    }

    public function setData_User($dados)
    {
        $this->setId_User($dados['id_usuario']);
        $this->setNome_User($dados['nome_usuario']);
        $this->setEmail_User($dados['email_usuario']);
        $this->setId_nivel_User($dados['id_nivel_usuario']);
        $this->getLogin_user($dados['login_usuario']);
        $this->setSenha_User($dados['senha_usuario']);
        $this->setFoto_User($dados['foto_usuario']);
    }

    public function createUser(): bool
    {
        $sql = new Sql();
        $res = $sql->select(
            "CALL sp_user_insert(:nome, :email, :id_nivel, :login, :senha, :foto)",

            array(

                ":nome" => $this->getNome_User(),
                ":email" => $this->getEmail_User(),
                ":id_nivel" => $this->getId_nivel_User(),
                ":login" => $this->getLogin_user(),
                ":senha" => $this->getSenha_User(),
                ":foto" => $this->getFoto_User()
            )
        );

        if(count($res) > 0){
            $this->setData_User($res[0]);
            return true;
        }

        return false;        
    }

    public static function getList()
    {
        $sql = new Sql();
        return $sql->select("SELECT u.id_usuario,
        u.nome_usuario,
        u.login_usuario,
        u.email_usuario,
        u.foto_usuario,
        u.id_nivel_usuario,
        n.nome_nivel
        FROM tbusuarios u INNER JOIN tbnivel n ON u.id_nivel_usuario = n.id_nivel");
    }

    public function update($idUser)
    {
        $sql = new Sql();
        $sql->querySql(
            "UPDATE tbusuarios SET nome_usuario = :nome, email_usuario = :email, 
            id_nivel_usuario = :id_nivel, login_usuario = :login_usuario WHERE id_usuario = $idUser",

            array(
                ":nome" => $this->getNome_User(),
                ":email" => $this->getEmail_User(),
                ":id_nivel" => $this->getId_nivel_User(),
                ":login_usuario" => $this->getLogin_user()
            )
        );

        return true;
    }

    public function delete($idUser)
    {
        $sql = new Sql();
        $sql = $sql->querySql("DELETE FROM tbusuarios WHERE id_usuario = :id", array(":id" => $idUser));
        return true;
    }

    public static function buscarUser($idUser)
    {
        $sql = new Sql();
        return $sql->select("SELECT * FROM tbusuarios WHERE id_usuario = $idUser");
        
    }


    public function login($login, $senha)
    {
        $sql = new Sql();

        $res = $sql->select(
            "SELECT * FROM tbusuarios WHERE login_usuario = :login_usuario",
            array(":login_usuario" => $login)
        );

        if (count($res) > 0 && password_verify($senha, $res[0]['senha_usuario'])) {
            $this->setData_User($res[0]);
            return true;
        }
        return false;
    }

    //Cumpre contrato interface Nivel e implementa o metodo listarNivel()

    public static function listarNivel()
    {
        $sql = new Sql();

        return $sql->select("SELECT * FROM tbnivel ORDER BY nome_nivel ASC");
    }
}
