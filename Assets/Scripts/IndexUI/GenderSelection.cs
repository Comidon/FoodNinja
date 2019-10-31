using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GenderSelection : MonoBehaviour
{
    // Start is called before the first frame update
    public static string Gender2 = "NA";
    public static string Gender3;
    public static string compareGender = "NA";
    void Start()
    {
       // getLabel = Hover.Core.Items.Types.HoverItemDataRadio.SelectedEventHandler
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void setGender(string Gender)
    {
        Gender2 = String.Copy(Gender);
        Debug.Log(Gender);
    }
    public string getGender()
    {
        Gender3 = String.Copy(Gender2);
        return Gender3;
    }
}
