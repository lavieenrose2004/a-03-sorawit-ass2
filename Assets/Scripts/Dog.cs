using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Constructor ��˹���������������Ѻ Dog
    public Dog() : base("Dog", 12, "Meat", 6, 4) { }

    // Override Method Move ���������͹��Ǣͧ Dog ���ѡɳ�੾��
    public override void Move()
    {
        Debug.Log("The dog runs swiftly.");
    }
}
