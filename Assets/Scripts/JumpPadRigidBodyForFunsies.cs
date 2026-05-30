using UnityEngine;

public class JumpPadRigidBodyForFunsies : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody rb))
        {
            Debug.Log("CollisedWithJumpPad");
            rb.AddForce(transform.up * jumpForce);
        }
    }
}
