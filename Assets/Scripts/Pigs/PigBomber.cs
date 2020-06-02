﻿using UnityEngine;

public class PigBomber : MonoBehaviour
{
    [SerializeField] private Vector2 _throwDirection;

    private Bombs _bombs;

    private void Awake()
    {
        _bombs = FindObjectOfType<Bombs>();
    }

    private void ThrowBomb()
    {
        GameObject bomb =_bombs.GetBomb();
        
        if (bomb != null)
        {
            bomb.transform.position = transform.position;
            bomb.SetActive(true);
            bomb.GetComponent<Bomb>().Armed();
            bomb.GetComponent<Rigidbody2D>().AddForce(_throwDirection, ForceMode2D.Impulse);
        }
    }
}
