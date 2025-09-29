    using ExemplosFundamentos.Common.Models;



    // Instanciando um objeto do tipo Pessoa
    Pessoa p = new Pessoa();  

    // Atribuindo valores as propriedades do objeto
    p.Nome = "Felipe";  
    p.Idade = 22;

    // Chamando o método do objeto  
    p.Apresentar();











    // List <string> listaString = new List<string>(); 

    // listaString.Add("SP");  
    // listaString.Add("BA");
    // listaString.Add("MG");  
    // listaString.Add("RJ");

    // Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade atual: {listaString.Capacity}");

    // listaString.Add("SC");
    
    // Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade atual: {listaString.Capacity}");

    // listaString.Remove("MG");

    // Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade atual: {listaString.Capacity}");   













//     Console.WriteLine("Percorrendo a lista com o for");
//     for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} : {listaString[contador]}");
// }

//     Console.WriteLine("Percorrendo a lista com o foreach");
//     int contadorforEach = 0;
//     foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorforEach} - {item}");
//     contadorforEach++;
// }





























//     int [] arrayInteiros = new int[4]; 

//     arrayInteiros[0] = 72;
//     arrayInteiros[1] = 64;  
//     arrayInteiros[2] = 50;
//     arrayInteiros[3] = 1; // altera o valor da posição 0 do array

//     int [] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//     Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);  

//     //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);  



//     Console.WriteLine("Percorrendo com o for"); 
//     for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} : {arrayInteiros[contador]}");
// }










//     Console.WriteLine("Percorrendo com o foreach");

//     int contadorforEach = 0;
// foreach (int valor in arrayInteiros)

// {
//     Console.WriteLine($"Posição N° {contadorforEach} : {valor}");
//     contadorforEach++; 
// }   


   


















    // Pessoa pessoa1 = new Pessoa();
    // pessoa1.Nome = "Felipe";
    // pessoa1.Idade = 22;
    // pessoa1.Apresentar();

    







// string? opcao;
// bool exibirMenu = true; 

// while (exibirMenu)

// { 
//   Console.Clear();
//   Console.WriteLine("Digite uma opção: ");
//   Console.WriteLine("1 - Cadastrar o cliente");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar cliente");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();

//   switch (opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro do cliente");
//       break;

//     case "2":
//       Console.WriteLine("Busca cliente");
//       break;

//     case "3":
//       Console.WriteLine("Apagar cliente");
//       break;

//     case "4":
//       Console.WriteLine("Encerrar");
//       exibirMenu = false;
//       //Enviroment.Exit(0); 
//       break;

//     default:
//       Console.WriteLine("Opção inválida, digite novamente");
//       break;
//   } 
// }

// Console.WriteLine("O programa se encerrou");



















// int soma = 0, numero = 0;


// do
// {
//   Console.WriteLine("Digite um número (O para sair)");
//   numero = Convert.ToInt32(Console.ReadLine()); 

//   soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números é: {soma}");















// int numero = 5;
// int contador = 1;

// while (contador <= 10)

// {
//   Console.WriteLine($"{contador} * Execucao: {numero} * {contador} = {numero * contador}");
//   contador++;

//   if (contador == 6)
//   {
//     break;
//   }

// }






















// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)

// {
//   Console.WriteLine($"{numero} * {contador} = {numero * contador}");

// }















// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9); 




// int numeroIncremento = 10;

// Console.WriteLine("Incrementando o 10");

//  numeroIncremento++; // operador de incremento 
// //numero = numero + 1; 

// Console.WriteLine(numeroIncremento);  


// int numeroDecremento = 20;

// Console.WriteLine("Decrementando o 20");

// numeroDecremento--; // operador de decremento 

// Console.WriteLine(numeroDecremento);







// Calculadora calc = new Calculadora();



// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);







// calc.Potencia(2, 10);







// calc.Somar(10, 30);
// calc.Subtrair(10, 30);  
// calc.Multiplicar(10, 30);
// calc.Dividir(10, 30);















// bool choveu = true; 
// bool estaTarde = false; 

// if (!choveu && !estaTarde) // ! operador "NÃO"

// {
//   Console.WriteLine("Vou pedalar");
// }
// else 
// {
//   Console.WriteLine("Vou pedalar outro dia");
// }










// bool possuiPresencaMinima = true;
// double media = 7.5;

// if(possuiPresencaMinima && media >= 8) // && operador "E"
// {
//   Console.WriteLine("Aprovado");
// }
// else
// {
//   Console.WriteLine("Reprovado");
// }















// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDosPais = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDosPais) // || operador "OU"
// {
//   Console.WriteLine("Entrada autorizada.");
// }
// else
// {
//   Console.WriteLine("Entrada não autorizada.");
// }



















// Console.WriteLine("Digite uma letra");

// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Não é uma vogal");
//     break;

//  }















// {
//   Console.WriteLine("Vogal 1");
// }

// else if (letra == "e")
// {
//   Console.WriteLine("Vogal 2");
// }

// else if (letra == "i")
// {
//   Console.WriteLine("Vogal 3");
// }

// else if (letra == "o")
// {
//   Console.WriteLine("Vogal 4");
// }

// else if (letra == "u")
// {
//   Console.WriteLine("Vogal 5");
// }

// else
// {
//   Console.WriteLine("Não é uma vogal");
// }


















// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 5;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: { quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade desejada para compra: { quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda?  {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("A quantidade de compra não pode ser zero.");
// }

// else if (possivelVenda) 

// {
//   Console.WriteLine("Compra realizada com sucesso!");
// }
// else
// {
//   Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }


























// string a = "15";

// //int b = 0;

// int.TryParse(a, out int b);


// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!"); 













// double a = 4 / (2 + 2); // ordem matématica

// Console.WriteLine(a);



















//int a = 5;
//double b = a; // conversão implícita

//int a = 5;
//long b = a; // conversão implícita

// int a = int.MaxValue;
// long b = a;


// Console.WriteLine(b);
















//int inteiro = 5;

//string a = inteiro.ToString();

//Console.WriteLine(a);


















// Cast - Casting (conversão de tipos)

//int a = Convert.ToInt32(null);

//int a = int.Parse(null);

//Console.WriteLine(a);










// int a = 10;
// int b = 20;

// int c = a + b;

// //c = c + 5;
// c += 5;

// Console.WriteLine(c);



//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); 





// string apresentacao = "Olá, seja bem vindo ao curso de .NET";

// int quantidade = 1;
// Console.WriteLine("Quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Quantidade: " + quantidade);


// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Quantidade: " + quantidade);
// Console.WriteLine("Altura: " + altura.ToString ("0.00"));
// Console.WriteLine("Preço: " + preco);
// Console.WriteLine("Condição: " + condicao);









//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Felipe";
//pessoa1.Idade = 22; 
//pessoa1.Apresentar();

//Pessoa pessoaFisicaRepresentacao = new Pessoa();
