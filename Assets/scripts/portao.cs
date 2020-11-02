using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portao : MonoBehaviour
{
    // Start is called before the first frame update
    public boss chefe;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!chefe )
        {
            Destroy(gameObject);
        }
    }
}
