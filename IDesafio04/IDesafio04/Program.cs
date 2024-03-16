// See https://aka.ms/new-console-template for more information

using IDesafio04;

Banco banco = new Banco();

Console.WriteLine($"Antes do deposito: {banco.getConta(2)}");
banco.adicionarUsuario(Usuario user(1));

banco.depositar(1, 3);
Console.WriteLine($"Depois do deposito: {banco.getConta(2)}");

banco.sacar(1, 10);
Console.WriteLine($"Depois do saque: {banco.getConta(2)}");
