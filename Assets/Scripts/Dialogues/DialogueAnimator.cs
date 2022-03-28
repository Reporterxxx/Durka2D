using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
	public Animator startAnim;
	public DialogueManager dm;
	
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		startAnim.SetBool("startOpen", true);

		//Debug.Log("Trigger!");
	}
	
	public void OnTriggerExit2D(Collider2D other)
	{
		startAnim.SetBool("startOpen", false);
		dm.EndDialogue();
		//Debug.Log("Trigger!");
	}
}
