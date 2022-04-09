using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPattern : MonoBehaviour
{
    [ContextMenu("pattern")]
    void pattern()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Debug.Log(" * ");
            }
        }
    }
}
