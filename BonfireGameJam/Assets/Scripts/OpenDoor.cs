using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    GameObject player;
    public float openRange;
    Animator anim;
    public bool isMoving;
    public bool isLocked;
    MeshCollider col;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        col = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            if(col.enabled == true)
            {
                col.enabled = false;
            }
        }
        else
        {
            if(col.enabled == false)
            {
                col.enabled = true;
            }
            float playerDist = Vector3.Distance(transform.position, player.transform.position);
            if(playerDist < openRange)
            {
                //Show display to open door
                if(Input.GetKeyDown(KeyCode.E))
                {
                    if(!isLocked)
                    {
                        //Open door animation
                        Open();
                    }
                    else
                    {
                        Debug.Log("Door is locked");
                    }
                }
            }
        }
    }

    void Open()
    {
        anim.SetTrigger("open");
    }
    void Close()
    {
        
    }

}
