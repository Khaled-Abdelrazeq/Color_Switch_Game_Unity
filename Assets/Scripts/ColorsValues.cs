using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsValues : MonoBehaviour
{
    public Color cyanColor;
    public Color yellowColor;
    public Color purpleColor;
    public Color pinkColor;

    public static ColorsValues Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

}
