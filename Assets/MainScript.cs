using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject UIAsset;
    public GameObject objectSpawnPoint;
    public GameObject sphereObject;
    public GameObject ballObejct;
    
    public GameObject sphere, ball;
    Vector3 ballposition;
    public AudioSource ClickSound;
    
    void Start()
    {
        sphere= Instantiate(sphereObject, objectSpawnPoint.transform.position, objectSpawnPoint.transform.rotation);
        sphere.SetActive(true);
    }
    

    public void SpawnNewBall()
    {
        if (sphere)
        {
            sphere.SetActive(false);
            ball = Instantiate(ballObejct, sphere.transform.position, sphere.transform.rotation);
            Destroy(sphere);
            ClickSoundPlay();
        }
    }

    IEnumerator MoveToSpawnPoint()
    {
        yield return new WaitForSeconds(2);
        playerObject.GetComponent<CharacterController>().enabled = false;
        playerObject.transform.position = transform.position;
        playerObject.GetComponent<CharacterController>().enabled = true;
        UIAsset.SetActive(false);
        sphere= Instantiate(sphereObject, objectSpawnPoint.transform.position, objectSpawnPoint.transform.rotation);
        sphere.SetActive(true);
        sphere.GetComponent<spherescript>().UI.SetActive(true);
    }
   
    public void ClickSoundPlay()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
