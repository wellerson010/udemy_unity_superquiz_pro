using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour
{
    private Material Material;

    public float VelocityX;

    public float VelocityY;

    public float Increment;

    private float Offset;

    // Start is called before the first frame update
    void Start()
    {
        Material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Offset += Increment;
        Material.SetTextureOffset("_MainTex", new Vector2(Offset * VelocityX, Offset * VelocityY));
    }
}
