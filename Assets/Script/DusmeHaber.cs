using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmeHaber : MonoBehaviour
{
    [SerializeField] private GameManager _GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Top"))
        {
            _GameManager.TopDustu();
        }
        else if(collision.gameObject.CompareTag("HedefObje"))
        {
            _GameManager.HedefObjeDustu();
        }
    }
}
