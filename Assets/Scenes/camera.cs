using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{   public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0f, 0f, -5.5f);  
    }

    // Update is called once per frame
    void Update()
    {
       transform.position=player.transform.position+offset;
    }
}
