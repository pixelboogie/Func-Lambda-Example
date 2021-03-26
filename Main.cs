using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


// create a delegate of type int that returns the lenght of the gameObjects name

public class Main : MonoBehaviour
{
    public Func <int> OnGetName;

    void Start()
    {
        OnGetName = () => this.gameObject.name.Length;
       int charCount = OnGetName();
       Debug.Log("Character count: " + charCount);
    }

    // int GetName()
    // {
    //     return gameObject.name.Length;
    // }

}
