<?php 
namespace Tecnoo\TecnooWeb\class;

class Endereco {
    private ?int $id_endereco;
    private ?int $id_cliente;
    private string $cep;
    private string $logradouro;
    private string $numeroCasa;
    private string $complemento;
    private string $bairro;
    private string $cidade;
    private string $estado;

    //Método construtor

    public function __construct(int $id_cliente = null, string $cep = "", string $logradouro = "", string $numeroCasa = "",
    string $complemento = "", string $bairro = "", string $cidade = "", string $estado = "")
    {
        
        $this->id_cliente  = $id_cliente;
        $this->cep         = $cep;
        $this->logradouro  = $logradouro;
        $this->numeroCasa  = $numeroCasa;
        $this->complemento = $complemento;
        $this->bairro      = $bairro;
        $this->cidade      = $cidade;
        $this->estado      = $estado;
    }

    //Métodos Gets
    public function getIdendereco()
    {
        return $this->id;
    }

    public function getId_cliente()
    {
       return $this->id_cliente;
    }

    public function getCep()
    {
       return $this->cep;
    }

    public function getLogradouro()
    {
       return $this->logradouro;
    }

    public function getNumeroCasa()
    {
       return $this->numeroCasa;
    }

    public function getComplemento()
    {
       return $this->complemento;
    }

    public function getBairro()
    {
       return $this->bairro;
    }

    public function getCidade()
    {
       return $this->cidade;
    }

    public function getEstado()
    {
       return $this->estado;
    }

    //Métodos Sets
    public function setIdendereco($id_endereco)
    {
        return $this->id = $id_endereco;
    }

    public function setId_cliente($id_cliente)
    {
       return $this->id_cliente = $id_cliente;
    }

    public function setCep($cep)
    {
       return $this->cep = $cep;
    }

    public function setLogradouro($logradouro)
    {
       return $this->logradouro = $logradouro;
    }

    public function setNumeroCasa($numeroCasa)
    {
       return $this->numeroCasa = $numeroCasa;
    }

    public function setComplemento($complemento)
    {
       return $this->complemento = $complemento;
    }

    public function setBairro($bairro)
    {
       return $this->bairro = $bairro;
    }

    public function setCidade($cidade)
    {
       return $this->cidade = $cidade;
    }

    public function setEstado($estado)
    {
       return $this->estado = $estado;
    }
}
