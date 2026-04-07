using UnityEngine;
using UnityEngine.UI;

public class NetworkStatus : MonoBehaviour
{
    public Text statusText;

    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            statusText.text = "Desconectado";
            statusText.color = Color.red;
        }
        else
        {
            statusText.text = "Conectado";
            statusText.color = Color.green;
        }
    }
}