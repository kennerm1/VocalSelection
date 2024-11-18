using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSelectionResponse : MonoBehaviour, ISelectionResponse
{
    private Vector3 startingPosition;
    public GameObject particleEffect;

    public void OnSelect(Transform selection)
    {
        if (startingPosition == Vector3.zero)
        {
            startingPosition = selection.position;
            particleEffect.transform.position = startingPosition;
        }

        selection.position = new Vector3(selection.position.x, startingPosition.y + 0.5f, selection.position.z);
        particleEffect.SetActive(true);
    }

    public void OnDeselect(Transform selection)
    {
        selection.position = startingPosition;
        startingPosition = Vector3.zero;
        particleEffect.transform.position = Vector3.zero;
        particleEffect.SetActive(false);
    }
}
