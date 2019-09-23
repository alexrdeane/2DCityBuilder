using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildAnimation : MonoBehaviour
{
    public GameObject buildingProgress;
    public float timer = 0f;


    void Update()
    {
        timer += Time.deltaTime;
    }

    void Build()
    {
        timer = 0;
        Instantiate(buildingProgress);

    }
}
