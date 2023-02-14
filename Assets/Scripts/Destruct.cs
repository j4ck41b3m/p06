using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct : MonoBehaviour
{
    private GameObject fog, Bfog, blue;
    // Start is called before the first frame update
    void Start()
    {
        fog = gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        blue = GameObject.FindGameObjectWithTag("blue");
        Bfog = blue.transform.GetChild(0).gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("blue"))
        {

            Invoke("normalize", 0.2f);

        }


        Destroy(this,0.2f);
    }

    public void normalize()
    {
        gameObject.tag = "metal";
        blue.tag = "metal";
        Destroy(fog);
        Destroy(Bfog);
    }
}