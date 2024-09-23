using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    void Start()
    {
        Cat cat = new Cat(); 
        Debug.Log("Cat has health: " + cat.Health + ", Speed: " + cat.speed + ", Hunger: " + cat.Hunger);
        cat.Eat("Meat");
        cat.Move();
        cat.Sleep();
        cat.Climb();  
    }
}

