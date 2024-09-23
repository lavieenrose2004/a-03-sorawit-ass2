using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Constructor กำหนดค่าเริ่มต้นสำหรับ Cat
    public Cat() : base("Cat", 10, "Meat", 5, 3) { }

    // Override Method Move ให้การเคลื่อนไหวของ Cat มีความพิเศษ
    public override void Move()
    {
        Debug.Log("The cat gracefully moves.");
    }

    // Method พิเศษของ Cat ที่สามารถปีนได้
    public void Climb()
    {
        Debug.Log("The cat climbs.");
    }
}

