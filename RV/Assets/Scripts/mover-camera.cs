using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 5.0f; // Sensibilidade do mouse

    float rotationX = 0.0f;
    float rotationY = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Trava o cursor no centro da tela
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f); // Limita a rotação vertical

        rotationY += mouseX;

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f); // Aplica rotação à câmera
    }
}
