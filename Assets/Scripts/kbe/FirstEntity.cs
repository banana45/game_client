

namespace KBEngine
{

using KBEngine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

/// <summary>
/// FirstEntity的客户端实现
/// </summary>
public class FirstEntity : FirstEntityBase
{
    /// <summary>
    /// 实现了基类中已经定义好的onEnter（该函数的基类抽象方法，由引擎的客户端SDK生成器自动生成）
    /// </summary>
    public override void onEnter()
    {
        //日志
        Dbg.INFO_MSG("FirstEntity::onEnter");
        //当进入后，加载某个场景
        SceneManager.LoadScene("map_new"); 
    }

    public override void onAddEquip(Int32 equipID)
    {
        Dbg.INFO_MSG("Bag::onAddEquip");
    }

    public override void onRemoveEquip(Int32 equipID)
    {
        Dbg.INFO_MSG("Bag::onRemoveEquip");
    }
    /*
    /// <summary>
    /// 实现了基类中已经定义好的onSay（该函数的基类抽象方法，由引擎的客户端SDK生成器自动生成）
    /// </summary>
    /// <param name="content"></param>
    public override void onSay(string content)
    {
        Dbg.INFO_MSG(content);
        //找到UI Text对象
        Text text = GameObject.Find("Canvas/Text").GetComponent<Text>();
        //增加一行say的内容
        text.text = text.text + "\n" + content;
    }
    */
}
}