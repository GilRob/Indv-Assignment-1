#include "Wrapper.h"

SimpleClass simpleClass;

int SimpleFunction()
{
	return simpleClass.SimpleFunction();
}

void SavePosition(float posX, float posY, float posZ)
{
	return simpleClass.SavePosition(posX, posY, posZ);
}

void LoadPosition(float posX, float posY, float posZ)
{
	return simpleClass.LoadPosition(posX, posY, posZ);
}