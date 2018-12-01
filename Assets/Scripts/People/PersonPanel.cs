using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonPanel : MonoBehaviour {
    public PersonData data;
    public Text titleText;
    public Text faithText;
    public Text mightText;
    public Text witText;
    public Image imageToColor;
    public void UpdateData()
    {
        titleText.text = data.name;
        faithText.text = data.devotion.ToString();
        mightText.text = data.might.ToString();
        witText.text = data.wit.ToString();
        imageToColor.color = data.panelColor;
    }

    public void SetData(PersonData newdata)
    {
        data = newdata;
        UpdateData();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
