//Old approach for Deeplink implementation
//http://stackoverflow.com/questions/36293425/galaxy-gear-s2-launche-android-application-on-phone-from-tizen-web-application
    
//New approach for Deeplink implementation.
//http://img-developer.samsung.com/onlinedocs/gear/Extension_PG_Web/html/prog_guide/remote_ww.htm


window.onload = function () {
    // TODO:: Do your initialization job

    // add eventListener for tizenhwkey
    document.addEventListener('tizenhwkey', function(e) {
        if(e.keyName === "back") {
			try {
			    tizen.application.getCurrentApplication().exit();
			} catch (ignore) {
			}
		}
	});
    
    
    document.getElementById('idDeepLink_Old').addEventListener('click', OldApproach);
    document.getElementById('idDeepLinkNewExplicit').addEventListener('click', explicitLaunch);
    document.getElementById('idDeepLinkNewimplicit').addEventListener('click', implicitLaunch);
    
};


function OldApproach() {
	
	var serviceName = "tizen.wearablemanager";
    var pkgName = "com.samsung.iap4sample";
    var appControlData = [new tizen.ApplicationControlData("type", ["phone"]), new tizen.ApplicationControlData("deeplink", ["samsungapps://ProductDetail/" + pkgName])];
    var appControl = new tizen.ApplicationControl("http://tizen.org/appcontrol/operation/default", null, null, null, appControlData);
    
    var callback = {
        onsuccess: function (data) {
            console.log("galaxy apps success: " + JSON.stringify(data));
        },
        onfailure: function () {
            console.log("galaxy apps reply failed");
        }
    };
    try {
        tizen.application.launchAppControl(appControl, serviceName, function () {
            console.log("[recents] launch NavigatorInstaller success");
        }, function (err) {
            //uiHelper.hideMBSplashPage();
            console.log("[recents] launch NavigatorInstaller failed: " + err.message);
        }, callback);
    } catch (err) {
        console.log("[launcher] error on launch NavigatorInstaller: " + err.message);
    }
}

function explicitLaunch(){
	 var remoteAppControlReplyCallback = {
         onsuccess: function(data) {
       	  createHTML('Recevied data is :' + data);
         },
         // callee returned failure
         onfailure: function() {
       	  createHTML('The launch remote application control failed');
         }
     }
	
		var remoteAppCtrl = new webapis.RemoteApplicationControl(
				"http://samsung.com/appcontrol/operation/remote/default", null,
				"com.samsung.iap4sample", 
				"com.samsung.iap4sample.activity.MainActivity", 
				"this data from host device"
				);

		try {
			webapis.remoteappcontrol.launchRemoteAppControl( remoteAppCtrl,
					function () {createHTML("launch success");}, function(e) {createHTML("failed : " + e.name);}, remoteAppControlReplyCallback);
		} catch(e) {
			console.log("Error Exception, error name : " + e.name + ", error message : " + e.message);
		}	 
}


var remoteAppControlReplyCallback = 
{
   /* Launched application sent a reply */
   onsuccess: function(data)
   {
      console.log('**** Received data is ' + data);
   },
   /* Remote device returned a failure */
   onfailure: function()
   {
      console.log('**** The remote application control launch failed');
   }
}


function implicitLaunch() {
	
	var remoteAppCtrl = new webapis.RemoteApplicationControl(
			"http://samsung.com/appcontrol/operation/remote/view",
			"samsungapps://ProductDetail/com.samsung.iap4sample/"
			);	

	try {
		webapis.remoteappcontrol.launchRemoteAppControl( remoteAppCtrl,
				function () {createHTML("launch success");}, function(e) {createHTML("failed : " + e.name);});
	} catch(e) {
		console.log("Error Exception, error name : " + e.name + ", error message : " + e.message);
	}
	
}



