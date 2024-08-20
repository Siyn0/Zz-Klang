using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerController.OnAttackEvent += attackEvent;
    }


    /// <summary>
    /// 接收攻击事件
    /// </summary>
    /// <param name="direction">方向 1左 2右</param>
    private void attackEvent(int direction)
    {
        Debug.Log("[zzzz]收到了攻击事件，方向是" + direction);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
