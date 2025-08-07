using System.Runtime;
using Atividade_O_O;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");

        var livro1 = new Livro()
        {
            Titulo = "O Senhor dos Anéis",
            Autor = "J.R.R. Tolkien",
            Editora = "HarperCollins",
            AnoDeLancamento = 1954
        };

        var livro2 = new Livro()
        {
            Titulo = "1984",
            Autor = "George Orwell",
            Editora = "Secker & Warburg",
            AnoDeLancamento = 1949
        };

        var livro3 = new Livro()
        {
            Titulo = "Dom Quixote",
            Autor = "Miguel de Cervantes",
            Editora = "Francisco de Robles",
            AnoDeLancamento = 1605
        };

        Console.WriteLine($"Título: {livro1.Titulo} | {livro1.Autor} | {livro1.Editora} | {livro1.AnoDeLancamento}");
        Console.WriteLine($"Título: {livro2.Titulo} | {livro2.Autor} | {livro2.Editora} | {livro2.AnoDeLancamento}");
        Console.WriteLine($"Título: {livro3.Titulo} | {livro3.Autor} | {livro3.Editora} | {livro3.AnoDeLancamento}");

        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------");

        var aluno1 = new Aluno()
        {
            RM = 123456,
            Nome = "João Silva",
            Nascimento = new DateTime(2005, 5, 15),
            Email = "Joaosilva@gmail.com"
        };

        var aluno2 = new Aluno()
        {
            RM = 654321,
            Nome = "Maria Oliveira",
            Nascimento = new DateTime(2003, 7, 18),
            Email = "Mariaoliveira@gmail.com"

        };

        var aluno3 = new Aluno()
        {
            RM = 789012,
            Nome = "Carlos Pereira",
            Nascimento = new DateTime(2008, 3, 14),
            Email = "Carlospereira@gmail.com"

        };

        Console.WriteLine($"RM: {aluno1.RM} | Nome: {aluno1.Nome} | Nascimento: {aluno1.Nascimento: dd/MM/yy} | Email: {aluno1.Email}");
        Console.WriteLine($"RM: {aluno2.RM} | Nome: {aluno2.Nome} | Nascimento: {aluno2.Nascimento: dd/MM/yy} | Email: {aluno2.Email}");
        Console.WriteLine($"RM: {aluno3.RM} | Nome: {aluno3.Nome} | Nascimento: {aluno3.Nascimento: dd/MM/yy} | Email: {aluno3.Email}");

        Console.WriteLine($"\n------------------------------------------------------------------------------------------------------------------------------------------------------------");

        var produto1 = new Produto()
        {
            Codigo = 3452,
            Nome = "Lapis",
            Preco = 5.00m,
            Estoque = 10
        };

        var produto2 = new Produto()
        {
            Codigo = 1234,
            Nome = "Caneta",
            Preco = 3.00m,
            Estoque = 20
        };

        var produto3 = new Produto()
        {
            Codigo = 5678,
            Nome = "Caderno",
            Preco = 15.00m,
            Estoque = 5
        };

        Console.WriteLine($"\nCódigo: {produto1.Codigo}");
        Console.WriteLine($"\n Nome: {produto1.Nome}");
        Console.WriteLine($"\n Preço: {produto1.Preco}");
        Console.WriteLine($"\n Estoque: {produto1.Estoque}");
        Console.WriteLine($"\n Total em estoque: R${produto1.ValorEstoque():0.00}");

        Console.WriteLine($"\nCódigo: {produto2.Codigo}");
        Console.WriteLine($"\n Nome: {produto2.Nome}");
        Console.WriteLine($"\n Preço: {produto2.Preco}");
        Console.WriteLine($"\n Estoque: {produto2.Estoque}");
        Console.WriteLine($"\n Total em estoque: R${produto2.ValorEstoque():0.00}");

        Console.WriteLine($"\nCódigo: {produto3.Codigo}");
        Console.WriteLine($"\n Nome: {produto3.Nome}");
        Console.WriteLine($"\n Preço: {produto3.Preco}");
        Console.WriteLine($"\n Estoque: {produto3.Estoque}");
        Console.WriteLine($"\n Total em estoque: R${produto3.ValorEstoque():0.00}");

        Console.WriteLine($"\n------------------------------------------------------------------------------------------------------------------------------------------------------------");

        var carro1 = new Carro
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Velocidade = 00,
        };

        Console.WriteLine($"\nMarca: {carro1.Marca}");
        Console.WriteLine($"Modelo: {carro1.Modelo}");
        Console.WriteLine($"Velocidade: {carro1.Velocidade}");
        Console.WriteLine($"Acelerar: {carro1.Acelerar(10)}Km/h");
        Console.WriteLine($"Acelerar: {carro1.Acelerar(20)}Km/h");
        Console.WriteLine($"Acelerar: {carro1.Desacelerar(15)}Km/h");

        Console.WriteLine($"\n------------------------------------------------------------------------------------------------------------------------------------------------------------");

        var f1 = new Funcionario("Ana", 25, "Analista");
        var f2 = new Funcionario("Bruno", 30, "Gerente");
        var f3 = new Funcionario("Carlos", 28, "Desenvolvedor");

        f1.Exibir();
        f2.Exibir();
        f3.Exibir();

        //Envelhecendo em cada um 
        f1.Envelhecer(2);
        f2.Envelhecer(5);
        f3.Envelhecer(1);

        Console.WriteLine($"\n------------------------------------------------------------------------------------------------------------------------------------------------------------");

        var gato = new Gato();
        var porco = new Porco();
        var capivara = new Capivara();

        gato.Exibir();
        gato.EmitirSom();

        porco.Exibir();
        porco.EmitirSom();

        capivara.Exibir();
        capivara.EmitirSom();

        Console.WriteLine

       ($"\n------------------------------------------------------------------------------------------------------------------------------------------------------------");

        ContaCorrente conta1 = new ContaCorrente
        {
            Banco = "Banco do Brasil",
            Agencia = "1234",
            Conta = "56789-0",
            Saldo = 1000.00m
        };

        ContaCorrente conta2 = new ContaCorrente
        {
            Banco = "Caixa Econômica",
            Agencia = "4321",
            Conta = "09876-5",
            Saldo = 500.00m,
            Limite = 200.00m
        };

        ContaCorrente conta3 = new ContaCorrente
        {
            Banco = "Santander",
            Agencia = "5678",
            Conta = "12345-6",
            Saldo = 1500.00m,
            Limite = 300.00m
        };

        conta1.Depositar(500.00m);
        Console.WriteLine($"Saldo da conta 1 após depósito: {conta1.Saldo:C}");

        bool saque = conta2.Sacar(200.00m);
        Console.WriteLine($"Saque na conta 2 {(saque ? "realizado com sucesso" : "falhou")}. Saldo atual: {conta2.Saldo:C}");

        bool SaqueInvalido = conta3.Sacar(1000.00m);
        Console.WriteLine($"Saque na conta 3 {(SaqueInvalido ? "realizado com sucesso" : "falhou")}. Saldo atual: {conta3.Saldo:C}");

        Console.WriteLine($"\n----------------------------------------------------------------------------------------------------------------------------------------------");

        ContaGenerica2 contagenerica = new ContaGenerica2("Banco", "Agencia", "Conta", 200);

        Console.WriteLine($"\n----------------------------------------------------------------------------------------------------------------------------------------------");
        Personagem personagem1 = new Personagem("Gandalf", "Mago", 5, 7, 10, 8, 6);

        Console.WriteLine("---- Dados do Personagem ----");
        Console.WriteLine($"Nome: {personagem1.Nome}");
        Console.WriteLine($"Categoria: {personagem1.Categoria}");
        Console.WriteLine($"Nivel: {personagem1.Nivel}");
        Console.WriteLine($"Força: {personagem1.Forca}");
        Console.WriteLine($"Inteligência: {personagem1.Inteligencia}");
        Console.WriteLine($"Vida: {personagem1.Vida}");

        Console.WriteLine($"\n----------------------------------------------------------------------------------------------------------------------------------------------");
        Retangulo retangulo1 = new Retangulo(5, 3);
        Circulo circulo1 = new Circulo(4);

        Console.WriteLine("Área do Retângulo: " + retangulo1.CalcularArea());
        Console.WriteLine("Área do Circulo: " + circulo1.CalcularArea());

    }
}