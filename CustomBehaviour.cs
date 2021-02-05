/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;

        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Set image holgram as face texture
        Hologram hologram = entry.getHologram();
        Hologram.hologramType hologramType = hologram.getType();
        // Check for image hologram
        if (hologramType == Hologram.hologramType.IMAGE_HOLOGRAM)
        {
            // Get mesh renderer
            MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();
            // Get material and texture
            Material material = meshRenderer.material;
            Texture texture = material.mainTexture;
            // Modify shader
            Shader shader = Shader.Find("Transparent/Diffuse");
            material.shader = shader;
            // Get session and face switcher
            GameObject session = GameObject.Find("AR Session Origin");
            FaceMaterialSwitcher faceMaterialSwitcher = session.GetComponentInChildren<FaceMaterialSwitcher>();
            // Set material and texture
            if (faceMaterialSwitcher != null)
            {
                // Set materials (overwrite all other face materials)
                int size = faceMaterialSwitcher.faceMaterials.Length;
                faceMaterialSwitcher.faceMaterials = new Material[size];
                for (int i = 0; i < size; i++) faceMaterialSwitcher.faceMaterials[i] = material;
            }
        }
    }
}