using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detail_Factory : MonoBehaviour
{
    public RectTransform UIMaterial;

    public Button hide;

    Item item;
    // Start is called before the first frame update
    void Start()
    {
        Hiden();
        Button btn = hide.GetComponent<Button>();
        btn.onClick.AddListener(Hiden);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {

                    UIMaterial.localPosition = new Vector3(0,0,0);

                }

            }

        }
    }

    public void Hiden()
    {
        UIMaterial.localPosition = new Vector3(0, 800, 0);
    }


    public void spawn(Item item)
    {
        Instantiate(item.Object, this.gameObject.transform.position, Quaternion.identity);
    }

}
