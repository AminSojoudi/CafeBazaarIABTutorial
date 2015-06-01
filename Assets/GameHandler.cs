using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using CafeBazarIab;

public class GameHandler : MonoBehaviour 
{
	public Text Gold;
	private StoreEventHandler eventHandler;
	private int currentGold = 0;

	public void AddGoldByClick()
	{
		currentGold = currentGold + 1;
		Gold.text = "Gold : " + currentGold;
	}
	void Start()
	{
		eventHandler = gameObject.GetComponent<StoreEventHandler>();
		StoreHandler.Instance.StartStore(eventHandler , "MIHNMA0GCSqGSIb3DQEBAQUAA4G7ADCBtwKBrwDfuo76c3dykf2VjN9QQF1SnxOfpmPtY20+JOsvyaQ2lZgl+i0FVEtXatFBYuFNTknBip9u9Nt/jE8yvzsAXmRYJ+rtc+nQqM742VqHFRzHa+OZM9ZeR6FTBoU/KNZWbEji7kNYIeY2kYMpf81UoM/WsUCiiAS3kQi+pNQcLLwxMrBYtXi58E8y4aW614ELHoXmZi8urbb9lwTnOByGscXqqz5ayM/OH1hbH/pufkECAwEAAQ==" , "payload");
	}
	public void BuyGold(ShopItem item)
	{
		StoreHandler.Instance.Purchase(item);
	}
	public void addGold(int value)
	{
		currentGold = currentGold + value;
		Gold.text = "Gold : " + currentGold;
	}
}
