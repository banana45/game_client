using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using KBEngine;

public class clientapp : KBEMain
{
    void OnDestory(){
        KBEngineApp.app.destroy();
    }
}
