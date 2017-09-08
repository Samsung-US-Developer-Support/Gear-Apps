#include "iapnativesample.h"
#include <iap_galaxyapps.h>
#include <string.h>
#include<time.h>
#include <sys/time.h>

/* Below IAP items are registered on Samsung seller portal */

char *consume = "consumable";
char *noncons = "nonconsumable";
char *autosub = "autosubscription";
char *subscri = "subscription";


char buffer[1000000];

void *data,*eventInfo;

#define DEBUG_MODE

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *btn;
	Evas_Object *naviframe;
	Eext_Circle_Surface *circle_surface;
	Evas_Object *circle_genlist;
} appdata_s;

appdata_s *appData;

static void
app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}

typedef struct {
	char* mErrorCode;
	char* mErrorString;
	char* mExtraString;

	char* mStartNumber;
	char* mEndNumber;
	char* mTotalCount;

	char* mItemId;
	char* mItemName;
	char* mItemPrice;
	char* mItemPriceString;
	char* mCurrencyUnit;
	char* mCurrencyCode;
	char* mItemDesc;
	char* mItemImageUrl;
	char* mItemDownloadUrl;
	char* mPaymentId;
	char* mPurchaseId;
	char* mPurchaseDate;
	char* mVerifyUrl;
	char* mType;
	char* mSubscriptionDurationUnit;
	char* mSubscriptionDurationMultiplier;
	char* mSubscriptionEndDate;
	char* mJsonString;
} output_data;



static void
_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	elm_naviframe_item_pop(ad->naviframe);
}

static void _showIAPDataOnListItemClick(char *buffer)
{
	char edj_path[PATH_MAX] = {0, };
	Evas_Object *naviframe = appData->naviframe;
	Evas_Object *layout = NULL;
	Evas_Object *label = NULL;
	Evas_Object *button = NULL;
	Evas_Object *scroller = NULL;
	Evas_Object *circle_scroller = NULL;
	Elm_Object_Item *nf_it = NULL;

	/* Unhighlight Item */
	//elm_genlist_item_selected_set((Elm_Object_Item *)event_info, EINA_FALSE);

	app_get_resource(EDJ_FILE, edj_path, (int)PATH_MAX);

	layout = elm_layout_add(naviframe);
	elm_layout_file_set(layout, edj_path, "info_layout");
	evas_object_show(layout);

	scroller = elm_scroller_add(layout);
	evas_object_show(scroller);

	elm_object_part_content_set(layout, "elm.swallow.content", scroller);

	/* Create Circle Scroller */
	circle_scroller = eext_circle_object_scroller_add(scroller, appData->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	label = elm_label_add(scroller);
	elm_label_line_wrap_set(label, ELM_WRAP_MIXED);

	elm_object_text_set(label,buffer);
	evas_object_show(label);

	elm_object_content_set(scroller, label);

	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "OK");
	elm_object_part_content_set(layout, "elm.swallow.button", button);
	evas_object_smart_callback_add(button, "clicked", _button_clicked_cb, appData);
	evas_object_show(button);

	nf_it = elm_naviframe_item_push(naviframe, _("Slider"), NULL, NULL, layout, "empty");

}


/******************************************** Purchase API start *************************************************/


static void
__purchase_cb(iap_galaxyapps_h reply, iap_galaxyapps_error_e result, void *user_data)
{
	output_data value = {0,};

	if (result != IAP_GALAXYAPPS_ERROR_NONE) {
		iap_galaxyapps_get_value(reply, "mErrorString", &value.mErrorString);
		// Error handling
		return;
	}

	// Get properties of the purchased item
	iap_galaxyapps_get_value(reply, "mItemId", &value.mItemId);
	iap_galaxyapps_get_value(reply, "mItemName", &value.mItemName);
	iap_galaxyapps_get_value(reply, "mItemPriceString", &value.mItemPriceString);
	iap_galaxyapps_get_value(reply, "mItemDesc", &value.mItemDesc);

	#ifdef DEBUG_MODE
		dlog_print(DLOG_INFO, LOG_TAG, value.mItemName);
	#endif

	// Handle properties
	int bufferLen= strlen(buffer);
	sprintf(&buffer[bufferLen], " Item has been purchased successfully: <br>ItemID : %s ItemName : %s ItemPrice : %s </br>", value.mItemId, value.mItemName,value.mItemPriceString);
	_showIAPDataOnListItemClick(buffer);
	return;
}

