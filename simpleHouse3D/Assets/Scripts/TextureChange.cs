using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextureChange : MonoBehaviour
{
    public Texture[] textures;
    public int textureIdx;
    public void changetoTexture(int textureIdx)
    {        
        gameObject.GetComponent<Renderer>().material.mainTexture = textures[textureIdx];
    }
}
