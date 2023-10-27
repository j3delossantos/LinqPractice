using System;
using System.Collections.Generic;
using System.Linq;

class Animals {
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
    animales.Add(new Animal() { Nombre = "Aguila", Color = "Verde" });

    // Escribe tu código aquí
    // filtra todos los animales que sean de color verde que su nombre inicie con una vocal
    var vocales = new string[] {"A","E","I","O","U","a","e","i","o","u"};
    
    var animalesfiltrados = animales.Where(p=> p.Color.Contains("Verde") && vocales.Contains(p.Nombre[0].ToString()));
    foreach (var item in animalesfiltrados)
    {
      Console.WriteLine($"Nombre: {item.Nombre}, Color: {item.Color}");
    }

      
  }


  
  public class Animal
  {
    public string Nombre {get;set;}
    public string Color {get;set;}
  }
  

 
 
    
  
}