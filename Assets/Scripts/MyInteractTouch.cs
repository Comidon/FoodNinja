using System;
using UnityEngine;
using VRTK;

[AddComponentMenu("VRTK/Scripts/Interactions/Interactors/VRTK_InteractTouch")]
public class MyInteractTouch : VRTK_InteractTouch
{
    public override void OnControllerStartTouchInteractableObject(ObjectInteractEventArgs e)
    {
        base.OnControllerTouchInteractableObject(e);
        
        Console.WriteLine("get hit");
    }
}
