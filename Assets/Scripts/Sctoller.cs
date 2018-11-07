using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sctoller : MonoBehaviour
{
    public float Scalar = 1f;
    private Material mat;
    // Use this for initialization
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetTextureOffset("_MainTex", new Vector2(Time.time * Scalar, 0));
    }
}
