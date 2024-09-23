using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{
    void Start()
    {
        Dog dog = new Dog(); 
        Debug.Log("Dog has health: " + dog.Health + ", Speed: " + dog.speed + ", Hunger: " + dog.Hunger);  
        dog.Eat("Meat");
        dog.Move();
        dog.Sleep();
    }
}

