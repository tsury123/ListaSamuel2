using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listinha_da_Cida_T4__VS_
{
    internal class Contato
    {
        //Variaveis internas da classe Contato
        //a palavra chave "private" indica que somente a classe
        //Contato tem acesso.
        private string primeiroNome;
        private string sobrenome;
        private string telefone;
        private string mail;

        // PROPRIEDADES (GET e SET)
        public string PrimeiroNome

        {
            get { return primeiroNome; }
            set { primeiroNome = value; }

        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)

                    telefone = value;
                else
                {
                    telefone = "00000000000";
                }

            }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        //Método construtor da classe
        public Contato()
        {
           
        }

        //sobrecarga do método construtor da classe
        public Contato(string primeiroNome, string sobrenome, string telefone, string mail)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Mail = mail;
        }
        public override string ToString()
        {
            string saída = String.Empty;
            saída += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saída += String.Format("{0}-{1}-{2}",
                Telefone.Substring(0, 1),
                Telefone.Substring(2, 4),
                Telefone.Substring(7, 3));
            saída += string.Format(Mail);
            return saída;
        }
    }
}
