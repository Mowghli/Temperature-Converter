# Temperature-Converter

A Desktop application made using ASP.NET and C#, that can convert the given Celcius value to Fahrenheit, and vice versa. The project solution consists of two parts:
- TempCovService 
- TemCovServiceForm 

## TempCovService
A WCF service that performs the conversion between Celcius and Fahrenheit temperatures. Check the code at ["Temperature-Converter/TempCovService/Service1.svc.cs"](https://github.com/Mowghli/Temperature-Converter/blob/master/TempCovService/Service1.svc.cs) for the logic. The function "C2f" is used to convert the given temperature in Celcius to Fahrenheit. The function "F2c" is used to convert the given temperature in Fahrenheit to Celcius.
## TemCovServiceForm
A Windows Forms Application to use the TempCovService service. Check the code at ["Temperature-Converter/TempConvServiceForm/Form1.cs"](https://github.com/Mowghli/Temperature-Converter/blob/master/TempConvServiceForm/Form1.cs) for the logic. 

## Steps to run the project
1. Download the project, or clone it by copying the URL.
2. Open Visual Studio 2019. If you downloaded the project file, unzip it, then open the solution file using Visual Studio. Or you can clone through "Open from Source Control".
3. After you open the project solution, open the solution explorer. Right-click on "Service1.svc" in the [TempCovService](https://github.com/Mowghli/Temperature-Converter/tree/master/TempCovService) project, and select "Open in Browser".
4. Click on the ["TempConvServiceForm"](https://github.com/Mowghli/Temperature-Converter/tree/master/TempConvServiceForm), and run it. A window will open.
5. To convert a Celcius value to Fahrenheit, enter the number in the corresponding textbox, and click on the "C2FBtn" button.
6. To convert a Fahrenheit value to Celcius, enter the number in the corresponding textbox, and click on the "F2CBtn" button.

**Notes:**
The project solution was developed as a course project for CSE 445: Distributed Software Development, at ASU.
