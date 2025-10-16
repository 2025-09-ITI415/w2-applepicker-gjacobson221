using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            //get a reference to the applepicker component of main camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            //call the public appledestroyed() method of apscript
            apScript.AppleDestroyed();
        }
    }
}
