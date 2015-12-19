using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;

namespace Empires.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private const int ProductionDelay = 1;
        private int cyclesCount = 0;
        private string unitType;
        private int unitCycleLenght;
        private ResourseType resourseType;
        private int resourcseCycleLenght;
        private int resourceQuantity;
        private IUnitFactory unitFactory;
        private IResourseFactory resourseFactory;

        protected Building(string unitType, int unitCycleLenght,
            ResourseType resourseType,
                int resoursesCycleLenght,
                int resourceQuantity,
                IUnitFactory unitFactory,
                IResourseFactory resourseFactory)
        {
            this.unitType = unitType;
            this.unitCycleLenght = unitCycleLenght;
            this.resourseType = resourseType;
            this.resourcseCycleLenght = resoursesCycleLenght;
            this.resourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourseFactory = resourseFactory;
        }




        public bool CanProduceResource
        {
            get { bool canProduceResourse = this.cyclesCount > ProductionDelay 
                    && (this.cyclesCount - ProductionDelay) % this.resourcseCycleLenght == 0;

                return canProduceResourse;
               }

        }

        public bool CanProduceUnit
        {
             get { bool canProduceUnit = this.cyclesCount > ProductionDelay 
                    && (this.cyclesCount - ProductionDelay) % this.unitCycleLenght == 0;

                return canProduceUnit;
            }
        }

        public IResource ProduceResource()
        {
            var  resource = this.resourseFactory.ProduceResource(this.resourseType,this.Quantity);
            return resource;
        }


        public IUnit ProduceUnit()
        {
            var unit =  this.unitFactory.CreateUnit(this.unitType);
            return unit;
        }

        public ResourseType ResourseType { get; }

        public int Quantity
        {
            get { return this.resourceQuantity; } 
        }



        public void Update()
        {
            this.cyclesCount++;
        }

        public override string ToString()
        {
            //--Archery: 4 turns (2 turns until Archer, 2 turns until Gold)
            int turnsUntilUnit = this.unitCycleLenght - (this.cyclesCount - ProductionDelay) % this.unitCycleLenght;
            int turnsUntilResource = this.resourcseCycleLenght - (this.cyclesCount - ProductionDelay) % this.resourcseCycleLenght;

            var result = string.Format(
                  "{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                  this.GetType().Name,
                  this.cyclesCount - ProductionDelay,
                  turnsUntilUnit,
                  this.unitType,
                  turnsUntilResource,
                  this.resourseType);

            return result; 
        }
    }
}
