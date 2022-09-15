# WiredInterviewTask

## Preamble
Dear Candidate. We are happy to meet you a second time. In this interview we as team wired want to get to know you in detail. Therefore, we will tell you what exactly we do work on, show you our project and will answer your questions.
We also want to make sure to get a good developer, so we prepared 2 little tasks we want you to solve during the meeting. This will take 20 approximately minutes. Have fun ;) 

### Task 1 (Application Insights Log Analysis)

Please go through the kusto query below. Explain what happens line by line and at the end, describe how the output will look like.​
```
requests
| where cloud_RoleName == "web-yello-prod"
| where url has "/solar/email-versendet-belieferung/" and not(url has "auftragsnummer=99999999")
| extend auftragsnummer = extract("auftragsnummer=([0-9a-zA-Z-]+)", 1, url)
| where auftragsnummer != ""
| project auftragsnummer
| distinct auftragsnummer
```

How does the output changes if you replace the last 2 lines with?
```
| summarize count() by bin(timestamp, 1h)
```

### Task2 (Development Task with MediatR)
Please clone this repository and open the solution in Visual Studio.
You will find a small Calculator API that has some flaws. Please follow the tasks below to improve the application

 1. At the moment, if you execute the "add" Action multiple times, it will always return the same value. Please adjust the code in a way that the result increases with every call of "add" Action. 
	 *Note: The variable definition of "result" field inside CalculatorService **must not** be changed to static.* 
2. The Dependency to CalculatorService in CalculatorController is already decoupled via a interface. We want to decouple it further using the mediatR library in a CQSR way. Please implement the MediatR as a bridge between Controller and Service.