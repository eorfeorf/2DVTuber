using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class CharacterPresenter : MonoBehaviour
{
    [SerializeField]
    private CharacterView view;

    [SerializeField]
    private CharacterModel model;

    private void Start()
    {
        model.Current.Subscribe(tuple =>
        {
            view.ApplySprite(tuple);
        }).AddTo(this);
    }
}