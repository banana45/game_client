using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    void Attack(string enemy_id)
    {   
        //向服务器请求战斗判定
        //Get(self_id,enemy_id);
    }

    void MoveEvent()
    {
        //根据移动至特定地点触发事件
    }

    void TimeEvent()
    {
        //根据位置及时间触发事件
    }

    void MoveIncident()
    {
        //根据移动距离触发随机事件
    }

    void TimeIncident()
    {
        //根据在线事件触发随机事件
    }

    void Update(){
        MoveEvent();
        TimeEvent();
        MoveIncident();
        TimeIncident();
    }

}
