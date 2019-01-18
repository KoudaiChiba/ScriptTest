using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;  //体力
    private int power = 25;  //攻撃力
    private int mp = 53;  //マジックポイント

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damege)
    {
        Debug.Log(damege + "のダメージを受けた");
        //残りｈｐを減らす
        this.hp -= damege;
    }

    //魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            //残りmpを減らす
            this.mp -= 5;

            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }
}


public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        int[] array = { 1, 3, 5, 7, 9 };

        //配列を順番に表示
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列を逆順で表示
        for(int j = array.Length - 1; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

        //魔法攻撃を11回使用する
        for(int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}