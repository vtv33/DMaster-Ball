using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonOption : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    // Start is called before the first frame update
    public void options()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void back()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
}
