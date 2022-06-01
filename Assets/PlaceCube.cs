using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCube : MonoBehaviour
{
    [SerializeField]
    GameObject spawn;

    public GameObject Cube;

    public void SpawnCube()
    {
        foreach (Transform child in spawn.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
       
        Instantiate(Cube, spawn.transform);
    }
}
