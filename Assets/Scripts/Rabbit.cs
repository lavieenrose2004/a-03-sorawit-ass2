using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal
{
    // Constructor ��˹���������������Ѻ Rabbit
    public Rabbit() : base("Rabbit", 8, "Plant", 3, 5) { }

    // Override Method Move ���������͹��Ǣͧ Rabbit �繡�á��ⴴ
    public override void Move()
    {
        Debug.Log("The rabbit hops quickly.");
    }
}

