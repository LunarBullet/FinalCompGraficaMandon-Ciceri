using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect2Intensity : MonoBehaviour
{
    [SerializeField] Material glowMaterial;
    public float MyIntensity; //between -0.5 and 4 for MAX MIN
    [SerializeField] Slider intensitySlider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyIntensity = intensitySlider.value*-3+2.5f;

        glowMaterial.SetFloat("_Intensity", MyIntensity);
    }
}
