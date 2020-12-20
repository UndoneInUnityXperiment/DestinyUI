using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingPanel : MonoBehaviour
{
    public Rect panel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<RectTransform>().transform.position.x < 1200 && this.GetComponent<RectTransform>().transform.position.x > 800 
            && this.GetComponent<RectTransform>().transform.position.y < 650 && this.GetComponent<RectTransform>().transform.position.y > 350)
        {
            UpdatePos();
        }
        Debug.Log(this.GetComponent<RectTransform>().transform.position);
    }

    void UpdatePos()
    {
        transform.position = -Input.mousePosition;
    }
}
