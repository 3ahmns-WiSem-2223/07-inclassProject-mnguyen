using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_click : MonoBehaviour
{
    [SerializeField]
    GameObject Canvas;
    Vector3 position;
    float x;
    float y;
    [SerializeField]
    GameObject Button;

    void Update()
    {
        x = Random.Range(5.5f, -5.5f);
        y = Random.Range(3, -3);
    }

    public void Pressed()
    {
        Canvas.GetComponent<Timer>().scorenumber += 1;
        position = new Vector3(x,y,0);
        Instantiate(Button, position, new Quaternion());
        Destroy(gameObject);    
    }
}
