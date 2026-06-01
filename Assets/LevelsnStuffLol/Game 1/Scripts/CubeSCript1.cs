using UnityEngine;

public class CubeSCript1 : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
      Scoremanager1.instance.AddScore(1);
      Destroy(this.gameObject);
   }
}
