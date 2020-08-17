using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using KBEngine;
public class ShowPlayerProperty : MonoBehaviour
{   
    private RequestedProperty property;
    private string text;

    void OnEnable()
    {
        property = GameObject.Find("/LocationBasedGame/PlayerTarget").GetComponent<PlayerProperty>().property;
        text = "race:  " + property._race + "\n";
        text += "strength:  " + property._strength + "\n";
        text += "agility:  " + property._agility + "\n";
        text += "intelligence:  " + property._intelligence + "\n";
        FirstEntity entity = KBEngineApp.getSingleton().player() as FirstEntity;
        text += "level:  " + entity.characters.level;
        this.GetComponent<TextMeshProUGUI>().text = text;
    }
}
