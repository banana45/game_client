using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{   
    private RequestedEquipment _response = new RequestedEquipment();

    public RequestedEquipment equipment
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

public class RequestedEquipment
{
    public string _helmet = "none";
    public string _necklace = "none";
    public string _armor = "none";
    public string _weapon = "none";
    /*
    public string race{
        get { return _race;}
    }

    public float strength{
        get { return _strength;}
    }

    public float agility{
        get { return _agility;}
    }

    public float intelligence{
        get { return _intelligence;}
    }
    */
}
