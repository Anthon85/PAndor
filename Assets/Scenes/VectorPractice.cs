using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    void Start()
    {
        Vector2 myVector2D = new Vector2(2, 3);
        Vector3 myVector3D = new Vector3(2, 3, 5);

        Debug.Log(myVector2D.x);    // 2
        Debug.Log(myVector3D.z);    // 5

        myVector3D.y = 12;

        Vector3 v3a = new(1, 2, 3);
        var v3b = new Vector3(1, 3, 7);
        Vector3 v3c = v3a + v3b;
        Vector3 v3d = v3a - v3b;
        Vector3 v3e = v3a * 12;
        Vector3 v3f = v3a / 12;
        float f = v3a.magnitude;    //hossz lekérdezés, floatba adja vissza
        Vector3 v3g = v3a.normalized;

        //
        Vector3 v3h = Vector3.right;   //Jobbra nézõ,egység hosszú vektor (1, 0, 0);

        v3h = Vector3.down;             //(0, -1, 0);
        v3h = Vector3.forward;          //(0, 0, 1);

        v3h = Vector3.one;              //(1, 1, 1)
        v3h = Vector3.zero;             //(0, 0, 0);









    }
}