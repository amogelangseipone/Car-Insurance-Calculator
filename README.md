# Car-Insurance-Calculator-
## Instructions
1. Open the solution file (`.sln`) in Visual Studio.
2. Build the project and run it to calculate insurance premiums.

I’ve created a basic Car Insurance Premium Calculator using C# with a Windows Forms interface. The idea behind this tool is to calculate an individual’s car insurance premium based on their age, gender, and accident history. This gives a simplified view of how insurance companies might assess risk and set premiums.
## User Interface
The form contains:
_Age input:_ The user enters their age to determine the associated risk level.
_Gender selection:_ The user selects their gender, as this can influence risk scoring in some insurance models.
_Accident history:_ The user inputs the number of accidents they’ve been involved in.
_Calculate button:_ When the user clicks this button, the program processes the inputs and calculates both a "risk score" and the corresponding insurance premium.
## Calculation Logic
I’ve implemented a simple risk scoring system that looks at a few factors:
_Age:_
Drivers 24 and younger are considered higher risk, so they get a higher risk score.
Drivers between 25 and 60 are seen as moderate risk.
Drivers over 60 are considered higher risk, so their score increases again.
_Gender:_
This might influence the risk score (in this case, females are assumed to be lower risk in the model).
_Accident History:_
The more accidents a person has, the higher their risk score becomes. Each accident adds a factor to the risk score. Once the risk score is calculated, it’s used to determine the premium. The premium starts at a base amount (R500),  and then I add an extra R50 per risk point. So, the higher the risk score, the more expensive the premium.
## Please Note:
The risk scores and premiums in this calculator are based on simplified assumptions for the sake of the project. 
The calculations are not based on actual insurance data. They are simply for demonstration purposes in the context of this project.
