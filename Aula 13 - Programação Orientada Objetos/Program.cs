﻿using System;
using Aula_13___Programação_Orientada_Objetos.obj;
using Aula_13___Programação_Orientada_Objetos.obj.Entities;

namespace POO
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            var professor = new Professor(5000m, "João", "12345", new DateTime(1980, 1, 1));
            var estudante = new Estudante("A","Luis","54321", new DateTime(1992, 1 , 1));

            var pessoas = new List<Pessoa> { estudante, professor };

            foreach (var pessoa in pessoas)
            {
                pessoa.SeApresentar();
            }
            Console.Read();
        }
    }
}