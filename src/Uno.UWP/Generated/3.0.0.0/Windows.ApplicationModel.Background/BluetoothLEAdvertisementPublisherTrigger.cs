#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BluetoothLEAdvertisementPublisherTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement Advertisement
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothLEAdvertisement BluetoothLEAdvertisementPublisherTrigger.Advertisement is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public BluetoothLEAdvertisementPublisherTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BluetoothLEAdvertisementPublisherTrigger", "BluetoothLEAdvertisementPublisherTrigger.BluetoothLEAdvertisementPublisherTrigger()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementPublisherTrigger.BluetoothLEAdvertisementPublisherTrigger()
		// Forced skipping of method Windows.ApplicationModel.Background.BluetoothLEAdvertisementPublisherTrigger.Advertisement.get
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
