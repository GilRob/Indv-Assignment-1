#pragma once

#include "PluginSettings.h"
#include "SimpleClass.h"

#ifdef __cplusplus
extern "C"
{
#endif

	// Put your functions here
	PLUGIN_API int SimpleFunction();
	
	PLUGIN_API void SavePosition(float posX, float posY, float posZ);

	PLUGIN_API void LoadPosition(float posX, float posY, float posZ);


#ifdef __cplusplus
}
#endif