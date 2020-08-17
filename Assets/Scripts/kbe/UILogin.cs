using KBEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 登录界面的绘制
/// </summary>
public class UILogin : MonoBehaviour
{
    /// <summary>
    /// 响应登录按钮，该按钮在Unity的UGUI系统中被绑定到按钮事件上。
    /// </summary>
    public void OnLoginClick()
    {
        //账号密码都要大于6位
        //得到账户输入框的文本
        string account = GameObject.Find("account").GetComponent<InputField>().text;
        //得到密码输入框的文本
        string password = GameObject.Find("psw").GetComponent<InputField>().text;
        //调用API的登录接口。最后一个参数可暂时无视，具体请参考API手册
        KBEngineApp.getSingleton().login(account, password, System.Text.Encoding.UTF8.GetBytes("kbengine_unity3d_demo"));
    }

    public void OnCreateClick()
    {
        //账号密码都要大于6位
        //得到账户输入框的文本
        string account = GameObject.Find("account").GetComponent<InputField>().text;
        //得到密码输入框的文本
        string password = GameObject.Find("psw").GetComponent<InputField>().text;
        //调用API的登录接口。最后一个参数可暂时无视，具体请参考API手册
        KBEngineApp.getSingleton().createAccount(account, password, System.Text.Encoding.UTF8.GetBytes("kbengine_unity3d_demo"));
        //KBEngineApp.getSingleton().login(account, password, System.Text.Encoding.UTF8.GetBytes("kbengine_unity3d_demo"));
    }
}