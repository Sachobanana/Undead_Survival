using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public PoolManager pool;
    public float gameTime; 
    public float maxGameTime = 2 * 10f; 
    void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime; 
        }
    }
    private void Awake()
    {
        instance = this;
    }
}
