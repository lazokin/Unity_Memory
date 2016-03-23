using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour {

    [SerializeField] private GameObject cardBack;

    public void OnMouseDown() {
        if (cardBack.activeSelf) {
            cardBack.SetActive(false);
        }
    }

}
