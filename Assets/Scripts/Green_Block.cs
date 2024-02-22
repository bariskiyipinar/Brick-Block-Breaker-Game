using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Block : MonoBehaviour
{

    public int blockhealth;
    public  AudioSource BlockVolume;
   

   
    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Ball")
        {
            BlockVolume.Play();
            blockhealth--;
            Ball.score += 10;
            if (blockhealth == 0)
            {
                Destroy(this.gameObject);
                Win.kirilanblock++;
            }
           
            

            
        }
    }
}
