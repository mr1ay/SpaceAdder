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
                Console.WriteLine("Lütfen programa en az bir argüman giriniz.");
                return;
            }

            if (args[0] == "-h" || args[0] == "/?" || args[0] == "h")
            {
                Console.WriteLine("Bu program iki argüman kullanır.");
                Console.WriteLine("1. Argüman: h veya -h veya /? ise yardım metnini görüntüler.");
                Console.WriteLine("2. Argüman: eğer girilmezse, 'output.txt' dosyasına sonuç yazdılır.");

                return;
            }

            if (args.Length < 2)
            {
//::if arg1 != "" && if arg2 == ""
string filePath = args[0];
if (File.Exists(filePath)){
//----------------------------------------------           
                Console.WriteLine("İşlem tamam.");
                Console.WriteLine("Output.txt'ye yazdırıldı"); 

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
else  {Console.WriteLine("Dosya bulunamadı"); }
//
                return;
            }

////::if arg1 != "" && if arg2 != ""
////--------------------------------------------
                Console.WriteLine("İşlem tamam.");
                Console.WriteLine("Output.txt'ye yazdırıldı"); 
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
