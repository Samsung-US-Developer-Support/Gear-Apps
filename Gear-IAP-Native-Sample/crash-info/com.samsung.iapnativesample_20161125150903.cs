S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.0
Build-Number: R765VVRE0APJE
Build-Date: 2016.10.19 20:02:06

Crash Information
Process Name: iapnativesample
PID: 13117
Date: 2016-11-25 15:09:03+0530
Executable File Path: /opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13117, uid 5000)

Register Information
r0   = 0xf5cbb508, r1   = 0xf5bc713c
r2   = 0x00000000, r3   = 0xffbef45c
r4   = 0xf2902378, r5   = 0xf77caec0
r6   = 0xf77cd778, r7   = 0xffbef468
r8   = 0x00000073, r9   = 0xf77c9890
r10  = 0xf77eb750, fp   = 0xf77ca190
ip   = 0x00000000, sp   = 0xffbee408
lr   = 0xf5bbe651, pc   = 0xf5bbe65a
cpsr = 0x80000030

Memory Information
MemTotal:   619860 KB
MemFree:     35300 KB
Buffers:     25408 KB
Cached:     149324 KB
VmPeak:      79712 KB
VmSize:      79476 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29200 KB
VmRSS:       29196 KB
VmData:      16064 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       25696 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13117 TID = 13117
13117 13228 

