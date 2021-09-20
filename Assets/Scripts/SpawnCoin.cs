using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject Coin;
    public float SecondsBetweenSpawning = 3.0f;
    public float DefaultY = 1.0f;
    public int MaxCoinNum = 10;

    private float savedTime;
    private int CoinNum;
    private GameObject[] Bumpers;

    // Start is called before the first frame update
    void Start()
    {
        savedTime = Time.time;
        Bumpers = GameObject.FindGameObjectsWithTag("bumper");
    }

    // Update is called once per frame
    void Update()
    {
        CoinNum = GameObject.FindGameObjectsWithTag("pickup").Length;
        if (Time.time - savedTime >= SecondsBetweenSpawning) // is it time to spawn again?
        {
            if (CoinNum < MaxCoinNum)
            {
                MakeCoinToSpawn();
                savedTime = Time.time;
            }
        }
    }
    void MakeCoinToSpawn()
    {
        float X = Random.Range(-12.0f, 12.0f);
        float Y = DefaultY;
        float Z = Random.Range(-12.0f, 12.0f);
        // create a new gameObject
        foreach ( GameObject b in Bumpers )
		{
            Vector3 pos = b.transform.position;
            if(X<pos.x+1.5f && X>pos.x-1.5f && Z<pos.z+1.5f&& Z>pos.z-1.5f)
			{
                Y = 2.0f;
			}
		}
        Vector3 CoinPos = new Vector3(X, Y, Z);
        GameObject clone = Instantiate(Coin, CoinPos, transform.rotation) as GameObject;
        clone.transform.SetParent(gameObject.transform);
    }
}
