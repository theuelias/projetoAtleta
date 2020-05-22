using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Pessoa
    {
        private double altura, peso;
        private string nome;
        private int idade;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("o nome deve ser obrigatoriamente preenchido");
                }
            }
            get { return this.nome; }
        }

        public int Idade
        {

            set
            {
                if (value >= 1.0)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade não pode ser negativa");
                }
            }
            get { return this.idade; }

        }

        public double Altura
        {
            set
            {
                if (value >= 1.0)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura não pode ser negativa");
                }
            }
            get { return this.altura; }
        }

        public double Peso
        {
            set
            {
                if (value >= 1.0)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso não pode ser negativo");
                }
            }
            get { return this.peso; }
        }

        public double Calcular()
        {
            double total;
            total = this.peso / (this.altura * this.altura);
            return total;
        }
    }
}
