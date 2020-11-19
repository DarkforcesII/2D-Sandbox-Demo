using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class SkipLevel : MonoBehaviour
{
    public Button skipButton;
    public BasicBehaviour basicBehaviour;
    public Animator anim;

    private void Awake()
    {
        skipButton.onClick.AddListener(NextLevel);
        DontDestroyOnLoad(gameObject);
    }

    private void OnMouseDown()
    {
        //basicBehaviour.MoveForward();
        if (Input.GetMouseButtonDown(0))
        {
            basicBehaviour.MoveForward();
            //anim.SetFloat("Speed", 0.8f);
        }
        //anim.SetFloat("Speed", 0.8f);
    }

    private void NextLevel()
    {
        //GameManager.Instance.LoadNextScene();
    }
}
