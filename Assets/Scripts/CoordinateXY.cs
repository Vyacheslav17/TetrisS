using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateXY : MonoBehaviour
{

    [SerializeField]
    private int x;
    [SerializeField]
    private int y;

    public int GetX()
    {
        return this.x;
    }
    public int GetY()
    {
        return this.y;
    }

    public void SetX(int x)
    {
        this.x = this.x + x;
    }
    public void SetY(int y)
    {
        this.y = this.y - y;

    }
}
