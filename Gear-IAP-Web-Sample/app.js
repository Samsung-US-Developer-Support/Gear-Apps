// http://img-developer.samsung.com/onlinedocs/gear/web_device/webapis/iap.html#::IAP::IAPMode
// Success Callback

// IAPMode {"IAP_COMMERCIAL_MODE", "IAP_SUCCESS_TEST_MODE", "IAP_FAILURE_TEST_MODE"};
// ItemType {"CONSUMABLE", "NON_CONSUMABLE", "SUBSCRIPTION", "AUTO_RECURRING_SUBSCRIPTION", "ALL"};

var IAPmode =  "IAP_SUCCESS_TEST_MODE"; // Test Success

//var IAPmode =  "IAP_COMMERCIAL_MODE";    // Commerical mode
//var IAPmode =  "IAP_FAILURE_TEST_MODE";  // Test Failure


// Item IDs which are registered on seller portal for this application.

var consume = "consumable";
var noncons = "nonconsumable";
var autosub = "autosubscription";
var subscri = "subscription";


function init() {
	
	document.getElementById('idConsume').addEventListener('click', onByConsume);
	document.getElementById('idNonConsume').addEventListener('click', onByNonConsume);
	document.getElementById('idAutoSubs').addEventListener('click', onByAutoSubs);
	document.getElementById('idSubs').addEventListener('click', onBySubs);
	
	document.getElementById('idGetItem').addEventListener('click', onGetItemList);
	document.getElementById('idPurItem').addEventListener('click', onGetPurchasedItems);
	document.getElementById('idPurItemByID').addEventListener('click', onGetPurchasedItemsByIds);
}

/********************** Purchase API start ****************************/

function onByConsume() {
	webapis.inapppurchase.startPayment(consume, IAPmode, purchaseSuccessCallback, purchaseErrorCallback);
}

function onByNonConsume() {
	webapis.inapppurchase.startPayment(noncons, IAPmode, purchaseSuccessCallback, purchaseErrorCallback);
}

function onByAutoSubs() {
	webapis.inapppurchase.startPayment(autosub, IAPmode, purchaseSuccessCallback, purchaseErrorCallback);
}

function onBySubs() {
	webapis.inapppurchase.startPayment(subscri, IAPmode, purchaseSuccessCallback, purchaseErrorCallback);
}

function purchaseSuccessCallback(item) {
	
	alert("Item has been purchased successfully. ID:"+item.mItemId + " Name:"+item.mItemName + " Price"+item.mItemPrice);
	
	console.log('Item ID : ' + item.mItemId);
	console.log('Item Name : ' + item.mItemName);
	console.log('Item Price : ' + item.mItemPrice);
	console.log("Item Price in Currency: " + item.mItemPriceString);
	console.log("Currency Unit: " + item.mCurrencyUnit);
	console.log("Currency Code: " + item.mCurrencyCode);
	console.log("Item Desc: " + item.mItemDesc);
	console.log("Item Image URL: " + item.mItemImageUrl);
	console.log("Item Download URL: " + item.mItemDownloadUrl);
	console.log("Item Payment ID: " + item.mPaymentId);
	console.log("Item Purchased ID: " + item.mPurchaseId);
	console.log("Item Purchased Date: " + item.mPurchaseDate);
	console.log("Verify URL: " + item.mVerifyUrl);
}

function purchaseErrorCallback(error) {

	console.log("error name >>"+error.name + ' message : ' + error.message);
	if(error.name == "AlreadyPurchaseError"){
		alert("Error. This item has already been purchased.");
	}
}
/********************** Purchase API end ****************************/


/********************** onGetItemList() API start *******************/

function onGetItemList() {
	webapis.inapppurchase.getItemList(1, 20, "ALL", IAPmode, getItemsuccessCallback, getItemeErorCallback);
}

function getItemsuccessCallback(result) {
	
	if(result._items.length == 0) {
		console.log("No item");
		alert("There is no item available in store of this type");
	} else {
		console.log("Total number of items available in store: "+result._items.length)
		var sb = new StringBuilder();
		
		for(var i = 0; i < result._items.length; i++) {
			
			console.log("***************Details of available item "+(i+1));
			console.log("Item ID : " + result._items[i].mItemId);
			console.log("Item Name : " + result._items[i].mItemName);
			console.log("Item Price : " + result._items[i].mItemPrice);
			console.log("Item Price in Currency: " + result._items[i].mItemPriceString);
			console.log("Currency Unit: " + result._items[i].mCurrencyUnit);
			console.log("Currency Code: " + result._items[i].mCurrencyCode);
			console.log("Item Desc: " + result._items[i].mItemDesc);
			console.log("Item Image URL: " + result._items[i].mItemImageUrl);
			console.log("Item Download URL: " + result._items[i].mItemDownloadUrl);
			console.log("Item Type: " + result._items[i].mType);
			console.log("Item Subcription duration: " + result._items[i].mSubscriptionDurationUnit);
			console.log("Item Subcription duration Mulitplyer: " + result._items[i].mSubscriptionDurationMultiplier);
					
			sb.append("Item ID : " + result._items[i].mItemId + "  ");
			sb.append("Item Name : " + result._items[i].mItemName + "  ");
			sb.append("Item Price : " + result._items[i].mItemPrice+ "  ");
		}
		alert(sb.toString());
	}
}

