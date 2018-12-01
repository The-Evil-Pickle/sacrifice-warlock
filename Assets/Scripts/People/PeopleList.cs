using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleList : MonoBehaviour {
    public Object personPanelPrefab;
    public Transform listParent;
    public List<PersonData> personDatas;


    public void AddPerson(PersonData data)
    {
        GameObject obj = (GameObject)Object.Instantiate(personPanelPrefab, listParent);
        obj.GetComponent<PersonPanel>().SetData(data);
        personDatas.Add(data);
    }

	// Use this for initialization
	void Start () {
        personDatas = new List<PersonData>();
        AddPerson(new PersonData(PersonType.CAPTIVE));
        AddPerson(new PersonData(PersonType.CAPTIVE));
        AddPerson(new PersonData(PersonType.FOLLOWER));
        AddPerson(new PersonData(PersonType.FOLLOWER));
        AddPerson(new PersonData(PersonType.FOLLOWER));
        AddPerson(new PersonData(PersonType.FOLLOWER));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
