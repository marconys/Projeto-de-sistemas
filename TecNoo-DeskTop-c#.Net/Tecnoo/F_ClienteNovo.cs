using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnoo.Entities;

namespace Tecnoo
{
    public partial class F_ClienteNovo : Form
    {
        int id;
        Cliente cliente = new Cliente();
        Endereco endereco = new Endereco();
        public F_ClienteNovo(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                cliente.ListaClienteId(this.id);
                textidCli.Text = cliente.Id.ToString();
                textNome.Text = cliente.Nome;
                textCpf.Text = cliente.Cpf;
                textTelefone.Text = cliente.Telefone;
                textEmail.Text = cliente.Email;
                textCnpj.Text = cliente.Cnpj;
                textRsocial.Text = cliente.RSocial;
                textSenha.Text = cliente.Senha;

                //Verificar tipo do cliente
                if (cliente.IdTipo == 1)
                {
                    radioPF.Checked = true;
                }
                else if(cliente.IdTipo == 2)
                {
                    radioPJ.Checked = true;
                }

                //Verifica contrato
                if (cliente.IdContrato == 4)
                {
                    cbContrato.Text = "SEM CONTRATO";                   
                }
                else if(cliente.IdContrato == 1)
                {
                    cbContrato.Text = "DIAMANTE";
                }
                else if (cliente.IdContrato == 2)
                {
                    cbContrato.Text = "OURO";
                }
                else if (cliente.IdContrato == 3)
                {
                    cbContrato.Text = "PRATA";
                }

                //Exibe os campos do endereço conforme o idCliente
                endereco.ListaEnderecoId(this.id);
                textCep.Text = endereco.Cep;
                textLogradouro.Text = endereco.Rua;
                textNumero.Text = endereco.Numero;
                textComplemento.Text = endereco.Complemento;
                textBairro.Text = endereco.Bairro;
                textCidade.Text = endereco.Cidade;
                textEstado.Text = endereco.Estado;
            }
        }

        private void btn_sairNovoCliente_Click(object sender, EventArgs e)
        {
            using (var flistaCliente = new F_ListaCliente())
            {
                flistaCliente.ShowDialog();
                this.Close();
            }
        }

        private void btn_IsereEAtualizaCliente_Click(object sender, EventArgs e)
        {
            int contrato;

            //Verifica o tipo de contrato vigente
            //SEM CONTRATO
            //DIAMANTE
            //OURO
            //PRATA

            if (cbContrato.Text == "DIAMANTE")
            {
                contrato = 1;
            }
            else if (cbContrato.Text == "OURO")
            {
                contrato = 2;
            }
            else if (cbContrato.Text == "PRATA")
            {
                contrato = 3;
            }
            else
            {
                contrato = 4;
            }


            int tipoCliente;
            //verifica o tipo do cliente
            if (radioPF.Checked == true)
            {
                tipoCliente = 1;
            }
            else
            {
                tipoCliente = 2;
            }

            try
            {
                Cliente cliente = new Cliente(
                    textNome.Text,
                    textEmail.Text,
                    textCpf.Text,
                    textCnpj.Text,
                    textTelefone.Text,
                    textRsocial.Text,
                    tipoCliente,
                    contrato,
                    textSenha.Text
                    );

                Endereco endereco = new Endereco(
                    textCep.Text,
                    textLogradouro.Text,
                    textNumero.Text,
                    textComplemento.Text,
                    textBairro.Text,
                    textCidade.Text,
                    textEstado.Text);

                if (this.id == 0)
                {
                    cliente.InserirCliente();
                    endereco.inserirEndereco();
                }
                else
                {
                    cliente.AtualizaCliente(id);
                    endereco.AtualizaEndereco(id);
                }

                MessageBox.Show("Cliente inserido/atualizado com sucesso!");

                
                F_ListaCliente f_ListaCliente = new F_ListaCliente();
                f_ListaCliente.ShowDialog();
                this.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir/atualizar cliente \n" + erro.Message);
            }
        }
    }
}
