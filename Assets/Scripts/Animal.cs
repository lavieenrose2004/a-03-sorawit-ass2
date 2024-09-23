using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // Attributes
    protected string name;
    protected int health;   // เปลี่ยนเป็น protected เช่นเดิม
    protected float hunger; // เปลี่ยนเป็น protected เช่นเดิม
    public readonly float speed;

    // เพิ่ม Property สำหรับการเข้าถึง health
    public int Health
    {
        get { return health; }
        protected set { health = value; }  // จำกัดการเขียนเฉพาะภายในคลาส
    }

    // เพิ่ม Property สำหรับการเข้าถึง hunger
    public float Hunger
    {
        get { return hunger; }
        protected set { hunger = value; }  // จำกัดการเขียนเฉพาะภายในคลาส
    }

    public Animal(string name, int health, string food, float hunger, float speed)
    {
        this.name = name;
        this.health = health;
        this.hunger = hunger;
        this.speed = speed;
    }

    public virtual void Eat(string food)
    {
        Debug.Log(name + " eats " + food);
    }

    public virtual void Move()
    {
        Debug.Log(name + " moves");
    }

    public virtual void Sleep()
    {
        Debug.Log(name + " sleeps");
    }
}

