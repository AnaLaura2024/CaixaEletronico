﻿class Program
{
    static void Main(string[] args)
    {
        // Definição de variáveis
        int contaNumero = 123456;
        double saldo = 0;
        int opcao;
        double valor;
                while (true)
        {
            // Menu de opções
            Console.WriteLine("\n--- Caixa Eletrônico ---");
            Console.WriteLine("1. Depósito");
            Console.WriteLine("2. Saque");
            Console.WriteLine("3. Extrato");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1: // Depósito
                    Console.Write("Valor do depósito: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    if (valor > 0)
                    {
                        saldo += valor;
                        Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
                    }
                    else



