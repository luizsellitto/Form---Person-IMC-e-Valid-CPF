using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Form___Person_IMC_e_Valid_CPF
{
    internal class Pessoa
    {

        private string nome;
        private string cpf;
        private string idade;
        private string sexo;
        private double peso;
        private double altura;


        public Pessoa(string nome, string cpf, string idade, string sexo, double peso, double altura) 
        { 

            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        
        }

        public string getNome()
        { return nome; }
        public void setNome(string nome)
        { this.nome = nome; }

        public string getCPF()
        { return cpf; }
        public void setCPF(string cpf)
        { this.cpf = cpf; }

        public string getIdade()
        { return idade; }
        public void setIdade(string idade)
        { this.idade = idade; }

        public string getSexo()
        { return sexo; }
        public void setSexo(string sexo)
        { this.sexo = sexo; }

        public double getPeso()
        { return peso; }
        public void setPeso( double peso)
        { this.peso = peso;}

        public double getAltura()
        { return altura; }
        public void setAltura(double altura)
        { this.altura = altura; }

        public (double, string, string) IMC()
        {
            string classificacao;
            string grau;

            double imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                classificacao = "Magreza";
                grau = "0";
            }
            else if (18.5 >= imc && imc < 25)
            {
                classificacao = "Normal";
                grau = "0";
            }
            
            else if (25 >= imc && imc < 30)
            {
                classificacao = "SobrePeso";
                grau = "I";
            }
            else if (30 >= imc && imc < 40)
            {
                classificacao = "Obesidade";
                grau = "II";
            }
            else
            {
                classificacao = "Obesidade Grave";
                grau = "III";
            }

            return (imc, classificacao, grau);
        }


    }
}
