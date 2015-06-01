using UnityEngine;
using System.Collections;
using CafeBazarIab;

public class StoreEventHandler : MonoBehaviour , IStoreEventHandler {
	private GameHandler gameHandler;

	void Start()
	{
		gameHandler = gameObject.GetComponent<GameHandler>();
	}


	#region IStoreEventHandler implementation

	public void ProcessPurchase (ShopItem item)
	{
		if (item.SKU == "gold") {
			StoreHandler.Instance.Consume(item);
		}
	}

	public void OnConsumeFinished (ShopItem item)
	{
		if (item.SKU == "gold") {
			gameHandler.addGold(100);
		}
	}

	public void OnGetPurchasesFinished (string allRawSKU, int length)
	{

	}

	public void OnSetupSuccessful ()
	{

	}

	public void OnProblemSettingUpIAB (string message, StoreErrorCodes errorCode)
	{
		throw new System.NotImplementedException ();
	}

	public void OnFailedToQueryInventory (string message, StoreErrorCodes errorCode)
	{
		throw new System.NotImplementedException ();
	}

	public void OnMissingToken (string message, StoreErrorCodes errorCode, ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	public void OnSubscriptionNotAvilable (string message, StoreErrorCodes errorCode, ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	public void OnFailedToConsumePurchase (string message, StoreErrorCodes errorCode, ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	public void OnConsumeFinishedListenerError (string message, StoreErrorCodes errorCode, ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	public void OnPurchaseFailed (string message, StoreErrorCodes errorCode, ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	public void OnPurchasePayloadVerificationFailed (string message, StoreErrorCodes errorCode, ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	public void OnUserCancelled (string message, StoreErrorCodes errorCode, ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	public void OnUnknownError (StoreErrorCodes errorCode, string message = "", ShopItem item = null)
	{
		throw new System.NotImplementedException ();
	}

	#endregion



}
