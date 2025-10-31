using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLUT : MonoBehaviour
{
    // Reference to the material with the LUT shader
    public Material lutMaterial;
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Debug.Log("OnRenderImage called"); // Check if this message appears
        if (lutMaterial != null)
        {
            Graphics.Blit(source, destination, lutMaterial);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }
}
