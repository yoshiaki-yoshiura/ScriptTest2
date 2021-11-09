using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic(int mpzan)
    {
        
        string mpkekka = (mpzan >= 5) ? "魔法攻撃をした。残りMPは〇〇。" : "MPが足りないため、魔法が使えない。";
        Debug.Log(mpkekka);


        //＜mpを消費して魔法攻撃をするMagic関数を作る＞

        //　mp5以上　　→　「mp5減らし」+「"魔法攻撃をした。残りMPは〇〇。"」 　＜3個処理＞
        //　mp5より下　→　「"MPが足りないため、魔法が使えない。"」　　　　  　　＜1個処理＞

        //「5以上」と「5より下」のif文で「2択の処理」　※「mp5減らす」のは↓の呼び出し元？

        //　for文の「合計値を求めるスクリプト」を応用すればMPの残量も出せるかも
        //　メモ　→　Debug.Log("魔法攻撃をした。残りMPは" + 〇〇 + "。");

    }
}

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        for (int i = 53; i < 5; i-=5)
        {
            lastboss.Magic(i);
        }
        

        //条件①　Magic関数を呼び出して魔法を使う
        //条件②　Magic関数を10回使った後、Magic関数を呼び出すと「mpが足りない〜」表示　　　　　　

        //　MPを5ずつ11回減らす「for文」

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
