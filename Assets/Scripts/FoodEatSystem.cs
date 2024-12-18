using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEatSystem : MonoBehaviour
{
    [SerializeField] private SoundSystem soundSystem;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            soundSystem.Sound();
            Debug.Log("Food");
        } else
        {
            print("Это не еда");
        }
    }
}
