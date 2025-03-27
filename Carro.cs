using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO;

namespace POO
{
    
    
        class Carro
        {
            //Atributos 
            public string Marca;
            public string Modelo;
            public string Ano;

            // Metodos
            public void Andar()
            {
                Console.WriteLine(" Carro esta andando!");

            }
            public void parar()
            {
                Console.WriteLine("O carro esta parado!");
            }
            public void MostrarInformacoes()
            {
                Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
            }
        }

    }

