using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
public class CreadorBanan : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void crear10banana()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab,new Vector3(5,-2,0),Quaternion.identity,null);  
        }
    }
}
