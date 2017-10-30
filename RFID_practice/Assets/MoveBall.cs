using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour {

	public InputField field;
	public Rigidbody rb;

	void Start () {
		field.onEndEdit.AddListener(delegate {LockInput(field); });
	}
	
	void LockInput(InputField input) {
		if (field.text == "19350113") {
			rb.AddForce(1, 0, 0, ForceMode.Impulse);
			field.text = "";
		}

		if (field.text == "19660615") {
			rb.AddForce(-1, 0, 0, ForceMode.Impulse);
			field.text = "";	
		}

		if (field.text == "19734406") {
			rb.AddForce(0, 0, 1, ForceMode.Impulse);
			field.text = "";	
		}

		if (field.text == "19626999") {
			rb.AddForce(0, 0, -1, ForceMode.Impulse);
			field.text = "";	
		}
	}
}
