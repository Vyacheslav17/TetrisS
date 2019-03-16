using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureManagement : MonoBehaviour
{

    public GameObject Logic;


    float timer;
    bool move = true;

    void SetTimer(float timer)
    {
        this.timer = timer;
    }
    void Update()
    {
        if (move)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                /*foreach ()
                {
                    if (Logic.getComponent<Logic>().GetMassivGo(17, 2))
                        {

                        }

                transform.Translate(52, 0, 0);
                }
                */
            //if (Input.GetkeyDown(KeyCode.A) || Input.GetkeyDown(KeyCode.RightArrow))
                //{
                //    transform.Translate(52, 0, 0);
                //}
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(-52, 0, 0);
            }
/*
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-52, 0, 0);
           } */

        }   
    }

    //Обычное движение фигуры
    IEnumerator Move(float timer)
    {
        for (int i = 0; i < 1; i++)
        {
            transform.position = new Vector3(0, -52, 0);
            yield return new WaitForSeconds(timer);
        }
    }
}
