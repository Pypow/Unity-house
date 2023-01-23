using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public void ButtonClicked()
    {
        spawnPrefab(-30.2f, 4.86f, -21.94f);

    }

    private void spawnPrefab(float posX, float posY, float posZ)
    {
        Vector3 locationToSpawn = new Vector3(posX, posY, posZ);
        GameObject go;
        go = Instantiate(prefabToSpawn, locationToSpawn, transform.rotation);
        go.transform.SetParent(GameObject.Find("Canvas").transform, true);
    }
}
