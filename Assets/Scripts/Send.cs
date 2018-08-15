using UnityEngine;
using System.Collections;

public class Send : MonoBehaviour {

    public GameObject Target;
    public string MethodName;

    void OnMouseDown()
    {
        Target.SendMessage(MethodName);
    }
}
