using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzarGranada : MonoBehaviour
{
    public GameObject granadaPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.G))
        {
            Lanzar();
        }
    }

    private void Lanzar()
    {
        GameObject nuevaGranada = Instantiate(granadaPrefab, transform.position, transform.rotation);
        nuevaGranada.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 50 * Time.deltaTime, ForceMode.Impulse);
    }
}
