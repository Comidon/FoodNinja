using System.Collections.Generic;
using UnityEngine;
using VRTK;

public struct ObjectInteractEventArgs
{
    public VRTK_ControllerReference controllerReference;
    public GameObject target;
}

public delegate void ObjectInteractEventHandler(object sender, ObjectInteractEventArgs e);

[AddComponentMenu("VRTK/Scripts/Interactions/Interactors/VRTK_InteractTouch")]



public class MyInteractTouch : VRTK_InteractTouch
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
