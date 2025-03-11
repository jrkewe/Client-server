//using System.Globalization;
//using Unity.Multiplayer.Samples.Utilities.ClientAuthority;
//using Unity.Netcode;
//using Unity.Netcode.Components;
//using UnityEngine;

//namespace HelloWorld
//{
//    public class HelloWorldManager : NetworkBehaviour
//    {

//        private void Start()
//        {
//            Debug.Log($"Connection Approval: {NetworkManager.Singleton.NetworkConfig.ConnectionApproval}");
//            Debug.Log($"Protocol Version: {NetworkManager.Singleton.NetworkConfig.ProtocolVersion}");
//            Debug.Log($"Transport Type: {NetworkManager.Singleton.NetworkConfig.NetworkTransport.GetType()}");
//        }

//        public override void OnNetworkSpawn()
//        {
//            base.OnNetworkSpawn();

//            if (IsOwner)
//            {
//                Debug.Log("Jestem wxaxcicielem tego obiektu!");
//                GetComponent<ClientNetworkTransform>().enabled = true;
//            }
//            else
//            {
//                Debug.Log("Nie jestem wxaxcicielem, nie wxxczam ClientNetworkTransform.");
//            }
//        }

//        private NetworkManager m_NetworkManager;

//        //void Awake()
//        //{
//        //    Debug.Log("HelloWorldManager zostxx dodany do obiektu: " + gameObject.name);
//        //    m_NetworkManager = NetworkManager.Singleton;
//        //}

//        void OnGUI()
//        {
//            GUILayout.BeginArea(new Rect(10, 10, 300, 300));
//            if (!m_NetworkManager.IsClient && !m_NetworkManager.IsServer)
//            {
//                StartButtons();
//            }
//            else
//            {
//                StatusLabels();

//            }

//            GUILayout.EndArea();
//        }

//        void StartButtons()
//        {
//            if (NetworkManager.Singleton.IsClient || NetworkManager.Singleton.IsServer)
//                return;

//            if (GUILayout.Button("Host")) NetworkManager.Singleton.StartHost();
//            if (GUILayout.Button("Client")) NetworkManager.Singleton.StartClient();
//            if (GUILayout.Button("Server")) NetworkManager.Singleton.StartServer();
//        }

//        void StatusLabels()
//        {
//            var mode = m_NetworkManager.IsHost ?
//                "Host" : m_NetworkManager.IsServer ? "Server" : "Client";

//            GUILayout.Label("Transport: " +
//                m_NetworkManager.NetworkConfig.NetworkTransport.GetType().Name);
//            GUILayout.Label("Mode: " + mode);
//        }

//    }
//}