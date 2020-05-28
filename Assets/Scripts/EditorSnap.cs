using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{
    [Range(1f, 20f)][SerializeField] float snapDistance = 10f;



    private void Awake()
    {

    }

    void Update()
    {

        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / snapDistance) * snapDistance;
        snapPos.y = 0f;
        snapPos.z = Mathf.RoundToInt(transform.position.z / snapDistance) * snapDistance;

        transform.position = snapPos;



    }
}
