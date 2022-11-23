var path = @"C:\Users\vladu\Desktop\";
bool exit = true;


while (exit)
{
    Console.WriteLine("Choose action: 1 - Spam,  2 - Delete, 3 - exit");
    int playerChoice = Convert.ToInt32(Console.ReadLine());
    switch (playerChoice)
    {
        case 1:
            CreateFolders();
            break;
        

        case 2:
            Delete();
            break;

        case 3:
            exit = false;
            break;
    }
}

void CreateFolders()
{
    for (int i = 1; i <= 100; i++)
    {
        Directory.CreateDirectory(path + "sorry, it's a prank" + i);
    }
}


void Delete()
{
    DirectoryInfo dekstopInfo = new DirectoryInfo(path);
    var directories = dekstopInfo.GetDirectories("sorry, it's a prank*");
    
    foreach (var directory in directories)
    {
        Directory.Delete(directory.FullName);
    }
    
}