Maps Information
f2a4d000 f2a4e000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f2ad5000 f2ad8000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f2ae0000 f2ae4000 r-xp /usr/lib/libogg.so.0.7.1
f2aec000 f2b0e000 r-xp /usr/lib/libvorbis.so.0.4.3
f2b16000 f2b25000 r-xp /usr/lib/libmdm-common.so.1.1.22
f2b2e000 f2b75000 r-xp /usr/lib/libsndfile.so.1.0.26
f2b81000 f2bca000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2bd3000 f2bd8000 r-xp /usr/lib/libjson.so.0.0.1
f2be0000 f2be3000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2beb000 f2c33000 r-xp /usr/lib/libmdm.so.1.2.62
f2c34000 f2c37000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2c3f000 f2c78000 r-xp /usr/lib/libpulse.so.0.16.2
f2c80000 f2c83000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2c8b000 f2cec000 r-xp /usr/lib/libasound.so.2.0.0
f2cf6000 f2d11000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2d19000 f2d1e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2d26000 f2d32000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f2d3f000 f2d44000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2d4c000 f2d66000 r-xp /usr/lib/libmmfsound.so.0.1.0
f2d77000 f2d7e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2d86000 f2d91000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f2d99000 f2d9b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f2da3000 f2da4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f2dac000 f2db5000 r-xp /usr/lib/libfeedback.so.0.1.4
f2dd7000 f2dd8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f30ff000 f3100000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f3188000 f3987000 rwxp [stack:13228]
f3987000 f3989000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3991000 f39a8000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f39b5000 f39ba000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f39c2000 f39cd000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3bd6000 f3cc8000 r-xp /usr/lib/libCOREGL.so.4.0
f3ce1000 f3ce6000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3cee000 f3d0f000 r-xp /usr/lib/libexif.so.12.3.3
f3d22000 f3d27000 r-xp /usr/lib/libsystem.so.0.0.0
f3d31000 f3d38000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3d40000 f3d47000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3d50000 f3d5c000 r-xp /usr/lib/libresourced.so.0.2.96
f3d64000 f3d65000 r-xp /usr/lib/librd-network.so.0.2.96
f3d6d000 f3d70000 r-xp /usr/lib/libresponse.so.0.2.96
f3d78000 f3d7e000 r-xp /usr/lib/libproc-stat.so.0.2.96
f561e000 f562c000 r-xp /usr/lib/libail.so.0.1.0
f5634000 f563b000 r-xp /usr/lib/libminizip.so.1.0.0
f5643000 f5645000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f564d000 f5655000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f565d000 f5665000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f566d000 f566f000 r-xp /usr/lib/libdri2.so.0.0.0
f5677000 f567f000 r-xp /usr/lib/libdrm.so.2.4.0
f5687000 f578d000 r-xp /usr/lib/libicuuc.so.57.1
f57a3000 f592b000 r-xp /usr/lib/libicui18n.so.57.1
f593b000 f593f000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f5947000 f594c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5954000 f5979000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f5982000 f599c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f59a4000 f59aa000 r-xp /usr/lib/libxcb-render.so.0.0.0
f59b2000 f59b3000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f59bc000 f59c0000 r-xp /usr/lib/libEGL.so.1.4
f59d0000 f59e1000 r-xp /usr/lib/libGLESv2.so.2.0
f59f1000 f59fd000 r-xp /usr/lib/libtbm.so.1.0.0
f5a05000 f5a2d000 r-xp /usr/lib/libui-extension.so.0.1.0
f5a2e000 f5a44000 r-xp /usr/lib/libtts.so
f5a4d000 f5a53000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f5a5c000 f5a5d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f5a66000 f5a74000 r-xp /usr/lib/libcapability-manager.so.0.0.1
f5a7d000 f5b35000 r-xp /usr/lib/libcairo.so.2.11200.14
f5b40000 f5b53000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5b5b000 f5b5f000 r-xp /usr/lib/libiap-galaxyapps.so.0.1.0
f5b67000 f5b88000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5b90000 f5b9c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5ba9000 f5bb4000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5bbc000 f5bbf000 r-xp /opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample
f5e4e000 f5e58000 r-xp /lib/libnss_files-2.13.so
f5e61000 f5f30000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5f47000 f5f6d000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5f77000 f5f7d000 r-xp /usr/lib/libappsvc.so.0.1.0
f5f86000 f5f8a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5f97000 f5fa2000 r-xp /usr/lib/elementary/modules/ui_analyzer_2.0/linux-gnueabi-armv7l-1.7.99/module.so
f5faa000 f5fac000 r-xp /usr/lib/libiniparser.so.0
f5fb5000 f5fba000 r-xp /usr/lib/libappcore-common.so.1.1
f5fc3000 f5fc5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5fce000 f5fd2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5fe0000 f5fe2000 r-xp /usr/lib/libXau.so.6.0.0
f5fea000 f5ff1000 r-xp /lib/libcrypt-2.13.so
f6021000 f6023000 r-xp /usr/lib/libiri.so
f602b000 f61d4000 r-xp /usr/lib/libcrypto.so.1.0.0
f61f5000 f623c000 r-xp /usr/lib/libssl.so.1.0.0
f6248000 f6276000 r-xp /usr/lib/libidn.so.11.5.44
f627e000 f6287000 r-xp /usr/lib/libcares.so.2.1.0
f6290000 f62a3000 r-xp /usr/lib/libxcb.so.1.1.0
f62ad000 f62af000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f62b7000 f62ba000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f62c2000 f638e000 r-xp /usr/lib/libxml2.so.2.7.8
f639b000 f639d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f63a5000 f63aa000 r-xp /usr/lib/libffi.so.5.0.10
f63b3000 f63b4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f63bc000 f63bf000 r-xp /lib/libattr.so.1.1.0
f63c7000 f63e4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f63ed000 f6405000 r-xp /usr/lib/libpng12.so.0.50.0
f640d000 f6423000 r-xp /lib/libexpat.so.1.6.0
f642e000 f64c2000 r-xp /usr/lib/libstdc++.so.6.0.16
f64d5000 f6519000 r-xp /usr/lib/libcurl.so.4.3.0
f6522000 f652c000 r-xp /usr/lib/libXext.so.6.4.0
f6535000 f6539000 r-xp /usr/lib/libXtst.so.6.1.0
f6541000 f6547000 r-xp /usr/lib/libXrender.so.1.3.0
f654f000 f6555000 r-xp /usr/lib/libXrandr.so.2.2.0
f655d000 f655e000 r-xp /usr/lib/libXinerama.so.1.0.0
f6567000 f6570000 r-xp /usr/lib/libXi.so.6.1.0
f6578000 f657b000 r-xp /usr/lib/libXfixes.so.3.1.0
f6583000 f6585000 r-xp /usr/lib/libXgesture.so.7.0.0
f658d000 f658f000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6597000 f6599000 r-xp /usr/lib/libXdamage.so.1.1.0
f65a1000 f65a8000 r-xp /usr/lib/libXcursor.so.1.0.2
f65b0000 f65b3000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f65bb000 f65bf000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f65c8000 f65cd000 r-xp /usr/lib/libecore_fb.so.1.7.99
f65d6000 f66b7000 r-xp /usr/lib/libX11.so.6.3.0
f66c2000 f66e5000 r-xp /usr/lib/libjpeg.so.8.0.2
f66fd000 f6713000 r-xp /lib/libz.so.1.2.5
f671b000 f671d000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6725000 f679a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f67a4000 f67c0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67c8000 f67fc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6805000 f68d8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68e3000 f68f3000 r-xp /lib/libresolv-2.13.so
f68f7000 f690f000 r-xp /usr/lib/liblzma.so.5.0.3
f6917000 f691a000 r-xp /lib/libcap.so.2.21
f6922000 f6951000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6959000 f695a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6962000 f6968000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6970000 f6987000 r-xp /usr/lib/liblua-5.1.so
f6990000 f6997000 r-xp /usr/lib/libembryo.so.1.7.99
f699f000 f69a5000 r-xp /lib/librt-2.13.so
f69ae000 f6a04000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6a11000 f6a67000 r-xp /usr/lib/libfreetype.so.6.11.3
f6a73000 f6a9b000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6a9c000 f6ae1000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6aea000 f6afd000 r-xp /usr/lib/libfribidi.so.0.3.1
f6b05000 f6b07000 r-xp /usr/lib/libttrace.so.1.1
f6b0f000 f6b12000 r-xp /usr/lib/libui-profiler.so.0.1.0
f6b1a000 f6b34000 r-xp /usr/lib/libecore_con.so.1.7.99
f6b3d000 f6b46000 r-xp /usr/lib/libedbus.so.1.7.99
f6b4e000 f6b9e000 r-xp /usr/lib/libecore_x.so.1.7.99
f6ba0000 f6ba9000 r-xp /usr/lib/libvconf.so.0.2.45
f6bb1000 f6bc2000 r-xp /usr/lib/libecore_input.so.1.7.99
f6bca000 f6bcf000 r-xp /usr/lib/libecore_file.so.1.7.99
f6bd7000 f6bf9000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6c02000 f6c43000 r-xp /usr/lib/libeina.so.1.7.99
f6c4c000 f6c65000 r-xp /usr/lib/libeet.so.1.7.99
f6c76000 f6cdf000 r-xp /lib/libm-2.13.so
f6ce8000 f6cee000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cf7000 f6cf8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d00000 f6d23000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d2b000 f6d30000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d38000 f6d62000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d6b000 f6d82000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d8a000 f6d95000 r-xp /lib/libunwind.so.8.0.1
f6dc2000 f6de0000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dea000 f6f0e000 r-xp /lib/libc-2.13.so
f6f1c000 f6f24000 r-xp /lib/libgcc_s-4.6.so.1
f6f25000 f6f29000 r-xp /usr/lib/libsmack.so.1.0.0
f6f32000 f6f3c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6f44000 f7014000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7015000 f7074000 r-xp /usr/lib/libedje.so.1.7.99
f707d000 f7094000 r-xp /usr/lib/libecore.so.1.7.99
f70ab000 f717a000 r-xp /usr/lib/libevas.so.1.7.99
f71a0000 f72df000 r-xp /usr/lib/libelementary.so.1.7.99
f72f6000 f730a000 r-xp /lib/libpthread-2.13.so
f7315000 f7317000 r-xp /usr/lib/libdlog.so.0.0.0
f731f000 f7322000 r-xp /usr/lib/libbundle.so.0.1.22
f732a000 f732c000 r-xp /lib/libdl-2.13.so
f7335000 f7343000 r-xp /usr/lib/libaul.so.0.1.0
f7353000 f735a000 r-xp /usr/lib/libappcore-efl.so.1.1
f7364000 f7368000 r-xp /usr/lib/libsys-assert.so
f7371000 f738e000 r-xp /lib/ld-2.13.so
f7397000 f739d000 r-xp /usr/bin/launchpad-loader
f75b2000 f7820000 rw-p [heap]
ffbd0000 ffbf0000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13117)
Call Stack Count: 1
 0: _showIAPDataOnListItemClick + 0x39 (0xf5bbe65a) [/opt/usr/apps/com.samsung.iapnativesample/bin/iapnativesample] + 0x265a
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
1+0530 D/APP_CORE(13117): appcore-efl.c: __update_win(742) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
11-25 15:08:37.541+0530 D/APP_CORE(13117): appcore-efl.c: __visibility_cb(919) > bvisibility 1, b_active 0
11-25 15:08:37.541+0530 D/APP_CORE(13117): appcore-efl.c: __visibility_cb(931) >  Go to Resume state
11-25 15:08:37.541+0530 I/APP_CORE(13117): appcore-efl.c: __do_app(453) > [APP 13117] Event: RESUME State: PAUSED
11-25 15:08:37.541+0530 D/LAUNCH  (13117): appcore-efl.c: __do_app(583) > [iapnativesample:Application:resume:start]
11-25 15:08:37.541+0530 D/APP_CORE(13117): appcore-efl.c: __do_app(585) > [APP 13117] RESUME
11-25 15:08:37.541+0530 I/CAPI_APPFW_APPLICATION(13117): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-25 15:08:37.541+0530 D/LAUNCH  (13117): appcore-efl.c: __do_app(598) > [iapnativesample:Application:resume:done]
11-25 15:08:37.541+0530 D/APP_CORE(13117): appcore-efl.c: __trm_app_info_send_socket(252) > __trm_app_info_send_socket
11-25 15:08:37.541+0530 D/APP_CORE(13117): appcore-efl.c: __trm_app_info_send_socket(279) > send
11-25 15:08:37.561+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.210411] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.571+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.227229] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.591+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.244211] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.611+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.260957] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.621+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.277655] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.641+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.294318] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.641+0530 I/APP_CORE(13207): appcore-efl.c: appcore_efl_main(1803) > [SECURE_LOG] [popup:Application:Terminate]
11-25 15:08:37.641+0530 I/efl-extension(13207): efl_extension.c: eext_mod_shutdown(46) > Shutdown
11-25 15:08:37.651+0530 W/AUL_PAD (13207): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
11-25 15:08:37.661+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.311241] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.671+0530 D/AUL_PAD ( 3348): launchpad.c: main(814) > pfds[LAUNCH_PAD].revent  : 0x0
11-25 15:08:37.671+0530 D/AUL_PAD ( 3348): launchpad.c: main(817) > pfds[POOL_TYPE + 0].revents : 0x0
11-25 15:08:37.671+0530 D/AUL_PAD ( 3348): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-25 15:08:37.671+0530 D/AUL_PAD ( 3348): launchpad.c: main(817) > pfds[POOL_TYPE + 1].revents : 0x0
11-25 15:08:37.671+0530 D/AUL_PAD ( 3348): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-25 15:08:37.671+0530 W/AUL_PAD ( 3348): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 13207 pgid = 13207
11-25 15:08:37.671+0530 W/AUL_PAD ( 3348): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
11-25 15:08:37.671+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.327864] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.691+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.344495] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.711+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.361172] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.721+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.379621] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.741+0530 D/AUL_PAD ( 3348): sigchild.h: __send_app_dead_signal(97) > send dead signal done
11-25 15:08:37.741+0530 W/AUL_PAD ( 3348): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
11-25 15:08:37.741+0530 D/STARTER ( 2766): starter.c: _w_app_dead_cb(230) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.38/src/starter.c:230:D] app dead cb call! (pid : 13207)
11-25 15:08:37.741+0530 I/AUL_AMD ( 2552): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 13207
11-25 15:08:37.741+0530 D/AUL_AMD ( 2552): amd_key.c: _unregister_key_event(170) > ===key stack===
11-25 15:08:37.741+0530 D/AUL_AMD ( 2552): amd_status.c: _status_publish_app_status(753) > [SECURE_LOG] pid(13207) status(0)
11-25 15:08:37.741+0530 D/AUL_AMD ( 2552): amd_status.c: _status_publish_app_status(760) > [SECURE_LOG] pid(13207) appid(com.samsung.iap-galaxyapps-consumer.popup)
11-25 15:08:37.741+0530 D/AUL_AMD ( 2552): amd_status.c: _status_remove_app_info_list(256) > ~STATUS_SERVICE : appid(com.samsung.iap-galaxyapps-consumer.popup)
11-25 15:08:37.741+0530 D/AUL_AMD ( 2552): amd_status.c: _status_remove_app_info_list(269) > pkg : appid(com.samsung.iap-galaxyapps-consumer.popup)
11-25 15:08:37.741+0530 D/AUL     ( 2552): simple_util.c: __trm_app_info_send_socket(311) > __trm_app_info_send_socket
11-25 15:08:37.741+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.394447] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.741+0530 D/AUL     ( 2552): simple_util.c: __trm_app_info_send_socket(338) > send
11-25 15:08:37.741+0530 W/AUL     ( 2552): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(13207)
11-25 15:08:37.751+0530 D/RESOURCED( 2635): proc-monitor.c: proc_dbus_aul_terminated(1262) > received terminated process : pid 13207
11-25 15:08:37.751+0530 D/RESOURCED( 2635): appinfo-list.c: resourced_appinfo_put(132) > appid com.samsung.iap-galaxyapps-consumer.popup, pkgname = com.samsung.iap-galaxyapps-consumer, ref = 8
11-25 15:08:37.761+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.411194] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.771+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.427866] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.791+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.444838] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.811+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.461528] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.821+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.478246] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.841+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.495020] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.861+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.511679] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.871+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.528381] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.891+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.545085] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.911+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.561740] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.921+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.578524] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.941+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.595246] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.961+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.611957] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.971+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.629013] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:37.991+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.645284] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:38.011+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17633.662036] pp(0x7a0f10) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:08:38.351+0530 D/capability-manager(13230): capability-manager.c: __auto_exit_timeout_cb(52) > Callback: Exiting capability-server
11-25 15:08:38.351+0530 D/capability-manager(13230): capability-manager.c: __auto_exit_timeout_cb(59) > Callback: quit main loop
11-25 15:08:39.391+0530 D/AUL_AMD ( 2552): amd_status.c: __app_terminate_timer_cb(164) > pid(13207)
11-25 15:08:39.391+0530 W/AUL_AMD ( 2552): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
11-25 15:08:39.681+0530 D/SCONTEXT-LIB( 2482): comm.c: response_received_cb(75) > [SECURE_LOG] Response received: { "Context" : 47, "Result" : 0, "CtxData" : { "Time" : 1480066719690, "Data" : 2, "Event" : 1 }, "ReqId" : 3 }
11-25 15:08:39.681+0530 E/WMS     ( 2482): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23534) > _wms_event_handler_cb_nomove_detector is called
11-25 15:08:39.681+0530 D/SCONTEXT-LIB( 2482): request.c: fire(100) > Callback invoked: ReqId=3
11-25 15:08:52.521+0530 D/RESOURCED( 2635): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-25 15:08:52.521+0530 D/RESOURCED( 2635): counter-process.c: _process_network_counter(1159) > There is no serialized counters in response
11-25 15:08:52.521+0530 D/RESOURCED( 2635): counter-process.c: _process_network_counter(1159) > There is no serialized counters in response
11-25 15:08:55.161+0530 D/SHealthCommon(11768): EnhancedTimer.cpp: OnTimeout(108) > [0mTIMER FIRED [0xf2c25244][0;m
11-25 15:08:55.161+0530 D/SHealthCommon(11768): EnhancedTimer.cpp: CancelTimerImpl(81) > [0mTIMER CANCEL [0xf2c25244][0;m
11-25 15:08:55.161+0530 D/SHealthCommon(11768): EnhancedTimer.cpp: RestartTimerImpl(66) > [0mTIMER RESTART [0xf2c25244], interval: 30000[0;m
11-25 15:08:55.161+0530 D/SHealthService(11768): StillMoveClockServiceController.cpp: CalulateStillMoveTime(98) > [0mrecentPedoActiveTimeInMillisec: 0.000000[0;m
11-25 15:08:55.161+0530 D/SHealthService(11768): StillMoveClockServiceController.cpp: UpdatgeAndCheckIfStillMoveLevelChanged(162) > [0mprevStillMoveCriterion 1, mCurStillMoveLevel 1[0;m
11-25 15:09:03.311+0530 I/IAP_CONSUMER(13233): sap.c: on_data_received(674) > >>> Receive data. len = 29
11-25 15:09:03.311+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [13233].
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:13233
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2511) > [SECURE_LOG] Called by process (pid:13233, unique_name=com.samsung.iap-galaxyapps-consumer)
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.lbs-server], alarm_id[1297722297]
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.update-service], alarm_id[1645493560]
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.w-magazine-wc1], alarm_id[1958610270]
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[/usr/bin/license-server], alarm_id[992088270]
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.w-calendar2-consumer], alarm_id[619602365]
11-25 15:09:03.311+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.shealth-service], alarm_id[1376104741]
11-25 15:09:03.311+0530 D/APPSYNC ( 2483): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f7408440
11-25 15:09:03.321+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
11-25 15:09:03.321+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1480070643.
11-25 15:09:03.321+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-25 15:09:03.321+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-11-2016, 10:44:03 (UTC).
11-25 15:09:03.321+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-25 15:09:03.331+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
11-25 15:09:03.341+0530 E/IAP_CONSUMER(13233): sap.c: _get_json_obj(510) > [SECURE_LOG] _get_json_obj
11-25 15:09:03.341+0530 I/IAP_CONSUMER(13233): sap.c: on_data_received(795) > Reply for WSM Request Nonce
11-25 15:09:03.341+0530 E/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = True
11-25 15:09:03.341+0530 I/WSM     ( 3063): WSM_I [Run, line = 118, thread  = f5e6b460] Read request from client. 
11-25 15:09:03.341+0530 I/WSM     ( 3063): WSM_I [Run] Request len 406c 
11-25 15:09:03.341+0530 I/WSM     ( 3063): WSM_D [Run] Request data  =  [len=16492] 000000002004000091c531612000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
11-25 15:09:03.341+0530 I/WSM     ( 3063): WSM_I [Run, line = 150] Send reply to client.
11-25 15:09:03.341+0530 I/WSM     ( 3063): WSM_D [Run] Send reply =  [len=16492] 01000000200400001a34f731200000007c4f0ce9fd48d5cbbc0c3acb5d7051d91c3e0e42cb18a317f796edcecf27bcd00000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
11-25 15:09:03.341+0530 E/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: send_json(1102) > [SECURE_LOG] Save current request. sender[iap.galaxyapps.com.samsung.iapnativesample] tID[13117_1]
11-25 15:09:03.341+0530 E/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: send_json(1115) > [SECURE_LOG] >>> Sending data. len = 96
11-25 15:09:03.341+0530 I/IAP_CONSUMER(13233): sap.c: send_data(1000) > Sending data
11-25 15:09:03.351+0530 D/ALARM_MANAGER(13233): alarm-lib.c: alarmmgr_add_alarm_appsvc(890) > [alarm-lib]:alarm_create() is called
11-25 15:09:03.351+0530 E/ALARM_MANAGER(13233): alarm-lib.c: __alarmmgr_init_appsvc(621) > alarm was already initialized.
11-25 15:09:03.351+0530 E/ALARM_MANAGER(13233): alarm-lib.c: alarmmgr_add_alarm_appsvc(973) > trigger_at_time(60), start(25-11-2016, 15:10:03), repeat(0), interval(0), type(-2147483648)
11-25 15:09:03.351+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [13233].
11-25 15:09:03.351+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:13233
11-25 15:09:03.381+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_create_appsvc(881) > [SECURE_LOG] caller_pkgid = com.samsung.iap-galaxyapps-consumer, callee_pkgid = com.samsung.iap-galaxyapps-consumer
11-25 15:09:03.381+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_generate_alarm_id(462) > __alarm_info->alarm_id is 1989128814
11-25 15:09:03.391+0530 D/PKGMGR_INFO( 2483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3943) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
11-25 15:09:03.391+0530 D/PKGMGR_INFO( 2483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3949) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/usr/apps/com.samsung.iap-galaxyapps-consumer/bin/iap-galaxyapps-consumer' and package_app_changeable_info.app_disable IN ('false','False')
11-25 15:09:03.401+0530 D/APPSYNC ( 2483): appsync-sync-scheduler.c: appsync_sync_scheduler_repeating_alarms(719) > [SECURE_LOG] pkg=com.samsung.iap-galaxyapps-consumer
11-25 15:09:03.401+0530 D/APPSYNC ( 2483): appsync-sync-scheduler.c: __print_alarm_info(128) > [SECURE_LOG]  app_unique_name=com.samsung.iap-galaxyapps-consumer, start=Fri Nov 25 15:10:03 2016 (I=0, R:0), alarm_id=1989128814, pid=13233, app_service_name=null, dst_service_name=null
11-25 15:09:03.401+0530 D/APPSYNC ( 2483): appsync-sync-scheduler.c: appsync_sync_scheduler_repeating_alarms(833) > out of interest
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: _alarm_next_duetime(479) > mode->repeat is 0
11-25 15:09:03.401+0530 E/ALARM_MANAGER( 2483): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1480066803, Fri Nov 25 15:10:03 2016
11-25 15:09:03.401+0530 E/ALARM_MANAGER( 2483): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1989128814, next duetime: 1480066803
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(488) > [alarm-server]: Before add alarm_id(1989128814)
11-25 15:09:03.401+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1989128814)
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1297722297).
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1645493560).
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1958610270).
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(992088270).
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(619602365).
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1376104741).
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_add_to_list(501) > [alarm-server]: alarm_id(1989128814).
11-25 15:09:03.401+0530 D/APPSYNC ( 2483): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f7408440
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_create_appsvc(939) > [SECURE_LOG] [alarm-server]:Create a new alarm: alarm(1989128814) due_time(Fri Nov 25 15:10:03 2016)
11-25 15:09:03.401+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __alarm_create_appsvc(942) > [alarm-server]:alarm_context.c_due_time(1480070643), due_time(1480066803)
11-25 15:09:03.401+0530 D/APPSYNC ( 2483): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = 0
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(105) > [SECURE_LOG] _add_to_scheduled_alarm_list :alarm->pid =13233, app_service_name=null(164)
11-25 15:09:03.401+0530 D/APPSYNC ( 2483): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = f74081a0
11-25 15:09:03.401+0530 D/ALARM_MANAGER( 2483): alarm-manager-timer.c: _alarm_set_timer(81) > [alarm-server][timer]: remain time from current is 60.000000 , due_time is 1480066803.
11-25 15:09:03.411+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
11-25 15:09:03.411+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1480066803.
11-25 15:09:03.411+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-25 15:09:03.411+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-11-2016, 09:40:03 (UTC).
11-25 15:09:03.411+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-25 15:09:03.421+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
11-25 15:09:03.421+0530 E/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: send_json(1186) > Register 1min alarm [1989128814]
11-25 15:09:03.421+0530 I/IAP_CONSUMER(13233): sap.c: on_data_received(674) > >>> Receive data. len = 1670
11-25 15:09:03.421+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [13233].
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __get_cached_unique_name(244) > Get cached unique_name: com.samsung.iap-galaxyapps-consumer, pid:13233
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2511) > [SECURE_LOG] Called by process (pid:13233, unique_name=com.samsung.iap-galaxyapps-consumer)
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.lbs-server], alarm_id[1297722297]
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.update-service], alarm_id[1645493560]
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.w-magazine-wc1], alarm_id[1958610270]
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[/usr/bin/license-server], alarm_id[992088270]
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.w-calendar2-consumer], alarm_id[619602365]
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.shealth-service], alarm_id[1376104741]
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2518) > [SECURE_LOG] Try to remove app_name[com.samsung.iap-galaxyapps-consumer], alarm_id[1989128814]
11-25 15:09:03.421+0530 D/APPSYNC ( 2483): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = 0
11-25 15:09:03.421+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2541) > alarm_id[1989128814] is removed.
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: alarm_manager_alarm_delete_all(2542) > [SECURE_LOG] Removing is done. app_name[com.samsung.iap-galaxyapps-consumer], alarm_id [1989128814]
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1297722297] with duetime(1480081181) at current(1480066743) pid: (3117)
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1645493560] with duetime(1480074014) at current(1480066743) pid: (3327)
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1958610270] with duetime(1480070643) at current(1480066743) pid: (9855)
11-25 15:09:03.421+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[992088270] with duetime(1480132496) at current(1480066743) pid: (3190)
11-25 15:09:03.431+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[619602365] with duetime(1480098600) at current(1480066743) pid: (11041)
11-25 15:09:03.431+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(539) > [SECURE_LOG] alarm[1376104741] with duetime(1480098600) at current(1480066743) pid: (11768)
11-25 15:09:03.431+0530 D/ALARM_MANAGER( 2483): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(105) > [SECURE_LOG] _add_to_scheduled_alarm_list :alarm->pid =9855, app_service_name=null(164)
11-25 15:09:03.431+0530 D/APPSYNC ( 2483): appsync-traffic-analyzer.c: appsync_update_scheduled_list(1889) > scheduled_list of alarm_manager = f7431b60
11-25 15:09:03.431+0530 D/ALARM_MANAGER( 2483): alarm-manager-timer.c: _alarm_set_timer(81) > [alarm-server][timer]: remain time from current is 3900.000000 , due_time is 1480070643.
11-25 15:09:03.431+0530 D/APPSYNC ( 2483): appsync-traffic-analyzer.c: appsync_update_server_alarm_list(1896) > server_alarm_list of alarm_manager = f7408440
11-25 15:09:03.431+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
11-25 15:09:03.431+0530 D/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(314) > alarm_context.c_due_time is 1480070643.
11-25 15:09:03.431+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-25 15:09:03.431+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-11-2016, 10:44:03 (UTC).
11-25 15:09:03.431+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-25 15:09:03.441+0530 E/ALARM_MANAGER( 2483): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: _get_json_obj(510) > [SECURE_LOG] _get_json_obj
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: on_data_received(697) > [SECURE_LOG] B64_encryptedData is exist
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: on_data_received(705) > [SECURE_LOG] B64_encryptedData_len: 1628
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: on_data_received(714) > [SECURE_LOG] encryptedData_len: 1221
11-25 15:09:03.441+0530 I/WSM     ( 3063): WSM_I [Run, line = 118, thread  = f5e6b460] Read request from client. 
11-25 15:09:03.441+0530 I/WSM     ( 3063): WSM_I [Run] Request len 406c 
11-25 15:09:03.441+0530 I/WSM     ( 3063): WSM_D [Run] Request data  =  [len=16492] e80350f46004000091c531619b4ba66f2af731ad7e1605ea39a7e13f347ad3641f616e959d879a4662c3103a2cf6d384c7a9ac535d02aa2c4a2e995a4619c0158d971661537415a8733b028d72166d413c8a1685f66c7f3229ecc74d019f1a5ab132384e76c394d8aa9a5862c2f91065e7f0d00570b187e5c8b318310ad20a26cf42382efe68ad19fc162642710e32dd8e686a29a003e01daed13741329ee516b9ec46732405c4304d1ab82cbeb77b511002e8cf684a0d1b20eec7e2a6f3e3051c8c3e3973a67990efd7f9b6a25ba59c5c61ce41e8c35a97a00e6176e71d25272b474f1e8fbdd5f497ef6c4bded26e1cbe7d16ecb8864088cc7e0fa4bbf0a32cb2c8283d4c8fdf5707387364b4360a81abedd8a248333e0e8edd81c6dd9c43eff58e3858e034f4143334778c78f878363fbef3634eb895f1048c1a9529583e64502b8bb7fa9e9cf278617680a6f9cb79c5987a926e43a54e30d7d12ec9b4610830fda10cf6abe809f2a8d182449a0d6f12b2fda57923065f3a181bc580b39cf5b3828a887214efcc70431dcfbf3d1f7383b075f9de52a73c7dd6febd622610dccf0636161525a5e5b657e09981e377dd5e529e841c465f638053feb5f7682f3f4bcd89ee4ebf45edc18a7f00310aa01e8c930871d36a46f42c9996f83b7ed55dfa3c4bb11735ae18053636
11-25 15:09:03.441+0530 I/WSM     ( 3063): WSM_I [Run, line = 150] Send reply to client.
11-25 15:09:03.441+0530 I/WSM     ( 3063): WSM_D [Run] Send reply =  [len=16492] 01000000600400001a34f7319b4ba66f2af731ad7e1605ea39a7e13f347ad3641f616e959d879a4662c3103a2cf6d384c7a9ac535d02aa2c4a2e995a4619c0158d971661537415a8733b028d72166d413c8a1685f66c7f3229ecc74d019f1a5ab132384e76c394d8aa9a5862c2f91065e7f0d00570b187e5c8b318310ad20a26cf42382efe68ad19fc162642710e32dd8e686a29a003e01daed13741329ee516b9ec46732405c4304d1ab82cbeb77b511002e8cf684a0d1b20eec7e2a6f3e3051c8c3e3973a67990efd7f9b6a25ba59c5c61ce41e8c35a97a00e6176e71d25272b474f1e8fbdd5f497ef6c4bded26e1cbe7d16ecb8864088cc7e0fa4bbf0a32cb2c8283d4c8fdf5707387364b4360a81abedd8a248333e0e8edd81c6dd9c43eff58e3858e034f4143334778c78f878363fbef3634eb895f1048c1a9529583e64502b8bb7fa9e9cf278617680a6f9cb79c5987a926e43a54e30d7d12ec9b4610830fda10cf6abe809f2a8d182449a0d6f12b2fda57923065f3a181bc580b39cf5b3828a887214efcc70431dcfbf3d1f7383b075f9de52a73c7dd6febd622610dccf0636161525a5e5b657e09981e377dd5e529e841c465f638053feb5f7682f3f4bcd89ee4ebf45edc18a7f00310aa01e8c930871d36a46f42c9996f83b7ed55dfa3c4bb11735ae18053636dd1
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: on_data_received(718) > [SECURE_LOG] decrypted_len:1189
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: _get_json_obj(510) > [SECURE_LOG] _get_json_obj
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: on_data_received(813) > Reply for IAP operations
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mErrorCode
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mErrorCode - 0
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mErrorString
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mErrorString - 
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemId
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mItemId - consumable
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemName
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mItemName - consumable
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemPrice
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mItemPrice - 1
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemPriceString
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mItemPriceString - $1.00
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mCurrencyUnit
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mCurrencyUnit - $
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mCurrencyCode
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mCurrencyCode - USD
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemDesc
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mItemDesc - consumable
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemImageUrl
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mItemImageUrl - http://img.samsungapps.com/appsitem/itemDefaultImage.jpg
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mItemDownloadUrl
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mItemDownloadUrl - 
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPaymentId
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mPaymentId - TPMTID20161125USA2402231
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPurchaseId
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mPurchaseId - db7d8f87bdd58bb42f22dc9804b88da40660d964c425e97b6044e575d100d756
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mPurchaseDate
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mPurchaseDate - 1480066740572
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mVerifyUrl
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mVerifyUrl - https://iap.samsungapps.com/iap/appsItemVerifyIAPReceipt.as?protocolVersion=2.0
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: json_obj_foreach(556) > [SECURE_LOG] member_name: mJsonString
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: parse_values(593) > [SECURE_LOG] JSON_NODE_VALUE
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: parse_values(629) > Add mJsonString - {"mErrorCode":"0","mErrorString":"","mItemId":"consumable","mItemName":"consumable","mItemPrice":"1","mItemPriceString":"$1.00","mCurrencyUnit":"$","mCurrencyCode":"USD","mItemDesc":"consumable","mItemImageUrl":"http:\/\/img.samsungapps.com\/appsitem\/itemDefaultImage.jpg","mItemDownloadUrl":"","mPaymentId":"TPMTID20161125USA2402231","mPurchaseId":"db7d8f87bdd58bb42f22dc9804b88da40660d964c425e97b6044e575d100d756","mPurchaseDate":"1480066740572","mVerifyUrl":"https:\/\/iap.samsungapps.com\/iap\/appsItemVerifyIAPReceipt.as?protocolVersion=2.0"}
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: _send_result_to_caller_app(158) > Reply to sender[iap.galaxyapps.com.samsung.iapnativesample] tID[13117_1] result[0]
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): sap.c: _send_result_to_caller_app(178) > Encoded bundle length = 1812
11-25 15:09:03.441+0530 D/IAP_CONSUMER(13233): sap.c: _send_result_to_caller_app(193) > >>> Asynchronously send the result
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: _set_busy(950) > [SECURE_LOG] is_busy = False
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: _start_iap(1225) > num of pending work: 0
11-25 15:09:03.441+0530 E/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: _start_iap(1227) > There is no job to handle
11-25 15:09:03.441+0530 I/CAPI_APPFW_APPLICATION(13233): service_app_main.c: service_app_exit(441) > service_app_exit
11-25 15:09:03.441+0530 I/IAP_CONSUMER(13233): sap.c: on_data_received(835) > << Finish sending result to caller app
11-25 15:09:03.441+0530 D/AUL     (13233): app_sock.c: __app_send_raw_with_noreply(352) > pid(-2) : cmd(22)
11-25 15:09:03.451+0530 W/AUL_AMD ( 2552): amd_request.c: __request_handler(669) > __request_handler: 22
11-25 15:09:03.451+0530 W/AUL_AMD ( 2552): amd_request.c: __request_handler(999) > app status : 4
11-25 15:09:03.451+0530 D/AUL_AMD ( 2552): amd_status.c: _status_update_app_info_list(180) > pid(13233), status(4)
11-25 15:09:03.451+0530 I/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: service_app_terminate(1405) > service_app_terminate
11-25 15:09:03.451+0530 E/IAP_CONSUMER(13233): iap-galaxyapps-consumer.c: __wsm_client_destroy(656) > [SECURE_LOG] Destroy wsm keys
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_I [Run, line = 118, thread  = f5e6b460] Read request from client. 
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_I [Run] Request len 406c 
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_D [Run] Request data  =  [len=16492] 0000000030020000e4feef290000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_I [Run, line = 150] Send reply to client.
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_D [Run] Send reply =  [len=16492] 01000000300200004d7c01230100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_I [Run, line = 118, thread  = f5e6b460] Read request from client. 
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_I [Run] Request len 406c 
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_D [Run] Request data  =  [len=16492] 000000006003000091c531610000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
11-25 15:09:03.451+0530 E/PRIVILEGE_CHECKER(13117): iap_galaxyapps.c: __handle_method_call(99) > Invoke reply callback. result: 0, transaction_id: 13117_1
11-25 15:09:03.451+0530 E/PRIVILEGE_CHECKER(13117): iap_galaxyapps.c: __handle_method_call(115) > Call IAP callback for 13117_1
11-25 15:09:03.451+0530 E/PRIVILEGE_CHECKER(13117): iap_galaxyapps.c: iap_galaxyapps_get_value(466) > Get [mItemId] - [consumable]
11-25 15:09:03.451+0530 E/PRIVILEGE_CHECKER(13117): iap_galaxyapps.c: iap_galaxyapps_get_value(466) > Get [mItemName] - [consumable]
11-25 15:09:03.451+0530 E/PRIVILEGE_CHECKER(13117): iap_galaxyapps.c: iap_galaxyapps_get_value(466) > Get [mItemPriceString] - [$1.00]
11-25 15:09:03.451+0530 E/PRIVILEGE_CHECKER(13117): iap_galaxyapps.c: iap_galaxyapps_get_value(466) > Get [mItemDesc] - [consumable]
11-25 15:09:03.451+0530 I/iapnativesample(13117): consumable
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_I [Run, line = 150] Send reply to client.
11-25 15:09:03.451+0530 I/WSM     ( 3063): WSM_D [Run] Send reply =  [len=16492] 01000000600300001a34f7310100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
11-25 15:09:03.571+0530 I/WSM     ( 3063): WSM_I [Run, line = 114, thread  = f5e6b460] Connection is closed by client. Close device and terminate thread. 
11-25 15:09:03.571+0530 I/WSM     ( 3063): WSM_I [Run, line = 173, thread  = f5e6b460] stopping, client socket file descriptor - 13 
11-25 15:09:03.771+0530 D/ELM_RPANEL( 2832): elm-rpanel.c: _ecore_x_message_cb(5486) > ev->message_type[560]
11-25 15:09:03.771+0530 D/ELM_RPANEL( 2832): elm-rpanel.c: _ecore_x_message_cb(5487) > _E_MOVE_W_HOME_FOREGROUND_BACKGROUND_STATE [746]
11-25 15:09:03.791+0530 I/TDM     ( 2010): tdm_pp.c: tdm_pp_set_info(322) > [17659.447603] pp(0x7d9b88) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
11-25 15:09:03.791+0530 D/AUL_PAD ( 3348): launchpad.c: main(814) > pfds[LAUNCH_PAD].revent  : 0x0
11-25 15:09:03.791+0530 D/AUL_PAD ( 3348): launchpad.c: main(817) > pfds[POOL_TYPE + 0].revents : 0x0
11-25 15:09:03.791+0530 D/AUL_PAD ( 3348): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-25 15:09:03.791+0530 D/AUL_PAD ( 3348): launchpad.c: main(817) > pfds[POOL_TYPE + 1].revents : 0x0
11-25 15:09:03.791+0530 D/AUL_PAD ( 3348): launchpad.c: main(818) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-25 15:09:03.791+0530 W/AUL_PAD ( 3348): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 13117 pgid = 13117
11-25 15:09:03.791+0530 W/AUL_PAD ( 3348): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 3 ssi_status = 11
11-25 15:09:03.801+0530 D/ELM_RPANEL( 2832): elm-rpanel.c: _ecore_x_message_cb(5486) > ev->message_type[560]
11-25 15:09:03.801+0530 D/ELM_RPANEL( 2832): elm-rpanel.c: _ecore_x_message_cb(5487) > _E_MOVE_W_HOME_FOREGROUND_BACKGROUND_STATE [746]
11-25 15:09:03.831+0530 W/WATCH_CORE( 2935): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
11-25 15:09:03.831+0530 I/WATCH_CORE( 2935): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
11-25 15:09:03.831+0530 D/WATCH_CORE( 2935): appcore-watch.c: __get_timeinfo(874) > Current time: 11-25 15:9:3.846
11-25 15:09:03.831+0530 I/CAPI_WATCH_APPLICATION( 2935): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
11-25 15:09:03.831+0530 D/WATCH_CORE( 2935): appcore-watch.c: __get_timeinfo(874) > Current time: 11-25 15:9:3.846
11-25 15:09:03.831+0530 D/AUL_AMD ( 2552): amd_launch.c: __e17_status_handler(2386) > pid(2832) status(3)
11-25 15:09:03.831+0530 D/AUL_AMD ( 2552): amd_key.c: _key_ungrab(250) > _key_ungrab, win : 1000002
11-25 15:09:03.831+0530 W/STARTER ( 2766): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2832] goes to (3)
11-25 15:09:03.831+0530 E/STARTER ( 2766): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2832)'s state(3)
11-25 15:09:03.831+0530 W/AUL_AMD ( 2552): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-25 15:09:03.831+0530 W/AUL_AMD ( 2552): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
11-25 15:09:03.831+0530 D/AUL_AMD ( 2552): amd_status.c: _status_update_app_info_list(180) > pid(2832), status(0)
11-25 15:09:03.831+0530 W/AUL     ( 2552): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2832) status(fg) type(uiapp)
11-25 15:09:03.841+0530 W/CRASH_MANAGER(13249): worker.c: worker_job(1199) > 1113117696170148006674
