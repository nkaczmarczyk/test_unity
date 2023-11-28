using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZnikanieOwocow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // SprawdŸ, czy na obiekt najecha³ gracz (Player)
        if (other.CompareTag("Player"))
        {
            // Zniknij owoc, gdy na niego najedzie gracz
            gameObject.SetActive(false); // Wy³¹cz obiekt (owoc)
            // Opcjonalnie mo¿esz u¿yæ Destroy(gameObject) jeœli chcesz go ca³kowicie usun¹æ
        }
    }
}

