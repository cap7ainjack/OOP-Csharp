using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Core
{
    using Contracts;
    using Models;

    public class Engine:IExecutable
    {

        private readonly IBlockFactory blobFactory;
        private readonly IAttackFactory attackFactory;
        private readonly IBehaviorFactory behaviorFactory;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IData data;

        public Engine(IBlockFactory blobFactory, IAttackFactory attackFactory,
            IBehaviorFactory behaviorFactory, IReader reader, IWriter writer, IData data)
        {
            this.blobFactory = blobFactory;
            this.attackFactory = attackFactory;
            this.behaviorFactory = behaviorFactory;
            this.reader = reader;
            this.writer = writer;
            this.data = data;
        }


        public virtual void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine();

                this.ExecuteInput(input.Split());
                this.UpdateBlobs();
            }
        }

        private void ExecuteInput(string[] commandArgs)
        {
            string command = commandArgs[0];

            switch (command)
            {
                case "create":
                    this.ExecuteCreateCommand(commandArgs);
                    break;
                case "attack":
                    this.ExecuteAttackCommand(commandArgs);
                    break;
                case "pass":
                    break;
                case "status":
                    this.ExecuteStatusCommand();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
            }
        }

        private void ExecuteStatusCommand()
        {
            var output = string.Join("\n", this.data.Blobs);

            this.writer.Print(output);
        }

        private void ExecuteAttackCommand(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            IBlob attacker = this.data.Blobs.FirstOrDefault(bl => bl.Name == attackerName);
            IBlob target = this.data.Blobs.FirstOrDefault(bl => bl.Name == targetName);

            if (attacker == null || target == null)
            {
                throw new ArgumentNullException($"Blob not found");
            }

            if (attacker.IsAlive && target.IsAlive)
            {
                attacker.PerformAttack(target);
            }
        }

        private void ExecuteCreateCommand(string[] commandArgs)
        {
            string name = commandArgs[1];
            int health = int.Parse(commandArgs[2]);
            int damage = int.Parse(commandArgs[3]);

            string behaviorType = commandArgs[4];
            string attackType = commandArgs[5];

            IBehave behavior = behaviorFactory.Create(behaviorType);
            IAttack attack = attackFactory.Create(attackType);

            IBlob blob = blobFactory.Create(name, health, damage, behavior, attack);

            //?????

            this.data.AddBlob(blob);
        }


        private void UpdateBlobs()
        {
            foreach (var blob in this.data.Blobs)
            {
                if (blob.IsAlive)
                {
                    blob.Update();
                }
            }
        }
    }
}
