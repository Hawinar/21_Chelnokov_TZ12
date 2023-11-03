using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIView : MonoBehaviour
{
    [SerializeField] private Button _playBtn;

    [SerializeField] private TextMeshProUGUI _lastScoreTMP;
    [SerializeField] private TextMeshProUGUI _bestScoreTMP;
    void Start()
    {
        _playBtn.onClick.AddListener(() => Play());
    }

    void Update()
    {
        _lastScoreTMP.text = $"Текущий счёт: {GameManager.LastScore}";
        _bestScoreTMP.text = $"Лучший счёт: {GameManager.BestScore}";
    }
    private void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
