using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncNumber() 
    {
        Singleton.Instance.number++;
        Debug.Log("Number is: " + Singleton.Instance.number);
    }
}
