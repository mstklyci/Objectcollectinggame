using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objects;
    public float x1, x2;

    private void Start()
    {
        x1 = transform.position.x - GetComponent<BoxCollider2D>().bounds.size.x / 2.3f;
        x2 = transform.position.x + GetComponent<BoxCollider2D>().bounds.size.x / 2.3f;

        StartCoroutine(Clone(1f));
    }

    IEnumerator Clone(float time)
    {
        yield return new WaitForSeconds(time);

        Instantiate(objects[Random.Range(0,objects.Length)],
            new Vector3(Random.Range(x1,x2),transform.position.y, transform.position.z), Quaternion.identity);

        StartCoroutine(Clone(Random.Range(1f, 2f)));
    }
}