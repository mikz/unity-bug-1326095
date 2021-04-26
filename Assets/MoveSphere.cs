using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveSphere : MonoBehaviour
{
    private Vector2 m_Move;

    // Update is called once per frame
    private void Update()
    {
        transform.position += new Vector3(m_Move.x, 0, m_Move.y) * Time.deltaTime;
    }

    public void OnMove(InputValue value)
    {
        m_Move = value.Get<Vector2>();
    }
}
