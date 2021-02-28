using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    bool wasChanged = false;
    // Start is called before the first frame update
    void Start()
    {
        Singleton.Instance.DoSomeAwesomeStuff();
        Singleton.Instance.number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Singleton.Instance.number == 2 && !wasChanged)
        {
            wasChanged = true;

            GameObject image =  GameObject.Find("Oxy_IT");
            GameObject oxy = image.transform.Find("Oxy").gameObject;
            GameObject h2o = image.transform.Find("H2O").gameObject;
         
            oxy.SetActive(false);
            h2o.SetActive(true);

            GameObject image_1 =  GameObject.Find("Hydro_IT1");
            GameObject h_1 = image_1.transform.Find("Hydro").gameObject;

            h_1.SetActive(false);

            GameObject image_2 =  GameObject.Find("Hydro_IT2");
            GameObject h_2 = image_2.transform.Find("Hydro").gameObject;

            h_2.SetActive(false);
        }
        else if(Singleton.Instance.number != 2)
        {
            wasChanged = false;

            GameObject image =  GameObject.Find("Oxy_IT");
            GameObject oxy = image.transform.Find("Oxy").gameObject;
            GameObject h2o = image.transform.Find("H2O").gameObject;

            oxy.SetActive(true);
            h2o.SetActive(false);

            GameObject image_1 =  GameObject.Find("Hydro_IT1");
            GameObject h_1 = image_1.transform.Find("Hydro").gameObject;

            h_1.SetActive(true);

            GameObject image_2 =  GameObject.Find("Hydro_IT2");
            GameObject h_2 = image_2.transform.Find("Hydro").gameObject;

            h_2.SetActive(true);
        }
    }
}
