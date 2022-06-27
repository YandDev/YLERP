using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using static System.Threading.Thread;
namespace FakeCodeGen
{

	class Program
	{
		static void Main(string[] args)
		{

			UInt64 NumberofPossibleCodeOutcomes = 11L*26L*8L*26L*4L*5L*4L*3L*5L*5L*4L*3L*4L*5L*4L*3L;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Yello! I am YLERP(Your Local Extremely Random Program). \nYour random fake stereotypical hacker code generator.\n press the spacebar to get started!\n\nNote you should indent the generated code to your liking.");
			Console.WriteLine("I currently can generate "+NumberofPossibleCodeOutcomes+" unique code results!");
			while(true)
			{
				ConsoleKey KeyPressed;
				ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
				KeyPressed = KeyInfo.Key;
				if (KeyPressed == ConsoleKey.Spacebar)
				{
					Console.Clear();

			        Random rnd = new Random();
			        string[] x = new string[] {"a","b","c","d","e","f","g","h","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"}; // 26
			        string[] y = new string[] {"a","b","c","d","e","f","g","h","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"}; // 26
			        string[] functionalOp = new string[] {">","<","==","!=","<=",">=", "^*", "!^"}; // 8
			        string[] RandomCode1 = new string[] {"If ","While ","Construct(StandardConstruct.Make) ", "private static IEnumerable<BreachData>: ", "public static IEnumerable<BreachData>: ", "private static void BreachData: ", "public static void BreachData: ", "public void BreachData: ", "private void BreachData: ", "Condition: ", "FalseCondition: "}; // 11
			        string[] RandomCodeStatements = new string[] {"\n{\n 	Foreach", "\n{\n 	For", "\n{\n 	ForEveryFalseOneIn", "\n{\n 	WhileAllAreEqualAcross"}; // 4
					string[] RandomCodeStatements2 = new string[] {"\n 	{\n 	Foreach{", "\n 	 	For{", "\n	 	ForEveryFalseOneIn{", "\n 	 	WhileAllAreEqualAcross{"}; // 4
					string[] RandomCodeItemsParents = new string[] {" System", " User", " Passwords", " Data", " UserBase"}; // 5
					string[] RandomCodeItemsChildren = new string[] {".CoreDatabase", ".ServerStorage", ".SystemDatabase", ".CentralDatabase"}; // 4
					string[] RandomCodeItemsGrandChildren = new string[] {".GetUsers(private readonly pastable int)", ".GetUserService:Users", ".GetUserIDs"}; // 3
					string[] RandomCodeItemsParents2 = new string[] {"\n 	 System", "\n 	 User", "\n 	 Passwords", "\n 	 Data", "\n 	 UserBase"}; // 5
					string[] RandomCodeItemsChildren2 = new string[] {".CoreDatabase", ".ServerStorage", ".SystemDatabase", ".CentralDatabase"}; // 4
					string[] RandomCodeItemsGrandChildren2 = new string[] {".GetUsers(private readonly pastable int)", ".GetUserService:Users", ".GetUserIDs"}; // 3
					string[] RandomCodeHashItemsParents = new string[] {"\n 		 			UserBase", "\n 		 				User", "\n 		 				Passwords", "\n 		 				Data", "\n 		 				UserBase"}; // 5
					string[] RandomCodeHashItemsChildren = new string[] {".GetHash", ".GetPassHash", ".Hash:GetService", ".ServiceGetter:Hash"}; // 4
					string[] RandomCodeHashItemsGrandChildren = new string[] {".SetHashLocation('./Passwords.txt/')", ".Location:Get;Set('./Passwords.txt/')", ".SetLocationToNearestTextFile"}; // 3			
					string[] RandomCodeBLoops = new string[] {" in ", " inside ", " out ", " outside ", " per "}; // 5					
					//string[] RandomCode2 = new string[] {"\n{\n System.CoreDatabase.GetUsers(int) in System.UserDatabaseCore do\n 		User.GetPasswordHash.SetPasswordHashLocation(Paswords.txt)", "\n{\n 	for i in pair.UserParsingService[user.CoreDatabase[ContainUsers]] do\n 	Passwords.DataBreachService(get; set:Passwords.txt;)", "\n{\nforeach CoreDatabase[UserName] in CoreDatabase do\n  	FunctionToGetPasswords = GetFunction(_FunctionPasswords)\n  	FunctionToGetPasswords(passwords,parent,FirstChild,CoreDatabase,true,false,20)"};
			        //string[] RandomCode2V = new string[] {"\n{\n System.CoreDatabase.GetUsers(int) in System.UserDatabaseCore do\n 		User.GetPasswordHash.SetPasswordHashLocation(Paswords.txt)", "\n{\n 	for i in pair.UserParsingService[user.CoreDatabase[ContainUsers]] do\n 	Passwords.DataBreachService(get; set:Passwords.txt;)", "\n{\nforeach CoreDatabase[UserName] in CoreDatabase do\n  	FunctionToGetPasswords = GetFunction(_FunctionPasswords)\n  	FunctionToGetPasswords(passwords,parent,FirstChild,CoreDatabase,true,false,20)"};
			        string[] RandomCode3 = new string[] {"\n 		Passwords.GetHashKey(Passwords.txt):ConvertTo(Base64.Encode(true))\n 	If Passwords/txt.IsEmpty(true)","\n 		HashService.PasswordStorage(Passwords.txt):Get(ChildOf(HashService):EncodeToBase64(true)", "\n 			System.GetService:HashService\n 	System.GetService:ConversionService\n 	Method ConvertToBase64():\n 		UseHashService(UseConversionService.Base64)\n 	end)\n 		ConvertToBase64(Passwords.txt)"};
			        string[] RandomCode4 = new string[] {"\n 			Try:\n 	 		System.DecodeToEncodableYerlp128(Service.Get()) = EncodableYerlp128\nCatch(UnknowServiceException):ServiceGetter.Activate(Service.System:Get(System.DecodeToEncodableYerlp128))\n 	EncodableYerlp128(Yerlp.LanguageLibrary.Translate(string = this.ToString()).GetFileService(file):'DecodedPasswords.txt'(WriteLine())", "		From(Base64) Of Passwords.txt Do:\n 	GetLanguageLibrary(Ylerp);UseLanguageLibrary(Base64->Ylerp) File.FileService(DecodedPasswords.txt).Write(Ylerp.DecodedPasswords)"};
			        int RC1Val = rnd.Next(RandomCode1.Length);
			        //int RC2Val = rnd.Next(RandomCode2.Length);
			        int RC3Val = rnd.Next(RandomCode3.Length);
			        int RC4Val = rnd.Next(RandomCode4.Length);
			        int FOVal = rnd.Next(functionalOp.Length);
			        //int RC2VVal = rnd.Next(RandomCode2V.Length);
			        int val = rnd.Next(x.Length);
			        int valu = rnd.Next(y.Length);
					int RCS = rnd.Next(RandomCodeStatements.Length);
					int RCS2 = rnd.Next(RandomCodeStatements2.Length);
					int RCIP = rnd.Next(RandomCodeItemsParents.Length);
					int RCIC = rnd.Next(RandomCodeItemsChildren.Length);
					int RCIGC = rnd.Next(RandomCodeItemsGrandChildren.Length);
					int RCBL = rnd.Next(RandomCodeBLoops.Length);
					int RCIP2 = rnd.Next(RandomCodeItemsParents2.Length);
					int RCIC2 = rnd.Next(RandomCodeItemsChildren2.Length);
					int RCIGC2 = rnd.Next(RandomCodeItemsGrandChildren2.Length);
					int RCHIP = rnd.Next(RandomCodeHashItemsParents.Length);
					int RCIHC = rnd.Next(RandomCodeHashItemsChildren.Length);
					int RCIHGC = rnd.Next(RandomCodeHashItemsGrandChildren.Length);					
					int number = rnd.Next(1,10000);

					var CodeOutput = RandomCode1[RC1Val]+x[val]+functionalOp[FOVal]+y[valu]+RandomCodeStatements[RCS]+RandomCodeItemsParents[RCIP]+RandomCodeItemsChildren[RCIC]+RandomCodeItemsGrandChildren[RCIGC]+RandomCodeBLoops[RCBL]+RandomCodeItemsParents2[RCIP2]+RandomCodeItemsChildren2[RCIC2]+RandomCodeItemsGrandChildren2[RCIGC2]+RandomCodeStatements2[RCS2]+RandomCodeHashItemsParents[RCHIP]+RandomCodeHashItemsChildren[RCIHC]+RandomCodeHashItemsGrandChildren[RCIHGC]+RandomCode3[RC3Val]+RandomCode4[RC4Val];
			        Logger.WriteLine(CodeOutput);
			        Console.WriteLine("Code Generated");
			        Thread.Sleep(500);
			        Console.WriteLine("The code is in the text file i created for you!");
			        Logger.SaveLog(false);
			        // 10,279,552,640,000 possible combinations!!!
			        // Theyre pretty similar, but they ARE different.
	    		}
	    	}
       	}
	}

	public static class Logger
{
    public static StringBuilder LogString = new StringBuilder();
    public static void WriteLine(string str)
    {
    	Console.Clear();
    	LogString.Clear();
        LogString.Append(str).Append(Environment.NewLine);
    }
    public static void Write(string str)
    {
        Console.Write(str);
        LogString.Append(str);

    }
    public static void SaveLog(bool Append = false, string Path = "./CodeOutput.txt")
    {
        if (LogString != null && LogString.Length > 0)
        {
            if (Append)
            {
                using (StreamWriter file = System.IO.File.AppendText(Path))
                {
                    file.Write(LogString.ToString());
                    file.Close();
                    file.Dispose();
                }
            }
            else
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path))
                {
                    file.Write(LogString.ToString());
                    file.Close();
                    file.Dispose();
                }
            }               
        }
    }
}
}