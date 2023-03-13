using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawnerScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(death());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PostAnimation()
    {
        //this.gameObject.SetActive(false);
    }

    IEnumerator death()
    {
        yield return new WaitForSeconds(3.1f);
        Destroy(this.gameObject);
    }
}
