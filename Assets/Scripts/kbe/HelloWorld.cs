using KBEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 进入空间后，HelloWorld交互界面的绘制
/// </summary>
public class HelloWorld : MonoBehaviour
{
    /// <summary>
    /// 响应Helloworld按钮，该按钮在Unity的UGUI系统中被绑定到按钮事件上。
    /// </summary>
    public void OnClick()
    {
        //通过API：player()获得账户自己的实体，在本例中账户自己的实体就是FirstEntity
        FirstEntity entity = KBEngineApp.getSingleton().player() as FirstEntity;
        //由于say方法是在cell上的远程方法，这边使用cellEntityCall属性来调用。
        //如果是一个base上的远程方法，则使用baseEntityCall进行调用
        //entity.cellEntityCall.say("hello world");
    }
}