using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackController : MonoBehaviour
{
    [SerializeField] private GameObject _bulletHole;
    private void OnMouseDown()
    {
        switch (this.gameObject.tag)
        {
            case "Background":
                Debug.Log("Попадание по стене");
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Instantiate(_bulletHole, new Vector3(worldPosition.x, worldPosition.y, -2), new Quaternion(0, 0, 0, 0));
                break;
        }
    }

}

