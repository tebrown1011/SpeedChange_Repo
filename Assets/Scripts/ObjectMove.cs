using System.Collections;
using System.Collections.Generic;
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
  
    }

    void OnEnable()
    {
        Timer.changeSpeed += SpeedChange;
    }

    public void SpeedChange(int num)
    {
        objectSpeed = Random.Range(1f, 3f);
    }
}