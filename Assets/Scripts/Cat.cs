using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Constructor ��˹���������������Ѻ Cat
    public Cat() : base("Cat", 10, "Meat", 5, 3) { }

    // Override Method Move ���������͹��Ǣͧ Cat �դ��������
    public override void Move()
    {
        Debug.Log("The cat gracefully moves.");
    }

    // Method ����ɢͧ Cat �������ö�չ��
    public void Climb()
    {
        Debug.Log("The cat climbs.");
    }
}

