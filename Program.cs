﻿    Console.WriteLine("Entre com o seu nome");
    string nome = Console.ReadLine();

    Console.WriteLine("Entre com sua altura em metros. Ex:1,70");
    float altura = Convert.ToSingle(Console.ReadLine());

            
    Console.WriteLine("Entre com seu peso em Kg. Ex: 102,5");
    float peso = Convert.ToSingle(Console.ReadLine());

    double imc = peso / (altura * altura);

    Console.WriteLine("{0} sua altura é {1} e seu peso {2}", nome, altura, peso);
    Console.WriteLine("Seu IMC é {0}", imc);
