using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
public class ChangeCamera : MonoBehaviour
{   
    private GameObject usercamera;
    private GameObject worldcamera;
    private AbstractMap map;
    private bool flag = false;
    private Vector3 player_positon;
    private float userzoom;
    private float worldzoom;
    void Start()
    {
        usercamera = GameObject.Find("/LocationBasedGame/PlayerTarget/UserCamera");
        worldcamera = GameObject.Find("/WorldCamera");
        map = GameObject.Find("/LocationBasedGame/Map").GetComponent<AbstractMap>();
        player_positon = GameObject.Find("/LocationBasedGame/PlayerTarget").transform.position;
        worldcamera.SetActive(false);
        userzoom = map.Options.locationOptions.zoom;
        worldzoom = map.Options.locationOptions.zoom;
    }

    public void Click()
    {
        if (flag == true)
        {   
            map.VectorData.SetLayerSource("mapbox.3d-buildings,mapbox.mapbox-streets-v8");
            usercamera.SetActive(true);
            worldcamera.SetActive(false);
            map.Options.extentOptions.defaultExtents.cameraBoundsOptions.camera = usercamera.GetComponent<Camera>();
            map.Options.extentOptions.defaultExtents.HasChanged = true;
            worldzoom = map.Options.locationOptions.zoom;
            map.Options.locationOptions.zoom = userzoom;
            map.UpdateMap();
            flag = false;
        }
        else
        {   
            map.VectorData.SetLayerSource("");
            worldcamera.SetActive(true);
            usercamera.SetActive(false);
            map.Options.extentOptions.defaultExtents.cameraBoundsOptions.camera = worldcamera.GetComponent<Camera>();
            map.Options.extentOptions.defaultExtents.HasChanged = true;
            map.Options.locationOptions.zoom = worldzoom;
            map.UpdateMap();
            flag = true;
        }
    }
}
