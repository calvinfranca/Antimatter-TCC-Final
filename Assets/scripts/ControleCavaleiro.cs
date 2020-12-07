using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCavaleiro : MonoBehaviour
{

    Vector3 playeraxis;
    public CharacterController cctrl;
    public GameObject projetil;
    
    public float cooldown = 10;
    public float nextFireEspecial = 0;
    public float tempo = 0;
    public float velocidade = 16;
    public float intervaloEspecial = 0.2f;
    public Animator anim;
    public GameObject escudo;





    public Camera cam;
    public GameObject foco;
    //public TiroTeleguiado tiro;
    //public GameObject target;

    //private GameObject currentball;


    Vector2 mousePos;

    public float bombForce = 1000;
    Quaternion newq = new Quaternion(0, 90, 0, 1);
    Vector3 vec = new Vector3(0, 90, 0);
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {


        StartTimer();

        //Animação de andar pela velocidade
        anim.SetFloat("Velocidade", cctrl.velocity.magnitude);





        if (Time.timeScale < 1)
        {
            //print(Time.timeScale);
            return;
        }

        //move o player
        playeraxis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cctrl.SimpleMove(playeraxis * velocidade);

        //player olha para o mouse
        Vector3 focosemy = new Vector3(foco.transform.position.x, transform.position.y, foco.transform.position.z);
        transform.LookAt(focosemy);


        //tiro
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject currentball = Instantiate(projetil, transform.position + transform.forward, transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);

            anim.SetBool("Attack", true);
            Invoke("SetAttackOff", 0.3f);
            
        }


        //Ativa o escudo
        if (Time.time > nextFireEspecial)
        {
            if (Input.GetButtonDown("Fire2"))
            {

                Invoke("EspecialLoop", 0);


                nextFireEspecial = Time.time + cooldown;
                tempo = 10f;

            }
        }

    }

    void StartTimer()
    {
        tempo -= Time.deltaTime;


    }

    //Ativar o escudo
    private void EspecialLoop()
    {
        escudo.SetActive(true);
        Invoke("DesativarEscudo", 5);

        ///transform.Rotate(0, 22, 0);


    }

    //função para upar a velocidade com o botao no PanelLevelUp
    public void UpVelocidade()
    {
        if (velocidade <= 15)
        {
            velocidade += 1;
        }

    }

    public void SetAttackOff()
    {
        anim.SetBool("Attack", false);
    }
    public void DesativarEscudo()
    {
        escudo.SetActive(false);
    }
}
