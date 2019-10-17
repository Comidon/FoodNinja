using System;
using UnityEngine;
using VRTK;

public class MyInteractableObject : VRTK_InteractableObject
{
    public override void OnInteractableObjectGrabbed(InteractableObjectEventArgs e)
    {
        base.OnInteractableObjectGrabbed(e);
        Console.WriteLine("Grabbed");
    }
}
