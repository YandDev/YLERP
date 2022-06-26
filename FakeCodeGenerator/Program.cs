using System;
namespace FakeCodeGen
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;

			while(true)
			{
				ConsoleKey KeyPressed;
				ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
				KeyPressed = KeyInfo.Key;
				if (KeyPressed == ConsoleKey.Spacebar)
				{
					Console.Clear();

			        Random rnd = new Random();
			        string[] x = new string[] {"a","b","c","d","e","f","g","h","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
			        string[] y = new string[] {"a","b","c","d","e","f","g","h","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
			        string[] functionalOp = new string[] {">","<","==","!=","<=",">="};
			        string[] RandomCode1 = new string[] {"If ","While ","Construct(StandardConstruct.Make) "};
			        string[] RandomCode2 = new string[] {"{\nForeach System.CoreDatabase.GetUsers(int) in System.UserDatabaseCore do\n 		User.GetPasswordHash.SetPasswordHashLocation(Paswords.txt)", "{\n 	for i in pair.UserParsingService[user.CoreDatabase[ContainUsers]] do\n 	Passwords.DataBreachService(get; set:Passwords.txt;)", "{\nforeach CoreDatabase[UserName] in CoreDatabase do\n  	FunctionToGetPasswords = GetFunction(_FunctionPasswords)\n  	FunctionToGetPasswords(passwords,parent,FirstChild,CoreDatabase,true,false,20)"};
			        string[] RandomCode3 = new string[] {"\n 	Passwords.GetHashKey(Passwords.txt):ConvertTo(Base64.Encode(true))\n 	If Passwords/txt.IsEmpty(true)","\n 	HashService.PasswordStorage(Passwords.txt):Get(ChildOf(HashService):EncodeToBase64(true)", "\n 		System.GetService:HashService\n 	System.GetService:ConversionService\n 	Method ConvertToBase64():\n 		UseHashService(UseConversionService.Base64)\n 	end)\n 		ConvertToBase64(Passwords.txt)"};
			        string[] RandomCode4 = new string[] {"\nTry:\n 	System.DecodeToEncodableYerlp128(Service.Get()) = EncodableYerlp128\nCatch(UnknowServiceException):ServiceGetter.Activate(Service.System:Get(System.DecodeToEncodableYerlp128))\n 	EncodableYerlp128(Yerlp.LanguageLibrary.Translate(string = this.ToString()).GetFileService(file):'DecodedPasswords.txt'(WriteLine())", "From(Base64) Of Passwords.txt Do:\n 	GetLanguageLibrary(Ylerp);UseLanguageLibrary(Base64->Ylerp) File.FileService(DecodedPasswords.txt).Write(Ylerp.DecodedPasswords)"};
			        int RC1Val = rnd.Next(RandomCode1.Length);
			        int RC2Val = rnd.Next(RandomCode2.Length);
			        int RC3Val = rnd.Next(RandomCode3.Length);
			        int RC4Val = rnd.Next(RandomCode4.Length);
			        int FOVal = rnd.Next(functionalOp.Length);
			        int val = rnd.Next(x.Length);
			        int valu = rnd.Next(y.Length);
					int number = rnd.Next(1,10000);


			        Console.WriteLine(RandomCode1[RC1Val]+x[val]+functionalOp[FOVal]+y[valu]+RandomCode2[RC2Val]+ RandomCode1[RC1Val]+RandomCode3[RC3Val]+RandomCode1[RC1Val]+RandomCode2[RC2Val]+RandomCode4[RC4Val]);
			        // 1,971,216 possible combinations!!!
			        // Theyre pretty similar, but they ARE different.

					// adding more randomness very soon
	    		}
	    	}
       	}
	}
}