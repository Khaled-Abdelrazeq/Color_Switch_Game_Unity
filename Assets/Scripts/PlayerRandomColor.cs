using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomColor : MonoBehaviour
{
    private SpriteRenderer renderer;

    public string currentColor;
    
    public static PlayerRandomColor Instance;
    

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();

        if (Instance == null)
            Instance = this;
    }

    public void ChangePlayerColor()
    {
        string lastColor = currentColor;
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                SetCyanColor();
                break;
                
            case 1:
                SetYellowColor();
                break;
            
            case 2:
                SetPurpleColor();
                break;
            
            case 3:
                SetPinkColor();
                break;
        }

        if(lastColor == currentColor)
        {
            ChangePlayerColor();
        }
        else
        {
            lastColor = currentColor;
        }

    }

    private void SetCyanColor()
    {
        renderer.color = ColorsValues.Instance.cyanColor;
        currentColor = "Cyan";
    }
    private void SetYellowColor()
    {
        renderer.color = ColorsValues.Instance.yellowColor;
        currentColor = "Yellow";
    }
    private void SetPurpleColor()
    {
        renderer.color = ColorsValues.Instance.purpleColor;
        currentColor = "Purple";
    }
    private void SetPinkColor()
    {
        renderer.color = ColorsValues.Instance.pinkColor;
        currentColor = "Pink";
    }
}
