using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PersonType
{
    NONE,
    CAPTIVE,
    FOLLOWER
}

public class PersonData {
    public string name = "Bob";
    public int devotion = 1;
    public int might = 1;
    public int wit = 1;
    public PersonType type = PersonType.NONE;
    public Color panelColor = Color.clear;
	
    public PersonData(PersonType _type)
    {
        type = _type;
        name = _type.ToString();
        if (_type == PersonType.CAPTIVE)
        {
            panelColor = Color.grey;
        } else if (_type == PersonType.FOLLOWER)
        {
            panelColor = Color.blue;
        }
    }
    public PersonData(PersonType _type, int _devotion, int _might, int _wit)
    {
        type = _type;
        name = _type.ToString();
        if (_type == PersonType.CAPTIVE)
        {
            panelColor = Color.grey;
        }
        else if (_type == PersonType.FOLLOWER)
        {
            panelColor = Color.blue;
        }
        devotion = _devotion;
        might = _might;
        wit = _wit;
    }
}
