using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;

namespace Empires.Core
{
   public class Engine : IExecutable
   {
       private IBuildingFactory buildingFactory;
       private IResourseFactory resourseFactory;
       private IUnitFactory unitFactory;
       private IData empireData;
       private IInputReader reader;
       private IOutputWriter writer;

       public Engine(IBuildingFactory buildingFactory, IResourseFactory resourseFactory, IUnitFactory unitFactory, IData empireData, IInputReader reader, IOutputWriter writer)
       {
           this.buildingFactory = buildingFactory;
           this.resourseFactory = resourseFactory;
           this.unitFactory = unitFactory;
           this.empireData = empireData;
           this.reader = reader;
           this.writer = writer;
       }


       public void Run()
       {
           while (true)
           {
               string[] input = this.reader.ReadLine().Split();

               this.ExecuteCommand(input);
               this.UpdateBuildings();
           }
       }

       private void UpdateBuildings()
       {
           foreach (var building in this.empireData.Buildings)
           {
               building.Update();

               if (building.CanProduceResource)
               {
                 var resource = building.ProduceResource();
                   this.empireData.Resources[resource.ResourseType] += resource.Quantity;
                   
               }

               if (building.CanProduceUnit)
               {
                   var unit = building.ProduceUnit();
                   this.empireData.AddUnit(unit);
               }
           }


       }

       private void ExecuteCommand(string[] input)
       {
           string command = input[0];
           switch (command)
           {
                case "empire-status":
                   this.ExecuteStatusCommand();
                   break;
                case "armistice":
                    Environment.Exit(0);         // 0 successful end
                    break;
                case "skip":
                    break;
                case "build":
                   this.ExecuteBuildCommand(input[1]);
                        break;
                default:
                   throw new NotImplementedException("Not implemented command");
           }
       }

       private void ExecuteBuildCommand(string buildingTypeName)
       {
           IBuilding building = this.buildingFactory.CreateBuilding(buildingTypeName, this.resourseFactory,
               this.unitFactory);

            this.empireData.AddBuilding(building);
            
       }

       private void ExecuteStatusCommand()
       {
           StringBuilder builder = new StringBuilder();

           AddTreasureInfo(builder);

           AddBuildingsInfo(builder);

           AddUnitsInfo(builder);

            this.writer.Print(builder.ToString().Trim());
       }

       private void AddUnitsInfo(StringBuilder builder)
       {
           builder.AppendLine("Units:");

           if (this.empireData.Units.Count == 0)
           {
               builder.AppendLine("N/A");
           }
           else
           {
               foreach (var unit in this.empireData.Units)
               {
                   builder.Append($"--{unit.Key}: {unit.Value}{Environment.NewLine}");
               }
           }
       }

       private void AddBuildingsInfo(StringBuilder builder)
       {
           builder.AppendLine("Buildings:");

           if (this.empireData.Buildings.Any())
           {
               foreach (var building in this.empireData.Buildings)
               {
                   //TODO override to string building
                   builder.Append($"--{building}{Environment.NewLine}");
               }
           }
           else
           {
               builder.AppendLine("N/A");
           }
       }

       private void AddTreasureInfo(StringBuilder builder)
       {
           builder.AppendFormat("Treasury:{0}", Environment.NewLine);

           foreach (var resource in this.empireData.Resources) // var - key value pair
           {
               builder.Append($"--{resource.Key}: {resource.Value}{Environment.NewLine}");
           }
       }
   }
   }

