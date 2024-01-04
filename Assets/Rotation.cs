using UnityEngine;

public class RotateObject : MonoBehaviour
{
    void Start()
    {
        // Aktuelle Rotation des GameObjects speichern
        Vector3 currentRotation = transform.eulerAngles;

        // Rotation um 90 Grad auf allen Achsen hinzufügen
        currentRotation.x += 90f;
        currentRotation.y += 90f;
        currentRotation.z += 90f;

        // Die Rotation des GameObjects aktualisieren
        transform.eulerAngles = currentRotation;
    }
}