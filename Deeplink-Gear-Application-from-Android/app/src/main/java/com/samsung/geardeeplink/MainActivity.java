package com.samsung.geardeeplink;

import android.content.ActivityNotFoundException;
import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    /***
     * @param _view
     * This function will open the "SRI Color Watch" app detail page of Galaxy app store in android mobile device.
     */

    public void LaunchGearAppDeatilPage( View _view ) {

        Intent deepLinkIntent;
        deepLinkIntent =new Intent(Intent.ACTION_VIEW, Uri.parse(Constants.SAMSUNG_MARKET_WEB_URL + Constants.SRI_COLOR_WATCH_APPID));

        try {
            deepLinkIntent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TASK |Intent.FLAG_ACTIVITY_NEW_TASK );
            //start activity with specified intent
            this.startActivity(deepLinkIntent);
        } catch (ActivityNotFoundException e) {
            Toast.makeText(this,"No Application found which can handle this request",Toast.LENGTH_SHORT).show();
            e.printStackTrace();
        }
    }

}
