using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRay : MonoBehaviour
{
    public GameObject foco;
    public GameObject personagem;
    public Vector3 offset;
    public int layerMask;

    //responsável pelo raycast da camera até o chao, fazendo com que a posicao do Foco seja lá. 
    //e tambem para que a camera siga o personagem (com um offset)


    // Start is called before the first frame update
    void Start()
    {
         layerMask = 1 << 8;
      //  layerMask = ~layerMask;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100, layerMask))
        {
            Debug.DrawLine(ray.origin, hit.point);
            foco.transform.position = hit.point;
        }
                
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(personagem.transform.position.x, transform.position.y, personagem.transform.position.z)+offset;
        transform.LookAt(personagem.transform);
    }
}
