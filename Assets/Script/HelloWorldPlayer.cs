using Unity.Multiplayer.Samples.Utilities.ClientAuthority;
using Unity.Netcode;
using UnityEngine;

public class HelloWorldPlayer : NetworkBehaviour
{
    //private void Start()
    //{
    //    if (!IsOwner)
    //    {
    //        GetComponent<ClientNetworkTransform>().enabled = true;
    //    }
    //}

    public override void OnNetworkSpawn()
    {
        Debug.Log($"Obiekt: {gameObject.name}, ClientID: {NetworkManager.LocalClientId}, IsOwner: {IsOwner}, IsHost: {NetworkManager.Singleton.IsHost}");
    }

    void Update()
    {
        if (!Application.isFocused) return;
        if (!IsOwner) return;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalInput, 0, verticalInput);
        
    }

}