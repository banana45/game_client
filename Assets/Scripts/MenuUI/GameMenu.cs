using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMenu : MonoBehaviour
{   
    private GameObject property;
    private GameObject equipment;

    // Start is called before the first frame update
    void Start()
    {
        property = GameObject.Find("/Canvas/PropertyScrollRectPanel");
        equipment = GameObject.Find("/Canvas/EquipmentScrollRectPanel");
        property.SetActive(false);
        equipment.SetActive(false);
    }

    public void GetValue(int i)
    {
        switch (i)
        {
            case 0: 
                property.SetActive(false);
                equipment.SetActive(false);
                break;
            case 1: 
                property.SetActive(true);
                equipment.SetActive(false);
                break;
            case 2: 
                property.SetActive(false);
                equipment.SetActive(true);
                break;
        }
    }
}
