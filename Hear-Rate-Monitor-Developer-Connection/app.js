/**** Global variable used in the application ****/

var TEXT_STOP = 'Stop';
var TEXT_START = 'Start';
var heartRateEl;
var heartImg;
var infoBackBtn;
var hrmControlBtn;
var deeplinkBtn;
var sensorStarted = false;

/**TAG for application logs *****/

var TAG = "HeartRateMonitor *****";

/**
 * function: init()
 * This function will be called on "onload" event of the html
 * This is the very fist function which will be called when the app is loaded.
 * Initialization of HTML variables and binding  of click events is done inside this function.
  * 
 */

function init() {
	console.log(TAG+ "init() function called");
	
	/*** Initialize the html variables  *****/
	
	heartRateEl = document.getElementById('heart-rate-value');
	heartImg = document.getElementById('heart-img');
	infoBackBtn = document.getElementById('info-back-btn');
	hrmControlBtn= document.getElementById('hrm-control-btn');
	deeplinkBtn = document.getElementById('idDeeplink');
	
	/*** Registering click event handler for buttons */
	
	hrmControlBtn.addEventListener('click', onhrmControlBtnClick);	
	infoBackBtn.addEventListener('click',   onInfoBackBtnClick);
	deeplinkBtn.addEventListener('click',   onDeeplinkToMobile);	
}

/** 
 * function: onhrmControlBtnClick()
 * This function is a click event handler for HRM sensor Start/Stop button
 * Toggles the sensor state
 * Toggles the text of the button
 */

function onhrmControlBtnClick() {
	console.log(TAG+"onhrmControlBtnClick() called...");
	
	if (hrmControlBtn.innerHTML === TEXT_START){
		console.log("info on button = start");
		startSensor();
	} else {
		console.log("info on button = stop");
		stopSensor();
		showMeasuringInfo();
	}
}

/** 
 * function: startSensor()
 * Starts the HRM sensor and registers a change listener.
 * Update the UI: change button text to Stop.
 */	

function startSensor() {
	console.log(TAG+"start sensor() called...");
	
	sensorStarted = true;
	hrmControlBtn.innerHTML = TEXT_STOP;
	
	/** Start heart image animation, 'animate' class is defined in style.css */
	
	if (!heartImg.classList.contains('animate')) {
		heartImg.classList.add('animate');
	}
    /** Start the HRM sensor*/	
	tizen.humanactivitymonitor.start('HRM', onHeartRateDataChange, onerrorCB);
}

/**
 * function: stopSensor()
 * Stops the sensor
 * Update the UI: Hides measuring text, stop animation on heart image and change button text to Start.
 */	

function stopSensor() {
	console.log(TAG+"stopSensor() called...");
	sensorStarted = false;
	/**Remove animation class from heart icon */
	heartImg.classList.remove('animate');
    /*** Stop sensor ***/
	tizen.humanactivitymonitor.stop("HRM");
	/*** Change button text to start ***/
	hrmControlBtn.innerHTML = TEXT_START;
}

/**
 * function: onHeartRateDataChange()
 * This is a callback function which will be called after receiving the current heart rate of the user
 * All the calucations for setting up the min, max & avg heart rate being done inside this function.
 * 
 */

