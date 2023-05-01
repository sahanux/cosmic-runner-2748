using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool creationgSection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if (creationgSection == false)
        {
            creationgSection = true;
            StartCoroutine(GenerateSection());
        }
        
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0,3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(2);
        creationgSection = false;
    }
}
