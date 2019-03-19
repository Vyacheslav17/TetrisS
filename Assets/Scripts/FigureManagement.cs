using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;

public class FigureManagement : MonoBehaviour
{
    //Ссылка добавлена в префабе но вылетает исключение
    public Rigidbody2D rb;
    public CircleCollider2D cc2d;

    bool move = true;

    float fall = 0;
    float fallspeed = 1;

    void Start()
    {
        cc2d = gameObject.GetComponent<CircleCollider2D>();
    }
    void Update()
    {
        if (move)
        {

            //Прирывное движение

            if (Time.time - fall >= fallspeed)
            {
                try
                {
                    rb.MovePosition(rb.position + new Vector2(0, -52));
                }
                catch { //Debug.Log("Исключение? ..не хорошо");
                        }

                fall = Time.time;
            }


                if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    try
                    {
                        rb.MovePosition(rb.position + new Vector2(-52, 0));
                    }
                    catch { Debug.Log("И влево"); }
                }   


                    if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        try
                        {
                            rb.MovePosition(rb.position + new Vector2(52, 0));
                        }
                        catch { Debug.Log("И вправо"); }
                    }


                        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                        {
                            try
                            {
                                rb.MovePosition(rb.position + new Vector2(0, -52) * 0.5f);
                            }
                            catch { Debug.Log("Ииии вниз");}
                        }


                            if (Input.GetKeyDown(KeyCode.Space))
                            {
                                cc2d.enabled = true;
                                transform.Rotate(0, 0, -90);
                                cc2d.enabled = false;
            }
                                    
        }
    }

    void OnCollisionEnter2D(Collision2D collision2)
    {
        if (move)
        {
            if (collision2.gameObject.tag == "border" || collision2.gameObject.tag == "figure")
            {

                move = false;
            }
        }
    }
}
