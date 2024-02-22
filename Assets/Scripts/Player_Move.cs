using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float playerspeed;

    
    void Start()
    {
        
    }

   
    void Update()
    {
        float yatayhareket = Input.GetAxis("Horizontal");
        transform.Translate(yatayhareket*playerspeed*Time.deltaTime,0f,0f);



        float yataysinir=Mathf.Clamp(transform.position.x, -5.8f, 5.8f);

        transform.position=new Vector3(yataysinir,transform.position.y,transform.position.z);

    }
}
