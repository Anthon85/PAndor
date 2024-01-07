using UnityEngine;

class MouseTest : MonoBehaviour
{ 
    void Update()
    {
        Vector2 d = Input.mouseScrollDelta;

        if(d!= Vector2.zero)
            Debug.Log(d);
    }
}