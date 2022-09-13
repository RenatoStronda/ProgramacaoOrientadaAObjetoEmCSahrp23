// See https://aka.ms/new-console-template for more information
﻿using System;
using Classes;
namespace celulaR{
	class Program{
		public static void Main(string [] args){
            cel ce = new cel(4, 5000, "modelo");
            Console.WriteLine(ce.getModelo());
            Console.WriteLine(ce.getPreco());
            Console.WriteLine(ce.getTamanhoTela());
            Console.WriteLine("");
            ce.setModelo("Samsung S22: ");
            ce.setPreco(8000);
            ce.setTamanhoTela(7);
            Console.WriteLine("O Modelo Do Seu Celular É: ");
            Console.WriteLine(ce.getModelo());
            Console.WriteLine("");
            Console.WriteLine("O Valor Do Seu Celular É: ");
            Console.WriteLine(ce.getPreco());
            Console.WriteLine("");
            Console.WriteLine("O Tamanho Da Tela Do Seu Celular É: ");
            Console.WriteLine(ce.getTamanhoTela());
        }
    }
}
/*4- Crie uma classe Celular com três atributos: preço : float, tamanhoTela : float e modelo : string. Implemente o método construtor e 
parametrize ele com todos os atributos da classe. 
Implemente todos os métodos getters e setters referentes aos três atributos.*/