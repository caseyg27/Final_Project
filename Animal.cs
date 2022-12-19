using System;
using System.ComponentModel;
// Base Class

public class Animal
{
    public string name;
    public int age;
    public string color;
    public string gender;
    public float weight;

    public Animal()
    {
    }

    public virtual void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

//Derived Class

public class Dog : Animal
{
    public string breed;
    public string ownerName;
    public bool rabbiesShot;
    public Dog()
    {

    }
}


public class Cat : Animal
{
    public string breed;
    public bool houseCat;
    public bool hair;
    public Cat()
    {

    }
    public override void Bark()
    {
        Console.WriteLine("Meow!");
    }
}

public class Fish : Animal
{
    public string WaterType;
    public bool zoo;
    public Fish()
    {

    }

    public override void Bark()
    {
        Console.WriteLine("Glumb Glumb");
    }
}