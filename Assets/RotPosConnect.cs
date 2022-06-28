using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPosConnect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform DragPointerObj;
    // Update is called once per frame
    void Update()
    {
        transform.position = DragPointerObj.position;
        transform.rotation = DragPointerObj.rotation;
    }
}
