using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvodStripp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    GameObject oldG;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Izol")
        {
            try { Destroy(oldG); } catch { }
            oldG = other.gameObject; 
            other.gameObject.AddComponent<Rigidbody>();
            if (other.gameObject.name == "EndIzol")
            {
                GameObject.Find("WirN_del").GetComponent<MeshCollider>().enabled = true;
                GameObject.Find("WirL_del").GetComponent<MeshCollider>().enabled = true;
                GameObject.Find("WirG_del").GetComponent<MeshCollider>().enabled = true;

                GameObject.Find("WirN_del2").GetComponent<MeshCollider>().enabled = true;
                GameObject.Find("WirL_del2").GetComponent<MeshCollider>().enabled = true;
                GameObject.Find("WirG_del2").GetComponent<MeshCollider>().enabled = true;
            }
        }
    }
}
