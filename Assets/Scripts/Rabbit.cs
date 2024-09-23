using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal
{
    // Constructor กำหนดค่าเริ่มต้นสำหรับ Rabbit
    public Rabbit() : base("Rabbit", 8, "Plant", 3, 5) { }

    // Override Method Move ให้การเคลื่อนไหวของ Rabbit เป็นการกระโดด
    public override void Move()
    {
        Debug.Log("The rabbit hops quickly.");
    }
}

