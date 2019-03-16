using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFigure : MonoBehaviour
{
    public GameObject Logic;
   //Следующая фигура
    public GameObject I, J, L, O, S, T, Z, NewC, New;

    //Объекты фигур на сцене 
    public GameObject NextFigure_I, NextFigure_J, NextFigure_L, NextFigure_O, 
        NextFigure_S, NextFigure_T, NextFigure_Z, NextFigure_NewC, NextFigure_New;
 
    //Canvas
    public GameObject Canvas;

    //Создание фигуры
    bool create = true;
    public void SetCreate(bool create)
    {
        this.create = create;
    }

    int StartCoordinateX()
    {
        int x = Logic.GetComponent<Logic>().GetMassivX(17,2);
        return x;
    }

    int StartCoordinateY()
    {
        int y = Logic.GetComponent<Logic>().GetMassivY(17, 2);
        return y;
    }

    void Update()
    {
        if (create)
        {
            NextFigure_I.SetActive(false);
            NextFigure_J.SetActive(false);
            NextFigure_L.SetActive(false);
            NextFigure_O.SetActive(false);
            NextFigure_S.SetActive(false);
            NextFigure_T.SetActive(false);
            NextFigure_Z.SetActive(false);
            NextFigure_NewC.SetActive(false);
            NextFigure_New.SetActive(false);

            System.Random gen = new System.Random();
            int result = gen.Next(0, 1);

            switch (1)
            {
                case 0:

                    GameObject I1 = Instantiate(I, new Vector3(StartCoordinateX(), StartCoordinateY(), 0),Quaternion.identity);
                    I1.name = "Figure_I";
                    I1.transform.SetParent(Canvas.transform, false);
                    NextFigure_I.SetActive(true);
                    create = false;

                    break;
                case 1:

                    GameObject J1 = Instantiate(J, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    J1.name = "Figure_J";
                    J1.transform.SetParent(Canvas.transform, false);
                    NextFigure_J.SetActive(true);
                    create = false;

                    break;
                case 2:

                    GameObject L1 = Instantiate(L, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    L1.name = "Figure_L";
                    L1.transform.SetParent(Canvas.transform, false);
                    NextFigure_L.SetActive(true);
                    create = false;

                    break;
                case 3:
                    GameObject O1 = Instantiate(O, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    O1.name = "Figure_O";
                    O1.transform.SetParent(Canvas.transform, false);
                    NextFigure_O.SetActive(true);
                    create = false;

                    break;
                case 4:

                    GameObject S1 = Instantiate(S, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    S1.name = "Figure_S";
                    S1.transform.SetParent(Canvas.transform, false);
                    NextFigure_S.SetActive(true);
                    create = false;

                    break;
                case 5:

                    GameObject T1 = Instantiate(T, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    T1.name = "Figure_T";
                    T1.transform.SetParent(Canvas.transform, false);
                    NextFigure_T.SetActive(true);
                    create = false;

                    break;
                case 6:

                    GameObject Z1 = Instantiate(Z, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    Z1.name = "Figure_Z";
                    Z1.transform.SetParent(Canvas.transform, false);
                    NextFigure_Z.SetActive(true);
                    create = false;

                    break;

                case 7:

                    GameObject NewC1 = Instantiate(NewC, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    NewC1.name = "Figure_NewC";
                    NewC1.transform.SetParent(Canvas.transform, false);
                    NextFigure_NewC.SetActive(true);
                    create = false;

                    break;

                case 8:

                    GameObject New1 = Instantiate(New, new Vector3(StartCoordinateX(), StartCoordinateY(), 0), Quaternion.identity);
                    New1.name = "Figure_New";
                    New1.transform.SetParent(Canvas.transform, false);
                    NextFigure_New.SetActive(true);
                    create = false;

                    break;
            }

        }
    }
}
