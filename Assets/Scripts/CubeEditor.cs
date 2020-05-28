using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [Range(1f, 20f)] [SerializeField] float snapDistance = 10f;
    [SerializeField] TextMesh textMesh = null;



    private void Awake()
    {

    }

    void Update()
    {
        MovementSnap();

    }

    private void MovementSnap()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / snapDistance) * snapDistance;
        snapPos.y = 0f;
        snapPos.z = Mathf.RoundToInt(transform.position.z / snapDistance) * snapDistance;
        transform.position = snapPos;
        textMesh.text = snapPos.x / snapDistance + "," + snapPos.z / snapDistance;
    }
}
