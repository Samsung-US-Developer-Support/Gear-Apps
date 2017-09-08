S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.1
Build-Number: R765VVRE0AQA1
Build-Date: 2017.01.04 14:35:39

Crash Information
Process Name: iapnativesample
PID: 4292
Date: 2017-02-22 10:51:44+0530
Executable File Path: /opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4292, uid 5000)

Register Information
r0   = 0xf5dd1700, r1   = 0xf5cdd330
r2   = 0x00000000, r3   = 0xff95d464
r4   = 0xf796b1c0, r5   = 0xf7966e08
r6   = 0xf7981698, r7   = 0xff95d470
r8   = 0x00000073, r9   = 0xf7965490
r10  = 0xf797d6f8, fp   = 0xf796ac78
ip   = 0x00000000, sp   = 0xff95c418
lr   = 0xf5ccc6a3, pc   = 0xf5ccc6ac
cpsr = 0x80000030

Memory Information
MemTotal:   619852 KB
MemFree:     22188 KB
Buffers:     14404 KB
Cached:     170360 KB
VmPeak:      81200 KB
VmSize:      79356 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29428 KB
VmRSS:       29424 KB
VmData:      16224 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       25704 KB
VmPTE:         120 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4292 TID = 4292
4292 4326 

Maps Information
f292a000 f292b000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f2933000 f2936000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f2abb000 f2abf000 r-xp /usr/lib/libogg.so.0.7.1
f2ac7000 f2ae9000 r-xp /usr/lib/libvorbis.so.0.4.3
f2af1000 f2b00000 r-xp /usr/lib/libmdm-common.so.1.1.22
f2b09000 f2b50000 r-xp /usr/lib/libsndfile.so.1.0.26
f2b5c000 f2ba5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2bae000 f2bb3000 r-xp /usr/lib/libjson.so.0.0.1
f2bbb000 f2bbe000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2bc6000 f2c0e000 r-xp /usr/lib/libmdm.so.1.2.62
f2c0f000 f2c12000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2c1a000 f2c53000 r-xp /usr/lib/libpulse.so.0.16.2
f2c5b000 f2c5e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2c66000 f2cc7000 r-xp /usr/lib/libasound.so.2.0.0
f2cd1000 f2cec000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2cf4000 f2cf9000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2d01000 f2d0d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f2d1a000 f2d1f000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2d27000 f2d41000 r-xp /usr/lib/libmmfsound.so.0.1.0
f2d52000 f2d59000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2d61000 f2d6c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f2d74000 f2d76000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f2d7e000 f2d7f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f2d87000 f2d90000 r-xp /usr/lib/libfeedback.so.0.1.4
f2db1000 f2db2000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f3213000 f3214000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f329c000 f3a9b000 rw-p [stack:4326]
f3a9b000 f3a9d000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3aa5000 f3abc000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3ac9000 f3ace000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3ad6000 f3ae1000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3cea000 f3ddc000 r-xp /usr/lib/libCOREGL.so.4.0
f3df5000 f3dfa000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3e02000 f3e23000 r-xp /usr/lib/libexif.so.12.3.3
f3e36000 f3e3b000 r-xp /usr/lib/libsystem.so.0.0.0
f3e45000 f3e4c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3e54000 f3e5b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3e64000 f3e70000 r-xp /usr/lib/libresourced.so.0.2.96
f3e78000 f3e79000 r-xp /usr/lib/librd-network.so.0.2.96
f3e81000 f3e84000 r-xp /usr/lib/libresponse.so.0.2.96
f3e8c000 f3e92000 r-xp /usr/lib/libproc-stat.so.0.2.96
f572b000 f5739000 r-xp /usr/lib/libail.so.0.1.0
f5741000 f5748000 r-xp /usr/lib/libminizip.so.1.0.0
f5750000 f5752000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f575a000 f5762000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f576a000 f5772000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f577a000 f577c000 r-xp /usr/lib/libdri2.so.0.0.0
f5784000 f578c000 r-xp /usr/lib/libdrm.so.2.4.0
f5794000 f589a000 r-xp /usr/lib/libicuuc.so.57.1
f58b0000 f5a38000 r-xp /usr/lib/libicui18n.so.57.1
f5a48000 f5a4c000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f5a54000 f5a59000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5a61000 f5a86000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f5a90000 f5aaa000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f5ab2000 f5ab8000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5ac0000 f5ac1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f5aca000 f5ace000 r-xp /usr/lib/libEGL.so.1.4
f5ade000 f5aef000 r-xp /usr/lib/libGLESv2.so.2.0
f5aff000 f5b0b000 r-xp /usr/lib/libtbm.so.1.0.0
f5b13000 f5b3b000 r-xp /usr/lib/libui-extension.so.0.1.0
f5b3c000 f5b53000 r-xp /usr/lib/libtts.so
f5b5b000 f5b61000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f5b6a000 f5b6b000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f5b74000 f5b82000 r-xp /usr/lib/libcapability-manager.so.0.0.1
f5b8b000 f5c43000 r-xp /usr/lib/libcairo.so.2.11200.14
f5c4e000 f5c61000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5c69000 f5c6d000 r-xp /usr/lib/libiap-galaxyapps.so.0.1.0
f5c75000 f5c96000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5c9e000 f5caa000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5cb7000 f5cc2000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5cca000 f5cce000 r-xp /opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample
f5f64000 f5f6e000 r-xp /lib/libnss_files-2.13.so
f5f77000 f6046000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f605d000 f6083000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f608d000 f6093000 r-xp /usr/lib/libappsvc.so.0.1.0
f609c000 f60a0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f60ad000 f60b8000 r-xp /usr/lib/elementary/modules/ui_analyzer_2.0/linux-gnueabi-armv7l-1.7.99/module.so
f60c0000 f60c2000 r-xp /usr/lib/libiniparser.so.0
f60cb000 f60d0000 r-xp /usr/lib/libappcore-common.so.1.1
f60d9000 f60db000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f60e4000 f60e8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f60f6000 f60f8000 r-xp /usr/lib/libXau.so.6.0.0
f6100000 f6107000 r-xp /lib/libcrypt-2.13.so
f6137000 f6139000 r-xp /usr/lib/libiri.so
f6141000 f62ea000 r-xp /usr/lib/libcrypto.so.1.0.0
f630b000 f6352000 r-xp /usr/lib/libssl.so.1.0.0
f635e000 f638c000 r-xp /usr/lib/libidn.so.11.5.44
f6394000 f639d000 r-xp /usr/lib/libcares.so.2.1.0
f63a6000 f63b9000 r-xp /usr/lib/libxcb.so.1.1.0
f63c3000 f63c5000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f63cd000 f63d0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f63d8000 f64a4000 r-xp /usr/lib/libxml2.so.2.7.8
f64b1000 f64b3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f64bb000 f64c0000 r-xp /usr/lib/libffi.so.5.0.10
f64c9000 f64ca000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f64d2000 f64d5000 r-xp /lib/libattr.so.1.1.0
f64dd000 f64fa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6503000 f651b000 r-xp /usr/lib/libpng12.so.0.50.0
f6523000 f6539000 r-xp /lib/libexpat.so.1.6.0
f6544000 f65d8000 r-xp /usr/lib/libstdc++.so.6.0.16
f65eb000 f662f000 r-xp /usr/lib/libcurl.so.4.3.0
f6638000 f6642000 r-xp /usr/lib/libXext.so.6.4.0
f664b000 f664f000 r-xp /usr/lib/libXtst.so.6.1.0
f6657000 f665d000 r-xp /usr/lib/libXrender.so.1.3.0
f6665000 f666b000 r-xp /usr/lib/libXrandr.so.2.2.0
f6673000 f6674000 r-xp /usr/lib/libXinerama.so.1.0.0
f667d000 f6686000 r-xp /usr/lib/libXi.so.6.1.0
f668e000 f6691000 r-xp /usr/lib/libXfixes.so.3.1.0
f6699000 f669b000 r-xp /usr/lib/libXgesture.so.7.0.0
f66a3000 f66a5000 r-xp /usr/lib/libXcomposite.so.1.0.0
f66ad000 f66af000 r-xp /usr/lib/libXdamage.so.1.1.0
f66b7000 f66be000 r-xp /usr/lib/libXcursor.so.1.0.2
f66c6000 f66c9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f66d1000 f66d5000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f66de000 f66e3000 r-xp /usr/lib/libecore_fb.so.1.7.99
f66ec000 f67cd000 r-xp /usr/lib/libX11.so.6.3.0
f67d8000 f67fb000 r-xp /usr/lib/libjpeg.so.8.0.2
f6813000 f6829000 r-xp /lib/libz.so.1.2.5
f6831000 f6833000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f683b000 f68b0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68ba000 f68d6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68de000 f6912000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f691b000 f69ee000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69f9000 f6a09000 r-xp /lib/libresolv-2.13.so
f6a0d000 f6a25000 r-xp /usr/lib/liblzma.so.5.0.3
f6a2d000 f6a30000 r-xp /lib/libcap.so.2.21
f6a38000 f6a67000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a6f000 f6a70000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6a78000 f6a7e000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6a86000 f6a9d000 r-xp /usr/lib/liblua-5.1.so
f6aa6000 f6aad000 r-xp /usr/lib/libembryo.so.1.7.99
f6ab5000 f6abb000 r-xp /lib/librt-2.13.so
f6ac4000 f6b1a000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b27000 f6b7d000 r-xp /usr/lib/libfreetype.so.6.11.3
f6b89000 f6bb1000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6bb2000 f6bf7000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c00000 f6c13000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c1b000 f6c1d000 r-xp /usr/lib/libttrace.so.1.1
f6c25000 f6c28000 r-xp /usr/lib/libui-profiler.so.0.1.0
f6c30000 f6c4a000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c53000 f6c5c000 r-xp /usr/lib/libedbus.so.1.7.99
f6c64000 f6cb4000 r-xp /usr/lib/libecore_x.so.1.7.99
f6cb6000 f6cbf000 r-xp /usr/lib/libvconf.so.0.2.45
f6cc7000 f6cd8000 r-xp /usr/lib/libecore_input.so.1.7.99
f6ce0000 f6ce5000 r-xp /usr/lib/libecore_file.so.1.7.99
f6ced000 f6d0f000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d18000 f6d59000 r-xp /usr/lib/libeina.so.1.7.99
f6d62000 f6d7b000 r-xp /usr/lib/libeet.so.1.7.99
f6d8c000 f6df5000 r-xp /lib/libm-2.13.so
f6dfe000 f6e04000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e0d000 f6e0e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e16000 f6e39000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e41000 f6e46000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e4e000 f6e78000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e81000 f6e98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ea0000 f6eab000 r-xp /lib/libunwind.so.8.0.1
f6ed8000 f6ef6000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f00000 f7024000 r-xp /lib/libc-2.13.so
f7032000 f703a000 r-xp /lib/libgcc_s-4.6.so.1
f703b000 f703f000 r-xp /usr/lib/libsmack.so.1.0.0
f7048000 f7052000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f705a000 f712a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f712b000 f718a000 r-xp /usr/lib/libedje.so.1.7.99
f7193000 f71aa000 r-xp /usr/lib/libecore.so.1.7.99
f71c1000 f7290000 r-xp /usr/lib/libevas.so.1.7.99
f72b6000 f73f5000 r-xp /usr/lib/libelementary.so.1.7.99
f740c000 f7420000 r-xp /lib/libpthread-2.13.so
f742b000 f742d000 r-xp /usr/lib/libdlog.so.0.0.0
f7435000 f7438000 r-xp /usr/lib/libbundle.so.0.1.22
f7440000 f7442000 r-xp /lib/libdl-2.13.so
f744b000 f7459000 r-xp /usr/lib/libaul.so.0.1.0
f7469000 f7470000 r-xp /usr/lib/libappcore-efl.so.1.1
f747a000 f747e000 r-xp /usr/lib/libsys-assert.so
f7487000 f74a4000 r-xp /lib/ld-2.13.so
f74ad000 f74b3000 r-xp /usr/bin/launchpad-loader
f7791000 f7a28000 rw-p [heap]
ff93e000 ff95f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4292)
Call Stack Count: 16
 0: _showIAPDataOnListItemClick + 0x2b (0xf5ccc6ac) [/opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample] + 0x26ac
 1: __purchase_cb + 0xfa (0xf5ccc653) [/opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample] + 0x2653
 2: (0xf5c6a2b9) [/usr/lib/libiap-galaxyapps.so.0] + 0x12b9
 3: (0xf699dc53) [/usr/lib/libgio-2.0.so.0] + 0x82c53
 4: (0xf708dfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 5: g_main_context_dispatch + 0xbc (0xf708f7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 6: (0xf71a4047) [/usr/lib/libecore.so.1] + 0x11047
 7: (0xf719ee67) [/usr/lib/libecore.so.1] + 0xbe67
 8: (0xf719f8e3) [/usr/lib/libecore.so.1] + 0xc8e3
 9: ecore_main_loop_begin + 0x30 (0xf719fc19) [/usr/lib/libecore.so.1] + 0xcc19
10: appcore_efl_main + 0x510 (0xf746d435) [/usr/lib/libappcore-efl.so.1] + 0x4435
11: ui_app_main + 0xb0 (0xf60e6421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
12: main + 0x134 (0xf5ccb929) [/opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample] + 0x1929
13: create_base_gui + 0x144 (0xf74aeb9d) [/opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample] + 0x1b9d
14: __libc_start_main + 0x114 (0xf6f1785c) [/lib/libc.so.6] + 0x1785c
15: _gl_main_text_get + 0x77 (0xf74af030) [/opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample] + 0x2030
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
settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 10:50:59.279+0530 D/SYSTEM-SETTINGS( 3718): system_setting_platform.c: system_setting_get_locale_language(1657) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_language. [0m
02-22 10:50:59.279+0530 E/WSLib   ( 3718): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
02-22 10:50:59.279+0530 W/WSLib   ( 3718): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[10:50][0;m
02-22 10:50:59.279+0530 D/COM_CORE( 3495): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 33 (recv_fd: -1)
02-22 10:50:59.279+0530 D/SHealthCommon( 3495): SystemUtil.cpp: GetMyVersion(360) > [0mGetMyVersion : 3.1.30[0;m
02-22 10:50:59.279+0530 D/COM_CORE( 2764): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
02-22 10:50:59.279+0530 D/COM_CORE( 2764): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(3495)
02-22 10:50:59.279+0530 D/COM_CORE( 2764): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
02-22 10:50:59.279+0530 D/COM_CORE( 2764): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
02-22 10:50:59.279+0530 D/COM_CORE( 2764): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(118) for pid(-1)
02-22 10:50:59.279+0530 E/COM_CORE( 2764): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
02-22 10:50:59.279+0530 W/SHealthCommon( 3495): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
02-22 10:50:59.279+0530 D/SHealthService( 3495): SHealthDataShareManager.cpp: OnTimelineUpdated(1032) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.279+0530 D/SHealthCommon( 3495): EnhancedTimer.cpp: CancelTimerImpl(81) > [0mTIMER CANCEL [0xf75ba8f0][0;m
02-22 10:50:59.279+0530 E/TIZEN_N_SYSTEM_SETTINGS( 3718): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 10:50:59.279+0530 E/TIZEN_N_SYSTEM_SETTINGS( 3718): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 10:50:59.279+0530 E/TIZEN_N_SYSTEM_SETTINGS( 3718): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 10:50:59.279+0530 E/TIZEN_N_SYSTEM_SETTINGS( 3718): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 10:50:59.279+0530 D/SYSTEM-SETTINGS( 3718): system_setting_platform.c: system_setting_get_locale_language(1657) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_language. [0m
02-22 10:50:59.279+0530 D/SHealthWidget( 3718): HrLogWidgetView.cpp: DrawArrow(218) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.279+0530 D/SHealthAppCommon( 3718): TodayLogItemData.cpp: TimeStampToDegree(199) > [0mdegree [162.745834] timestamp [2017/2/22 10:50:59][0;m
02-22 10:50:59.279+0530 D/SHealthWidget( 3718): HrLogWidgetView.cpp: DrawArrow(246) > [1;40;34m END <<<<[0;m
02-22 10:50:59.279+0530 D/SHealthWidget( 3718): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(80) > [1;40;34m END <<<<[0;m
02-22 10:50:59.279+0530 D/SHealthWidget( 3718): WidgetMain.cpp: widget_update(150) > [1;40;34m END <<<<[0;m
02-22 10:50:59.279+0530 I/CAPI_WIDGET_APPLICATION( 3718): widget_app.c: __provider_update_cb(281) > received updating signal
02-22 10:50:59.289+0530 D/SHealthCommon( 3495): EnhancedTimer.cpp: RestartTimerImpl(66) > [0mTIMER RESTART [0xf75ba8f0], interval: 60000[0;m
02-22 10:50:59.289+0530 D/SHealthService( 3495): SHealthDataShareManager.cpp: OnTriggered(1375) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.289+0530 D/SHealthService( 3495): SHealthDataShareManager.cpp: UpdateDataImpl(939) > [0mUPDATE SHARED DATA [shealth_pedometer_info][step : 0, calorie : 733000, distance : 0, speed_in_mps : 0.000000, steps_per_sec : 0.000000, ][0;m
02-22 10:50:59.289+0530 D/healthData( 3495): health_connection_hmac.c: generate_HMAC_Key(40) > [1;40;34m END <<<<[0;m
02-22 10:50:59.289+0530 D/healthData( 3495): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(333) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): server_dbus_connection.c: __handle_health_client_message(89) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): server_dbus_connection.c: __handle_health_client_message(174) > [0mHealthRequestSyncWith2ndParty received[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): server_dbus_connection.c: __handle_health_client_message(176) > [SECURE_LOG] [0m[DBUS] Message type : com.samsung.shealth-service SHARE_ADD[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): health_connection_hmac.c: generate_HMAC_Key(40) > [1;40;34m END <<<<[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): health_ipc_server.c: __health_ipc_verify_HMAC(467) > [0mThe recv_hmac length : 172 server hmac length: 172[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): health_ipc_server.c: __health_ipc_verify_HMAC(475) > [0mClient authentication success[0;m
02-22 10:50:59.299+0530 I/HealthDataService( 3192): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): RequestHandler.cpp: ProcessShareSetData(321) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): health_jason_builder_parser.c: __jason_parse_get_string_value(427) > [0m[SharedInfoAPPID] json_object_get_member is NULL[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): ShareManager.cpp: SetShareInfo(197) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): ShareManager.cpp: CheckValidityWithManifest(344) > [0mvalidity [AppID: com.samsung.shealth-service]  [MetaKey: shealth_pedometer_info][0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): PackageNameGetter.cpp: GetPackageNumberWithAppID(101) > [0mCircular Queue Cache hit for app ID[0;m
02-22 10:50:59.299+0530 D/HealthDataService( 3192): HealthShareDBHelper.cpp: SetShareInfo(205) > [SECURE_LOG] [0mSQL_QUERY: INSERT OR REPLACE INTO HealthShare ( AppId,CreateTime,ShareKey, Bundle, Attributes, PackageNumber) VALUES ('com.samsung.shealth-service', 1487740859306,'shealth_pedometer_info','YzVkY2I3NDQ2OWM3YjFmNTY2ZGYxNmZiYTBiOTdmYzMXAAAAAQQAAAUAAABzdGVwAAIAAAAwAB8AAAABBAAACAAAAGNhbG9yaWUABwAAADczMzAwMAAbAAAAAQQAAAkAAABkaXN0YW5jZQACAAAAMAAmAAAAAQQAAA0AAABzcGVlZF9pbl9tcHMACQAAADAuMDAwMDAwACcAAAABBAAADgAAAHN0ZXBzX3Blcl9zZWMACQAAADAuMDAwMDAwAA==', 2, 1 ) [0;m
02-22 10:50:59.309+0530 D/HealthDataService( 3192): ShareManager.cpp: NotifySharedDataChanged(394) > [1;40;34m BEGIN >>>>[0;m
02-22 10:50:59.309+0530 D/HealthDataService( 3192): ShareManager.cpp: NotifySharedDataChanged(410) > [1;40;34m END <<<<[0;m
02-22 10:50:59.309+0530 D/HealthDataService( 3192): ShareManager.cpp: SetShareInfo(211) > [1;40;34m END <<<<[0;m
02-22 10:50:59.309+0530 D/HealthDataService( 3192): health_common_util.c: __health_util_free(10) > [0mFILE: RequestHandler.cpp, LINE:349, Invalid parameter in free operation (pointer is NULL)[0;m
02-22 10:50:59.309+0530 D/HealthDataService( 3192): RequestHandler.cpp: ProcessShareSetData(351) > [1;40;34m END <<<<[0;m
02-22 10:50:59.309+0530 D/HealthDataService( 3192): server_dbus_connection.c: __handle_health_client_message(185) > [0mOK {}[0;m
02-22 10:50:59.309+0530 D/HealthDataService( 3192): server_dbus_connection.c: __handle_health_client_message(195) > [1;40;34m END <<<<[0;m
02-22 10:50:59.319+0530 I/healthData( 3495): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-22 10:50:59.319+0530 D/healthData( 3495): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(372) > [1;40;34m END <<<<[0;m
02-22 10:50:59.529+0530 D/MUSIC_TRANSFER( 3690): mt-controller.c: _exit_timeout_cb(171) > [32m[TID:3690]   g_exit_timeout_cnt[10][0m
02-22 10:51:00.009+0530 D/W_HOME  ( 3131): util_time.c: __util_time_formatted_time_get(465) > time(1487740860) formatted(10:51)
02-22 10:51:00.009+0530 W/APPS    ( 3131): apps_main.c: _time_changed_cb(308) >  date : 22->22
02-22 10:51:09.539+0530 D/MUSIC_TRANSFER( 3690): mt-controller.c: _exit_timeout_cb(171) > [32m[TID:3690]   g_exit_timeout_cnt[9][0m
02-22 10:51:15.609+0530 I/samsung-log-manager( 2980): SLogMgr_SamsungLogManager.cpp: samsung_log_manager_insert(569) > [SECURE_LOG] [(569)]: Insert: User consent not taken for using samsung log service
02-22 10:51:19.549+0530 D/MUSIC_TRANSFER( 3690): mt-controller.c: _exit_timeout_cb(171) > [32m[TID:3690]   g_exit_timeout_cnt[8][0m
02-22 10:51:28.919+0530 D/SHealthCommon( 3495): EnhancedTimer.cpp: OnTimeout(108) > [0mTIMER FIRED [0xf75b50c4][0;m
02-22 10:51:28.919+0530 D/SHealthCommon( 3495): EnhancedTimer.cpp: CancelTimerImpl(81) > [0mTIMER CANCEL [0xf75b50c4][0;m
02-22 10:51:28.919+0530 D/SHealthCommon( 3495): EnhancedTimer.cpp: RestartTimerImpl(66) > [0mTIMER RESTART [0xf75b50c4], interval: 30000[0;m
02-22 10:51:28.919+0530 D/SHealthService( 3495): StillMoveClockServiceController.cpp: CalulateStillMoveTime(98) > [0mrecentPedoActiveTimeInMillisec: 0.000000[0;m
02-22 10:51:28.919+0530 D/SHealthService( 3495): StillMoveClockServiceController.cpp: UpdatgeAndCheckIfStillMoveLevelChanged(162) > [0mprevStillMoveCriterion 1, mCurStillMoveLevel 1[0;m
02-22 10:51:29.559+0530 D/MUSIC_TRANSFER( 3690): mt-controller.c: _exit_timeout_cb(171) > [32m[TID:3690]   g_exit_timeout_cnt[7][0m
02-22 10:51:39.569+0530 D/MUSIC_TRANSFER( 3690): mt-controller.c: _exit_timeout_cb(171) > [32m[TID:3690]   g_exit_timeout_cnt[6][0m
02-22 10:51:44.629+0530 I/IAP_CONSUMER( 4331): sap.c: on_data_received(674) > >>> Receive data. len = 29
02-22 10:51:44.629+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [4331].
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:4331
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2513) > [SECURE_LOG] Called by process (pid:4331, unique_name=com.samsung.iap-galaxyapps-consumer)
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.lbs-server], alarm_id[133163577]
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[/usr/bin/license-server], alarm_id[1362249617]
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.update-service], alarm_id[469552526]
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.shealth-service], alarm_id[1693623909]
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.w-calendar2-consumer], alarm_id[1732221210]
02-22 10:51:44.629+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[/usr/bin/oma-dm-agent], alarm_id[815171648]
02-22 10:51:44.629+0530 D/APPSYNC ( 2514): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f73352b0
02-22 10:51:44.639+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
02-22 10:51:44.639+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1487747782.
02-22 10:51:44.639+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 10:51:44.639+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 07:16:22 (UTC).
02-22 10:51:44.639+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 10:51:44.649+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
02-22 10:51:44.649+0530 E/IAP_CONSUMER( 4331): sap.c: _get_json_obj(510) > [SECURE_LOG] _get_json_obj
02-22 10:51:44.649+0530 I/IAP_CONSUMER( 4331): sap.c: on_data_received(795) > Reply for WSM Request Nonce
02-22 10:51:44.649+0530 E/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = True
02-22 10:51:44.649+0530 I/WSM     ( 2984): WSM_I [Run, line = 118, thread  = f58b7460] Read request from client. 
02-22 10:51:44.649+0530 I/WSM     ( 2984): WSM_I [Run] Request len 406c 
02-22 10:51:44.649+0530 I/WSM     ( 2984): WSM_D [Run] Request data  =  [len=16492] 00000000200400005f631c752000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-22 10:51:44.659+0530 I/WSM     ( 2984): WSM_I [Run, line = 150] Send reply to client.
02-22 10:51:44.659+0530 I/WSM     ( 2984): WSM_D [Run] Send reply =  [len=16492] 0100000020040000c87eb47920000000b1c84079dcef0d79b6a1bdf2ffcb1c542fa6d5b640142779988973ad7555c1ec0000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-22 10:51:44.659+0530 E/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: send_json(1102) > [SECURE_LOG] Save current request. sender[iap.galaxyapps.com.samsung.iapnativesample] tID[4292_1]
02-22 10:51:44.659+0530 E/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: send_json(1115) > [SECURE_LOG] >>> Sending data. len = 96
02-22 10:51:44.659+0530 I/IAP_CONSUMER( 4331): sap.c: send_data(1000) > Sending data
02-22 10:51:44.659+0530 D/ALARM_MANAGER( 4331): alarm-lib.c: alarmmgr_add_alarm_appsvc(890) > [alarm-lib]:alarm_create() is called
02-22 10:51:44.659+0530 E/ALARM_MANAGER( 4331): alarm-lib.c: __alarmmgr_init_appsvc(621) > alarm was already initialized.
02-22 10:51:44.659+0530 E/ALARM_MANAGER( 4331): alarm-lib.c: alarmmgr_add_alarm_appsvc(973) > trigger_at_time(60), start(22-2-2017, 10:52:45), repeat(0), interval(0), type(-2147483648)
02-22 10:51:44.669+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [4331].
02-22 10:51:44.669+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:4331
02-22 10:51:44.699+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_create_appsvc(881) > [SECURE_LOG] caller_pkgid = com.samsung.iap-galaxyapps-consumer, callee_pkgid = com.samsung.iap-galaxyapps-consumer
02-22 10:51:44.699+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_generate_alarm_id(462) > __alarm_info->alarm_id is 1136106308
02-22 10:51:44.699+0530 D/SECURITY_EXTENSION_SERVER( 2548): security_extension_system.c: __security_extension_system_handler(214) > Thread created: client_fd(9)
02-22 10:51:44.699+0530 D/SECURITY_EXTENSION_SERVER( 2548): security_extension_system.c: __security_extension_process_handler(165) > enter: 9
02-22 10:51:44.699+0530 D/SECURITY_EXTENSION_SERVER( 2548): security_extension_system.c: __security_extension_process_handler(186) > exit: 9
02-22 10:51:44.699+0530 D/PKGMGR_INFO( 2514): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3943) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
02-22 10:51:44.699+0530 D/PKGMGR_INFO( 2514): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3949) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
02-22 10:51:44.709+0530 D/APPSYNC ( 2514): appsync-sync-scheduler.c: appsync_sync_scheduler_repeating_alarms(719) > [SECURE_LOG] pkg=com.samsung.iap-galaxyapps-consumer
02-22 10:51:44.709+0530 D/APPSYNC ( 2514): appsync-sync-scheduler.c: __print_alarm_info(128) > [SECURE_LOG]  app_unique_name=com.samsung.iap-galaxyapps-consumer, start=Wed Feb 22 10:52:45 2017 (I=0, R:0), alarm_id=1136106308, pid=4331, app_service_name=null, dst_service_name=null
02-22 10:51:44.709+0530 D/APPSYNC ( 2514): appsync-sync-scheduler.c: appsync_sync_scheduler_repeating_alarms(833) > out of interest
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: _alarm_next_duetime(479) > mode->repeat is 0
02-22 10:51:44.709+0530 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1487740965, Wed Feb 22 10:52:45 2017
02-22 10:51:44.709+0530 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1136106308, next duetime: 1487740965
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(488) > [alarm-server]: Before add alarm_id(1136106308)
02-22 10:51:44.709+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1136106308)
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(133163577).
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1362249617).
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(469552526).
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1693623909).
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1732221210).
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(815171648).
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1136106308).
02-22 10:51:44.709+0530 D/APPSYNC ( 2514): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f73352b0
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_create_appsvc(939) > [SECURE_LOG] [alarm-server]:Create a new alarm: alarm(1136106308) due_time(Wed Feb 22 10:52:45 2017)
02-22 10:51:44.709+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_create_appsvc(942) > [alarm-server]:alarm_context.c_due_time(1487747782), due_time(1487740965)
02-22 10:51:44.709+0530 D/APPSYNC ( 2514): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = 0
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(105) > [SECURE_LOG] _add_to_scheduled_alarm_list :alarm->pid =4331, app_service_name=null(217)
02-22 10:51:44.709+0530 D/APPSYNC ( 2514): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = f7335298
02-22 10:51:44.709+0530 D/ALARM_MANAGER( 2514): alarm-manager-timer.c: _alarm_set_timer(81) > [alarm-server][timer]: remain time from current is 61.000000 , due_time is 1487740965.
02-22 10:51:44.719+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
02-22 10:51:44.719+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1487740965.
02-22 10:51:44.719+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 10:51:44.719+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 05:22:45 (UTC).
02-22 10:51:44.719+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 10:51:44.729+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
02-22 10:51:44.729+0530 E/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: send_json(1186) > Register 1min alarm [1136106308]
02-22 10:51:44.739+0530 I/IAP_CONSUMER( 4331): sap.c: on_data_received(674) > >>> Receive data. len = 1689
02-22 10:51:44.739+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [4331].
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:4331
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2513) > [SECURE_LOG] Called by process (pid:4331, unique_name=com.samsung.iap-galaxyapps-consumer)
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.lbs-server], alarm_id[133163577]
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[/usr/bin/license-server], alarm_id[1362249617]
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.update-service], alarm_id[469552526]
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.shealth-service], alarm_id[1693623909]
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.w-calendar2-consumer], alarm_id[1732221210]
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[/usr/bin/oma-dm-agent], alarm_id[815171648]
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2520) > [SECURE_LOG] Try to remove app_name[com.samsung.iap-galaxyapps-consumer], alarm_id[1136106308]
02-22 10:51:44.739+0530 D/APPSYNC ( 2514): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = 0
02-22 10:51:44.739+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2543) > alarm_id[1136106308] is removed.
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete_all(2544) > [SECURE_LOG] Removing is done. app_name[com.samsung.iap-galaxyapps-consumer], alarm_id [1136106308]
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[133163577] with duetime(1487747782) at current(1487740904) pid: (3153)
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1362249617] with duetime(1487839583) at current(1487740904) pid: (3136)
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[469552526] with duetime(1487827015) at current(1487740904) pid: (3502)
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1693623909] with duetime(1487788200) at current(1487740904) pid: (3495)
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1732221210] with duetime(1487788200) at current(1487740904) pid: (3685)
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[815171648] with duetime(1487827065) at current(1487740904) pid: (3714)
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(105) > [SECURE_LOG] _add_to_scheduled_alarm_list :alarm->pid =3153, app_service_name=ALARM.libslp-lbsplugin-brcm(228)
02-22 10:51:44.739+0530 D/APPSYNC ( 2514): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = f73352b8
02-22 10:51:44.739+0530 D/ALARM_MANAGER( 2514): alarm-manager-timer.c: _alarm_set_timer(81) > [alarm-server][timer]: remain time from current is 6878.000000 , due_time is 1487747782.
02-22 10:51:44.739+0530 D/APPSYNC ( 2514): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f73352b0
02-22 10:51:44.749+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
02-22 10:51:44.749+0530 D/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1487747782.
02-22 10:51:44.749+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 10:51:44.749+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 07:16:22 (UTC).
02-22 10:51:44.749+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 10:51:44.749+0530 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: _get_json_obj(510) > [SECURE_LOG] _get_json_obj
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: on_data_received(697) > [SECURE_LOG] B64_encryptedData is exist
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: on_data_received(705) > [SECURE_LOG] B64_encryptedData_len: 1636
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: on_data_received(714) > [SECURE_LOG] encryptedData_len: 1225
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run, line = 118, thread  = f58b7460] Read request from client. 
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run] Request len 406c 
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_D [Run] Request data  =  [len=16492] 386601f7600400005f631c753a3a0453423fc7c93a00d0def0b88e7eaa75ce11bc31ec9357a4d93c713e6b21dbc80fca84308c05e219066924e3f48fc3320caad9328a12d618ccfe7d4b13d7ea86635007e2de03f6dfe04eb60d5ac59aa387c7eb813b93791936ca0cfef7f40fe62d574e2153ad3798f9c708f4289bc22bb13d186eac88520ecf7cecef6af675ed5414682ad9e4ee6bb2b733ca4161a249dee81dbb3c147223f4e5098663e1c2ebf923a61dadb7d609afe2116a854c821bf045f057eabd22bbd14c0be81d673ae6dc2d9c52eb634f46983f655e73c1f22f2d915a18438cef5956d40d2a2fba4f882e488b83dff1e5d90cabe64cee9578f9eab8f08f290d9d0f676c373daff394015bd059647138abfa086af862596905893ef552760635670870ee805f643f514149675681a43eb67bb8240ff8709cddf8ff72d8bf348b7af4beeb6d2c1dc857908e79ae4733e8a1b685d6161c199a2a65bb148bbddcc61e7066c325f56e54b682a5c1f2e0db76a98e8a99175dc7eb4c1332b0bd3aaad1a78c587465fb8599224a7d6300c5bbd6c2e8940ee04906b28a512ac25777ab4d829a89f360841e8867a190d98a8f5533574c485676c2bbec45aba84a668a160649039c21808c2684962c13823bbb014aef954ffe8733d991215976ba0eca8c77f77188ecbb10f9
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run, line = 150] Send reply to client.
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: on_data_received(718) > [SECURE_LOG] decrypted_len:1193
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: _get_json_obj(510) > [SECURE_LOG] _get_json_obj
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_D [Run] Send reply =  [len=16492] 0100000060040000c87eb4793a3a0453423fc7c93a00d0def0b88e7eaa75ce11bc31ec9357a4d93c713e6b21dbc80fca84308c05e219066924e3f48fc3320caad9328a12d618ccfe7d4b13d7ea86635007e2de03f6dfe04eb60d5ac59aa387c7eb813b93791936ca0cfef7f40fe62d574e2153ad3798f9c708f4289bc22bb13d186eac88520ecf7cecef6af675ed5414682ad9e4ee6bb2b733ca4161a249dee81dbb3c147223f4e5098663e1c2ebf923a61dadb7d609afe2116a854c821bf045f057eabd22bbd14c0be81d673ae6dc2d9c52eb634f46983f655e73c1f22f2d915a18438cef5956d40d2a2fba4f882e488b83dff1e5d90cabe64cee9578f9eab8f08f290d9d0f676c373daff394015bd059647138abfa086af862596905893ef552760635670870ee805f643f514149675681a43eb67bb8240ff8709cddf8ff72d8bf348b7af4beeb6d2c1dc857908e79ae4733e8a1b685d6161c199a2a65bb148bbddcc61e7066c325f56e54b682a5c1f2e0db76a98e8a99175dc7eb4c1332b0bd3aaad1a78c587465fb8599224a7d6300c5bbd6c2e8940ee04906b28a512ac25777ab4d829a89f360841e8867a190d98a8f5533574c485676c2bbec45aba84a668a160649039c21808c2684962c13823bbb014aef954ffe8733d991215976ba0eca8c77f77188ecbb10f97a7
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: on_data_received(813) > Reply for IAP operations
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mErrorCode
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mErrorCode - 0
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mErrorString
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mErrorString - 
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemId
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mItemId - consumable
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemName
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mItemName - consumable
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemPrice
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mItemPrice - 1.1
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemPriceString
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mItemPriceString - $1.10
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mCurrencyUnit
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mCurrencyUnit - $
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mCurrencyCode
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mCurrencyCode - USD
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemDesc
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mItemDesc - consumable
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemImageUrl
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mItemImageUrl - http://img.samsungapps.com/appsitem/itemDefaultImage.jpg
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemDownloadUrl
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mItemDownloadUrl - 
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPaymentId
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mPaymentId - TPMTID20170222USA2543247
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPurchaseId
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mPurchaseId - 3862b76418d2198c7f66359c5fb0c10d63d337ef95678912b1e6bb90b3be933a
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPurchaseDate
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mPurchaseDate - 1487740903997
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mVerifyUrl
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mVerifyUrl - https://iap.samsungapps.com/iap/appsItemVerifyIAPReceipt.as?protocolVersion=2.0
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mJsonString
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: parse_values(629) > Add mJsonString - {"mErrorCode":"0","mErrorString":"","mItemId":"consumable","mItemName":"consumable","mItemPrice":"1.1","mItemPriceString":"$1.10","mCurrencyUnit":"$","mCurrencyCode":"USD","mItemDesc":"consumable","mItemImageUrl":"http:\/\/img.samsungapps.com\/appsitem\/itemDefaultImage.jpg","mItemDownloadUrl":"","mPaymentId":"TPMTID20170222USA2543247","mPurchaseId":"3862b76418d2198c7f66359c5fb0c10d63d337ef95678912b1e6bb90b3be933a","mPurchaseDate":"1487740903997","mVerifyUrl":"https:\/\/iap.samsungapps.com\/iap\/appsItemVerifyIAPReceipt.as?protocolVersion=2.0"}
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: _send_result_to_caller_app(158) > Reply to sender[iap.galaxyapps.com.samsung.iapnativesample] tID[4292_1] result[0]
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): sap.c: _send_result_to_caller_app(178) > Encoded bundle length = 1816
02-22 10:51:44.759+0530 D/IAP_CONSUMER( 4331): sap.c: _send_result_to_caller_app(193) > >>> Asynchronously send the result
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = False
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: _start_iap(1225) > num of pending work: 0
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: _start_iap(1227) > There is no job to handle
02-22 10:51:44.759+0530 I/CAPI_APPFW_APPLICATION( 4331): service_app_main.c: service_app_exit(441) > service_app_exit
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): sap.c: on_data_received(835) > << Finish sending result to caller app
02-22 10:51:44.759+0530 D/AUL     ( 4331): app_sock.c: __app_send_raw_with_noreply(352) > pid(-2) : cmd(22)
02-22 10:51:44.759+0530 W/AUL_AMD ( 2555): amd_request.c: __request_handler(669) > __request_handler: 22
02-22 10:51:44.759+0530 W/AUL_AMD ( 2555): amd_request.c: __request_handler(999) > app status : 4
02-22 10:51:44.759+0530 D/AUL_AMD ( 2555): amd_status.c: _status_update_app_info_list(180) > pid(4331), status(4)
02-22 10:51:44.759+0530 I/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: service_app_terminate(1405) > service_app_terminate
02-22 10:51:44.759+0530 E/IAP_CONSUMER( 4331): iap-galaxyapps-consumer.c: __wsm_client_destroy(656) > [SECURE_LOG] Destroy wsm keys
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run, line = 118, thread  = f58b7460] Read request from client. 
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run] Request len 406c 
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_D [Run] Request data  =  [len=16492] 000000003002000024f031220000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run, line = 150] Send reply to client.
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_D [Run] Send reply =  [len=16492] 01000000300200006573621b0100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run, line = 118, thread  = f58b7460] Read request from client. 
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_I [Run] Request len 406c 
02-22 10:51:44.759+0530 I/WSM     ( 2984): WSM_D [Run] Request data  =  [len=16492] 00000000600300005f631c750000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-22 10:51:44.769+0530 E/PRIVILEGE_CHECKER( 4292): iap_galaxyapps.c: __handle_method_call(99) > Invoke reply callback. result: 0, transaction_id: 4292_1
02-22 10:51:44.769+0530 E/PRIVILEGE_CHECKER( 4292): iap_galaxyapps.c: __handle_method_call(115) > Call IAP callback for 4292_1
02-22 10:51:44.769+0530 E/PRIVILEGE_CHECKER( 4292): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemId] - [consumable]
02-22 10:51:44.769+0530 E/PRIVILEGE_CHECKER( 4292): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemName] - [consumable]
02-22 10:51:44.769+0530 E/PRIVILEGE_CHECKER( 4292): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemPriceString] - [$1.10]
02-22 10:51:44.769+0530 E/PRIVILEGE_CHECKER( 4292): iap_galaxyapps.c: iap_galaxyapps_get_value(475) > Get [mItemDesc] - [consumable]
02-22 10:51:44.769+0530 I/iapnativesample( 4292): consumable
02-22 10:51:44.769+0530 I/WSM     ( 2984): WSM_I [Run, line = 150] Send reply to client.
02-22 10:51:44.769+0530 I/WSM     ( 2984): WSM_D [Run] Send reply =  [len=16492] 0100000060030000c87eb4790100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-22 10:51:44.889+0530 I/WSM     ( 2984): WSM_I [Run, line = 114, thread  = f58b7460] Connection is closed by client. Close device and terminate thread. 
02-22 10:51:44.889+0530 I/WSM     ( 2984): WSM_I [Run, line = 173, thread  = f58b7460] stopping, client socket file descriptor - 15 
02-22 10:51:45.099+0530 D/ELM_RPANEL( 3131): elm-rpanel.c: _ecore_x_message_cb(5493) > ev->message_type[560]
02-22 10:51:45.099+0530 D/ELM_RPANEL( 3131): elm-rpanel.c: _ecore_x_message_cb(5494) > _E_MOVE_W_HOME_FOREGROUND_BACKGROUND_STATE [747]
02-22 10:51:45.109+0530 D/AUL_PAD ( 3509): launchpad.c: main(814) > pfds[LAUNCH_PAD].revent  : 0x0
02-22 10:51:45.109+0530 D/AUL_PAD ( 3509): launchpad.c: main(817) > pfds[POOL_TYPE + 0].revents : 0x0
02-22 10:51:45.109+0530 D/AUL_PAD ( 3509): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-22 10:51:45.109+0530 D/AUL_PAD ( 3509): launchpad.c: main(817) > pfds[POOL_TYPE + 1].revents : 0x0
02-22 10:51:45.109+0530 D/AUL_PAD ( 3509): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-22 10:51:45.109+0530 W/AUL_PAD ( 3509): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4292 pgid = 4292
02-22 10:51:45.109+0530 W/AUL_PAD ( 3509): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 3 ssi_status = 11
02-22 10:51:45.129+0530 W/WATCH_CORE( 3319): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-22 10:51:45.129+0530 I/WATCH_CORE( 3319): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
02-22 10:51:45.129+0530 D/WATCH_CORE( 3319): appcore-watch.c: __get_timeinfo(874) > Current time: 2-22 10:51:45.137
02-22 10:51:45.129+0530 I/CAPI_WATCH_APPLICATION( 3319): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-22 10:51:45.129+0530 E/watchface-loader( 3319): watchface-loader.cpp: OnAppTimeTick(616) > 
02-22 10:51:45.129+0530 I/watchface-loader( 3319): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
02-22 10:51:45.129+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(787) > [SECURE_LOG] text[<font_size=34 font=SamsungOneNum:style=normal:weight=thin>51</font_size>]
02-22 10:51:45.129+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
02-22 10:51:45.129+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 36x34
02-22 10:51:45.129+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: UpdateText(888) > mActor[360x34] image[360x34]
02-22 10:51:45.129+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(787) > [SECURE_LOG] text[<font_size=34 font=SamsungOneNum:style=normal:weight=thin>51</font_size>]
02-22 10:51:45.129+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
02-22 10:51:45.129+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 36x34
02-22 10:51:45.129+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: UpdateText(888) > mActor[360x34] image[360x34]
02-22 10:51:45.129+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(787) > [SECURE_LOG] text[<font_size=66 font=SamsungOneNum:style=normal:weight=thin>51</font_size>]
02-22 10:51:45.129+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
02-22 10:51:45.129+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 70x66
02-22 10:51:45.129+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: UpdateText(888) > mActor[356x66] image[356x66]
02-22 10:51:45.139+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(787) > [SECURE_LOG] text[<font_size=66 font=SamsungOneNum:style=normal:weight=thin>51</font_size>]
02-22 10:51:45.139+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
02-22 10:51:45.139+0530 I/watchface-viewer( 3319): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 70x66
02-22 10:51:45.139+0530 D/watchface-viewer( 3319): viewer-part-resource-evas.cpp: UpdateText(888) > mActor[356x66] image[356x66]
02-22 10:51:45.139+0530 I/watchface-viewer( 3319): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
02-22 10:51:45.159+0530 W/CRASH_MANAGER( 4362): worker.c: worker_job(1205) > 1104292696170148774090
