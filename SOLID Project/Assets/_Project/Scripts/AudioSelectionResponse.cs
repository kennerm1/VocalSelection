using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public void OnSelect(Transform selection)
    {
        var selectionAudio = selection.GetComponent<IAudio>();
        if (selectionAudio != null) selectionAudio.Play();
    }

    public void OnDeselect(Transform selection)
    {
        var selectionAudio = selection.GetComponent<IAudio>();
        if (selectionAudio != null) selectionAudio.Stop();
    }
}
