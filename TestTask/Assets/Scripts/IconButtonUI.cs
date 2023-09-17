using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IconButtonUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TypeEnum type;
    [SerializeField] private Sprite targetSprite;

    private enum TypeEnum { Variant1, Variant2 }

    private Sprite sourceSprite;
    private Color sourceColor;

    private Image image;
    private Outline outline;

    private void Awake()
    {
        image = GetComponent<Image>();
        outline = GetComponent<Outline>();

        sourceSprite = GetComponent<Image>().sprite;
        sourceColor = GetComponent<Outline>().effectColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(type == TypeEnum.Variant1) 
            image.sprite = targetSprite;

        outline.effectColor = Color.green;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(type == TypeEnum.Variant1)
            image.sprite = sourceSprite;

        outline.effectColor = sourceColor;
    }
}
