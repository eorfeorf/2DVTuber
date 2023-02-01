using System;
using UniRx;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites;

    [SerializeField]
    private MicAudio micAudio;

    public IReadOnlyReactiveProperty<(bool,Sprite)> Current => current;
    private ReactiveProperty<(bool,Sprite)> current = new ();

    private void Start()
    {
        micAudio.OnMic.Subscribe(isActive =>
        {
            var sprite = isActive ? sprites[1] : sprites[0];
            ;
            current.Value = (isActive, sprite);
        }).AddTo(this);
    }
}