using UnityEngine;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour
{ 
    private float speed;

    private void Initialize() 
    {
        speed = 1f;
    }

    public override void OnNetworkSpawn() 
    {
        Initialize();
    }

    void Update() 
    {
        if (!Application.isFocused) return;
        float horizontalInput = Input.GetAxis("Horizontal") * speed;
        float verticalInput = Input.GetAxis("Vertical") * speed;
        transform.position += new Vector3(horizontalInput, 0, verticalInput);
    
    }
}
