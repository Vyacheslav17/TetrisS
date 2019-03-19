using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Logic : MonoBehaviour
{
    //Массив для движения фигуры
        GameObject[,] massiv_GameObject = new GameObject[18, 9];

        //Можно или нельзя двигаться 
        public bool GetMassivGo(int line, int column)
        {

            if (massiv_GameObject[line, column] != null)
            {
                return false;
            }
            else return true;
        }
        //Для того чтобы фигуры ложились друг на друга
        public void SetMassivGo(int line, int column, GameObject go)
        {
            massiv_GameObject[line, column] = go;
        }
}
