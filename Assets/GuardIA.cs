using UnityEngine;

public class GuardIA ;  AIprofile
{
    Private Quaternion targetRotation;
    private float nextTurnTime;
     
    private void Start()
    {

     nextTurnTime = Time.time + Random.Range(Of, waitForTurn);

    }

    Public  override void ExecuteProfile()
    {
        if(Time.time >= nextTurnTime)
        {
            targetRotation = Quaternion.Euler(0, Random.Range(Of, 360f),0);
            nextTurnTime = Time.time + waitForTurn;
        }

        trasnform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation,Time.deltaTime * 50f);
    }

    public override void OnPlayerDetected()
     {
        Debug.Log("Player found");
     }
    public override void DetectedPlayer()
     {
       GameObject = GameObject.FindGameObjectWhitTag("Player");
       if (player != null )
       {
          float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        
          if(distanceToPlayer <= viewDistance)
            {
               OnPlayerDetected()
            }
        
       }

     }
}