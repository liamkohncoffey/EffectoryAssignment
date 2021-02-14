# EffectoryAssignment.API
This coding assignment for a role at effectory. The main focus of this assignment for me was showing how i would set up a soulution for the first time. Below should be reasonings and descriptions on how to run and what some of the class libraries mean.

# Explination Behind Some of the class libraries:
- EffectoryAssignment.SharedKernel
- This is the shared kernals for the solution usually this would be Shared between C# projects via Nuget or MyGet containing specific classes and enums that would be considered part of the questionare's Domain
- EffectoryAssignment.Definition
- This is the class library which would also be shared also via Nuget, this would contaion any requests and responses for this Domain, also any event defientions or interfaces.
- EffectoryAssignment.Domain
- This would conatin anything specific to the questionnares domain, meaning Database models, database interfaces and any other internal classes that you would like to remain inside this domain.

# What was Finished/Not Finished

Completed:
- Getting one or more questions and answer options.
- Posting one or more answers for the questions.

Incomplete
- paging the result.
- Returning a results calculation of min, max, average for each answer, calculated across the departments.
- Create a test-suite 

# How to run:
- Launch your prefered ide.
- Open the solution.
- Hit run.
- It should be running on http://localhost:5000/
- If you have postman there is a postman enviroment and collection included with this solution
- You should be able to import these both in order to test out the API

# Possible hotspots
- The only thing i can think of that might not workin is the .json object path, If this doesn't work update the pathname to what ever it should be.
