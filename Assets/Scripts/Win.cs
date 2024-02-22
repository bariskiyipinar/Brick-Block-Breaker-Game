using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour
{

    public TextMeshProUGUI WinText;
    private int blocksayisi;
    public Transform blocklar;
    public static int kirilanblock;
    public GameObject ball;
    public AudioSource BackGroundSound;
    public GameObject Player;

    void Start()
    {
        
    }


     void Update()
    {
    
        blocksayisi = blocklar.childCount;

            if(blocksayisi == 0)
                {
            BackGroundSound.Pause();
            WinText.text = "Tebrikler Oyunu Kazandiniz  !!!\n" + " Score: " + Ball.score +"\n"+ "Kirilan Blok:" + kirilanblock+ "\n\n" + "Lütfen Tekrar Oynamak Ýcin Bir Tusa Basin...";
            Time.timeScale = 0;
            Destroy(ball);
            Destroy(Player);

            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
            }

    }

    
}
