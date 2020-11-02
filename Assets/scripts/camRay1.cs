using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRay1 : MonoBehaviour
{
    public GameObject foco;
    public GameObject personagem;
    public Vector3 offset;
    public int layerMask;
    // Start is called before the first frame update
    void Start()
    {
         layerMask = 1 << 8;
      //  layerMask = ~layerMask;
    }

    // Update is called once per frame
    void Update()
    {
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;
        //
        // if (Physics.Raycast(ray, out hit, 100, layerMask))
        // {
        //     Debug.DrawLine(ray.origin, hit.point);
        //     foco.transform.position = hit.point;
        // }
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }

    }

    private void LateUpdate()
    {
        transform.position = new Vector3(personagem.transform.position.x, transform.position.y, personagem.transform.position.z)+offset;
        transform.LookAt(personagem.transform);
    }
}
