using System.Runtime.InteropServices;
using TheSlum.Models;

namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Engine
    {
        protected List<Character> characterList = new List<Character>();
        protected List<Bonus> timeoutItems;

        private const int GameTurns = 4;

        public virtual void Run()
        {
            this.ReadUserInput();
            this.InitializeTimeoutItems();

            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in this.characterList)
                {
                    if (character.IsAlive)
                    {
                        this.ProcessTargetSearch(character);
                    }
                }

                this.ProcessItemTimeout(this.timeoutItems);
            }

            this.PrintGameOutcome();
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (int i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = this.GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        public void InitializeTimeoutItems()
        {
            this.timeoutItems = this.characterList
                .SelectMany(c => c.Inventory)
                .Where(i => i is Bonus)
                .Cast<Bonus>()
                .ToList();
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }

        protected virtual void CreateCharacter(string[] inputParams)
        {
            //try
            var characterClass = inputParams[1];
            var characterName = inputParams[2];
            var characterX = int.Parse(inputParams[3]);
            var characterY = int.Parse(inputParams[4]);
            var characterTeam = inputParams[5];

            if (characterClass == "mage")
            {
                Character newCharacter = new Mage(characterName, characterX, characterY, characterTeam == "Red" ? Team.Red : Team.Blue);
                characterList.Add(newCharacter);
                Console.WriteLine("New mage {0} created", newCharacter.Id);
            }
            if (characterClass == "warrior")
            {
                Character newCharacter = new Warrior(characterName, characterX, characterY,
                    characterTeam == "Red" ? Team.Red : Team.Blue);
                characterList.Add(newCharacter);
                Console.WriteLine("New warrior {0} created", newCharacter.Id);
            }
            if (characterClass == "healer")
            {
                Character newCharacter = new Healer(characterName, characterX, characterY, characterTeam == "Red" ? Team.Red : Team.Blue);
                characterList.Add(newCharacter);
                Console.WriteLine("New Healer {0} created", newCharacter.Id);
            }

        }

        protected void AddItem(string[] inputParams)
        {
            var characterID = inputParams[1];
            var itemType = inputParams[2];
            var itemID = inputParams[3];

            switch (itemType)
            {
                case "axe":
                    Item newItem = new Axe(itemID);
                    characterList.First(c => c.Id == characterID).AddToInventory(newItem);
                    Console.WriteLine("{0} added to hero {1}", newItem.Id, characterID);
                    break;
                case "pill":
                    Item pillItem = new Pill(itemID);
                    characterList.First(c => c.Id == characterID).AddToInventory(pillItem);
                    Console.WriteLine("{0} added to hero {1}", pillItem, characterID);
                    break;
                case "injection":
                    Item injectionItem = new Injection(itemID);
                    characterList.First(c => c.Id == characterID).AddToInventory(injectionItem);
                    Console.WriteLine("{0} added to hero {1}", injectionItem, characterID);
                    break;
                case "shield":
                    Item shieldItem = new Shield(itemID);
                    characterList.First(c => c.Id == characterID).AddToInventory(shieldItem);
                    Console.WriteLine("{0} added to hero {1}", shieldItem, characterID);
                    break;
                default:
                    throw new ArgumentException("Invalid item type!");
            }
        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets = this.characterList
                .Where(t => this.IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range))
                .ToList();

            if (availableTargets.Count == 0)
            {
                return;
            }

            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }

            this.ProcessInteraction(currentCharacter, target);
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected bool IsWithinRange(int attackerX, int attackerY, int targetX, int targetY, int range)
        {
            double distance = Math.Sqrt(
                (attackerX - targetX) * (attackerX - targetX) +
                (attackerY - targetY) * (attackerY - targetY));

            return distance <= range;
        }

        protected Character GetCharacterById(string characterId)
        {
            return this.characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return this.characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = this.characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);

            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                string winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }

            var aliveCharacters = this.characterList.Where(c => c.IsAlive);
            this.PrintCharactersStatus(aliveCharacters);
            
        }

        private void ReadUserInput()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != string.Empty)
            {
                string[] parameters = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                this.ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }
    }
}
