using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintObject : MonoBehaviour
{
    [SerializeField]
    GameObject spawn;

    public GameObject[] Printables;

    public void SpawbPrintables()
    {
        foreach (Transform child in spawn.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        int index = Random.Range(0, Printables.Length);
        Instantiate(Printables[index], spawn.transform);
    }
}
