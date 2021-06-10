using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public InputController InputController { get; private set; }

    void Awake()  // Runs first (before start)
    {
        Instance = this;        // Visible confusion
        InputController = GetComponentInChildren<InputController>(); //Find me an input controller!
    }

    void Update()
    {
        
    }
}
