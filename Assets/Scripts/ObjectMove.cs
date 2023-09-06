using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private GameObject timeManager;

    [SerializeField] private bool moveOpposite;

    [SerializeField] private float objectSpeed;


    void Start()
    {

    }


    void Update()
    {   
        if(transform.position.y >= 3f)
        {
            moveOpposite = true;
        }
        else if(transform.position.y <= -3f)
        {
            moveOpposite = false;
        }

        if(moveOpposite == true)
        {
            transform.position -= new Vector3(0f, objectSpeed * Time.deltaTime);
        }

        if (moveOpposite == false)
        {
            transform.position += new Vector3(0f, objectSpeed * Time.deltaTime);
        }


        if(timeManager.GetComponent<Timer>().slowDown == true)
        {
            objectSpeed = 0.5f;
        }

        else if (timeManager.GetComponent<Timer>().slowDown == false)
        {
            objectSpeed = 1f;
        }
    }
}