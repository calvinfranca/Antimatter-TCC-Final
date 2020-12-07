using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Responsável por fazer com que as barras de vida dos inimigos fiquem de frente para a tela

    public Transform cam;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
