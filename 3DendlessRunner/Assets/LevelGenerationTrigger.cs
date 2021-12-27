using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerationTrigger : MonoBehaviour
{
    public GameObject[] levelCollection;
    [SerializeField] private float xPosition;
    [SerializeField] private float yPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var rand = Random.Range(0, levelCollection.Length);
            Instantiate(levelCollection[rand], new Vector3(transform.position.x + xPosition, transform.position.y + yPosition, transform.position.z), Quaternion.identity);
        }
    }
}
