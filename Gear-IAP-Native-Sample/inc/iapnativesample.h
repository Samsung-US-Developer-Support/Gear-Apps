#ifndef __iapnativesample_H__
#define __iapnativesample_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "iapnativesample"

#if !defined(PACKAGE)
#define EDJ_FILE "edje/setting.edj"
#define PACKAGE "com.samsung.iapnativesample"
#endif

#endif /* __iapnativesample_H__ */
