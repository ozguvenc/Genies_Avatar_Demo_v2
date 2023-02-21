using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This class is currently not being used, and reserved for potential project updates.
public class UIManager : MonoBehaviour
{
    [Header("Animation Buttons")]
    [SerializeField] private Button[] animationButtons = new Button[5];

    [Header("Color Buttons")]
    [SerializeField] private Button[] colorButtons = new Button[2];

    [Header("Exit Button")]
    [SerializeField] private Button exitButtons;
}
