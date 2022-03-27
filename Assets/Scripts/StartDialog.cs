using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDialog : MonoBehaviour
{
    public GameObject panelDialog;
	public Text nameCharacter;
	public Text dialog;
	public string[] message;
	public static bool dialogStart = false;
	static int counter_e = 0;  //
void Start()
{
	//Фразы диалога
	nameCharacter.text = "Медсестра";
	message[0] = "Здравствуй! Ты в дурке";
	message[1] = "Чтобы начать работу иди\n в кабинет заведующего";
	panelDialog.SetActive(false);
}

private void OnTriggerEnter2D(Collider2D collision)
{
	if (collision.tag == "Player")
	{
		panelDialog.SetActive(true);
		dialog.text = message[0];
		dialogStart = true;
		
	}
}

private void OnTriggerExit2D(Collider2D collision)
{
	// теперь закрывается при выходе из зоны диалога
	// или на E
	panelDialog.SetActive(false);
	dialogStart = false;
}


	private void Update ()
	{
		if (dialogStart == true)
		{
			if(Input.GetKeyDown(KeyCode.E))
		{
			counter_e++; // поправка
			if (counter_e != 2) //
			{ //
			dialog.text = message[1];
			} //
			else //
			{ //
			panelDialog.SetActive(false); //
			counter_e = 0; //
			} //
		}
		}
	}
}
