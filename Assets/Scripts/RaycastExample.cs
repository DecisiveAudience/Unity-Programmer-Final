using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Objects Script;
    //Collider collider;


    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit,20f,1,QueryTriggerInteraction.Collide))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Script = hit.transform.gameObject.GetComponent<Objects>())
                {
                    Script.clickedEvent();
                }
                /*if (Script = hit.transform.gameObject.GetComponent<Stone>())
                {
                    Script.clickedEvent();
                }
                */
            }

        }



    }
}