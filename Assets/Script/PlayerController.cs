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
    /// 刚刚按过攻击键
    /// </summary>
    private bool isAttack = false;

    /// <summary>
    /// 攻击事件
    /// </summary>
    /// <param name="direction">方向 1左 2右</param>

    public delegate void attackEventHandler(int direction);

    public static event attackEventHandler OnAttackEvent;


    /// <summary>
    /// 加减血
    /// </summary>
    /// <param name="change">变化量（负数为减少）</param>
    public void changeHp(int change)
    {
        hp += change;
        if (hp <= 0)
        {
            Debug.Log("You Died！！！");
            // TODO: 死了显示UI
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAttack)
        {
            return;
        }

        if (Input.GetButtonDown("left"))
        {
            Debug.Log("[zzzz]left");
            if (OnAttackEvent != null)
            {
                OnAttackEvent(1);
                isAttack = true;
            }
        }

        if (Input.GetButtonDown("right"))
        {
            if (OnAttackEvent != null)
            {
                OnAttackEvent(2);
                isAttack = true;
            }
        }
    }


    private void FixedUpdate()
    {
        if (!isAttack)
        {
            return;
        }
        attackTime += 0.02f;
        if (attackTime >= Constants.ATTACK_INTERVAL)
        {
            attackTime = 0;
            isAttack = false;
        }
    }
}
