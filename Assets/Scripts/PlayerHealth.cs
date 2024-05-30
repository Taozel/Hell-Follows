﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;
    public Animator animator;

    public GameObject gameplayUI;
    public GameObject gameOverScreen;

    private float _maxValue;

    private void Start()
    {
        _maxValue = value;
        DrawHealthBar();
    }
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlayerIsDead();
        }

        DrawHealthBar();
    }
  
    public void AddHealth(float amount)
    {
        value += amount;
        value = Mathf.Clamp(value, 0, _maxValue);
        DrawHealthBar();
    }

    private void PlayerIsDead()
    {
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
        GetComponent<PlayerControllerr>().enabled = false;
        animator.SetTrigger("death");
    }

    private void DrawHealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
}
