S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.1
Build-Number: R765VVRE0AQA1
Build-Date: 2017.01.04 14:35:39

Crash Information
Process Name: iapnativesample
PID: 6301
Date: 2017-01-05 15:13:25+0530
Executable File Path: /opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6301, uid 5000)

Register Information
r0   = 0xf5e23508, r1   = 0xf5d2f13c
r2   = 0x00000000, r3   = 0xfff836bc
r4   = 0xf7dea3b8, r5   = 0xf7c94368
r6   = 0xf7dc75c8, r7   = 0xfff836c8
r8   = 0x00000073, r9   = 0xf7dd32f0
r10  = 0xf7df4638, fp   = 0xf2b01368
ip   = 0x00000000, sp   = 0xfff82668
lr   = 0xf5d26651, pc   = 0xf5d2665a
cpsr = 0x80000030

Memory Information
MemTotal:   619852 KB
MemFree:     26772 KB
Buffers:     18304 KB
Cached:     178588 KB
VmPeak:      83544 KB
VmSize:      80592 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29228 KB
VmRSS:       28532 KB
VmData:      17496 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       25700 KB
VmPTE:         116 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6301 TID = 6301
6301 6512 

Maps Information
f2c79000 f2c7d000 r-xp /usr/lib/libogg.so.0.7.1
f2c85000 f2ca7000 r-xp /usr/lib/libvorbis.so.0.4.3
f2caf000 f2cbe000 r-xp /usr/lib/libmdm-common.so.1.1.22
f2cc7000 f2d0e000 r-xp /usr/lib/libsndfile.so.1.0.26
f2d1a000 f2d63000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2d6c000 f2d71000 r-xp /usr/lib/libjson.so.0.0.1
f2d79000 f2d7c000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2d84000 f2d85000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f2d8d000 f2d90000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f2da0000 f2de8000 r-xp /usr/lib/libmdm.so.1.2.62
f2de9000 f2dec000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2df4000 f2e2d000 r-xp /usr/lib/libpulse.so.0.16.2
f2e35000 f2e38000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2e40000 f2ea1000 r-xp /usr/lib/libasound.so.2.0.0
f2eab000 f2ec6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2ece000 f2ed3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2edb000 f2ee7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f2ef4000 f2ef9000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2f01000 f2f1b000 r-xp /usr/lib/libmmfsound.so.0.1.0
f2f2c000 f2f33000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2f3b000 f2f46000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f2f4e000 f2f50000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f2f58000 f2f59000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f2f61000 f2f6a000 r-xp /usr/lib/libfeedback.so.0.1.4
f2f8b000 f2f8c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f326d000 f326e000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f32f6000 f3af5000 rwxp [stack:6512]
f3af5000 f3af7000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3aff000 f3b16000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3b23000 f3b28000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3b30000 f3b3b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3d44000 f3e36000 r-xp /usr/lib/libCOREGL.so.4.0
f3e4f000 f3e54000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3e5c000 f3e7d000 r-xp /usr/lib/libexif.so.12.3.3
f3e90000 f3e95000 r-xp /usr/lib/libsystem.so.0.0.0
f3e9f000 f3ea6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3eae000 f3eb5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3ebe000 f3eca000 r-xp /usr/lib/libresourced.so.0.2.96
f3ed2000 f3ed3000 r-xp /usr/lib/librd-network.so.0.2.96
f3edb000 f3ede000 r-xp /usr/lib/libresponse.so.0.2.96
f3ee6000 f3eec000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5785000 f5793000 r-xp /usr/lib/libail.so.0.1.0
f579b000 f57a2000 r-xp /usr/lib/libminizip.so.1.0.0
f57aa000 f57ac000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f57b4000 f57bc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f57c4000 f57cc000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f57d4000 f57d6000 r-xp /usr/lib/libdri2.so.0.0.0
f57de000 f57e6000 r-xp /usr/lib/libdrm.so.2.4.0
f57ee000 f58f4000 r-xp /usr/lib/libicuuc.so.57.1
f590a000 f5a92000 r-xp /usr/lib/libicui18n.so.57.1
f5aa2000 f5aa6000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f5aae000 f5ab3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5abb000 f5ae0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f5aea000 f5b04000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f5b0c000 f5b12000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5b1a000 f5b1b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f5b24000 f5b28000 r-xp /usr/lib/libEGL.so.1.4
f5b38000 f5b49000 r-xp /usr/lib/libGLESv2.so.2.0
f5b59000 f5b65000 r-xp /usr/lib/libtbm.so.1.0.0
f5b6d000 f5b95000 r-xp /usr/lib/libui-extension.so.0.1.0
f5b96000 f5bad000 r-xp /usr/lib/libtts.so
f5bb5000 f5bbb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f5bc4000 f5bc5000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f5bce000 f5bdc000 r-xp /usr/lib/libcapability-manager.so.0.0.1
f5be5000 f5c9d000 r-xp /usr/lib/libcairo.so.2.11200.14
f5ca8000 f5cbb000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5cc3000 f5cc7000 r-xp /usr/lib/libiap-galaxyapps.so.0.1.0
f5ccf000 f5cf0000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5cf8000 f5d04000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5d11000 f5d1c000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5d24000 f5d27000 r-xp /opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample
f5fb6000 f5fc0000 r-xp /lib/libnss_files-2.13.so
f5fc9000 f6098000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f60af000 f60d5000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f60df000 f60e5000 r-xp /usr/lib/libappsvc.so.0.1.0
f60ee000 f60f2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f60ff000 f610a000 r-xp /usr/lib/elementary/modules/ui_analyzer_2.0/linux-gnueabi-armv7l-1.7.99/module.so
f6112000 f6114000 r-xp /usr/lib/libiniparser.so.0
f611d000 f6122000 r-xp /usr/lib/libappcore-common.so.1.1
f612b000 f612d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f6136000 f613a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6148000 f614a000 r-xp /usr/lib/libXau.so.6.0.0
f6152000 f6159000 r-xp /lib/libcrypt-2.13.so
f6189000 f618b000 r-xp /usr/lib/libiri.so
f6193000 f633c000 r-xp /usr/lib/libcrypto.so.1.0.0
f635d000 f63a4000 r-xp /usr/lib/libssl.so.1.0.0
f63b0000 f63de000 r-xp /usr/lib/libidn.so.11.5.44
f63e6000 f63ef000 r-xp /usr/lib/libcares.so.2.1.0
f63f8000 f640b000 r-xp /usr/lib/libxcb.so.1.1.0
f6415000 f6417000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f641f000 f6422000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f642a000 f64f6000 r-xp /usr/lib/libxml2.so.2.7.8
f6503000 f6505000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f650d000 f6512000 r-xp /usr/lib/libffi.so.5.0.10
f651b000 f651c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6524000 f6527000 r-xp /lib/libattr.so.1.1.0
f652f000 f654c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6555000 f656d000 r-xp /usr/lib/libpng12.so.0.50.0
f6575000 f658b000 r-xp /lib/libexpat.so.1.6.0
f6596000 f662a000 r-xp /usr/lib/libstdc++.so.6.0.16
f663d000 f6681000 r-xp /usr/lib/libcurl.so.4.3.0
f668a000 f6694000 r-xp /usr/lib/libXext.so.6.4.0
f669d000 f66a1000 r-xp /usr/lib/libXtst.so.6.1.0
f66a9000 f66af000 r-xp /usr/lib/libXrender.so.1.3.0
f66b7000 f66bd000 r-xp /usr/lib/libXrandr.so.2.2.0
f66c5000 f66c6000 r-xp /usr/lib/libXinerama.so.1.0.0
f66cf000 f66d8000 r-xp /usr/lib/libXi.so.6.1.0
f66e0000 f66e3000 r-xp /usr/lib/libXfixes.so.3.1.0
f66eb000 f66ed000 r-xp /usr/lib/libXgesture.so.7.0.0
f66f5000 f66f7000 r-xp /usr/lib/libXcomposite.so.1.0.0
f66ff000 f6701000 r-xp /usr/lib/libXdamage.so.1.1.0
f6709000 f6710000 r-xp /usr/lib/libXcursor.so.1.0.2
f6718000 f671b000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6723000 f6727000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6730000 f6735000 r-xp /usr/lib/libecore_fb.so.1.7.99
f673e000 f681f000 r-xp /usr/lib/libX11.so.6.3.0
f682a000 f684d000 r-xp /usr/lib/libjpeg.so.8.0.2
f6865000 f687b000 r-xp /lib/libz.so.1.2.5
f6883000 f6885000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f688d000 f6902000 r-xp /usr/lib/libsqlite3.so.0.8.6
f690c000 f6928000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6930000 f6964000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f696d000 f6a40000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a4b000 f6a5b000 r-xp /lib/libresolv-2.13.so
f6a5f000 f6a77000 r-xp /usr/lib/liblzma.so.5.0.3
f6a7f000 f6a82000 r-xp /lib/libcap.so.2.21
f6a8a000 f6ab9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ac1000 f6ac2000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6aca000 f6ad0000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6ad8000 f6aef000 r-xp /usr/lib/liblua-5.1.so
f6af8000 f6aff000 r-xp /usr/lib/libembryo.so.1.7.99
f6b07000 f6b0d000 r-xp /lib/librt-2.13.so
f6b16000 f6b6c000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b79000 f6bcf000 r-xp /usr/lib/libfreetype.so.6.11.3
f6bdb000 f6c03000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6c04000 f6c49000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c52000 f6c65000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c6d000 f6c6f000 r-xp /usr/lib/libttrace.so.1.1
f6c77000 f6c7a000 r-xp /usr/lib/libui-profiler.so.0.1.0
f6c82000 f6c9c000 r-xp /usr/lib/libecore_con.so.1.7.99
f6ca5000 f6cae000 r-xp /usr/lib/libedbus.so.1.7.99
f6cb6000 f6d06000 r-xp /usr/lib/libecore_x.so.1.7.99
f6d08000 f6d11000 r-xp /usr/lib/libvconf.so.0.2.45
f6d19000 f6d2a000 r-xp /usr/lib/libecore_input.so.1.7.99
f6d32000 f6d37000 r-xp /usr/lib/libecore_file.so.1.7.99
f6d3f000 f6d61000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d6a000 f6dab000 r-xp /usr/lib/libeina.so.1.7.99
f6db4000 f6dcd000 r-xp /usr/lib/libeet.so.1.7.99
f6dde000 f6e47000 r-xp /lib/libm-2.13.so
f6e50000 f6e56000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e5f000 f6e60000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e68000 f6e8b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e93000 f6e98000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ea0000 f6eca000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ed3000 f6eea000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ef2000 f6efd000 r-xp /lib/libunwind.so.8.0.1
f6f2a000 f6f48000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f52000 f7076000 r-xp /lib/libc-2.13.so
f7084000 f708c000 r-xp /lib/libgcc_s-4.6.so.1
f708d000 f7091000 r-xp /usr/lib/libsmack.so.1.0.0
f709a000 f70a4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f70ac000 f717c000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f717d000 f71dc000 r-xp /usr/lib/libedje.so.1.7.99
f71e5000 f71fc000 r-xp /usr/lib/libecore.so.1.7.99
f7213000 f72e2000 r-xp /usr/lib/libevas.so.1.7.99
f7308000 f7447000 r-xp /usr/lib/libelementary.so.1.7.99
f745e000 f7472000 r-xp /lib/libpthread-2.13.so
f747d000 f747f000 r-xp /usr/lib/libdlog.so.0.0.0
f7487000 f748a000 r-xp /usr/lib/libbundle.so.0.1.22
f7492000 f7494000 r-xp /lib/libdl-2.13.so
f749d000 f74ab000 r-xp /usr/lib/libaul.so.0.1.0
f74bb000 f74c2000 r-xp /usr/lib/libappcore-efl.so.1.1
f74cc000 f74d0000 r-xp /usr/lib/libsys-assert.so
f74d9000 f74f6000 r-xp /lib/ld-2.13.so
f74ff000 f7505000 r-xp /usr/bin/launchpad-loader
f7b45000 f7e18000 rw-p [heap]
fff64000 fff85000 rwxp [stack]
End of Maps Information

