//// Listas
////string[] nomes = new string[5]

////Generico
//using System.Threading.Channels;

//List<string> ListaDeNomes = new List<string>();
////Ou
//List<string> ListaDeNomes2 = new();

//ListaDeNomes.Add("Fulano");
//ListaDeNomes.Add("Siclano");
//ListaDeNomes.Add("Beltramo");

////Para exibir a liste de nomes 
//foreach (var item in ListaDeNomes) 
//{
//    Console.WriteLine(item);
//}

////Para apagar nomes 
//ListaDeNomes.Remove("Fulano");


//POO - Programacao Orientada a Objetos 
// Programacao estruturada
// Objetivo - Aproximar a programacao do mundo real
// Separar os nossos sistemas em partes menores 
//Classe e Objetos 

// Classe : Definocao de um item da vida real representados em codigo
// Atributis (caracteristicas) - Metodos (Acoes)

using POO;

Console.WriteLine("");

// Objeto - E uma instancia de uma classe 

Carro carro1 = new Carro();
//Para acessar informacoes do objeito eu vou usar "."
carro1.Modelo = "HB20";
carro1.Marca = "Hyndai";
carro1.Ano = "2024";

    carro1.Andar();
    carro1.parar(); 

Carro carro2 = new Carro();

carro2.Modelo = "Passat";
carro2.Marca = "volkswagen";
carro2.Ano = "2017";

carro2.Andar();
carro2.parar();

Carro carro3 = new Carro();

carro3.Modelo = "Spin";
carro3.Marca = "Chevrolet";
carro3.Ano = "2017";

Carro carro4 = new Carro();

carro4.Marca = "volkswagen";
carro4.Marca = "Up!";
carro4.Ano = "2017";