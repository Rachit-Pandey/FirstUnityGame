﻿using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter() {
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
