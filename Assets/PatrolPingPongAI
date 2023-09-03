using UnityEngine;

public class PatrolPingPongAI : AIprofile
{
    public transform[] waypoints;
    private int currentWaypointIndex = 0;
    private int direction = 1;
    
    public override void ExecuteProfile()
    {
        Transform currentWaypoint = waypoints[currentWaypointIndex];
        trasnform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position,  Time.deltaTime * 2f);

        if (Vector3.Distance(transform.position, currentWaypoint.position) < 0.1f)
        {
            currentWaypointIndex += direction;

            if(currentWaypointIndex == 0 || currentWaypointIndex == waypoints.Lenght - 1)
            {
                direction *= -1;
            }
        }
    }
public override void OnPlayerDetected()
    {
        Debug.Log("Player found");
    }

    public override void DetectPlayer()
    {
        // Implementa la lógica de detección de jugador aquí
    }

}