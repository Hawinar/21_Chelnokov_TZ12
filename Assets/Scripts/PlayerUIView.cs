using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUIView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timeTMP;
    [SerializeField] private TextMeshProUGUI _scoreTMP;
    [SerializeField] private TextMeshProUGUI _bulletsTMP;

    private float _time;

    private void Start()
    {
        GameManager.Score = 0;
        GameManager.Bullets = 0;
        GameManager.Time = 7;
}

    private void Update()
    {
        if (Time.time > _time)
        {
            GameManager.Time--;
            _time = Time.time + 1f;
        }
    }

    void FixedUpdate()
    {
        _timeTMP.text = $"Time: {GameManager.Time}";
        _scoreTMP.text = $"Score: {GameManager.Score}";
        _bulletsTMP.text = $"Bullets: {GameManager.Bullets}";

        if(GameManager.Time == 0)
        {
            SceneManager.LoadScene("MainMenu");
            GameManager.LastScore = GameManager.Score;
            if(GameManager.BestScore < GameManager.Score)
            {
                GameManager.BestScore = GameManager.Score;
            }
        }
    }
}
