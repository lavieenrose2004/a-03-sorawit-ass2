using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // Attributes
    protected string name;
    protected int health;   // ����¹�� protected �����
    protected float hunger; // ����¹�� protected �����
    public readonly float speed;

    // ���� Property ����Ѻ�����Ҷ֧ health
    public int Health
    {
        get { return health; }
        protected set { health = value; }  // �ӡѴ�����¹੾�����㹤���
    }

    // ���� Property ����Ѻ�����Ҷ֧ hunger
    public float Hunger
    {
        get { return hunger; }
        protected set { hunger = value; }  // �ӡѴ�����¹੾�����㹤���
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

