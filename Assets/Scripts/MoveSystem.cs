using UnityEngine;

public class MoveSystem : MonoBehaviour, IMove
{
    [SerializeField] private float speed = 5f;
    [SerializeField] LayerMask ground;

    public void Move()
    {
        print("Move");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        //по идее тут только логика должна быть
        if (Physics.Raycast(ray, out hit, 2000, ground))
        {
            transform.position = Vector3.MoveTowards(transform.position, hit.point + Vector3.up * 0.5f, speed * Time.deltaTime);
        }
    }
}
