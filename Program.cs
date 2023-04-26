// See https://aka.ms/new-console-template for more information
using Explorando_c_.Models;
/*
//para alterar a configuração da cultura do sistema
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");//altera de maneira geral no sistema
// valores monetarios
decimal valorMonetario = 156682.45M;
// :C em numeros decimal serve para pegar a configuração de moeda do sistema em que tá rodando e usar para configurar o valor de acordo
Console.WriteLine($"{valorMonetario:C}");
//Altera de maneira de maneira local no sistema
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
//ALterando de maneira personalizada
Console.WriteLine(valorMonetario.ToString("N9"));

//Porcentagem
double porcentagem = .5865;
Console.WriteLine(porcentagem.ToString("p"));

//Formatação personalizada
int numero = 152356;
Console.WriteLine(numero.ToString("##-##-##"));

//manipulando data
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

Console.WriteLine("Digite uma data");
string dataDigitada = "03-10-2000";
//Validando e convertendo para uma data validada
if(DateTime.TryParseExact(dataDigitada,"dd-MM-yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
{
    Console.WriteLine(date.ToShortDateString());
}else
{
    Console.WriteLine("Data Invalida");
}




Pessoa p1 = new Pessoa();
p1.Nome = "Karma";
p1.SobreNome = "Angelo";
p1.Idade = 22;

Pessoa p2 = new Pessoa(nome:"Deltina",sobreNome:"Gatinha");
p2.Idade = 22;

Cursos cursoIngles = new Cursos();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdcionarAlunos(p1);
cursoIngles.AdcionarAlunos(p2);
cursoIngles.ListaAlunos();
*/

/*

//Leiturar de arquivos 
//para contornar algum erro usamos o try para testar casa algum erro, para não finalizar o codigo o trecho catch é executado e o algoritimo 
//continua rodando
//podemos também prever alguma exceções mais expecificas e tratar cada uma de maneira expecifica com varios catch seguidos 
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(String linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não localizado. {ex.Message}");
} catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretorio não localizado. {ex.Message}");
} catch(Exception ex)
{
    Console.WriteLine($" Exceção generica. {ex.Message}");
}//temos o bloco finally onde é executado independente se ocorreu um erro ou não diferente dos blocas catch que execeutam quando ocorre uma erro
finally
{
    Console.WriteLine("Chegou até aqui");
}

new ExemploExcecao().Metodo1();

*/
//FILA
//criando uma fila

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(8);

foreach(int item in fila)
{
    //Console.WriteLine(item);
}
//Não passa nem um parametro pois em fila sempre sai o primeiro elemento
Console.WriteLine($"Removendo elemento {fila.Dequeue()}");

foreach(int item in fila)
{
    //Console.WriteLine(item);
}

fila.Enqueue(16);

foreach(int item in fila)
{
    //Console.WriteLine(item);
}

//Pilhas
Console.WriteLine("Pilha");
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(8);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("Removendo Elementod do topo: "+ pilha.Pop());

