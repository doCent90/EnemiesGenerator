using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        SetColor();
    }

    private void SetColor()
    {
        _sprite.color = Color.red;
    }
}
