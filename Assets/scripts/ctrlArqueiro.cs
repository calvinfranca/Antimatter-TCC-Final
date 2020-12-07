using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//script obsoleto



public class ctrlArqueiro : MonoBehaviour
{
    Vector3 playeraxis;
    public CharacterController cctrl;
    public GameObject projetil;
    public GameObject especial_dispersao;

    public Camera cam;
    public GameObject foco;

    Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale < 1)
            return;
        playeraxis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        cctrl.SimpleMove(playeraxis * 10);


        transform.LookAt(foco.transform.position + Vector3.up);
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject currentball = Instantiate(projetil, transform.position + transform.forward, projetil.transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        }
        if (Input.GetButtonDown("Fire2"))
        {
  
             GameObject currentespecial = Instantiate(especial_dispersao, transform.position * 2 + transform.forward, especial_dispersao.transform.rotation);
             currentespecial.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);

            GameObject currentespecial1 = Instantiate(especial_dispersao, transform.position + transform.forward, especial_dispersao.transform.rotation);
            currentespecial1.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);

            GameObject currentespecial2 = Instantiate(especial_dispersao, transform.position * 3 + transform.forward, especial_dispersao.transform.rotation);
            currentespecial2.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);

        }
    }
}
