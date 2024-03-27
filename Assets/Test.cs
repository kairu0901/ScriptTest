using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mission1
{
    private int[] array = { 10, 20, 30, 40, 50 };

    public void Asc()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
    }
    public void Desc()
    {
        for (int i = 4; i > -1;i--)
        {
            Debug.Log(array[i]);
        }
    }
}

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;


    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Mission1 mission1 = new Mission1();
        mission1.Asc();
        mission1.Desc();

        Boss lastboss = new Boss();
        lastboss.Magic();

        for (int i = 0; i<10; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}