using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }
    void Start()
    {
        StartCoroutine(death());
    }




    IEnumerator death()
    {
        yield return new WaitForSeconds(6f);
        Destroy(this.gameObject);
    }
}
