using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Private variables.
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -9);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Camera movement.
        transform.position = player.transform.position + offset;
    }
}
