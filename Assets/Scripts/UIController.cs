using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAddButtonClick()
    {
        int num = Int32.Parse(text.text);
        text.text = num + 1 + "";

    }

    public void OnDecreaseButtonClick()
    {
        int num = Int32.Parse(text.text);
        text.text = num - 1 + "";

    }
}
