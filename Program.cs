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

//using POO;

//Console.WriteLine("");

//// Objeto - E uma instancia de uma classe 

//Carro carro1 = new Carro();
////Para acessar informacoes do objeito eu vou usar "."
//carro1.Modelo = "HB20";
//carro1.Marca = "Hyndai";
//carro1.Ano = "2024";

//    carro1.Andar();
//    carro1.parar(); 

//Carro carro2 = new Carro();

//carro2.Modelo = "Passat";
//carro2.Marca = "volkswagen";
//carro2.Ano = "2017";

//carro2.Andar();
//carro2.parar();

//Carro carro3 = new Carro();

//carro3.Modelo = "Spin";
//carro3.Marca = "Chevrolet";
//carro3.Ano = "2017";

//Carro carro4 = new Carro();

//carro4.Marca = "volkswagen";
//carro4.Marca = "Up!";
//carro4.Ano = "2017";

//-------------------------------------------------------------------------------------------------------------------------------------------------------

// Livro livro1 = new Livro();

//livro1.Autor = " Robert Martin ";
//livro1.Titulo = " Clean Code";
//livro1.Paginas = 353;


//Livro livro2 = new Livro()
//{
//    Autor = "Robert Martn",
//    Titulo = "Clean Code",
//    Paginas = 353

//};
//Console.WriteLine(livro1.Autor);
//Console.WriteLine(livro1.Titulo);
//Console.WriteLine(livro1.Paginas);

//-------------------------------------------------------------------------------------------------------------------------------------------------------


//Aluno aluno1 = new Aluno()
//{
//    Nome = "Ingryd",
//    Idade = 16,
//    NotaFinal = 10,

//};
//Console.WriteLine(aluno1.Nome);
//Console.WriteLine(aluno1.Idade);
//Console.WriteLine(aluno1.NotaFinal);


//-------------------------------------------------------------------------------------------------------------------------------------------------------





//Também crie o seguinte método:

//- `CalcularTotal` que retorna o total da `quantidadeEmEstoque` *  `preco`

//Depois, crie um objeto da classe `Produto`, altere os valores dos atributos e imprima as informações antes e depois da alteração, também imprima o resultado do método CalcularTotal.


//Produto produto1 = new Produto()
//{
//    produto = "Pão",
//    Preço = 9.90,
//    QuantidadeEmEstoque = 34,
//};

//Console.WriteLine(" O resultado e: " + produto1.CalcularTotal());
//_______________________________________________________________________________________________________________________________________________________

// Ferramentas - Formas de trabalhar com POO

//Emcapsulamento e Herança

// Encapsulamento - Esconder comportamentos e atributos para que nao possam ser acessados diretamente
// Conta bancaria (saldo)
// Sacar() - Depositar() - podem acessar o saldo

// Public - Esse atributo/metudo/classe poder ser acessado por qualquer um
// Private -  Esse atributo/metudo/classe poder ser acessado por ele mesmo 
// Protected/internal - Esse atributo/metudo/classe poder ser acessado por ele mesmo ou pela sua classe pai
//Nomenclatura - todo atributo privado deve comecar com "_"

//Get - Set - Pegar - Definir
// Get metodo para pegar um atributo privado 
// Set metodo para alterar um atributo privado

