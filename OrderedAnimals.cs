using System;
using System.Collections.Generic;
using System.Linq;

class OrderedAnimals {
  public static void Main (string[] args) {

    List<Animal> animales = new List<Animal>();
    animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
    animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
    animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
    animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
    animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
    animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
    animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
    animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
    animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

    // Escribe tu código aquí
    // Retorna los elementos de la colleción animal ordenados por nombre

    var orderedAnimals = animales.OrderBy(p=> p.Nombre);

    foreach (var item in orderedAnimals)
    {
       Console.WriteLine(item.Nombre);
    }
   

  }

  public class Animal
  {
    public string Nombre {get;set;}
    public string Color {get;set;}
  }
}