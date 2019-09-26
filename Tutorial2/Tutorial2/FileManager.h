#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"

#include <iostream>
#include <fstream>
#include <string>

class PLUGIN_API FileManager
{
public:

	void WriteFile(std::string fileName);//, FileManager* temp);// , SimpleClass sClass);
	void ReadFile(std::string fileName);// , SimpleClass sClass);

	void SavePosition(float posX, float posY, float posZ);

	void LoadPosition(float posX, float posY, float posZ);

	void setX(float posX);
	void setY(float posY);
	void setZ(float posZ);

	float getX();
	float getY();
	float getZ();

protected:
	float X; //= 0.0f;
	float Y; //= 0.0f;
	float Z; //= 0.0f;

private:
	
	std::ofstream write;
	std::ifstream read;


};