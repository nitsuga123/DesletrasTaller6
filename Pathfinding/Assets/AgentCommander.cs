using UnityEngine;

public class AgentCommander : MonoBehaviour {

    private NavMeshAgent motion;

	private void Awake () {
        motion = GetComponent<NavMeshAgent>();
	}
	
	private void Update () {
        if (Input.GetMouseButtonDown(0))
            SetTargetPosition(Input.mousePosition);
	}

    private void SetTargetPosition(Vector2 screenPos)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hitInfo;
        if (Physics.Raycast (ray, out hitInfo))
            motion.SetDestination(hitInfo.point);
    }
}
