using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillsButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject lowerPanel;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            lowerPanel.SetActive(!lowerPanel.activeInHierarchy);
        });
    }
}
