using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Neste projeto, devemos criar uma malha crescente com asteriscos:

//*
//**
//***
//****
//*****
//******
//*******
//********
//*********
//**********

namespace ComandoBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso do Break");

            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                        if (contadorColuna >= contadorLinha)
                    {
                        break;
                    }   
                }

                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
