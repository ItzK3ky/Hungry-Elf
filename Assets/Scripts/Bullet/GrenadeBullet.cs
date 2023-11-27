using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeBullet : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float timeUntilExplosionInSec;

    [Header("GameEvents")]
    [SerializeField] private GameObject bulletPrefab;

    private void Awake()
    {
        StartCoroutine(Explode());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StopCoroutine(Explode());
            timeUntilExplosionInSec = 0;
            StartCoroutine(Explode());
        }
    }

    private IEnumerator Explode()
    {
        Debug.Log("niggege");
        yield return new WaitForSeconds(timeUntilExplosionInSec);
        Debug.Log("hosenbold");

        Quaternion rotation1 = transform.rotation;
        Quaternion rotation2 = transform.rotation;
        Quaternion rotation3 = transform.rotation;
        Quaternion rotation4 = transform.rotation;
        Quaternion rotation5 = transform.rotation;
        Quaternion rotation6 = transform.rotation;
        Quaternion rotation7 = transform.rotation;
        Quaternion rotation8 = transform.rotation;

        rotation1.eulerAngles = new Vector3(0, 0, 0);
        rotation2.eulerAngles = new Vector3(0, 0, 45);
        rotation3.eulerAngles = new Vector3(0, 0, 90);
        rotation4.eulerAngles = new Vector3(0, 0, 135);
        rotation5.eulerAngles = new Vector3(0, 0, 180);
        rotation6.eulerAngles = new Vector3(0, 0, 225);
        rotation7.eulerAngles = new Vector3(0, 0, 270);
        rotation8.eulerAngles = new Vector3(0, 0, 315);

        Instantiate(bulletPrefab, transform.position, rotation1, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));
        Instantiate(bulletPrefab, transform.position, rotation2, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));
        Instantiate(bulletPrefab, transform.position, rotation3, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));
        Instantiate(bulletPrefab, transform.position, rotation4, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));
        Instantiate(bulletPrefab, transform.position, rotation5, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));
        Instantiate(bulletPrefab, transform.position, rotation6, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));
        Instantiate(bulletPrefab, transform.position, rotation7, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));
        Instantiate(bulletPrefab, transform.position, rotation8, null).GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 2500f));

        Destroy(gameObject);
    }
}
