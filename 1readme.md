#include "opencv2/highgui/highgui.hpp"

#include  "opencv2/imgproc/imgproc.hpp"

#include  <iostream>

#include  <stdio.h>

#include  <stdlib.h>

using namespace cv;
using namespace std;

int main(int argc, char** argv)

{
	setlocale(LC_ALL, "Russian");
	char filename[80];
	cout << "Введите имя файла, в который хотите внести изменения, и нажмите Enter" << endl;
	cin.getline(filename, 80);
	cout << "открыть файл";
	cout << filename << endl;
	Mat imgt = imread(filename, 1);

	namedWindow("source_window", WINDOW_AUTOSIZE);
	imshow("source_window", imgt);
	waitKey(0);
	return 0;

}
  
