using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Logic : MonoBehaviour
{
    //Массив координат по х
        int[,] massiv_X = new int[18, 9];
    //Массив координат по у
        int[,] massiv_Y = new int[18, 9];
    //Массив для движения фигуры
        GameObject[,] massiv_GameObject = new GameObject[18, 9];

        public int GetMassivX(int line, int column)
        {
            return massiv_X[line, column];
        }

        public int GetMassivY(int line, int column)
        {
            return massiv_Y[line, column];
        }

        //Можно или нельзя двигаться 
        public bool GetMassivGo(int line, int column)
        {
            if (massiv_GameObject[line, column] != null)
            {
                return true;
            }
            else return false;
        }
        //Для того чтобы фигуры ложились друг на друга
        public void SetMassivGo(int line, int column, GameObject go)
        {
            massiv_GameObject[line, column] = go;
        }

    void Awake()
    {
        InizializationMassiv();
    }
    //Заполнение координатами по Х и по У
    void InizializationMassiv()
    {
        int y = -382;

        for (int L = 0; L < 18; L++)
        {
            int x = -451;
            y = y + 52;

            int Kx = x;
            //Debug.Log("X = " + x);
            //Debug.Log("Y = " + y);

            for (int M = 0; M < 9; M++)
            {
                massiv_GameObject[L, M] = null;
                massiv_X[L, M] = Kx;
                massiv_Y[L, M] = y;

                Kx = Kx + 52;
                //Debug.Log("[X] = " + massiv_X[L, M]);
                //Debug.Log("[Y] = " + massiv_Y[L, M]);
            }
        }
    }
}
