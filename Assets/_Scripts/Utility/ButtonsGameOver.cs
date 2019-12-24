﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsGameOver : MonoBehaviour
{
    [SerializeField] GameObject GameOverScreen;
    [SerializeField] Player player;
    [SerializeField] Image fillAmountBar;
    [SerializeField] GameObject insanityBar;

    private PlayerStats stats;
    [SerializeField] GameObject manager;
    private InsanityMode mode;

    private void Start()
    {
        stats = manager.GetComponent<PlayerStats>();
        mode = manager.GetComponent<InsanityMode>();
    }


    public void ContinueGame()
    {
        GameOverScreen.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        manager.GetComponent<GameOver>().isPlayerDead = false;
        player.GetComponent<Animator>().enabled = true;
        mode.InsanityModeDeactivated();
        if (insanityBar.GetComponent<InsanityBar>().isInHallucination == true)
        {
            insanityBar.GetComponent<InsanityBar>().isInHallucination = false ;
        }
        fillAmountBar.fillAmount = stats.insanityAmount;
        player.transform.position = stats.locationSave;
        player.GetComponent<Collider2D>().enabled = true;
        

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}