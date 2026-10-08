using System;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake(): " + gameObject.name);
    }

    void Start()
    {
        Debug.Log("Start(): " + gameObject.name);
    }

    void Update()
    {
        //Debug.Log("Update(): " + gameObject.name);
    }

    void FixedUpdate()
    {
        //Debug.Log("FixedUpdate(): " + gameObject.name);
    }

    void LateUpdate()
    {
        //Debug.Log("LateUpdate(): " + gameObject.name);
    }

    void OnEnable()
    {
        Debug.Log("OnEnable(): " + gameObject.name);
    }

    void OnDisable()
    {
        Debug.Log("OnDisable(): " + gameObject.name);
    }

    void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit(): " + gameObject.name);
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy(): " + gameObject.name);
    }
}
