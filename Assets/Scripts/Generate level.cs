using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int Zposition = 40;
    public bool CreateSection = false;
    public int secNum;

    void Update()
    {
        if (CreateSection == false)
        {
            CreateSection = true;
            StartCoroutine(GenerateSection());

        }
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 2);
        Instantiate(section[secNum], new Vector3(0, 0, Zposition), Quaternion.identity);
        Zposition += 40;
        yield return new WaitForSeconds(10);
        CreateSection = false;
    }
}
