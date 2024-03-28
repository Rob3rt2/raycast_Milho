using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCode : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
    Color color;
    public Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("inicio");
        StartCoroutine(GerarTarget());

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
           
            ray = _camera.ScreenPointToRay(Input.mousePosition);
            color = Color.green;
            Lancar(ray, color, 1);
        }
    }
    private void Lancar(Ray ray, Color color, int tipo)
    {
        Debug.Log("Origem" + ray.origin);

        Debug.Log("Direção" + ray.direction);

        if (Physics.Raycast(ray, out hitData))
        {
            Vector3 hitPosition = hitData.point;
            Debug.Log("hitPosition" + hitPosition);

            float hitDistance = hitData.distance;
            Debug.Log("Distancia" + hitDistance);
            string tag = hitData.collider.tag;
            Debug.Log("Tag: " + tag);
            GameObject hitObject = hitData.transform.gameObject;
            Debug.DrawRay(ray.origin, hitPosition * hitDistance, color);

            if (tag == "target")
                Destroy(hitObject);

            else
            {
                Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red);
                Debug.Log("Target missed");

            }

        }

    }

    private IEnumerator GerarTarget()
    {
        while (true)
        {
            float x = Random.Range(-12.0f, 17.0f);
            float y = Random.Range(8.0f, 11.0f);
            float z = Random.Range(-15.0f, 18.0f);

            Vector3 position = new Vector3(x, y, z);
            GameObject obj = Resources.Load("Prefabs/Nave", typeof(GameObject)) as GameObject;
            Instantiate(obj, position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
}
