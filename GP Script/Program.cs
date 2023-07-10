namespace main{
    internal class Program{
        static bool isRunnig = false;
        static List<string> fileContent = new List<string>();
        static string? getFileContent = "";
        public static int currentI = 0;

        static void Main(string[] arg){
            Console.Title = "GP Script";

            //=========Make all of the list==========
            //Variables
            List<string> varNAme = new List<string>();
            List<int> varValue = new List<int>();
            fileContent.Clear();


            //Inisialize all of the functuions
 



            //Show a list of commmands of the commands
            string[] commands = {"RUN", "PRINT ", "VAR"};
            for(int i = 0; i < commands.Length; i++){
                Console.WriteLine(commands[i]);
            }
            Console.WriteLine("=========Program========");


            while(true){
                //Get the text in the console
                getFileContent = Console.ReadLine();
                fileContent.Add(getFileContent);
                mainLoop();
            }

        }
        static void mainLoop(){
            //End the program
         
            if(fileContent.Contains("RUN")){
                Run();
                ResetConsole();
                fileContent.Remove("RUN");
            }
            //This checks for anny keywords
            if(isRunnig == true){ 
                for(int i = 0; i < fileContent.Count; i++){
                    currentI = i;
                    Console.WriteLine(fileContent[i]);
                    if(fileContent[i].Contains("VAR")){
                        Console.WriteLine("Yay a VARIBLE!");
                        VAR();
                    }
                }
            }
        }

        static void Run(){
         isRunnig = true;

        }

        static void VAR(){
            string? varCharacters = fileContent[currentI];
            string[] token = varCharacters.Split(' ');
            if(currentI >= 0){
                currentI ++;
                varCharacters = token[currentI];
                currentI--;
            }else{
                varCharacters = token[currentI];
            }
            
            Console.WriteLine(varCharacters);
        }
        static void ResetConsole(){
            Console.Clear();
            Console.WriteLine("-------Running--------");
            Console.WriteLine("========Output========");
        }
        static void getCUrrentVariable(){

        }
    }
    
}