function onHeartRateDataChange(heartRateInfo) {
	console.log(TAG+"onHeartRateDataChange() called...");
	if (!sensorStarted){
		return;
	}
	heartRateEl.innerHTML = '';
	
	var rate = heartRateInfo.heartRate;
	var activePage = document.getElementsByClassName('ui-page-active')[0];
	var activePageId = activePage ? activePage.id : '';

	/**
	 * If heart rate value is valid, set the value and show the information page.
	 */
	if (rate > 1) {
		console.log(TAG+"heartRateEl is valid information...");
		/*Show the information page & set the heart rate value on Heart Rate image*/
		tau.changePage('#information');
		heartRateEl.innerHTML = rate;

		/**
		 * Sensor only provide the current heart rate of the user, to show minimum heart rate, maximum heart rate & average heart rate
		 * We have to do the calculations at application side. We are using tizen pereferences to achieve this.
		 * https://developer.tizen.org/ko/development/guides/web-application/application-management/application-preferences?langredirect=1
		 * tizen pereferences are something like we have shared preferences in Abdroid.
		 */
		
		document.getElementById("currentHR").innerHTML = "Current HR: "+rate;

		/** MINHR pereferences Key is used to store the minimum heart rate 
		
		* If MINHR key is alreadty exists then get the value of the key and if saved value is greater than the current Heart rate then update the key with the current heart rate
		* If MINHR key does not exists then it means this is very first heart rate reading, then create the MINHR key and save the value as the current heart rate
		**/
		
		if (tizen.preference.exists("MINHR")) {
			var value = tizen.preference.getValue("MINHR");
			if(value > rate) {
				tizen.preference.setValue("MINHR", rate);
			}
		} else {
			tizen.preference.setValue("MINHR", rate);
		}
		
		/** MAXHR pereferences Key is used to store the maximum heart rate 

		 *If MAXHR key is alreadty exists then get the value of the key and if saved value is lesser than the current Heart rate then update the key with the current heart rate
		 *If MAXHR key does not exists then it means this is very first heart rate reading, then create the MAXHR key and save the value as the current heart rate
		 **/
		
		if (tizen.preference.exists("MAXHR")) {
			var value = tizen.preference.getValue("MAXHR");
			if(value < rate) {
				tizen.preference.setValue("MAXHR", rate);
			}
		} else {
			tizen.preference.setValue("MAXHR", rate);
		}
		
		/** AVGHR Key is used to store the maximum heart rate & COUNT key is used to store the number of successfull heart rate reading,
		 *  COUNT will be used in calculating the average heart rate of the user
		 *  If AVGHR & COUNT key are alreadty exists then get the value of the keys and perform the calculations.
		 *  If AVGHR & COUNT keys does not exists then it means this is very first heart rate reading, then create AVGHR key and save the value as the current heart rate
		 *  & set the value of COUNT key as one as this is the first hear rate reading.
		 **/
		
		if (tizen.preference.exists("AVGHR") && tizen.preference.exists("COUNT")) {
			
			var value = tizen.preference.getValue("AVGHR");
			var count = tizen.preference.getValue("COUNT");
			
			var total = value * count + rate;
			count = count + 1;
			
			var avg = total/count;
			
			tizen.preference.setValue("AVGHR", avg);
			tizen.preference.setValue("COUNT", count);
			
		} else {
			tizen.preference.setValue("AVGHR", rate);
			tizen.preference.setValue("COUNT", 1);
		}
		
		/** Get the values of the heart rate from perefernce keys and show that on html page */
		var minHR = tizen.preference.getValue("MINHR");
		var maxHR = tizen.preference.getValue("MAXHR");
		/** Remove decimal value from Avg HR */
		var avgHR = parseInt(tizen.preference.getValue("AVGHR"));
		
		document.getElementById("minHR").innerHTML = "Min HR: "+ minHR;
		document.getElementById("maxHR").innerHTML = "Max HR: "+ maxHR;
		document.getElementById("avgHR").innerHTML = "Avg HR: "+ avgHR;
		
		console.log(TAG + "Current HR: "+rate);
		console.log(TAG + "Minimum HR: "+minHR);
		console.log(TAG + "Maximum HR: "+maxHR);
		console.log(TAG + "Average HR: "+avgHR);
		
		/** Stop the sensor as we have got the hear rate reading.*/
		
		stopSensor();
	}
}

/** 
 * function: onerrorCB()
 * Call back when an error occurs in starting the HRM sensor
 **/

function onerrorCB(error) {
    console.log(TAG+"Error name:"+error.name + ", message: "+error.message);
}

/**
 * function: showMeasuringInfo()
 * Displas information popup when stop button is tapped.
 */

function showMeasuringInfo() {
	console.log(TAG+"showMeasuringInfo() called..");
    tau.changePage('#info');
 }

