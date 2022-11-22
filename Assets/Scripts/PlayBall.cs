using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayBall : MonoBehaviour
{
    public XRController leftController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var success = leftController.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 result);
        //if (success)
        //{
        //    var position = transform.position;
        //    transform.position = new Vector3(position.x * result.x * Time.deltaTime, position.y, position.z * result.y * Time.deltaTime);
        //}
        
    }
}
