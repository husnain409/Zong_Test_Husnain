using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxCollision : MonoBehaviour
{
    private MainScript manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<MainScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Destroy(other.gameObject, 1);
            if (this.name == "Box_C")
            {
                manager.UIAsset.SetActive(true);
                manager.UIAsset.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You Droped In " + this.name;
                manager.StartCoroutine("MoveToSpawnPoint");
            }
            else
            {
                manager.UIAsset.SetActive(true);
                manager.UIAsset.SetActive(true);
                manager.UIAsset.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You Droped In " + this.name;
               // transform.GetChild(1).gameObject.SetActive(true);
                //transform.GetChild(2).gameObject.SetActive(false);
                StartCoroutine(closeUI());
            }
        }
    }

    IEnumerator closeUI()
    {
        yield return new WaitForSeconds(4);
        manager.UIAsset.SetActive(true);
        manager.UIAsset.SetActive(false);
        Application.LoadLevel(0);
    }
}
