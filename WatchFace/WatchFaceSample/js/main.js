(function() {
    
	var isAmbientMode = false;
	
	/**
     * This function rotates the hour, minute & second handle. We are using java script "style transform" property to rotate the "element". 
     * @private
     * @param {string} elementID - ID of the element to be rotated
     * @param {number} angle - angle of rotation
     */
    function rotateElement(elementID, angle) {
        var element = document.querySelector("#" + elementID);

        element.style.transform = "rotate(" + angle + "deg)";
    }

    /**
     * This function updates time in watch face, the hour/minute/second hands according to the current time.
     * This function will get called every second.
     * This will also get called when the time zone is changed or the visibility of the watch face is changed.
     * @private
     */
    function updateTime() {
        var datetime = tizen.time.getCurrentDateTime(),
            hour = datetime.getHours(),
            minute = datetime.getMinutes(),
            second = datetime.getSeconds();

        // Rotate the hour/minute/second hands
        rotateElement("hand-main-hour", (hour + (minute / 60) + (second / 3600)) * 30);
        rotateElement("hand-main-minute", (minute + second / 60) * 6);
        rotateElement("hand-main-second", second * 6);
    }
    
    /**
     *This is a Callback function which will get invoked on pedometer data change, then it updates the steps count in watch face acordingly
     * @private
     */
    
    function onchangedCB(pedometerInfo)
    {    
       var element = document.querySelector("#step-count");
       element.innerHTML = pedometerInfo.accumulativeTotalStepCount;
    }
    
    /**
     *This will launch the SHealth application, this will get triggered when user tap on steps count.
     * @private
     */
    
    function onOpenShealth() {
    	console.log("launching SHealth");

    	 // Launch sHealth application expicitly
    	 tizen.application.launch("com.samsung.shealth", 
    			 function() {console.log("launch application control succeed"); },
     		     function(e) {console.log("launch application control failed. reason: " + e.message); }
    			 );
    }
    
    /**
     * Sets default event listeners.
     * This function will bind click events to step count & buy button as well.
     * When user tap on step count, it will trigger the onOpenShealth callback & when user tap on buy button it will trigger the onBySubscription callback function
     * @private
     */
    function bindEvents() {
       
    	// Add an event listener to update the screen immediately when the device wakes up
        document.addEventListener("visibilitychange", function() {
            
        	if (!document.hidden) {
                updateTime();
                
                if (isAmbientMode === true) {
                    // Rendering ambient mode case
                    activateMode("Ambient");
                } else {
                    // Rendering normal case
                    activateMode("Normal");
                }
            }
        });
        
        
        // Add an eventListener for ambientmodechanged
        window.addEventListener("ambientmodechanged", function(e) {
            if (e.detail.ambientMode === true) {
                // Rendering ambient mode case
                activateMode("Ambient");
            } else {
                // Rendering normal case
                activateMode("Normal");
            }
        });
        
        // Add an click event listener of div to launch sHealth application
        document.getElementById("action-steps").addEventListener("click", onOpenShealth);
        
          // Add eventListener to update the screen when the time zone is changed
        tizen.time.setTimezoneChangeListener(function() {
            updateTime();
        });
        
        //Add listner for pedometer data change
        tizen.humanactivitymonitor.setAccumulativePedometerListener(onchangedCB);
    }

    /**
     * Activates a mode of the watch. Amibent mode is Always on mode watch face, 
     * To use the ambient mode, the user must enable it in the device settings. 
     * In addition, in the Gear S2 device, the ambient mode activates only when you are wearing the watch on the wrist.
     * @param {string} mode - The mode of the watch to be activated.
     * @private
     */
    function activateMode(mode) {
        
    	'use strict';

        switch (mode) {
        
            case "Ambient":
                // Normal -> Ambient
            	isAmbientMode = true;
            	showAmbientWatch();
                break;
            
            case "Normal":
                // Ambient -> Normal
            	isAmbientMode = false;
            	showNormalWatch();
                break;
            
            default:
                break;
        }
    }
    /**
     * This function activates normal watch face on Gear device.
     * It will first remove the css class which is used for ambient mode and the add css for normal watch face.
     * It will change the visibility of the componenets to "visible" which were set as "hidden" in ambient mode. 
     * @private
     */
    function showNormalWatch(){
        
    	var myButtonClasses = document.getElementById("background").classList;
        
        if (myButtonClasses.contains("amibentBackground")) {
            myButtonClasses.remove("amibentBackground");
        }  
        
        myButtonClasses.add("normalBackground");
        
        document.getElementById("hand-main-second").style.visibility 	= "visible";
        document.getElementById("components-steps").style.visibility 	= "visible";
        document.getElementById("action-steps").style.visibility 		= "visible";
    }
    
    /**
     * This function activates Ambient watch face.
     * This is being done by changing the background of the watchface as black.
     * and setting the visibility of second niddle, steps count component & buy component to hidden
     * @private
     */
    
    function showAmbientWatch(){

        var myButtonClasses = document.getElementById("background").classList;
        
        if (myButtonClasses.contains("normalBackground")){
        	myButtonClasses.remove("normalBackground");
        }
               
        myButtonClasses.add("amibentBackground");
            
        document.getElementById("hand-main-second").style.visibility	= "hidden";
        document.getElementById("components-steps").style.visibility 	= "hidden";
        document.getElementById("action-steps").style.visibility 		= "hidden";
    }
    
    /**
     * Initiates the Watch face application
     * @private
     */
    function init() {
        bindEvents();
        // Update the watch hands every second
        
        setInterval(function() {
            updateTime();
        }, 1000);
    }

    window.onload = init();
}());