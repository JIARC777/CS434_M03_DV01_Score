using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightModifier : MonoBehaviour
{
    Light directionalLight;
    // Start is called before the first frame update
    void Start()
    {
        Score score = FindObjectOfType<Score>();
        directionalLight = this.GetComponent<Light>();
        score.OnMilestone += changeLightColor;
    }


    public void changeLightColor()
    {
        directionalLight.color = Random.ColorHSV();
    }
}