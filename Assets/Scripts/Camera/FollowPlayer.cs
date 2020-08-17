using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    private GameObject player;
    private GameObject worldcamera;
    private Vector3 root_position = new Vector3();
    private Quaternion root_rotation = new Quaternion();

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("/LocationBasedGame/PlayerTarget");
        worldcamera = GameObject.Find("/WorldCamera");
        root_position = worldcamera.transform.position;
        root_rotation = worldcamera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {   
        this.transform.position = new Vector3(player.transform.position.x, root_position.y, player.transform.position.z);
        this.transform.rotation = root_rotation;
    }
}
