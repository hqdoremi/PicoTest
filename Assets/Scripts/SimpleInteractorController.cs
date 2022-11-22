using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInteractorController : MonoBehaviour
{
    public GameObject obj;
    public Material blue, yellow, grey;
    //射线悬停,变蓝
    public void OnHoverEnter()
    {
        obj.GetComponent<MeshRenderer>().material = blue;
    }
    //射线未悬停，变灰
    public void OnHoverExit()
    {
        obj.GetComponent<MeshRenderer>().material = grey;

    }
    //射线悬停后按下扳机键，变黄
    public void OnSelectEnter()
    {
        obj.GetComponent<MeshRenderer>().material = yellow;
    }
    public void OnSelectExit()
    {
        obj.GetComponent<MeshRenderer>().material = blue;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
