using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [Header("Background")]
    [SerializeField] private Material backgroundMaterial;
    [SerializeField] private Color[] groundColors = new Color[0];

    [Header("Sounds")]
    [SerializeField] private AudioSource audioPlayer;
    [SerializeField] private AudioClip buttonSound;

    private int lastColorIndex = -1;

    public void ChangeBackgroundColor()
    {
        int randomColorIndex = Random.Range(0, groundColors.Length);
        if(randomColorIndex == lastColorIndex)
        {
            ChangeBackgroundColor();
        }
        else
        {
            backgroundMaterial.color = groundColors[randomColorIndex];
            lastColorIndex = randomColorIndex;
        }
        
    }
}
