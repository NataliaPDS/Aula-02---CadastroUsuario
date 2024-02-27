using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    internal class Cliente
    {
        public string NomeCompleto { get; set; }
        public string DataNascimentoi { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }

        public string Rua { get; set; }
        public string Numero { get; set; }  
        public string CEP { get; set; }

        public string Cidade { get; set; }

        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Celular{ get; set; }
        public string Email { get; set; }

        public Cliente() { }

        public Cliente(string nomeCompleto, string dataNascimentoi, string cPF, string sexo, string rua, string numero, string cEP, string cidade, string complemento, string telefone, string celular, string email)
        {
            NomeCompleto = nomeCompleto;
            DataNascimentoi = dataNascimentoi;
            CPF = cPF;
            Sexo = sexo;
            Rua = rua;
            Numero = numero;
            CEP = cEP;
            Cidade = cidade;
            Complemento = complemento;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }
    }
}
