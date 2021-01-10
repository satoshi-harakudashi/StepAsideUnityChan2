using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    private GameObject unityChan;

    // Start is called before the first frame update
    void Start()
    {
        unityChan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < unityChan.transform.position.z-5)
        {
            Destroy(this.gameObject);
        }
    }
}
