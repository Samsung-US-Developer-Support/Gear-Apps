// http://img-developer.samsung.com/onlinedocs/gear/web_device/webapis/iap.html#::IAP::IAPMode
// Success Callback

// IAPMode {"IAP_COMMERCIAL_MODE", "IAP_SUCCESS_TEST_MODE", "IAP_FAILURE_TEST_MODE"};
// ItemType {"CONSUMABLE", "NON_CONSUMABLE", "SUBSCRIPTION", "AUTO_RECURRING_SUBSCRIPTION", "ALL"};

var IAPmode =  "IAP_SUCCESS_TEST_MODE"; // Test Success
//var IAPmode =  "IAP_COMMERCIAL_MODE";    // Commerical mode
//var IAPmode =  "IAP_FAILURE_TEST_MODE";  // Test Failure


//Item IDs,Name,Price which are registered on seller portal for this application.
var itm_id = ['','',''];
var itm_name =['','',''];
var itm_price = ['','',''];
var currency_unit = [''];

/********************** Welcome Page ****************************/
function welcome(){
	tau.changePage('#welcome');
	document.getElementById('play_btn').addEventListener('click', onWelcomeClick);
}

function onWelcomeClick(){
	more();
}

/********************** Game Page ****************************/
function more(){
	tau.changePage('#more');
	document.getElementById('more_btn').addEventListener('click', onMoreClick);
}

function onMoreClick(){
	onGetItemList();
}

/********************** itemList page ****************************/
function optionList(){
	
	tau.changePage('#optionList');
	
	document.getElementById('remove-ads-text').innerHTML=itm_name[0]+"-"+currency_unit[0]+""+itm_price[0];
	document.getElementById('get-more-coins-text').innerHTML=itm_name[1]+"-"+currency_unit[0]+""+itm_price[1];
	document.getElementById('unlock-new-level-text').innerHTML=itm_name[2]+"-"+currency_unit[0]+""+itm_price[2];
	
	document.getElementById('idRemoveAds').addEventListener('click', onNonConsumableClick);
	document.getElementById('idMoreCoins').addEventListener('click', onConsumableClick);
	document.getElementById('idUnlockNewLevel').addEventListener('click', onSubscriptionClick);
}

/********************** Buy - Remove Ads ****************************/
function onNonConsumableClick(){

	tau.changePage('#buy');
	document.getElementById('buy_btn').addEventListener('click', onBuyNonConsume);
	document.getElementById('purchase_btn').addEventListener('click', onGetPurchasedItems);
}

/********************** Buy - Get more coins ****************************/
function onConsumableClick(){
	
	tau.changePage('#buy');
	document.getElementById('buy_btn').addEventListener('click', onBuyConsume);
	document.getElementById('purchase_btn').addEventListener('click', onGetPurchasedItems);	
}

/********************** Buy - Unlock new level ****************************/
function onSubscriptionClick(){
	
	tau.changePage('#buy');
	document.getElementById('buy_btn').addEventListener('click', onBuySubs);
	document.getElementById('purchase_btn').addEventListener('click', onGetPurchasedItems);	
}


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
			sb.append("Currency Unit : " +  result._items[i].mCurrencyUnit+ "  ");
			
			itm_id[i]=result._items[i].mItemId;
			itm_name[i]=result._items[i].mItemName;			
			itm_price[i]=result._items[i].mItemPrice;
			currency_unit[0]=result._items[i].mCurrencyUnit;
							
		}
		//alert(sb.toString());

		optionList();
		
	}
}

function getItemeErorCallback(error) {
	console.log("error name >>"+error.name + ' message : ' + error.message);
}

/********************** onGetItemList() API end ***********************/



/********************** Purchase API start ****************************/

function onBuyNonConsume() {
	webapis.inapppurchase.startPayment(itm_id[0], IAPmode, purchaseSuccessCallback, purchaseErrorCallback);
}

function onBuyConsume() {
	webapis.inapppurchase.startPayment(itm_id[1], IAPmode, purchaseSuccessCallback, purchaseErrorCallback);
}

function onBuySubs() {
	webapis.inapppurchase.startPayment(itm_id[2], IAPmode, purchaseSuccessCallback, purchaseErrorCallback);
}

function purchaseSuccessCallback(item) {
	
	alert("Item has been purchased successfully. Name:"+item.mItemName + ", Price:"+item.mItemPrice);
	
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



/********************** getPurchasedItemList() API start ************/

function onGetPurchasedItems() {
	webapis.inapppurchase.getPurchasedItemList(1, 15, new tizen.TZDate(2017, 06, 1), new tizen.TZDate(2019, 06, 01), purItemSuccessCallback, purItemErrorCallback);
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
		    
			//sb.append("Item ID : " + result._items[i].mItemId + "  ");
			sb.append("Item Name : " + result._items[i].mItemName + ",  ");
			sb.append("Item Price : " + result._items[i].mItemPrice+ ",  ");
			sb.append("Purchased Date : " + original_date+ "\n  ");
		}
		alert(sb.toString());
	}
}

function purItemErrorCallback(error) {
	console.log("error name >>"+error.name + ' message : ' + error.message);
	alert("error="+error.message)
}

/********************** getPurchasedItemList() API end **************************/



/*************** Back button funtcionality **********************/

( function () {
	
	window.addEventListener( 'tizenhwkey', function( ev ) {
		if( ev.keyName === "back" ) {
			var page = document.getElementsByClassName( 'ui-page-active' )[0],
				pageid = page ? page.id : "";
			if( pageid === "welcome" ) {
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

