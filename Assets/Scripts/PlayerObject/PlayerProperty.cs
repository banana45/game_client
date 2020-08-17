using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperty : MonoBehaviour
{   
    private RequestedProperty _response = new RequestedProperty();

    public RequestedProperty property
    {
        get 
        {
            //向服务器请求数据
            //_response = Get(self_id);
            return _response;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //向服务器请求数据
        //_response = Get(...)
    }

}

public class RequestedProperty
{
    public string _race = "dog";
    public float _strength = 0;
    public float _agility = 0;
    public float _intelligence = 0;
}
