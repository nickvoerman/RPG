using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{

    public static bool dontDestroyonLoad;

    // Start is called before the first frame update
    void Start()
    {
        if (!dontDestroyonLoad)
        {
            dontDestroyonLoad = true;
            DontDestroyOnLoad(transform.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
