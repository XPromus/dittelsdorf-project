using UnityEngine;
using UnityEngine.Events;

public class MenuStart : MonoBehaviour {
    
    public UnityEvent OnStartUp;
    
    void Start() {
        OnStartUp.Invoke();
    }
    
}
