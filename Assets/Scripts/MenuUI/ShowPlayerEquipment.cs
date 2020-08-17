using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowPlayerEquipment : MonoBehaviour
{   
    private RequestedEquipment equipment;
    private string text;

    void OnEnable()
    {
        equipment = GameObject.Find("/LocationBasedGame/PlayerTarget").GetComponent<PlayerEquipment>().equipment;
        text = "helmet:  " + equipment._helmet + "\n";
        text += "necklace:  " + equipment._necklace + "\n";
        text += "armor:  " + equipment._armor + "\n";
        text += "weapon:  " + equipment._weapon;
        this.GetComponent<TextMeshProUGUI>().text = text;
    }
}