/**
 * function: onInfoBackBtnClick()
 * Click event handler for back button on info page
 * Hides the information popup and redirects to main page.
 */

function onInfoBackBtnClick() {
	console.log(TAG+"onInfoBackBtnClick() called...");
    tau.changePage('#main');
}

/**
 * function: onDeeplinkToMobile()
 * This function will execute when user press on "On Phone" button which will be visible on HRM Information page.
 * The deeplinking is being done to one of the samsung app "ABC mouse".
 * There can be two case, once ABC mouse app is installed on the connected android mobile device and another case is app is not installed on the device.
 * If "ABC mouse" app is not installed on connected anroid mobile device => On tap of "On Phone" button, it will show the "ABC mouse" app detail page on Samsung Galaxy app store.
 * If "ABC mouse" app is already insatalled on connected anroid mobile device => => On tap of "On Phone" button, it will launch the "ABC mouse" app in android mobile device.
 * For deeplink implementation you may refer to http://img-developer.samsung.com/onlinedocs/gear/Extension_PG_Web/html/prog_guide/remote_ww.htm
 */

function onDeeplinkToMobile(){
	
	/**** Launched application sent a reply from android device ****/
	
	var remoteAppControlReplyCallback = {
		// callee returned success
        onsuccess: function(data) {
        	console.log(TAG+"onsuccess "+data);
        },
        // callee returned failure
        onfailure: function() {
        	console.log(TAG+"fail "+data);
        }
    }

	var remoteAppCtrl = new webapis.RemoteApplicationControl("http://samsung.com/appcontrol/operation/remote/default", null,
			"mobi.abcmouse.samsung",  // pkg name of the ABC mouse application
			"com.abcmouse.MainActivity", // MainActivity of the ABC mouse application
			"Lauch app on connected mobile"
			);
	try {
		webapis.remoteappcontrol.launchRemoteAppControl( remoteAppCtrl,
				function () { // success callback method
					console.log(TAG+ "app launch success callback");
				}, 
				function(e) { // error callback method
	
					console.log(TAG+"app launch failure callback");
					console.log(TAG+"app was not found on the connected android mobile device, try to launch the app detail page on Samsung Galaxy app store");
					
					launchAppDetailPage();
				}, 
				remoteAppControlReplyCallback);
	} catch(e) {
		console.log(TAG+"Error Exception, error name : " + e.name + ", error message : " + e.message);
	}	
}

/**
 * function: launchAppDetailPage()
 * launchAppDetailPage() will be called if ABC mosue is not installed in the connected android mobile device.
 * It will launch the app detail page on Samsung Galaxy app store.
 */

function launchAppDetailPage() {
	
	var remoteAppCtrl = new webapis.RemoteApplicationControl(
			"http://samsung.com/appcontrol/operation/remote/view",
			"samsungapps://ProductDetail/mobi.abcmouse.samsung/" // Create a deeplink of Samsung galaxy app store page using ABC mouse app pkg name.
			);	

	try {
		webapis.remoteappcontrol.launchRemoteAppControl( remoteAppCtrl,
				function () {
					console.log(TAG+ "launch success callback");
				}, 
				function(e) {
					console.log(TAG+ "launch success callback "+e.name);
				});
	} catch(e) {
		console.log(TAG+"Error Exception, error name : " + e.name + ", error message : " + e.message);
	}
}

/**
 * Handle the basic Back button (hard key of gear device) funtcionality
 */

( function () {
	
	window.addEventListener( 'tizenhwkey', function( ev ) {
		if( ev.keyName === "back" ) {
			var page = document.getElementsByClassName( 'ui-page-active' )[0],
				pageid = page ? page.id : "";
			if( pageid === "main" ) {
				try {
					tizen.humanactivitymonitor.stop("HRM");
					tizen.application.getCurrentApplication().exit();
				} catch (ignore) {
				}
			} else {
				window.history.back();
			}
		}
	} );
	
} () );