using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private IMove move;

    private void Start()
    {
        move = GetComponent<MoveSystem>();
    }

    private void FixedUpdate()
    {
        move.Move();
    }
}
