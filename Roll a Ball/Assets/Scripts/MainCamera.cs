using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    //LateUpdate runs every frame but it is garunteed to run after all items have been processed in update.
    //So when we set the position of the camera, we know absolutely that the player has moved for that frame.
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
