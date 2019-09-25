#pragma once

#include "PluginSettings.h"

class PLUGIN_API SimpleClass
{
public:
	int SimpleFunction();

	void SavePosition(float posX, float posY, float posZ);

	void LoadPosition(float posX, float posY, float posZ);

private:
	float X = 0.0f;
	float Y = 0.0f;
	float Z = 0.0f;
};