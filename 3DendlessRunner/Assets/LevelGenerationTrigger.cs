using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerationTrigger : MonoBehaviour
{
    public GameObject[] levelCollection;
    [SerializeField] private float xPosition;
    [SerializeField] private float yPosition;

    [SerializeField] private int rand = 0;
    [SerializeField] private int repeat = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rand = Random.Range(0, levelCollection.Length);
            while (rand == repeat)
            {
                rand = Random.Range(0, levelCollection.Length);
            }
            Instantiate(levelCollection[rand], new Vector3(transform.position.x + xPosition, transform.position.y + yPosition, transform.position.z), Quaternion.identity);
            repeat = rand;
        }
    }
}
