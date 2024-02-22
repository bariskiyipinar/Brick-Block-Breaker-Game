using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Block : MonoBehaviour
{
    public int blockhealth;
    private MeshRenderer ressam;
    public Material Kirik;
    public AudioSource BlockVolume;

    void Start()
    {
        ressam = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Ball")
        {
            BlockVolume.Play();
            blockhealth--;
            Ball.score += 20;

            if (blockhealth == 1)
            {
                ressam.material = Kirik;
            }

            if(blockhealth == 0 )
            {
                Destroy(this.gameObject);
                Win.kirilanblock++;
            }
            



        }
    }
}
