using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//以下の{}内は「ボスの処理」に関する変数と関数
public class Boss
{
    //↓「pribate」だから、Bossクラス内でしか使えない
    private int hp = 100;
    private int power = 25;
    //private int mp = 53;


    //↓「public」だから、Bossクラス以外でも使える
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;  　//残りhpを減らす　←これってもしかしてmp消費のヒント？（←結局関係無い）
    }

    public void Magic(int mp)　　　　//←Magic関数内でmpを5以上の場合は5減らす + 文字列表示
    {
        if (mp >= 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。"); 
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test2 : MonoBehaviour
{
    void Start()
    {
        //lastboss変数に対してボスの実態を作り(代入し)、この{}内で「ボスの処理」を呼び出せるようにした
        Boss lastboss = new Boss();

        //↓Bossクラスのメンバ関数を使う時は「変数名.関数名」と記述

        lastboss.Attack();　　　//Bossクラスの「Attack関数」を呼び出して{}内の処理を実行
        lastboss.Defence(3);　　//Bossクラスの「Defence関数」に3を代入して呼び出し{}内の処理を実行

        for (int mp = 53; mp >= 3; mp -= 5)　　　//ここでMagic関数を「11回」呼び出す処理
        {
            lastboss.Magic(mp);
        }

        //ボツ　for (int i = mp; i >= 3; i-=5)　←これだとmpではなくiが減っている。
        //{
        //}
}

    void Update()
    {
        
    }
}