/***  This method is called when user tap on "Buy Consumable" button in Gear application ****/

static void onPurchaseConsumable(void *data, Evas_Object *obj, void *event_info)
{
	#ifdef DEBUG_MODE
		dlog_print(DLOG_INFO,  LOG_TAG, "Info-Purchase Consumable clicked\n");
    #endif

	buffer[0] = '\0';
	// Request to purchase an item //
	int ret = iap_galaxyapps_start_payment(consume, IAP_GALAXYAPPS_SUCCESS_TEST_MODE, __purchase_cb, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		dlog_print(DLOG_INFO, LOG_TAG, ret+"ERROR IN PURCHASE");
		return;
	}
}

/***  This method is called when user tap on "Buy Non Consumable" button in Gear application ****/

static void onPurchaseNonConsumable(void *data, Evas_Object *obj, void *event_info)
{
	#ifdef DEBUG_MODE
		dlog_print(DLOG_INFO, LOG_TAG, "Purchase Non-Consumable clicked\n");
	#endif

	buffer[0] = '\0';
	// Request to purchase an item //
	int ret = iap_galaxyapps_start_payment(noncons, IAP_GALAXYAPPS_SUCCESS_TEST_MODE, __purchase_cb, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		dlog_print(DLOG_INFO, LOG_TAG, ret+"ERROR IN PURCHASE");
		return;
	}
}

/***  This method is called when user tap on "Buy Auto-Recurring Subscription" button in Gear application ****/

static void onPurchaseAutoRecurringSubscription(void *data, Evas_Object *obj, void *event_info)
{
	#ifdef DEBUG_MODE
		dlog_print(DLOG_INFO, LOG_TAG, "Purchase AutoSubscription clicked\n");
	#endif
	buffer[0] = '\0';
	// Request to purchase an item //
	int ret = iap_galaxyapps_start_payment(autosub, IAP_GALAXYAPPS_SUCCESS_TEST_MODE, __purchase_cb, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		dlog_print(DLOG_INFO, LOG_TAG, ret+"ERROR IN PURCHASE");
		return;
	}
}

/***  This method is called when user tap on "Buy Subscription" button in Gear application ****/

static void onPurchaseNonRecurringSubscription(void *data, Evas_Object *obj, void *event_info)
{
	#ifdef DEBUG_MODE
		dlog_print(DLOG_INFO, LOG_TAG, "Purchase Non-Recurring Subscription clicked\n");
	#endif
	buffer[0] = '\0';
	// Request to purchase an item //
	int ret = iap_galaxyapps_start_payment(subscri, IAP_GALAXYAPPS_SUCCESS_TEST_MODE, __purchase_cb, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		dlog_print(DLOG_INFO, LOG_TAG, ret+"ERROR IN PURCHASE");
		return;
	}

}

/******************************************** Purchase API end *************************************************/


/******************************************* Get Items List start  ********************************************/

static bool
__foreach_item(iap_galaxyapps_h handle, void *user_data) {
	output_data value = {0,};

	// Get properties of Nth item
	iap_galaxyapps_get_value(handle, "mItemId", &value.mItemId);
	iap_galaxyapps_get_value(handle, "mItemName", &value.mItemName);
	iap_galaxyapps_get_value(handle, "mItemPriceString", &value.mItemPriceString);
	iap_galaxyapps_get_value(handle, "mItemDesc", &value.mItemDesc);

	dlog_print(DLOG_INFO, LOG_TAG, value.mItemName);

	int bufferLen= strlen(buffer);
	sprintf(&buffer[bufferLen], " <br>ItemID : %s ItemName : %s ItemPrice : %s </br>", value.mItemId, value.mItemName,value.mItemPriceString);

	dlog_print(DLOG_INFO, LOG_TAG,buffer);

	// Handle properties
	return true;
}


