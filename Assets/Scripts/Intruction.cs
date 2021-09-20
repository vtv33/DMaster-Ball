using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Intruction : MonoBehaviour
{
    public GameObject point;
    public GameObject[] instructions;
    public Button NextBtn;
    public Button BackBtn;
    public Button SkipBtn;
    public Button FinishBtn;

    private int now = 0;
    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
        point.SetActive(false);
        instructions[0].SetActive(true);
        NextBtn.onClick.AddListener(NextButtonOnClick);
        BackBtn.onClick.AddListener(BackButtonOnClick);
        SkipBtn.onClick.AddListener(FinishButtonOnClick);
        FinishBtn.onClick.AddListener(FinishButtonOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (now < instructions.Length - 1)
        {
            NextBtn.gameObject.SetActive(true);
            FinishBtn.gameObject.SetActive(false);
        }
        if (now > 0)
        {
            SkipBtn.gameObject.SetActive(false);
            BackBtn.gameObject.SetActive(true);
        }
        if (now == 0)
        {
            BackBtn.gameObject.SetActive(false);
            SkipBtn.gameObject.SetActive(true);
        }
        if (now == instructions.Length - 1)
        {
            NextBtn.gameObject.SetActive(false);
            FinishBtn.gameObject.SetActive(true);
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    void NextButtonOnClick()
	{
        instructions[now].SetActive(false);
        now++;
        instructions[now].SetActive(true);
    }

    void BackButtonOnClick()
	{
        instructions[now].SetActive(false);
        now--;
        instructions[now].SetActive(true);
    }

    void FinishButtonOnClick()
	{
        point.SetActive(true);
        ResumeGame();
        Destroy(gameObject);

    }
}
