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
                Debug.Log("��������� �� ����");
                break;
            case "Red":
                GameManager.Time--;
                Debug.Log("��������� �� �������");
                break;
            case "Egg":
                GameManager.Time = 0;
                Debug.Log("��������� �� ����");
                break;
            case "Background":
                Debug.Log("��������� �� �����");
                break;
        }
        hitObject.gravityScale = 1;
        GameManager.Bullets++;
    }
}
