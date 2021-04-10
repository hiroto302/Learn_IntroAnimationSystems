using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendingExample : MonoBehaviour
{
    [Range (0f, 1f)]
    public float weight = 1f;
    Animator m_Animator;
    // readOnly : 中身のデータは書き換えられる
    // Animator.StringToHash : 文字列から ID(int型) へと変換する
    static readonly int k_HashWeight = Animator.StringToHash("Weight");

    void Start ()
    {
        m_Animator = GetComponent<Animator> ();
    }

    void Update ()
    {
        // public void SetFloat (int id, float value);
        m_Animator.SetFloat (k_HashWeight, weight);
    }
}
