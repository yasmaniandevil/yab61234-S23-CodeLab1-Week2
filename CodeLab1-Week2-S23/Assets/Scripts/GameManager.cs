using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    
    
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null) //instance has not been set
        {
           DontDestroyOnLoad(gameObject); //dont destroy the game manager
           Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
