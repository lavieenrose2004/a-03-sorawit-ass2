using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitScript : MonoBehaviour
{
    void Start()
    {
        Rabbit rabbit = new Rabbit(); 
        Debug.Log("Rabbit has health: " + rabbit.Health + ", Speed: " + rabbit.speed + ", Hunger: " + rabbit.Hunger);  
        rabbit.Eat("Plant");
        rabbit.Move();
        rabbit.Sleep();
    }
}

