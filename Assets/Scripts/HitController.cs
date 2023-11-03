using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    [SerializeField] Rigidbody2D hitObject;
    private void OnMouseDown()
    {
        switch(hitObject.gameObject.tag)
        {
            case "Target":
                GameManager.Score++;
                GameManager.Time++;
                Debug.Log("Попадание по цели");
                break;
            case "Red":
                GameManager.Time--;
                Debug.Log("Попадание по красной");
                break;
            case "Egg":
                GameManager.Time = 0;
                Debug.Log("Попадание по яйцу");
                break;
            case "Background":
                Debug.Log("Попадание по стене");
                break;
        }
        hitObject.gravityScale = 1;
        GameManager.Bullets++;
    }
}
