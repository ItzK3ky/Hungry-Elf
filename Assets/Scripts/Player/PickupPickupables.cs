using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPickupables : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private List<GameObject> weaponPrefabs = new List<GameObject>();

    private void ChangeWeapon(GameObject newWeapon)
    {
        Destroy(GameObject.FindGameObjectWithTag("Weapon"));
        Instantiate(newWeapon, transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pickupable")
        {
            ChangeWeapon(weaponPrefabs[collision.GetComponent<Pickupable>().id]);
            Destroy(collision.gameObject);
        }
    }
}
