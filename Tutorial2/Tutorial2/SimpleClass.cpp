#include "SimpleClass.h"

int SimpleClass::SimpleFunction()
{
	return 1;
}

void SimpleClass::SavePosition(float posX, float posY, float posZ)
{
	X = posX;
	Y = posY;
	Z = posZ;
}

void SimpleClass::LoadPosition(float posX, float posY, float posZ)
{
	posX = X;
	posY = Y;
	posZ = Z;
}