Callstack Information (PID:6301)
Call Stack Count: 1
 0: _showIAPDataOnListItemClick + 0x39 (0xf5d2665a) [/opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample] + 0x265a
End of Call Stack

Package Information
Package Name: com.samsung.iapnativesample
Package ID : com.samsung.iapnativesample
Version: 1.0.0
Package Type: rpm
App Name: iapnativesample
App ID: com.samsung.iapnativesample
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
AP_CONSUMER( 5978): sap.c: parse_values(629) > Add mCurrencyCode - INR
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemDesc
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mItemDesc - consumable
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemImageUrl
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mItemImageUrl - http://img.samsungapps.com/appsitem/itemDefaultImage.jpg
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemDownloadUrl
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mItemDownloadUrl - 
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPaymentId
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mPaymentId - TPMTID20170105INA2467813
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPurchaseId
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mPurchaseId - 412ea2b7311f2b8c855614f0f504f971fb0d5b9ead9856762f038c19d4e3a904
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPurchaseDate
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mPurchaseDate - 1483609398064
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mVerifyUrl
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mVerifyUrl - https://iap.samsungapps.com/iap/appsItemVerifyIAPReceipt.as?protocolVersion=2.0
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mJsonString
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: parse_values(629) > Add mJsonString - {"mErrorCode":"0","mErrorString":"","mItemId":"consumable","mItemName":"consumable","mItemPrice":"73","mItemPriceString":"Rs.73","mCurrencyUnit":"Rs.","mCurrencyCode":"INR","mItemDesc":"consumable","mItemImageUrl":"http:\/\/img.samsungapps.com\/appsitem\/itemDefaultImage.jpg","mItemDownloadUrl":"","mPaymentId":"TPMTID20170105INA2467813","mPurchaseId":"412ea2b7311f2b8c855614f0f504f971fb0d5b9ead9856762f038c19d4e3a904","mPurchaseDate":"1483609398064","mVerifyUrl":"https:\/\/iap.samsungapps.com\/iap\/appsItemVerifyIAPReceipt.as?protocolVersion=2.0"}
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: _send_result_to_caller_app(158) > Reply to sender[iap.galaxyapps.com.samsung.iapnativesample] tID[6301_1] result[0]
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): sap.c: _send_result_to_caller_app(178) > Encoded bundle length = 1820
01-05 15:13:25.821+0530 D/IAP_CONSUMER( 5978): sap.c: _send_result_to_caller_app(193) > >>> Asynchronously send the result
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = False
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _start_iap(1225) > num of pending work: 22
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _start_iap(1245) > IAP is available. Start! [requestWsmNonce]
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = True
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: send_json(1102) > [SECURE_LOG] Save current request. sender[iap.galaxyapps.com.samsung.iapnativesample] tID[6301_2]
01-05 15:13:25.821+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: send_json(1115) > [SECURE_LOG] >>> Sending data. len = 33
01-05 15:13:25.821+0530 I/IAP_CONSUMER( 5978): sap.c: send_data(1000) > Sending data
01-05 15:13:25.831+0530 E/PRIVILEGE_CHECKER( 6301): iap_galaxyapps.c: __handle_method_call(99) > Invoke reply callback. result: 0, transaction_id: 6301_1
01-05 15:13:25.831+0530 E/PRIVILEGE_CHECKER( 6301): iap_galaxyapps.c: __handle_method_call(115) > Call IAP callback for 6301_1
01-05 15:13:25.831+0530 E/PRIVILEGE_CHECKER( 6301): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemId] - [consumable]
01-05 15:13:25.831+0530 E/PRIVILEGE_CHECKER( 6301): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemName] - [consumable]
01-05 15:13:25.831+0530 E/PRIVILEGE_CHECKER( 6301): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemPriceString] - [Rs.73]
01-05 15:13:25.831+0530 E/PRIVILEGE_CHECKER( 6301): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemDesc] - [consumable]
01-05 15:13:25.831+0530 I/iapnativesample( 6301): consumable
01-05 15:13:25.841+0530 D/ALARM_MANAGER( 5978): alarm-lib.c: alarmmgr_add_alarm_appsvc(890) > [alarm-lib]:alarm_create() is called
01-05 15:13:25.841+0530 E/ALARM_MANAGER( 5978): alarm-lib.c: __alarmmgr_init_appsvc(621) > alarm was already initialized.
01-05 15:13:25.841+0530 E/ALARM_MANAGER( 5978): alarm-lib.c: alarmmgr_add_alarm_appsvc(973) > trigger_at_time(60), start(5-1-2017, 15:14:26), repeat(0), interval(0), type(-2147483648)
01-05 15:13:25.851+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [5978].
01-05 15:13:25.851+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:5978
01-05 15:13:25.891+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_create_appsvc(881) > [SECURE_LOG] caller_pkgid = com.samsung.iap-galaxyapps-consumer, callee_pkgid = com.samsung.iap-galaxyapps-consumer
01-05 15:13:25.891+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_generate_alarm_id(462) > __alarm_info->alarm_id is 1327668821
01-05 15:13:25.891+0530 D/SECURITY_EXTENSION_SERVER( 2539): security_extension_system.c: __security_extension_system_handler(214) > Thread created: client_fd(9)
01-05 15:13:25.891+0530 D/SECURITY_EXTENSION_SERVER( 2539): security_extension_system.c: __security_extension_process_handler(165) > enter: 9
01-05 15:13:25.891+0530 D/PKGMGR_INFO( 2522): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3943) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
01-05 15:13:25.891+0530 D/PKGMGR_INFO( 2522): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3949) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
01-05 15:13:25.901+0530 D/SECURITY_EXTENSION_SERVER( 2539): security_extension_system.c: __security_extension_process_handler(186) > exit: 9
01-05 15:13:25.901+0530 D/APPSYNC ( 2522): appsync-sync-scheduler.c: appsync_sync_scheduler_repeating_alarms(719) > [SECURE_LOG] pkg=com.samsung.iap-galaxyapps-consumer
01-05 15:13:25.901+0530 D/APPSYNC ( 2522): appsync-sync-scheduler.c: __print_alarm_info(128) > [SECURE_LOG]  app_unique_name=com.samsung.iap-galaxyapps-consumer, start=Thu Jan  5 15:14:26 2017 (I=0, R:0), alarm_id=1327668821, pid=5978, app_service_name=null, dst_service_name=null
01-05 15:13:25.901+0530 D/APPSYNC ( 2522): appsync-sync-scheduler.c: appsync_sync_scheduler_repeating_alarms(833) > out of interest
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: _alarm_next_duetime(479) > mode->repeat is 0
01-05 15:13:25.901+0530 E/ALARM_MANAGER( 2522): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1483609466, Thu Jan  5 15:14:26 2017
01-05 15:13:25.901+0530 E/ALARM_MANAGER( 2522): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1327668821, next duetime: 1483609466
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(488) > [alarm-server]: Before add alarm_id(1327668821)
01-05 15:13:25.901+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1327668821)
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(960352109).
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1685484032).
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(2045934058).
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1240092863).
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(2051491887).
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1736906572).
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1327668821).
01-05 15:13:25.901+0530 D/APPSYNC ( 2522): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f7576438
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_create_appsvc(939) > [SECURE_LOG] [alarm-server]:Create a new alarm: alarm(1327668821) due_time(Thu Jan  5 15:14:26 2017)
01-05 15:13:25.901+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __alarm_create_appsvc(942) > [alarm-server]:alarm_context.c_due_time(1483610500), due_time(1483609466)
01-05 15:13:25.901+0530 D/APPSYNC ( 2522): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = 0
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(105) > [SECURE_LOG] _add_to_scheduled_alarm_list :alarm->pid =5978, app_service_name=null(164)
01-05 15:13:25.901+0530 D/APPSYNC ( 2522): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = f7576448
01-05 15:13:25.901+0530 D/ALARM_MANAGER( 2522): alarm-manager-timer.c: _alarm_set_timer(81) > [alarm-server][timer]: remain time from current is 61.000000 , due_time is 1483609466.
01-05 15:13:25.911+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
01-05 15:13:25.911+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1483609466.
01-05 15:13:25.911+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
01-05 15:13:25.911+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 5-1-2017, 09:44:26 (UTC).
01-05 15:13:25.911+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
01-05 15:13:25.921+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
01-05 15:13:25.921+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: send_json(1186) > Register 1min alarm [1327668821]
01-05 15:13:25.921+0530 I/IAP_CONSUMER( 5978): sap.c: on_data_received(835) > << Finish sending result to caller app
01-05 15:13:25.951+0530 I/IAP_CONSUMER( 5978): sap.c: on_data_received(674) > >>> Receive data. len = 89
01-05 15:13:25.951+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [5978].
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:5978
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2513) > [SECURE_LOG] Called by process (pid:5978, unique_name=com.samsung.iap-galaxyapps-consumer)
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.update-service], alarm_id[960352109]
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.lbs-server], alarm_id[1685484032]
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[/usr/bin/license-server], alarm_id[2045934058]
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.shealth-service], alarm_id[1240092863]
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.w-calendar2-consumer], alarm_id[2051491887]
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[/usr/bin/oma-dm-agent], alarm_id[1736906572]
01-05 15:13:25.951+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.iap-galaxyapps-consumer], alarm_id[1327668821]
01-05 15:13:25.951+0530 D/APPSYNC ( 2522): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = 0
01-05 15:13:25.961+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2543) > alarm_id[1327668821] is removed.
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: alarm_manager_alarm_delete_all(2544) > [SECURE_LOG] Removing is done. app_name[com.samsung.iap-galaxyapps-consumer], alarm_id [1327668821]
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[960352109] with duetime(1483689733) at current(1483609405) pid: (3562)
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1685484032] with duetime(1483610500) at current(1483609405) pid: (3165)
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[2045934058] with duetime(1483656979) at current(1483609405) pid: (3188)
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1240092863] with duetime(1483641000) at current(1483609405) pid: (3429)
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[2051491887] with duetime(1483641000) at current(1483609405) pid: (3541)
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1736906572] with duetime(1483692326) at current(1483609405) pid: (3571)
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(105) > [SECURE_LOG] _add_to_scheduled_alarm_list :alarm->pid =3165, app_service_name=ALARM.libslp-lbsplugin-brcm(171)
01-05 15:13:25.961+0530 D/APPSYNC ( 2522): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = f75762b8
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager-timer.c: _alarm_set_timer(81) > [alarm-server][timer]: remain time from current is 1095.000000 , due_time is 1483610500.
01-05 15:13:25.961+0530 D/APPSYNC ( 2522): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f7576438
01-05 15:13:25.961+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
01-05 15:13:25.961+0530 D/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1483610500.
01-05 15:13:25.961+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
01-05 15:13:25.961+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 5-1-2017, 10:01:40 (UTC).
01-05 15:13:25.961+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
01-05 15:13:25.971+0530 E/ALARM_MANAGER( 2522): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): sap.c: _get_json_obj(510) > [SECURE_LOG] _get_json_obj
01-05 15:13:25.971+0530 I/IAP_CONSUMER( 5978): sap.c: on_data_received(798) > Reply for WSM Response Nonce
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): sap.c: on_data_received(806) > [SECURE_LOG] WSM Nonce received:V8AzUrap2DAZjgRHSVEZoAvCqjrE2jhQpGTFiNRuWZw=
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): sap.c: on_data_received(808) > [SECURE_LOG] Len of decoded Nonce:32
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = False
01-05 15:13:25.971+0530 I/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _start_iap(1225) > num of pending work: 21
01-05 15:13:25.971+0530 I/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _start_iap(1245) > IAP is available. Start! [startPayment]
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = True
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: send_json(1102) > [SECURE_LOG] Save current request. sender[iap.galaxyapps.com.samsung.iapnativesample] tID[6301_2]
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: send_json(1115) > [SECURE_LOG] >>> Sending data. len = 146
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: send_json(1129) > [SECURE_LOG] Encrypting Sending Data
01-05 15:13:25.971+0530 E/IAP_CONSUMER( 5978): iap-galaxyapps-consumer.c: __wsm_client_encrypt_str(881) > [SECURE_LOG] encrypt str len:178
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_I [Run, line = 118, thread  = f5565460] Read request from client. 
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_I [Run] Request len 406c 
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_D [Run] Request data  =  [len=16492] 0000000021040000bdbc39292000000057c03352b6a9d830198e0447495119a00bc2aa3ac4da3850a464c588d46e599c0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_I [Run, line = 150] Send reply to client.
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_D [Run] Send reply =  [len=16492] 01000000210400002b2538072000000057c03352b6a9d830198e0447495119a00bc2aa3ac4da3850a464c588d46e599c0000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_I [Run, line = 118, thread  = f5565460] Read request from client. 
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_I [Run] Request len 406c 
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_D [Run] Request data  =  [len=16492] 10e612f750040000bdbc39297b20226d4d6574686f6422203a202273746172745061796d656e74222c20226d5472616e73616374696f6e496422203a2022363330315f32222c20226d5061636b6167654e616d6522203a2022636f6d2e73616d73756e672e6961706e617469766573616d706c65222c20226d4974656d496422203a2022636f6e73756d61626c65222c20226d4d6f646522203a2031207d000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_I [Run, line = 150] Send reply to client.
01-05 15:13:25.971+0530 I/WSM     ( 3019): WSM_D [Run] Send reply =  [len=16492] 01000000500400002b2538077b20226d4d6574686f6422203a202273746172745061796d656e74222c20226d5472616e73616374696f6e496422203a2022363330315f32222c20226d5061636b6167654e616d6522203a2022636f6d2e73616d73756e672e6961706e617469766573616d706c65222c20226d4974656d496422203a2022636f6e73756d61626c65222c20226d4d6f646522203a2031207d000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
01-05 15:13:25.981+0530 I/IAP_CONSUMER( 5978): sap.c: send_data(1000) > Sending data
01-05 15:13:25.981+0530 E/IAP_CONSUMER( 5978): sap.c: _request_popup(134) > Show popup for samsung_billig_purchase_in_progress
01-05 15:13:25.981+0530 D/APP_SVC ( 5978): appsvc.c: __set_bundle(159) > __set_bundle
01-05 15:13:25.981+0530 D/APP_SVC ( 5978): appsvc.c: __set_bundle(159) > __set_bundle
01-05 15:13:25.981+0530 D/APP_SVC ( 5978): appsvc.c: __set_bundle(159) > __set_bundle
01-05 15:13:25.981+0530 D/APP_SVC ( 5978): appsvc.c: __run_svc_with_pkgname(236) > [SECURE_LOG] pkg_name : com.samsung.iap-galaxyapps-consumer.popup - no result
01-05 15:13:25.981+0530 W/AUL     ( 5978): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.iap-galaxyapps-consumer.popup)
01-05 15:13:25.981+0530 D/AUL     ( 5978): app_sock.c: __app_send_raw(253) > pid(-2) : cmd(0)
01-05 15:13:25.981+0530 W/AUL_AMD ( 2549): amd_request.c: __request_handler(669) > __request_handler: 0
01-05 15:13:25.981+0530 D/AUL_AMD ( 2549): amd_request.c: __request_handler(689) > [SECURE_LOG] alias appid: com.samsung.iap-galaxyapps-consumer.popup, appid: com.samsung.iap-galaxyapps-consumer.popup
01-05 15:13:25.991+0530 D/PKGMGR_INFO( 2549): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3943) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
01-05 15:13:25.991+0530 D/PKGMGR_INFO( 2549): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3949) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
01-05 15:13:25.991+0530 D/AUL_AMD ( 2549): amd_status.c: _status_get_appid_bypid(533) > [SECURE_LOG] appid for 5978 is com.samsung.iap-galaxyapps-consumer
01-05 15:13:25.991+0530 W/AUL_AMD ( 2549): amd_launch.c: _start_app(1780) > [SECURE_LOG] caller appid : com.samsung.iap-galaxyapps-consumer
01-05 15:13:25.991+0530 W/AUL_AMD ( 2549): amd_launch.c: _start_app(1782) > caller pid : 5978
01-05 15:13:25.991+0530 I/AUL_AMD ( 2549): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: _start_app(2017) > [SECURE_LOG] prelaunch attribute 0000(2) for com.samsung.iap-galaxyapps-consumer
01-05 15:13:26.011+0530 W/AUL_AMD ( 2549): amd_launch.c: __send_proc_prelaunch_signal(480) > [SECURE_LOG] send a prelaunch signal done: appid(com.samsung.iap-galaxyapps-consumer.popup) pkgid(com.samsung.iap-galaxyapps-consumer) attribute(0) category(0)
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: __send_cpu_boost(494) > __send_cpu_boost enter
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: __send_cpu_boost(519) > __send_cpu_boost ok
01-05 15:13:26.011+0530 D/RESOURCED( 2629): proc-monitor.c: proc_dbus_prelaunch_signal_handler(692) > call proc_dbus_prelaunch_handler: appid = com.samsung.iap-galaxyapps-consumer.popup, pkgid = com.samsung.iap-galaxyapps-consumer, flags = 0, categories = 0
01-05 15:13:26.011+0530 D/RESOURCED( 2629): appinfo-list.c: resourced_appinfo_get(117) > appid com.samsung.iap-galaxyapps-consumer.popup, pkgname = com.samsung.iap-galaxyapps-consumer, ref = 4
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: _start_app(2074) > org.tizen.system.coord.rotation-Degree : 0
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: _start_app(2201) > process_pool: false
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: _start_app(2204) > h/w acceleration: SYS
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: _start_app(2206) > [SECURE_LOG] appid: com.samsung.iap-galaxyapps-consumer.popup
01-05 15:13:26.011+0530 W/AUL_AMD ( 2549): amd_launch.c: _start_app(2218) > pad pid(-5)
01-05 15:13:26.011+0530 D/AUL_AMD ( 2549): amd_launch.c: __set_appinfo_for_launchpad(2571) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
01-05 15:13:26.011+0530 D/AUL     ( 2549): app_sock.c: __app_send_raw(253) > pid(-5) : cmd(0)
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: main(814) > pfds[LAUNCH_PAD].revent  : 0x1
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: main(817) > pfds[POOL_TYPE + 0].revents : 0x0
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: main(817) > pfds[POOL_TYPE + 1].revents : 0x0
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: main(854) > pfds[LAUNCH_PAD].revents & POLLIN
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: __launchpad_main_loop(569) > [SECURE_LOG] pkg name : com.samsung.iap-galaxyapps-consumer.popup
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): process_pool.h: __get_launchpad_type(70) > [launchpad] launchpad type: COMMON(0)
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: __modify_bundle(242) > parsing app_path: No arguments
01-05 15:13:26.011+0530 W/AUL_PAD ( 3436): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: __set_launchpad_loader_high_priority(524) > high_priority: false
01-05 15:13:26.011+0530 D/AUL     ( 3436): process_pool.c: __send_pkt_raw_data(242) > send(11) : 1164 / 1164
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: __send_launchpad_loader(499) > [SECURE_LOG] Request to candidate process, pid: 6860, bin path: /usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer-popup
01-05 15:13:26.011+0530 W/AUL_PAD ( 3436): launchpad.c: __send_result_to_caller(272) > Check app launching
01-05 15:13:26.011+0530 D/AUL_PAD ( 3436): launchpad.c: __send_result_to_caller(303) > -- now wait cmdline changing --
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_proces_fd_handler(459) > [candidate] ECORE_FD_READ
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_proces_fd_handler(478) > [candidate] recv_ret: 1164, pkt->len: 1156
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(357) > [SECURE_LOG] app id: com.samsung.iap-galaxyapps-consumer.popup, launchpad type: 0
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __modify_bundle(235) > parsing app_path: No arguments
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(378) > [SECURE_LOG] app id: com.samsung.iap-galaxyapps-consumer.popup
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(393) > [SECURE_LOG] pkg id: com.samsung.iap-galaxyapps-consumer
01-05 15:13:26.011+0530 W/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_prepare_exec(258) > [SECURE_LOG] [candidata] pkg_name : com.samsung.iap-galaxyapps-consumer.popup / pkg_type : rpm / app_path : /usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer-popup 
01-05 15:13:26.011+0530 W/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
01-05 15:13:26.011+0530 W/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
01-05 15:13:26.011+0530 W/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 0 : /usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer-popup##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 2 : __APP_SVC_PKG_NAME__##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 3 : TwAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AKgAAAGNvbS5zYW1zdW5nLmlhcC1nYWxheHlhcHBzLWNvbnN1bWVyLnBvcHVwAA==##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 4 : type##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAFAAAAdHlwZQAkAAAAc2Ftc3VuZ19iaWxsaWdfcHVyY2hhc2VfaW5fcHJvZ3Jlc3MA##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 6 : __APP_SVC_OP_TYPE__##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 7 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 9 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODM2MDk0MDUvOTg4MTI4AA==##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 11 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1OTc4AA==##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 12 : __AUL_CALLER_APPID__##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 13 : SQAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AJAAAAGNvbS5zYW1zdW5nLmlhcC1nYWxheHlhcHBzLWNvbnN1bWVyAA==##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 14 : __AUL_INTERNAL_POOL__##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 15 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 16 : __AUL_HIGHPRIORITY__##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] input argument 17 : KwAAAAEEAAAVAAAAX19BVUxfSElHSFBSSU9SSVRZX18ABgAAAGZhbHNlAA==##
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_proces_fd_handler(482) > [SECURE_LOG] [candidate] real app argv[0]: /usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer-popup, real app argc: 18
01-05 15:13:26.011+0530 D/AUL_PAD ( 6860): launchpad_loader.c: __candidate_proces_fd_handler(486) > [candidate] ecore main loop quit
01-05 15:13:26.011+0530 W/AUL_PAD ( 6860): launchpad_loader.c: main(679) > [SECURE_LOG] [candidate] Launch real application (/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer-popup)
01-05 15:13:26.011+0530 W/AUL_PAD ( 6860): launchpad_loader.c: main(680) > [candidate] dlopen(com.samsung.iap-galaxyapps-consumer.popup)
01-05 15:13:26.041+0530 D/RESOURCED( 6860): main.c: librsml_initialize(47) > librsml_initialize
01-05 15:13:26.051+0530 D/UXT     ( 6860): uxt_theme_private.c: uxt_theme_get_table_number(1570) > index: 0, hsv: 207, 75, 16
01-05 15:13:26.051+0530 D/UXT     ( 6860): uxt_theme_private.c: uxt_theme_get_table_number(1580) > input color table for theme index (0): ChangeableColorTable1.xml
01-05 15:13:26.051+0530 D/UXT     ( 6860): uxt_theme.c: uxt_theme_add_color_table(561) > color table (f7b295b8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
01-05 15:13:26.051+0530 D/UXT     ( 6860): uxt_theme_private.c: uxt_theme_get_core_color_list(1630) > core base color index : 0 (/usr/share/themes/ChangeableColorTable1.xml)
01-05 15:13:26.051+0530 I/UXT     ( 6860): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
01-05 15:13:26.051+0530 I/efl-extension( 6860): efl_extension.c: eext_mod_init(40) > Init
01-05 15:13:26.061+0530 W/AUL_PAD ( 6860): launchpad_loader.c: main(690) > [candidate] dlsym
01-05 15:13:26.061+0530 W/AUL_PAD ( 6860): launchpad_loader.c: main(694) > [candidate] dl_main(com.samsung.iap-galaxyapps-consumer.popup)
01-05 15:13:26.061+0530 D/AUL     ( 6860): pkginfo.c: aul_app_get_appid_bypid(269) > [SECURE_LOG] appid for 6860 is com.samsung.iap-galaxyapps-consumer.popup
01-05 15:13:26.061+0530 I/CAPI_APPFW_APPLICATION( 6860): app_main.c: ui_app_main(704) > app_efl_main
01-05 15:13:26.061+0530 D/LAUNCH  ( 6860): appcore-efl.c: appcore_efl_main(1753) > [popup:Application:main:done]
01-05 15:13:26.061+0530 D/APP_CORE( 6860): appcore-efl.c: appcore_efl_main(1754) > [SECURE_LOG] [popup:Application:Launch]
01-05 15:13:26.061+0530 D/AUL     ( 6860): pkginfo.c: aul_app_get_appid_bypid(269) > [SECURE_LOG] appid for 6860 is com.samsung.iap-galaxyapps-consumer.popup
01-05 15:13:26.061+0530 D/APP_CORE( 6860): appcore-efl.c: __before_loop(1160) > elm_config_preferred_engine_set is not called
01-05 15:13:26.061+0530 D/APP_CORE( 6860): appcore-efl.c: __before_loop(1176) > taskmanage is false
01-05 15:13:26.061+0530 D/APP_CORE( 6860): appcore.c: appcore_init(590) > [SECURE_LOG] locale dir: /usr/apps/com.samsung.iap-galaxyapps-consumer/res/locale
01-05 15:13:26.061+0530 D/APP_CORE( 6860): appcore-i18n.c: __load_lang_info_for_fallback_translated_msg(62) > default lang : en_US.UTF-8
01-05 15:13:26.061+0530 D/APP_CORE( 6860): appcore-i18n.c: update_region(118) > *****appcore setlocale=en_US.UTF-8
01-05 15:13:26.061+0530 D/AUL     ( 6860): app_sock.c: __create_server_sock(124) > pg path - already exists
01-05 15:13:26.061+0530 D/LAUNCH  ( 6860): appcore-efl.c: __before_loop(1208) > [popup:Platform:appcore_init:done]
01-05 15:13:26.061+0530 I/CAPI_APPFW_APPLICATION( 6860): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
01-05 15:13:26.091+0530 D/APP_CORE( 6860): appcore-rotation.c: __dbus_signal_handler_init_with_param(259) > app signal initialized
01-05 15:13:26.101+0530 D/TBM     ( 6860): tbm_bufmgr.c: tbm_bufmgr_init(1040) > [libtbm:6860] bufmgr init: fd=27
01-05 15:13:26.101+0530 D/TBM     ( 6860): tbm_bufmgr.c: tbm_bufmgr_init(1070) > [libtbm:6860] duplicate the drm_fd(27), bufmgr use fd(28).
01-05 15:13:26.101+0530 D/TBM     ( 6860): tbm_bufmgr.c: _check_version(709) > [libtbm:6860] TBM module exynos: vendor="Samsung" ABI=1,1
01-05 15:13:26.101+0530 D/TBM     ( 6860): tbm_bufmgr_backend.c: tbm_backend_init(97) > [libtbm:6860] cache_crtl: BACKEND
01-05 15:13:26.101+0530 D/TBM     ( 6860): tbm_bufmgr_backend.c: tbm_backend_init(98) > [libtbm:6860] lock_crtl: BACKEND
01-05 15:13:26.101+0530 D/TBM     ( 6860): tbm_bufmgr.c: _tbm_bufmgr_load_module(817) > [libtbm:6860] Success to load module(libtbm_default.so)
01-05 15:13:26.101+0530 D/TBM     ( 6860): tbm_bufmgr.c: tbm_bufmgr_init(1088) > [libtbm:6860] create tizen bufmgr: ref_count:1
01-05 15:13:26.111+0530 D/AUL_PAD ( 3436): launchpad.c: __send_result_to_caller(294) > -- now wait app mainloop creation --
01-05 15:13:26.111+0530 W/AUL     ( 2549): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.iap-galaxyapps-consumer.popup) pid(6860) type(uiapp) bg(0)
01-05 15:13:26.111+0530 D/AUL     ( 2549): simple_util.c: __trm_app_info_send_socket(311) > __trm_app_info_send_socket
01-05 15:13:26.111+0530 D/AUL     ( 2549): simple_util.c: __trm_app_info_send_socket(338) > send
01-05 15:13:26.111+0530 W/AUL_AMD ( 2549): amd_status.c: __socket_monitor_cb(1277) > (6860) was created
01-05 15:13:26.111+0530 E/AUL     ( 2549): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
01-05 15:13:26.111+0530 W/AUL     ( 5978): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6860)
01-05 15:13:26.111+0530 E/IAP_CONSUMER( 5978): sap.c: _request_popup(148) > Successfully send request to show popup
01-05 15:13:26.111+0530 W/STARTER ( 2780): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [6860]
01-05 15:13:26.111+0530 W/STARTER ( 2780): pkg-monitor.c: _app_mgr_status_cb(396) > [SECURE_LOG] [_app_mgr_status_cb:396] Launch request a[com.samsung.iap-galaxyapps-consumer.popup] p[com.samsung.iap-galaxyapps-consumer] type[uiapp] bg[0]
01-05 15:13:26.121+0530 D/RESOURCED( 2629): proc-main.c: resourced_proc_status_change(1549) > [SECURE_LOG] launch request com.samsung.iap-galaxyapps-consumer.popup, 6860
01-05 15:13:26.121+0530 D/RESOURCED( 2629): proc-main.c: resourced_proc_status_change(1551) > [SECURE_LOG] launch request com.samsung.iap-galaxyapps-consumer with pkgname
01-05 15:13:26.121+0530 D/RESOURCED( 2629): appinfo-list.c: resourced_appinfo_get(117) > appid com.samsung.iap-galaxyapps-consumer.popup, pkgname = com.samsung.iap-galaxyapps-consumer, ref = 5
01-05 15:13:26.121+0530 D/RESOURCED( 2629): proc-main.c: proc_add_program_list(512) > new program info : com.samsung.iap-galaxyapps-consumer
01-05 15:13:26.141+0530 D/LAUNCH  ( 6860): appcore-efl.c: __before_loop(1218) > [popup:Application:create:done]
01-05 15:13:26.141+0530 D/APP_CORE( 6860): appcore-efl.c: __check_wm_rotation_support(778) > Disable window manager rotation
01-05 15:13:26.141+0530 D/APP_CORE( 6860): appcore.c: __aul_handler(472) > [APP 6860]     AUL event: AUL_START
01-05 15:13:26.141+0530 I/APP_CORE( 6860): appcore-efl.c: __do_app(453) > [APP 6860] Event: RESET State: CREATED
01-05 15:13:26.141+0530 D/APP_CORE( 6860): appcore-efl.c: __do_app(511) > [APP 6860] RESET
01-05 15:13:26.141+0530 D/LAUNCH  ( 6860): appcore-efl.c: __do_app(513) > [popup:Application:reset:start]
01-05 15:13:26.141+0530 I/CAPI_APPFW_APPLICATION( 6860): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _window_visibility_cb(466) > Window [0x1200003] is now visible(0)
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
01-05 15:13:26.331+0530 D/W_HOME  ( 2991): win.c: win_rotation_disable_set(193) > c_val:0 set_val:0
01-05 15:13:26.331+0530 D/W_HOME  ( 2991): win.c: win_rotation_disable_set(201) > screen rotation 0 0
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): main.c: _window_visibility_cb(964) > Window [0x1200003] is now visible(0)
01-05 15:13:26.331+0530 D/APP_CORE( 2991): appcore-efl.c: __update_win(742) > [EVENT_TEST][EVENT] __update_win WIN:1200003 fully_obscured 0
01-05 15:13:26.331+0530 D/APP_CORE( 2991): appcore-efl.c: __visibility_cb(919) > bvisibility 1, b_active 0
01-05 15:13:26.331+0530 D/APP_CORE( 2991): appcore-efl.c: __visibility_cb(931) >  Go to Resume state
01-05 15:13:26.331+0530 I/APP_CORE( 2991): appcore-efl.c: __do_app(453) > [APP 2991] Event: RESUME State: PAUSED
01-05 15:13:26.331+0530 D/LAUNCH  ( 2991): appcore-efl.c: __do_app(583) > [w-home:Application:resume:start]
01-05 15:13:26.331+0530 D/APP_CORE( 2991): appcore-efl.c: __do_app(585) > [APP 2991] RESUME
01-05 15:13:26.331+0530 I/CAPI_APPFW_APPLICATION( 2991): app_main.c: app_appcore_resume(223) > app_appcore_resume
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): main.c: _appcore_resume_cb(479) > appcore resume
01-05 15:13:26.331+0530 D/W_HOME  ( 2991): main.c: _resume_cb(441) > Resumed
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
01-05 15:13:26.331+0530 D/APPS    ( 2991): apps_main.c: apps_main_resume(1001) >  Resume starts
01-05 15:13:26.331+0530 W/APPS    ( 2991): apps_main.c: _time_changed_cb(308) >  date : 5->5
01-05 15:13:26.331+0530 D/APPS    ( 2991): layout.c: _resume_result_cb(192) >  
01-05 15:13:26.331+0530 D/APPS    ( 2991): AppsViewNecklace.cpp: onResume(723) >  
01-05 15:13:26.331+0530 W/APPS    ( 2991): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): rotary.c: rotary_attach(138) > rotary_attach:0xf8292ab8
01-05 15:13:26.331+0530 D/APPS    ( 2991): AppsViewNecklace.cpp: onRotaryResumeResultCb(5181) >  Activate the rotary events for apps
01-05 15:13:26.331+0530 I/efl-extension( 2991): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf8292ab8, elm_layout, _activated_obj : 0xf81d1650, activated : 1
01-05 15:13:26.331+0530 I/efl-extension( 2991): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): win.c: win_back_gesture_disable_set(170) > disable back gesture
01-05 15:13:26.331+0530 W/W_HOME  ( 2991): win.c: win_back_gesture_disable_set(173) > enable back gesture
01-05 15:13:26.331+0530 D/W_HOME  ( 2991): clock_inf_dbox.c: home_resumed_cb(398) > Thaw all freezed objects
01-05 15:13:26.331+0530 D/LAUNCH  ( 2991): appcore-efl.c: __do_app(598) > [w-home:Application:resume:done]
01-05 15:13:26.331+0530 D/APP_CORE( 2991): appcore-efl.c: __trm_app_info_send_socket(252) > __trm_app_info_send_socket
01-05 15:13:26.331+0530 D/APP_CORE( 2991): appcore-efl.c: __trm_app_info_send_socket(279) > send
01-05 15:13:26.331+0530 I/wnotib  ( 2991): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(760) > fully_obscured: 0
01-05 15:13:26.331+0530 E/wnotib  ( 2991): w-notification-board-action.c: wnb_action_is_drawer_hidden(4816) > [NULL==g_wnb_action_data] msg Drawer not initialized.
01-05 15:13:26.331+0530 W/wnotib  ( 2991): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
01-05 15:13:26.331+0530 D/W_CLOCK_VIEWER( 2884): clock-viewer.c: __clock_viewer_homescreen_clock_visibility_changed_cb(790) >  homescreen clock visibility changed [0]->[0]
01-05 15:13:26.341+0530 W/CRASH_MANAGER( 6897): worker.c: worker_job(1205) > 1106301696170148360940
