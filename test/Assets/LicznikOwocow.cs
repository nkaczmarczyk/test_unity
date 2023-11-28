using UnityEngine;
using TMPro;

public class LicznikOwocow : MonoBehaviour
{
    public TMP_Text tekstLicznika;
    private int iloscZebranychOwocow = 0;

    void Start()
    {
        AktualizujLicznik();
    }

    public void UstawTekstLicznika(TMP_Text tekstMesh)
    {
        tekstLicznika = tekstMesh;
        AktualizujLicznik();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Owoc"))
        {
            iloscZebranychOwocow++;
            AktualizujLicznik();
            other.gameObject.SetActive(false); // Wy³¹cz owoc
        }
    }

    void AktualizujLicznik()
    {
        if (tekstLicznika != null)
        {
            tekstLicznika.text = "Zebrane owoce: " + iloscZebranychOwocow.ToString();
        }
        else
        {
            Debug.LogError("TextMeshPro nie zosta³ przypisany.");
        }
    }
}


