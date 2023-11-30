using UnityEngine;
using TMPro;

public class LicznikOwocow : MonoBehaviour
{
    public TextMeshProUGUI tekstLicznika;
    private int iloscZebranychOwocow = 0;

    void Start()
    {
        AktualizujLicznik();
    }

    public void UstawTekstLicznika(TextMeshProUGUI tekstMesh)
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
        }
    }

    void AktualizujLicznik()
    {
        if (tekstLicznika == null)
        {
            Debug.LogError("TextMeshPro nie zosta³ przypisany.");
            return;
        }

        tekstLicznika.text = $"Zebrane owoce: {iloscZebranychOwocow}";
    }
}


