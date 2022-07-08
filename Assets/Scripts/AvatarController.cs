using UnityEngine;

namespace HeroicArcade.CC
{
    public class AvatarController : MonoBehaviour
    {
        private Vector3 currentMovement;
        public void OnMoveInput(Vector2 moveInput)
        {
            //y preserves its value from the previous Update.
            currentMovement.x = moveInput.x;
            currentMovement.z = moveInput.y;
        }

        [SerializeField] float moveSpeed;
        private void Update()
        {
            transform.position += currentMovement * Time.deltaTime * moveSpeed;
        }
    }
}