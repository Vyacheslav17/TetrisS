using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCollider : MonoBehaviour
{
    public Vector2 offset1;
    public Vector2 offset2;
    public Vector2 offset3;
    public Vector2 offset4;

    public Vector2 circleCollider2D1;

    public Vector2 size;
    public int radius;

    private BoxCollider2D figure1;
    private BoxCollider2D figure2;
    private BoxCollider2D figure3;
    private BoxCollider2D figure4;

    private CircleCollider2D circleCollider2D;

    void Awake()
    {
        figure1 = gameObject.AddComponent<BoxCollider2D>();
        figure1.offset = offset1;
        figure1.size = size;

        figure2 = gameObject.AddComponent<BoxCollider2D>();
        figure2.offset = offset2;
        figure2.size = size;

        figure3 = gameObject.AddComponent<BoxCollider2D>();
        figure3.offset = offset3;
        figure3.size = size;

        figure4 = gameObject.AddComponent<BoxCollider2D>();
        figure4.offset = offset4;
        figure4.size = size;

        circleCollider2D = gameObject.AddComponent<CircleCollider2D>();
        circleCollider2D.offset = circleCollider2D1;
        circleCollider2D.radius = radius;
    }
}
