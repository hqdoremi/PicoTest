using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice inputDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        var success = inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 result);
        Debug.Log("heqheq result:" + result+";"+success);
        if (success)
        {
            var position = transform.position;
            var value = 3;
            transform.position = new Vector3(position.x + result.x * Time.deltaTime* value, position.y, position.z+ result.y * Time.deltaTime* value);
            print("heqheq position before:"+position+";after:" + transform.position);
        }
    }
}
