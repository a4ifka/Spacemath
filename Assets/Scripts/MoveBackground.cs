using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    public SpriteRenderer sprite;
    private float speed = 3f;
    private float posMinY;
    private Vector2 resPos;

    private void Awake() {

        resPos = transform.position;
        posMinY = sprite.bounds.size.y * 2 - resPos.y;

    }

    private void Update() {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if(transform.position.y <= -posMinY) {
            transform.position = resPos;
        }
    }
}
