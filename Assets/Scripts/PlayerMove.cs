using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{

    private NavMeshAgent plyerAgent;

    // Start is called before the first frame update
    void Start()
    {
        plyerAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        // EventSystem 为UI 服务，IsPointerOverGameObject 判断是否是点击在UI上
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject() == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            bool isCollide = Physics.Raycast(ray, out hit);
            if (isCollide)
            {
                if (hit.collider.tag == "Ground")
                {
                    plyerAgent.stoppingDistance = 0;
                    plyerAgent.SetDestination(hit.point);
                }
                else if (hit.collider.tag == "Interactable")
                {
                    // TODO

                    hit.collider.GetComponent<InteractableObject>().OnClick(plyerAgent);
                }

            }

        }

    }
}
