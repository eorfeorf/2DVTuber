using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterView : MonoBehaviour
{
    [SerializeField]
    private Image chara;

    private RectTransform rt;
    
    private void Awake()
    {
        rt = chara.gameObject.GetComponent<RectTransform>();
    }

    public void ApplySprite((bool isActive, Sprite sprite) item)
    {
        chara.sprite = item.sprite;
        Anim(item.isActive);
    }
    
    private void Anim(bool isActive)
    {
        Vector2 pos = default;
        if (isActive)
        {
            pos = new Vector2(0, 60f);
        }
        rt.anchoredPosition = pos;
    }
}
