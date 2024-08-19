/*
玩家
    血量
    控制攻击方向
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    /// <summary>
    /// 血量
    /// </summary>
    private int hp = 100;

    /// <summary>
    /// 攻击间隔计时器，防止不停乱按也能打到的情况
    /// </summary>
    private float attackTime = 0;


    /// <summary>
    /// 加减血
    /// </summary>
    /// <param name="change">变化量（负数为减少）</param>
    public void changeHp(int change)
    {
        hp += change;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        attackTime += 0.02f;
        if (attackTime >= Constants.ATTACK_INTERVAL)
        {
            attackTime = 0;
        }
    }
}
