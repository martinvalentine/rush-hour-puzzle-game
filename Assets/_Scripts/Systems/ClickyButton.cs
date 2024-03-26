using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] private Image _image; // Reference to the image component
    [SerializeField] private Sprite _default, _pressed; // Reference to the default and pressed sprites
    [SerializeField] private AudioSource _audioSource; // Reference to the audio source component
    [SerializeField] private AudioClip _audioClip; // Reference to the audio clip

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down");
        _image.sprite = _pressed;
        _audioSource.PlayOneShot(_audioClip);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Pointer Up");
        _image.sprite = _default;
    }
}
