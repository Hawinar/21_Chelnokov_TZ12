using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{
    [SerializeField] private GameObject _duck;
    [SerializeField] private SpriteRenderer _sprite;
    void Start()
    {
        int rnd = Random.Range(1, 10);
        if(rnd >= 7)
        {
            _duck.tag = "Red";
            _sprite.color = Color.red;
        }
        else
        {
            _duck.tag = "Target";
        }

    }
}
