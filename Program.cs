// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Dictionary<string, string> projectStrings = new Dictionary<string, string>();

void fillDictionary(){
	projectStrings.Add("menuHeader", "Enter menu point:");
	projectStrings.Add("menu1", "1. Summary payment for department");
	projectStrings.Add("menu2", "2. Minimal payment department");
	projectStrings.Add("menu3", "3. Payments of directors");
	projectStrings.Add("exit", "0. Exit");
}

bool waitCommand(out int command){
	var commandRaw = Console.ReadLine();
	command = -1;
	if(Int32.TryParse(commandRaw, out command))
		return true;
	return false;
	
}

void fillMenu(){
	Console.Clear();
	Console.WriteLine(projectStrings["menuHeader"]);
	Console.WriteLine(projectStrings["menu1"]);
	Console.WriteLine(projectStrings["menu2"]);
	Console.WriteLine(projectStrings["menu3"]);
	Console.WriteLine(projectStrings["exit"]);
}


fillDictionary();
while(true){
	fillMenu();
	int command = -1;
	if(!waitCommand(out command))
		continue;
	switch(command){
		case(0):{return;}
		case(1):{
			Console.WriteLine();
			break;
			}
		case(2):{
			Console.WriteLine();
			break;
			}
		case(3):{
			Console.WriteLine();
			break;
			}
		case(4):{
			Console.WriteLine();
			break;
			}
	}
}




