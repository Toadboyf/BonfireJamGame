using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public float doorRange;
    public LayerMask doorMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
                CheckForDoor();
        }
    }

    void CheckForDoor()
    {
        RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, doorRange, doorMask))
            {
                Animator doorAnim = hit.collider.GetComponent<Animator>();
                switch(hit.collider.tag)
                {
                    case("door"):
                        if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor") || doorAnim.GetCurrentAnimatorStateInfo(0).IsName("CloseDoor"))
                        {
                            // Door moving, dont touch
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("StayClosed"))
                        {
                            //Open Door
                            doorAnim.SetTrigger("open");
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("StayOpen"))
                        {
                            // Close Door
                            doorAnim.SetTrigger("close");
                        }
                        break;
                    case("cupboard"):
                        if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("OpenCupboard") || doorAnim.GetCurrentAnimatorStateInfo(0).IsName("CloseCupBoard"))
                        {
                            // Door moving, dont touch
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("KeepCupClosed"))
                        {
                            //Open Door
                            doorAnim.SetTrigger("open");
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("KeepCupOpen"))
                        {
                            // Close Door
                            doorAnim.SetTrigger("close");
                        }
                        break;
                    case("wardrobeLeft"):
                        if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WL_Open") || doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WL_Close"))
                        {
                            // Door moving, dont touch
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WL_StayClosed"))
                        {
                            //Open Door
                            doorAnim.SetTrigger("open");
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WL_StayOpen"))
                        {
                            // Close Door
                            doorAnim.SetTrigger("close");
                        }
                        break;
                    case("wardrobeRight"):
                        if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WR_Open") || doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WR_Close"))
                        {
                            // Door moving, dont touch
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WR_StayClosed"))
                        {
                            //Open Door
                            doorAnim.SetTrigger("open");
                        }
                        else if(doorAnim.GetCurrentAnimatorStateInfo(0).IsName("WR_StayOpen"))
                        {
                            // Close Door
                            doorAnim.SetTrigger("close");
                        }
                        break;
                    default:
                        break;
                }
            }
    }
}
