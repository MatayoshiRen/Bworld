using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NEstSen : MonoBehaviour
{

    private AudioSource[] sources;
    public float Number = 0f;

    bool ooo = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Number == 11 && Input.GetButtonDown("BlockMove"))
        {
            SceneManager.LoadScene("Title");
        }

        if (ooo && Input.GetButtonDown("BlockMove"))
        {
            if (Number == 0)
            {
                Invoke("GoTuto", 0.1f);//--メインに飛ぶ
            }
        }

        

        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("G"))
        {

            if (Number == 1)
            {
                Invoke("GoS1", 0.1f);//--メインに飛ぶ
            }
            if (Number == 2)
            {
                Invoke("GoS2", 0.1f);//--メインに飛ぶ
            }

            if (Number == 3)
            {
                Invoke("GoS3", 0.1f);//--メインに飛ぶ
            }
            
            if(Number == 10)
            {
                Invoke("GoClear", 0.1f);
            }
        }

    }

    void GoTuto()
    {
        SceneManager.LoadScene("TutorialStage");
    }


    void GoS1()
    {
        SceneManager.LoadScene("Stage1");
    }

    void GoS2()
    {
        SceneManager.LoadScene("Stage2");
    }

    void GoS3()
    {
        SceneManager.LoadScene("Stage3");
    }

    void GoClear()
    {
        SceneManager.LoadScene("Clear");
    }
}
