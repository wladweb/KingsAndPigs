﻿using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class DoorIn : MonoBehaviour
{
    [SerializeField] private King _king;

    private Animator _animator;

    public event UnityAction KingEnteredRoom;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Open()
    {
        _animator.Play("Opening");
    }

    private void PlaceKing()
    {
        _king.transform.position = transform.GetChild(0).transform.position;
        _king.gameObject.SetActive(true);
        _king.LockControls(false);
        KingEnteredRoom?.Invoke();
    }
}
