using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public CharacterController player;
    public float moveSpeed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    private Transform t;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (player.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= moveSpeed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        player.Move(moveDirection * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
            StartCoroutine(LoadScene(1f));
    }
    private bool isCoroutine = true;
    IEnumerator LoadScene(float seconds)
    {
        isCoroutine = false;
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Level01");
        isCoroutine = true;
    }
}
