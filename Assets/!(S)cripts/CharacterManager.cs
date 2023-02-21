using System;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [Header("Animator")]
    [SerializeField] private Animator characterAnimator;

    [Header("Audio")]
    [SerializeField] private AudioSource audioPlayer;
    [SerializeField] private AudioClip buttonSound;

    [Header("Skin Color")]
    [SerializeField] private Color[] skinColors;
    [SerializeField] private Material skinMaterial;
   
    [Header("Hair Color")]
    [SerializeField] private Color[] hairColors;
   
    [Header("Hair Objects")]
    [SerializeField] private Material[] hairObjectMaterials;
    [SerializeField] private GameObject[] hairObjects;

    [Header("Facial Hair Objects")]
    [SerializeField] private Material[] facialHairObjectMaterials;
    [SerializeField] private GameObject[] facialHairObjects;

    [Header("Clothing Objects")]
    [SerializeField] private Color[] clothColors;
    [SerializeField] private Material[] clothingMaterials;

    public void PlayAnimation(string stateName)
    {
        characterAnimator.SetTrigger(stateName);
        audioPlayer.PlayOneShot(buttonSound);
    }

    public void RandomizeCharacter()
    {
        RandomizeSkinColor();
        RandomizeHairColor();
        RandomizeClothColor();
        RandomizeHairStyle();
        RandomizeFacialHairStyle();
    }

    public void RandomizeSkinColor()
    {
        int randomSkinIndex = UnityEngine.Random.Range(0,skinColors.Length);
        int lastSkinIndex = -1;
        if (randomSkinIndex == lastSkinIndex)
        {
            RandomizeSkinColor();
        }
        else
        {
            skinMaterial.color = skinColors[randomSkinIndex];
            lastSkinIndex = randomSkinIndex;
        }
    }

    public void RandomizeHairColor()
    {
        int randomHairColorIndex = UnityEngine.Random.Range(0, hairColors.Length);
        int lastHairColorIndex = -1;
        if (randomHairColorIndex == lastHairColorIndex)
        {
            RandomizeHairColor();
        }
        else
        {
            for(int i = 0; i < hairObjectMaterials.Length; i++)
            {
                hairObjectMaterials[i].color = hairColors[randomHairColorIndex];
            }
            for (int i = 0; i < facialHairObjectMaterials.Length; i++)
            {
                facialHairObjectMaterials[i].color = hairColors[randomHairColorIndex];
            }
            lastHairColorIndex = randomHairColorIndex;
        }
    }

    public void RandomizeClothColor()
    {
        for (int i = 0; i < clothingMaterials.Length; i++)
        {
            int randomClothColorIndex = UnityEngine.Random.Range(0, clothColors.Length);
            clothingMaterials[i].color = clothColors[randomClothColorIndex];
        }
    }

    public void RandomizeHairStyle()
    {
        int randomHairStyleIndex = UnityEngine.Random.Range(0, hairObjects.Length);
        
        for (int i = 0; i < hairObjects.Length; i++)
        {
            hairObjects[i].SetActive(false);
        }
        hairObjects[randomHairStyleIndex].SetActive(true);
    }

    public void RandomizeFacialHairStyle()
    {
        int randomFacialHairStyleIndex = UnityEngine.Random.Range(0, facialHairObjects.Length);

        for (int i = 0; i < hairObjects.Length; i++)
        {
            facialHairObjects[i].SetActive(false);
        }
        facialHairObjects[randomFacialHairStyleIndex].SetActive(true);
    }
}
