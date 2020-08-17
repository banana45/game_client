using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using KBEngine;
public class FocusOn : MonoBehaviour
{   
    private AbstractMap map;

    void Start()
    {
        map = GameObject.Find("/LocationBasedGame/Map").GetComponent<AbstractMap>();
    }

    public void Click()
    {
        if (GameObject.Find("/WorldCamera") != null) 
        {
            GameObject.Find("/WorldCamera").GetComponent<FollowPlayer>().enabled = true;
            if (map.Options.locationOptions.zoom < 12) 
            {
                map.Options.locationOptions.zoom = 16;
                map.UpdateMap();
            }
        }
        /////以下为用这个按钮作test部分
        FirstEntity entity = KBEngineApp.getSingleton().player() as FirstEntity;
        entity.characters.level += 1;
        print(entity.test[0]);
    }
}
