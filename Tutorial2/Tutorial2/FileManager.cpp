#include "FileManager.h"

//SimpleClass sClass;

void FileManager::WriteFile(std::string fileName)//, FileManager* temp)//, SimpleClass sClass)
{
	write.open(fileName);
	if (write.is_open())
	{
		write << getX() << "\n";
		write << getY() << "\n";
		write << getZ() << "\n";

		write.close();
	}
}

void FileManager::ReadFile(std::string fileName)//, SimpleClass sClass)
{
	float posVal;
	std::string line;
	read.open(fileName);
	int counter = 0;

	if (read.is_open())
	{
		while (std::getline(read, line))
		{
			if (counter == 0)
			{
				posVal = std::stof(line);
				setX(posVal);
			}
			else if (counter == 1)
			{
				posVal = std::stof(line);
				setY(posVal);
			}
			else if (counter == 2)
			{
				posVal = std::stof(line);
				setZ(posVal);
			}

			counter++;
		}

		read.close();
	}
}

void FileManager::SavePosition(float posX, float posY, float posZ)
{
	setX(posX);
	setY(posY);
	setZ(posZ);

	WriteFile("save.txt");//, this);
}

void FileManager::LoadPosition(float posX, float posY, float posZ)
{
	posX = X;
	posY = Y;
	posZ = Z;
}

void FileManager::setX(float posX)
{
	X = posX;
}

void FileManager::setY(float posY)
{
	Y = posY;
}

void FileManager::setZ(float posZ)
{
	Z = posZ;
}

float FileManager::getX()
{
	return X;
}

float FileManager::getY()
{
	return Y;
}

float FileManager::getZ()
{
	return Z;
}
