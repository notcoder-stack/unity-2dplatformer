using System.Drawing;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float pointX;
    public float pointY;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
