using System;
using System.IO;

namespace SpaceAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please enter at least one argument to the program.");
                Console.WriteLine("Type h or -h or / for help");
                return;
            }

            if (args[0] == "-h" || args[0] == "/?" || args[0] == "h")
            {
                Console.WriteLine("This program uses two arguments.");
                Console.WriteLine("1. Argument: h or -h or /? displays the help text.");
                Console.WriteLine("2. Argument: if not entered, the result is printed to the 'output.txt' file.");

                return;
            }

            if (args.Length < 2)
            {
//::if arg1 != "" && if arg2 == ""
string filePath = args[0];
if (File.Exists(filePath)){
//----------------------------------------------           
                Console.WriteLine("Process successful");
                Console.WriteLine("Saved to output.txt"); 

                using (StreamWriter outputFile = new StreamWriter("output.txt"))
                {
			outputFile.WriteLine("        ::Writed by SpaceAdder v:2.1.x");
			outputFile.WriteLine("        ::Thanks mr1ay ");
			outputFile.WriteLine("        ");

	                 using (StreamReader sr = new StreamReader(args[0]))
	                {
				string line = sr.ReadLine();
	                        if (line != null && line.Length > 0 && line[0] != ':')
	                        {
	                            outputFile.WriteLine("        " + line);
	                        }
				while ((line = sr.ReadLine()) != null)
	                        {
	                            if (line.Length > 0 && line[0] == ':')
	                            {
	                                outputFile.WriteLine("        " + line);
	                            }
	                            else
	                            {
	                                outputFile.WriteLine("                " + line);
	                            }
	                        }
        	        }
		
		}
//----------------------------------------------   
}
else  {Console.WriteLine("The file does not exist."); }
//
                return;
            }

////::if arg1 != "" && if arg2 != ""
////--------------------------------------------
                Console.WriteLine("Process successful");
                Console.WriteLine("Saved to output.txt");

                using (StreamWriter outputFile = new StreamWriter(args[1]))
                {
			outputFile.WriteLine("        ::Writed by SpaceAdder v:2.1.x");
			outputFile.WriteLine("        ::Thanks mr1ay ");
			outputFile.WriteLine("        ");

	                 using (StreamReader sr = new StreamReader(args[0]))
	                {
				string line = sr.ReadLine();
	                        if (line != null && line.Length > 0 && line[0] != ':')
	                        {
	                            outputFile.WriteLine("        " + line);
	                        }
				while ((line = sr.ReadLine()) != null)
	                        {
	                            if (line.Length > 0 && line[0] == ':')
	                            {
	                                outputFile.WriteLine("        " + line);
	                            }
	                            else
	                            {
	                                outputFile.WriteLine("                " + line);
	                            }
	                        }
        	        }
		
		}
////--------------------------------------------


        }
    }
}
