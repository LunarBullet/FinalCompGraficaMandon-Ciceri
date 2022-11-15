using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect2Intensity : MonoBehaviour
{
    [SerializeField] Material glowMaterial;
    [SerializeField] Material escudoMaterial;
    [SerializeField] Material caidaMaterial;

    public float MyIntensityEffect1; //between -0.5 and 4 for MAX MIN
    public float MyIntensityEffect2; //between -0.5 and 4 for MAX MIN


    [SerializeField] Slider intensitySlider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Efecto1Intensity();
        Efecto2Intensity();
        Efecto3Intensity();

    }

    void Efecto1Intensity()
    {

        MyIntensityEffect2 = 0.5f*intensitySlider.value * 8;

        escudoMaterial.SetFloat("_interfecsionfallout", MyIntensityEffect2);
        escudoMaterial.SetFloat("_Rimfallof", 0.5f*intensitySlider.value*2+0.84f);
    }
    void Efecto2Intensity()
    {
        MyIntensityEffect1 = intensitySlider.value * -3 + 2.5f;

        glowMaterial.SetFloat("_Intensity", MyIntensityEffect1);

    }

    void Efecto3Intensity()
    {

        caidaMaterial.SetFloat("_Intensity", intensitySlider.value*3f);
    }
}
