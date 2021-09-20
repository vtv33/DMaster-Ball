using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonOnHover : MonoBehaviour
{
    public GameObject Display;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        Display.SetActive(true);
    }

    public void OnMouseExit()
    {
        Display.SetActive(false);
    }
}