/********Callback method which will get called after getting the response of get item list API  ******/

static void
__get_item_list_cb(iap_galaxyapps_h reply, iap_galaxyapps_error_e result, void *user_data)
{
	if (result != IAP_GALAXYAPPS_ERROR_NONE) {
		char *mErrorString = NULL;
		iap_galaxyapps_get_value(reply, "mErrorString", &mErrorString);
		// Error handling
		return;
	}
	// Retrieve all items contained in handle
	buffer[0] = '\0';
	int ret = iap_galaxyapps_foreach_item_info(reply, __foreach_item, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		dlog_print(DLOG_INFO, LOG_TAG, ret+"ERROR IN RETREIVING ITEMS LIST");
		return;
	}

	_showIAPDataOnListItemClick(buffer);

	return;
}

/***  This method is called when user tap on "Item List" button in Gear application ****/

static void onGetItemsList(void *data, Evas_Object *obj, void *event_info)
{
	appData =data;
	dlog_print(DLOG_INFO, LOG_TAG, "Get Items List clicked\n");

	// Request to get item list
	int ret = iap_galaxyapps_get_item_list(1, 10, "10", IAP_GALAXYAPPS_SUCCESS_TEST_MODE, __get_item_list_cb, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		return;
	}

}

/******************************************* Get Items List end  ********************************************/



/*********************** onGetPurchasedItemList() and onGetPurchasedItemListById()  API START****************/

static bool
__foreach_purchased_item(iap_galaxyapps_h handle, void *user_data) {
	output_data value = {0,};

	// Get properties of Nth item
	iap_galaxyapps_get_value(handle, "mItemId", &value.mItemId);
	iap_galaxyapps_get_value(handle, "mItemName", &value.mItemName);
	iap_galaxyapps_get_value(handle, "mItemPriceString", &value.mItemPriceString);
	iap_galaxyapps_get_value(handle, "mItemDesc", &value.mItemDesc);
	iap_galaxyapps_get_value(handle, "mItemPrice", &value.mItemPrice);
	iap_galaxyapps_get_value(handle, "mPurchaseDate", &value.mPurchaseDate);

	dlog_print(DLOG_INFO, LOG_TAG, value.mItemName);
	dlog_print(DLOG_INFO, LOG_TAG, value.mItemPrice);
	// Handle properties

	int bufferLen= strlen(buffer);
	sprintf(&buffer[bufferLen], "<br> ItemID : %s ItemName : %s ItemPrice : %s    </br>", value.mItemId, value.mItemName,value.mItemPriceString);

	return true;
}



/********Callback method which will get called after getting the response of get purchased item list API  ******/

static void
__get_purchased_item_list_cb(iap_galaxyapps_h reply, iap_galaxyapps_error_e result, void *user_data)
{
	if (result != IAP_GALAXYAPPS_ERROR_NONE) {
		char *mErrorString = NULL;
		// Error handling
		return;
	}
	buffer[0] = '\0';
	// Retrieve all items contained in handle
	int ret = iap_galaxyapps_foreach_item_info(reply, __foreach_purchased_item, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		dlog_print(DLOG_INFO, LOG_TAG, ret+"ERROR IN RETREIVING PURCHASED ITEMS LIST");
		return;
	}
	_showIAPDataOnListItemClick(buffer);
	return;
}

/***  This method is called when user tap on "Purchased List" button in Gear application ****/


static void onGetPurchasedItemList(void *data, Evas_Object *obj, void *event_info)
{

	appData =data;
	dlog_print(DLOG_INFO, LOG_TAG, "Get Purchased Items List clicked\n");

	// Request to get purchased item list
	// #1. iap_galaxyapps_get_purchased_item_list
	int ret = iap_galaxyapps_get_purchased_item_list(1, 10, "20160101", "20191231", __get_purchased_item_list_cb, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		return;
	}
}

