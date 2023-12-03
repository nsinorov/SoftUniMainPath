## Databases Advanced Exam - 02 December 2023

Before submitting your solutions in the SoftUni Judge system, delete all bin/obj and packages folders. If the zip file is still too large, you can delete the ImportResults, ExportsResults and Datasets folders too.

Your task is to create a database application, using Entity Framework Core, using the Code First approach. Design the domain models and methods for manipulating the data, as described below.

## Medicines

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/87df2cc2-b91e-424b-b25e-c6debedeabaf)

## 1.	Project Skeleton Overview

You are given a project skeleton, which includes the following folders:

	Data – contains the MedicinesContext class, Models folder, which contains the entity classes and the Configuration class with connection string
	DataProcessor – contains the Serializer and Deserializer classes, which are used for importing and exporting data
	Datasets – contains the .json and .xml files for the import part
	ImportResults – contains the import results you make in the Deserializer class
	ExportResults – contains the export results you make in the Serializer class
 
## 2.	Model Definition (50 pts)
