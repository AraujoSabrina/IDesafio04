// See https://aka.ms/new-console-template for more information

using IDesafio04;

Banco banco = new Banco();

Usuario usuario = new Usuario(1);

Console.WriteLine($"Antes do deposito: {banco.getConta(1)}");
banco.adicionarUsuario(usuario);

banco.depositar(1, 3);
Console.WriteLine($"Depois do deposito: {banco.getConta(1)}");

banco.sacar(1, 100000);
Console.WriteLine($"Depois do saque: {banco.getConta(1)}");
