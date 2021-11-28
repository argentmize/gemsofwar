using System;

namespace gemsofwar.console
{
    class Program
    {
        static int Main(string[] args)
        {
            var options = Options.Parse(args);

            if (options.ShowHelp)
            {
                Options.DisplayHelp();
                return -1;
            }
            switch (options.Action)
            {
                case Verb.Train:
                    ModelTraining.Train(inputdirectory: options.Path, outputfilename: options.Output);
                    break;
                case Verb.Evaluate:
                    ModelFitness.Evaluate(filename: options.Input);
                    break;
                case Verb.Evolve:
                    ModelFitness.Evolve(filename: options.Input, options.Generations, options.Population);
                    break;
                case Verb.Check:
                    ModelTraining.Check(inputdirectory: options.Path, filename: options.Input);
                    break;
                case Verb.Create:
                    CreateBoards.CreateAllBoards(options.Dimension, options.GemCount);
                    break;
                case Verb.Dump:
                    CreateBoards.Dump(options.Input, options.Skip, options.Take);
                    break;
                case Verb.Play:
                    GamePlay.Play(options.GameMode);
                    break;
                default:
                    Console.WriteLine($"ERR: unknown action : {options.Action}");
                    break;
            }

            return 0;
        }
    }
}