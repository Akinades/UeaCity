using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    public Button yourButton;

    // Start is called before the first frame update
    void Start()
    {
       Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick); 
    }

   void TaskOnClick(){
	Destroy(this.gameObject);
	}


}