/***  This method is called when user tap on "Purchased List ID" button in Gear application, It will retrieve all purchased items of type consumable and non consumable ****/

static void onGetPurchasedItemListById(void *data, Evas_Object *obj, void *event_info)
{

	appData =data;
	dlog_print(DLOG_INFO, LOG_TAG, "Get Purchased Items List By Id clicked\n");

	// Request to get purchased item list
	// #2. iap_galaxyapps_get_purchased_item_list_by_item_ids
	int ret = iap_galaxyapps_get_purchased_item_list_by_item_ids("consumable, nonconsumable", __get_purchased_item_list_cb, NULL);
	if (ret != IAP_GALAXYAPPS_ERROR_NONE) {
		// Error handling
		return;
	}

}

/*********************** onGetPurchasedItemList() and onGetPurchasedItemListById()  API end****************/


static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}
char *main_menu_names[] = {
		"Buy Consumable", "Buy Non Consumable", "Buy Auto-Recur Subscription","Buy Subscription","Purchased List","Purchased List ID","Item List",
		NULL
};

typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

static char*
_gl_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];

	snprintf(buf, 1023, "%s", "IAP Native");

	return strdup(buf);
}

static char *
_gl_main_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	item_data *id = data;
	int index = id->index;

	if (!strcmp(part, "elm.text")) {
		snprintf(buf, 1023, "%s", main_menu_names[index]);
		return strdup(buf);
	}
	return NULL;
}

static void _gl_del(void *data, Evas_Object *obj)
{
	// FIXME: Unrealized callback can be called after this.
	// Accessing Item_Data can be dangerous on unrealized callback.
	item_data *id = data;
	if (id) free(id);
}

static Eina_Bool
_naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	ui_app_exit();
	return EINA_FALSE;
}

static void
create_list_view(appdata_s *ad)
{
	Evas_Object *genlist = NULL;
	Evas_Object *naviframe = ad->naviframe;
	Elm_Object_Item *nf_it = NULL;
	Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *titc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *pitc = elm_genlist_item_class_new();
	item_data *id = NULL;
	int index = 0;

	/* Create Genlist */
	genlist = elm_genlist_add(naviframe);
	elm_genlist_mode_set(genlist, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(genlist, "selected", NULL, NULL);

	/* Create Circle Genlist */
	ad->circle_genlist = eext_circle_object_genlist_add(genlist, ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_genlist_scroller_policy_set(ad->circle_genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(ad->circle_genlist, EINA_TRUE);

	/* Genlist Item Style */
	itc->item_style = "default";
	itc->func.text_get = _gl_main_text_get;
	itc->func.del = _gl_del;

	/* Genlist Title Item Style */
	titc->item_style = "title";
	titc->func.text_get = _gl_title_text_get;
	titc->func.del = _gl_del;

	/* Genlist Padding Item Style */
	pitc->item_style = "padding";

	/* Title Item Here */
	elm_genlist_item_append(genlist, titc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	/* Main Menu Items Here */
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, onPurchaseConsumable, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, onPurchaseNonConsumable, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, onPurchaseAutoRecurringSubscription, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, onPurchaseNonRecurringSubscription, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, onGetPurchasedItemList, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, onGetPurchasedItemListById, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, onGetItemsList, ad);

	/* Padding Item Here */
	elm_genlist_item_append(genlist, pitc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	nf_it = elm_naviframe_item_push(naviframe, NULL, NULL, NULL, genlist, "empty");
	elm_naviframe_item_pop_cb_set(nf_it, _naviframe_pop_cb, ad->win);
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);


	/* Naviframe */
	ad->naviframe = elm_naviframe_add(ad->conform);
	elm_object_content_set(ad->conform, ad->naviframe);

	/* Eext Circle Surface*/
	ad->circle_surface = eext_circle_surface_naviframe_add(ad->naviframe);

	/* Main View */
	create_list_view(ad);

	eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_MORE, eext_naviframe_more_cb, NULL);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);

}



static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
