using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZnikanieOwocow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Sprawd�, czy na obiekt najecha� gracz (Player)
        if (other.CompareTag("Player"))
        {
            // Zniknij owoc, gdy na niego najedzie gracz
            gameObject.SetActive(false); // Wy��cz obiekt (owoc)
            // Opcjonalnie mo�esz u�y� Destroy(gameObject) je�li chcesz go ca�kowicie usun��
        }
    }
}

