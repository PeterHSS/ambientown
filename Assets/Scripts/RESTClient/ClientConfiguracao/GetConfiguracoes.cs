using Assets.Lineker.Assets.REST_Client;
using Assets.Lineker.Assets.REST_Client.Models;
using UnityEngine;

public class GetConfiguracoes : MonoBehaviour
{
    [SerializeField]
    private string baseUrl = "https://ambientown.ddns.net/api/configuracoes";

    [SerializeField]
    private string clientId;

    [SerializeField]
    private string clientSecret;

    void GetConfigurations()
    {
        //Configura o RequestHeader
        RequestHeader header = new RequestHeader()
        {
            Key = "Content-Type",
            Value = "application/json"
        };

        StartCoroutine(RestWebClient.Instance.HttpGet($"{baseUrl}", (r) => OnRequestComplete(r)));
    }

    void OnRequestComplete(Response response)
    {
        //caso a requisi��o seja efetuada com sucesso, o retorno estar� em response.Data
    }
}