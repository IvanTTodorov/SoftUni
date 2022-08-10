using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();


            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputInfo = input.Split();

                string action = inputInfo[0];
                int id = int.Parse(inputInfo[1]);
                string firstName = inputInfo[2];
                string lastName = inputInfo[3];

                if (action == "Private")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(id, @private);
                }
                else if (action == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < inputInfo.Length; i++)
                    {
                        int currentId = int.Parse(inputInfo[i]);
                        IPrivate @private = soldiers[currentId] as IPrivate;
                        lieutenantGeneral.Privates.Add(@private);
                    }
                    soldiers.Add(id, lieutenantGeneral);
                }
                else if (action == "Engineer")
                {

                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corpsAsString = inputInfo[5];

                    bool isValid = Enum.TryParse(corpsAsString, out Corps result);
                    if (isValid)
                    {
                        IEngineer engineer = new Engineer(id, firstName, lastName, salary, result);
                        
                        for (int i = 6; i < inputInfo.Length; i += 2)
                        {
                            string partName = inputInfo[i];
                            int hoursWorked = int.Parse(inputInfo[i + 1]);
                            IRepair repair = new Repair(partName, hoursWorked);
                            engineer.Repairs.Add(repair);
                        }
                        soldiers.Add(id, engineer);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Commando")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corpsAsString = inputInfo[5];

                    bool isValid = Enum.TryParse(corpsAsString, out Corps result);
                    if (!isValid)
                    {
                        continue;
                    }
                    else
                    {
                        ICommando commando = new Commando(id, firstName, lastName, salary, result);
                        for (int i = 6; i < inputInfo.Length; i += 2)
                        {
                            string missionCodeName = inputInfo[i];
                            string missionState = inputInfo[i + 1];
                            bool isStateValid = Enum.TryParse(missionState, out State state);

                            if (!isStateValid)
                            {
                                continue;
                            }
                            else
                            {
                                IMission mission = new Mission(missionCodeName, state);
                                commando.Missions.Add(mission);
                            }
                        }
                        soldiers.Add(id, commando);
                    }
                }
                else if (action == "Spy")
                {
                    int codeNum = int.Parse(inputInfo[4]);
                    ISpy spy = new Spy(id, firstName, lastName, codeNum);
                    soldiers.Add(id, spy);
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value.ToString()); 
            }
        }
    }
}
