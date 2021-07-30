using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
	}

    // Update is called once per frame
    void ValueChangeCheck()
    {
		Debug.Log(mainSlider.value);
	}
}
