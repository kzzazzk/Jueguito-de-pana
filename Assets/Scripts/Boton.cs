using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boton : MonoBehaviour
{
    public GameObject automat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Jugador 1"))
        {
            automat.GetComponent<CreadorBanan>().crear10banana();
        }
    }
}
