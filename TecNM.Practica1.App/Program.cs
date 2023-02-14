// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Enums;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;
using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.App;

public static class Program {

    public static void Main(string[] args){
        float Weight = 0;
        
        System.Console.WriteLine("Please enter the Weight");
        Single.TryParse(System.Console.ReadLine(), out Weight);

        var person = new Person{weight = Weight};

        var service = new CalculeServices();
        var manager = new CalculeWManager(service);

        CalculeW cal = manager.GetCal(person);

        System.Console.WriteLine($"Tu peso ingresado es: {Weight} ");
        System.Console.WriteLine($"Tu peso en marte es: {cal.pesoMarte} ");
        System.Console.WriteLine($"Tu peso en venus es: {cal.pesoVenus } ");
        System.Console.WriteLine($"Tu peso en Urano es: {cal.pesoUrano} ");
        System.Console.WriteLine($"Tu peso en mercurio: {cal.pesoMercurio} ");




    }
    
}