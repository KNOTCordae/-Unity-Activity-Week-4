using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomDisableValue;


    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        if (gameObject.tag == "Blue")
        {
            randomDisableValue = Random.Range(150, 251);
        }
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == randomDisableValue)
        {
            rend.enabled = false;
        }
    }
}