function getItemeErorCallback(error) {
	console.log("error name >>"+error.name + ' message : ' + error.message);
}

/********************** onGetItemList() API end *******************/



/********************** getPurchasedItemList() API & getPurchasedItemListByIds() API start **********/


function onGetPurchasedItems() {
	webapis.inapppurchase.getPurchasedItemList(1, 15, new tizen.TZDate(2016, 01, 01), new tizen.TZDate(2019, 12, 31), purItemSuccessCallback, purItemErrorCallback);
}

function onGetPurchasedItemsByIds() {
	webapis.inapppurchase.getPurchasedItemListByIds(["consumable", "nonconsumable"], purItemSuccessCallback, purItemErrorCallback);
}


function purItemSuccessCallback(result) {
	
	if(result._items.length == 0) {
		console.log("No purchased item");
		alert("There is no purchased item");
	} else {
		console.log("Total number of items purchased by the user: "+result._items.length)
		var sb = new StringBuilder();
		for(var i = 0; i < result._items.length; i++) {
			
			console.log("***************Details of purchased item "+(i+1));
			console.log("Item ID : " + result._items[i].mItemId);
			console.log("Item Name : " + result._items[i].mItemName);
			console.log("Item Price : " + result._items[i].mItemPrice);
			console.log("Item Price in Currency: " + result._items[i].mItemPriceString);
			console.log("Currency Unit: " + result._items[i].mCurrencyUnit);
			console.log("Currency Code: " + result._items[i].mCurrencyCode);
			console.log("Item Desc: " + result._items[i].mItemDesc);
			console.log("Item Image URL: " + result._items[i].mItemImageUrl);
			console.log("Item Download URL: " + result._items[i].mItemDownloadUrl);
			console.log("Item Type: " + result._items[i].mType);
			console.log("Item Payment ID: " + result._items[i].mPaymentId);
			console.log("Item Purchased ID: " + result._items[i].mPurchaseId);
					
			
			var todate 	= 	new Date(result._items[i].mPurchaseDate).getDate();
		    var tomonth = 	new Date(result._items[i].mPurchaseDate).getMonth()+1;
		    var toyear	=	new Date(result._items[i].mPurchaseDate).getFullYear();
		    
		    var original_date=tomonth+'/'+todate+'/'+toyear;
			
		    console.log("Item Purchased Date : " + original_date);
		    
		    if(result._items[i].mSubscriptionEndDate > 0){
		    
		    	var todate 	= 	new Date(result._items[i].mSubscriptionEndDate).getDate();
			    var tomonth = 	new Date(result._items[i].mSubscriptionEndDate).getMonth()+1;
			    var toyear	=	new Date(result._items[i].mSubscriptionEndDate).getFullYear();
			    
			    var original_date=tomonth+'/'+todate+'/'+toyear;
		    	console.log("Item Subscription End Date: " + original_date);
		    }
		    console.log("*************************************************");
		    
			sb.append("Item ID : " + result._items[i].mItemId + "  ");
			sb.append("Item Name : " + result._items[i].mItemName + "  ");
			sb.append("Item Price : " + result._items[i].mItemPrice+ "  ");
			sb.append("Purchased Date : " + original_date);
		}
		alert(sb.toString());
	}
}

function purItemErrorCallback(error) {
	console.log("error name >>"+error.name + ' message : ' + error.message);
}


/********************** getPurchasedItemList() API & getPurchasedItemListByIds() API end **********/




( function () {
	
	window.onload = init;
	window.addEventListener( 'tizenhwkey', function( ev ) {
		if( ev.keyName === "back" ) {
			var page = document.getElementsByClassName( 'ui-page-active' )[0],
				pageid = page ? page.id : "";
			if( pageid === "main" ) {
				try {
					tizen.application.getCurrentApplication().exit();
				} catch (ignore) {
				}
			} else {
				window.history.back();
			}
		}
	} );
} () );


//Initializes a new instance of the StringBuilder class and appends the given value if supplied
function StringBuilder(value){
	this.strings = new Array("");
	this.append(value);
}

//Appends the given value to the end of this instance.
StringBuilder.prototype.append = function (value){
	if (value){
		this.strings.push(value);
	}
}

//Clears the string buffer
StringBuilder.prototype.clear = function (){
	this.strings.length = 1;
}

//Converts this instance to a String.
StringBuilder.prototype.toString = function (){
	return this.strings.join("");
}

