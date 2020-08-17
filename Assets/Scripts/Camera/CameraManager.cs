using System.Collections;
using System.Collections.Generic;
using HedgehogTeam.EasyTouch;
using UnityEngine;
using Mapbox.Unity.Map;
 
public class CameraManager : MonoBehaviour
{
    private Camera camera;
    private AbstractMap map;
    private float zoom;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        map = GameObject.Find("/LocationBasedGame/Map").GetComponent<AbstractMap>();
    }
 
    // Update is called once per frame
    void OnEnable()
    {
        EasyTouch.On_PinchIn += OnPinchIn;
        EasyTouch.On_PinchOut += OnPinchOut;
        EasyTouch.On_Swipe += OnSwipe;
    }

    void OnDisable()
    {
        EasyTouch.On_PinchIn -= OnPinchIn;
        EasyTouch.On_PinchOut -= OnPinchOut;
        EasyTouch.On_Swipe -= OnSwipe;
    }
 
 
    //双指往里缩小
    private void OnPinchIn(Gesture gesture)
    {   
        this.GetComponent<FollowPlayer>().enabled = false;
        zoom = gesture.deltaPinch*0.005f;
        map.Options.locationOptions.zoom = Mathf.Clamp(map.Options.locationOptions.zoom - zoom, 0, 22);
        map.UpdateMap();
    }
    //双指往外放大
    private void OnPinchOut(Gesture gesture)
    {   
        this.GetComponent<FollowPlayer>().enabled = false;
        zoom = gesture.deltaPinch*0.005f;
        map.Options.locationOptions.zoom = Mathf.Clamp(map.Options.locationOptions.zoom + zoom, 0, 22);
        map.UpdateMap();
    }
    
    private void OnSwipe(Gesture gesture)
    {   
        this.GetComponent<FollowPlayer>().enabled = false;
        camera.transform.position -= new Vector3(gesture.deltaPosition.x*0.1f, 0 , gesture.deltaPosition.y*0.1f);
    }
 
}