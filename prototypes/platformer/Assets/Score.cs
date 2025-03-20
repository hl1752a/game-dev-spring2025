using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;

    public TMP_Text scoreText2;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText2.text = score.ToString();
    }

    public void addPoint()
    {
        score += 1;
        scoreText2.text = score.ToString();
    }
}

