using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {
    private Rigidbody rb;
    private float horizontalValue;
    private float verticalValue;
    private Vector3 moveDirection;
    public float moveSpeed;
    private int count;
    public Text countText;
    public Text winText;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    private void SetCountText()
    {
        countText.text = "Count: " + count;
    }

    private void FixedUpdate()
    {
        horizontalValue = Input.GetAxis("Horizontal");
        verticalValue = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontalValue, 0.0F, verticalValue);
        rb.AddForce(moveDirection * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PackUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            if (count >= 12)
            {
                winText.text = "YouWin!";
            }
        }
    }
}
