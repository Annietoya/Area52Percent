using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// UI - parameters screen
// this script is applied to the menu object that combines each individual parameter slider and text

public class SC_SliderText : MonoBehaviour
{
    public Slider _Slider;
    public Text _Text;
    // Start is called before the first frame update
    void Start()
    {
        _Text.text = _Slider.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _Text.text = _Slider.value.ToString();
    }
}
