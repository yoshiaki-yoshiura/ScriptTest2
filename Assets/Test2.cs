using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//以下の{}内は「ボスの処理」に関する変数と関数
public class Boss
{
    //↓「pribate」だから、Bossクラス内でしか使えない
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    //↓「public」だから、Bossクラス以外でも使える
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        for (int i = mp; i >= 3; i-=5)
        {
            //↓ボツ
            //int mpzan = i;
            //if (mpzan >= 5)
            if (i >= 5)
            {
                Debug.Log("魔法攻撃をした。残りMPは〇〇。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }
    }
}

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //lastboss変数に対してボスの実態を作り(代入し)、この{}内で「ボスの処理」を呼び出せるようにした
        Boss lastboss = new Boss();

        //↓Bossクラスのメンバ関数を使う時は「変数名.関数名」と記述

        lastboss.Attack();　　　//Bossクラスの「Attack関数」を呼び出して{}内の処理を実行
        lastboss.Defence(3);　　//Bossクラスの「Defence関数」に3を代入して呼び出し{}内の処理を実行
        lastboss.Magic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
