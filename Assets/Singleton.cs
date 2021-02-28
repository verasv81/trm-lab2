using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public int number;
    private static Singleton instance;
    // Start is called before the first frame update
    public static Singleton Instance 
    {
      get { return instance ?? (instance = new GameObject("Singleton").AddComponent<Singleton>()); }
    }

  public void DoSomeAwesomeStuff()
    {
      Debug.Log("I'm doing awesome stuff");
    }
}
