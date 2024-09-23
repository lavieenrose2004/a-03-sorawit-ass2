using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Constructor กำหนดค่าเริ่มต้นสำหรับ Dog
    public Dog() : base("Dog", 12, "Meat", 6, 4) { }

    // Override Method Move ให้การเคลื่อนไหวของ Dog มีลักษณะเฉพาะ
    public override void Move()
    {
        Debug.Log("The dog runs swiftly.");
    }
}
