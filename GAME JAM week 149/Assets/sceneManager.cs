﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    [SerializeField] private string next_lvl;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            SceneManager.LoadScene(next_lvl);
            Destroy(gameObject);
        }
    }
}
