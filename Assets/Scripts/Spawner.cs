using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public AudioContainer audioContainer;

    private int spawnerCount = 0;

    private bool sourceTwo = false;
    private bool sourceThree = false;

    public Transform spawnPointOne;
    public Transform spawnPointTwo;
    public Transform spawnPointThree;

    private void Start()
    {
        audioContainer.PlayMusicSource1();
        audioContainer.PlayMusicSource2(0);
        audioContainer.PlayMusicSource3(0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "SpawnPointTwo")
        {
            spawnerCount = 1;

            if (sourceTwo == false)
            {
                sourceTwo = true;
                audioContainer.StartCrossfadeOne();
                //audioContainer.StopMusicSource1();
                //audioContainer.PlayMusicSource2(1.0f);
            }
        }
        if (collision.collider.tag == "SpawnPointThree")
        {
            spawnerCount = 2;

            if (sourceThree == false)
            {
                sourceThree = true;
                audioContainer.StartCrossfadeTwo();
                //audioContainer.StopMusicSource2();
                //audioContainer.PlayMusicSource3(1.0f);
            }
        }
        if (collision.collider.tag == "Deadzone")
        {
            //print("deadzone");

            if (spawnerCount == 0)
            {
                transform.position = new Vector3(spawnPointOne.position.x, spawnPointOne.position.y, spawnPointOne.position.z);
            }
            if (spawnerCount == 1)
            {
                transform.position = new Vector3(spawnPointTwo.position.x, spawnPointTwo.position.y, spawnPointTwo.position.z);
            }
            if (spawnerCount == 2)
            {
                transform.position = new Vector3(spawnPointThree.position.x, spawnPointThree.position.y, spawnPointThree.position.z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            //audioContainer.StopMusicSource3();
            //audioContainer.PlayMusicSource4();
            GameManager.Instance.LoadNextScene();
        }
        if (other.tag == "FinalStage")
        {
            GameManager.Instance.LoadMainMenu();
        }
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, -1);
    }
}
