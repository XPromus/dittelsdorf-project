using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuStart : MonoBehaviour
{
    public UnityEvent OnStartUp;
    // Start is called before the first frame update
    void Start()
    {
        OnStartUp.Invoke();
    }


}
