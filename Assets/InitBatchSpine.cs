using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBatchSpine : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    void Init() {
        for (int i = 0; i < 1000; i++) {
            GameObject child = GameObject.Instantiate(prefab);
            child.transform.name = i.ToString();
            child.transform.localPosition = new Vector3(-8 + (i % 32)/2.0f, 3 - (i % 10), 0);
        }

    }

}
