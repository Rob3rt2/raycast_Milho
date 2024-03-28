using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milho : MonoBehaviour
{

    void Start()
    {
        Debug.Log("INIT");
        for (int i = 0; i < 25; i++)
        {

            float x1 = -9 + i;
            float y1 = 1;
            float z1 = -6;


            Vector3 position = new Vector3(x1, y1, z1);

            GameObject obj = Resources.Load("Prefabs/Corn_Plant", typeof(GameObject)) as GameObject;
            Instantiate(obj, position, Quaternion.identity);
            Debug.Log("MILHO");

        }

        for (int i = 0; i < 25; i++)
        {

            float x = -9 + i;
            float y = 1;
            float z = -6 + i;


            Vector3 position = new Vector3(x, y, z);

            GameObject obj = Resources.Load("Prefabs/Corn_Plant", typeof(GameObject)) as GameObject;
            Instantiate(obj, position, Quaternion.identity);
            Debug.Log("MILHO");

        }
        for (int i = 0; i < 30; i++)
        {

            float x = 14 ;
            float y = 1;
            float z = 10 - i;

            Vector3 position = new Vector3(x, y, z);

            GameObject obj = Resources.Load("Prefabs/Corn_Plant", typeof(GameObject)) as GameObject;
            Instantiate(obj, position, Quaternion.identity);
            Debug.Log("MILHO");

        }
        for (int i = 0; i < 25; i++)
        {

            float x = 14 - i;
            float y = 1;
            float z = -19;

            Vector3 position = new Vector3(x, y, z);

            GameObject obj = Resources.Load("Prefabs/Corn_Plant", typeof(GameObject)) as GameObject;
            Instantiate(obj, position, Quaternion.identity);
            Debug.Log("MILHO");

        }
        for (int i = 0; i < 25; i++)
        {

            float x = -10 ;
            float y = 1;
            float z = -19 + i;

            Vector3 position = new Vector3(x, y, z);

            GameObject obj = Resources.Load("Prefabs/Corn_Plant", typeof(GameObject)) as GameObject;
            Instantiate(obj, position, Quaternion.identity);
            Debug.Log("MILHO");

        }
      
        void Update()
        {

        }
    }
}


