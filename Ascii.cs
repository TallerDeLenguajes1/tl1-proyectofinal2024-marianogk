using EspacioPersonaje;

public class Ascii
{
    public static void MenuPrincipal()
    {
        Console.WriteLine("\n1. CREAR PERSONAJES ");
        Console.WriteLine("\n2. NUEVA PARTIDA ");
        Console.WriteLine("\n3. CARGAR PARTIDA ");
        Console.WriteLine("\n4. MOSTRAR HISTORIAL ");
        Console.WriteLine("\n5. SALIR ");
        Console.WriteLine("\nINGRESE:");
    }

    public static void MenuSecundario()
    {
        Thread.Sleep(1000);
        Console.WriteLine("\n1. PARA SEGUIR JUGANDO: ");
        Console.WriteLine("\n2. PARA GUARDAR LA PARTIDA: ");
        Console.WriteLine("\n3. PARA SALIR SIN GUARDAR: \n");
        Console.WriteLine("\nINGRESE:");
    }

    public static void JuegoTitulo()
    {
        string texto = @"

███╗░░░███╗░█████╗░██████╗░██╗░░░██╗███████╗██╗░░░░░    ██╗░░░██╗░██████╗      ██████╗░░█████╗░
████╗░████║██╔══██╗██╔══██╗██║░░░██║██╔════╝██║░░░░░    ██║░░░██║██╔════╝      ██╔══██╗██╔══██╗
██╔████╔██║███████║██████╔╝╚██╗░██╔╝█████╗░░██║░░░░░    ╚██╗░██╔╝╚█████╗░      ██║░░██║██║░░╚═╝
██║╚██╔╝██║██╔══██║██╔══██╗░╚████╔╝░██╔══╝░░██║░░░░░    ░╚████╔╝░░╚═══██╗      ██║░░██║██║░░██╗
██║░╚═╝░██║██║░░██║██║░░██║░░╚██╔╝░░███████╗███████╗    ░░╚██╔╝░░██████╔╝      ██████╔╝╚█████╔╝
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚══════╝    ░░░╚═╝░░░╚═════╝░      ╚═════╝░░╚════╝░";
        Console.WriteLine(texto);
    }

    public static void PersonajesTitulo()
    {
        Console.WriteLine("");
        Console.WriteLine("██████╗░███████╗██████╗░░██████╗░█████╗░███╗░░██╗░█████╗░░░░░░██╗███████╗░██████╗");
        Console.WriteLine("██╔══██╗██╔════╝██╔══██╗██╔════╝██╔══██╗████╗░██║██╔══██╗░░░░░██║██╔════╝██╔════╝");
        Console.WriteLine("██████╔╝█████╗░░██████╔╝╚█████╗░██║░░██║██╔██╗██║███████║░░░░░██║█████╗░░╚█████╗░");
        Console.WriteLine("██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗██║░░██║██║╚████║██╔══██║██╗░░██║██╔══╝░░░╚═══██╗");
        Console.WriteLine("██║░░░░░███████╗██║░░██║██████╔╝╚█████╔╝██║░╚███║██║░░██║╚█████╔╝███████╗██████╔╝");
        Console.WriteLine("╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚══════╝╚═════╝░");
        Console.WriteLine("");
    }
    public static void GanadorFinal()
    {
        string texto = @"

█▀▀ █░░   █▀▀ ▄▀█ █▄░█ ▄▀█ █▀▄ █▀█ █▀█   █▀▀ █▀ ░ ░ ░
██▄ █▄▄   █▄█ █▀█ █░▀█ █▀█ █▄▀ █▄█ █▀▄   ██▄ ▄█ ▄ ▄ ▄";
        ImprimirConDelay(texto, 10);

    }


    public static void Perdiste()
    {
        Console.WriteLine("        ▒▒▒▒▒▒▒▒▒▒▒▄▄▄▄░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒▒▒▒▒▒▄██████▒▒▒▒▒▄▄▄█▄▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒▒▒▒▄██▀░░▀██▄▒▒▒▒████████▄▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒▒▒███░░░░░░██▒▒▒▒▒▒█▀▀▀▀▀██▄▄▒▒▒");
        Console.WriteLine("        ▒▒▒▒▒▄██▌░░░░░░░██▒▒▒▒▐▌▒▒▒▒▒▒▒▒▀█▄▒");
        Console.WriteLine("        ▒▒▒▒▒███░░▐█░█▌░██▒▒▒▒█▌▒▒▒▒▒▒▒▒▒▒▀▌");
        Console.WriteLine("        ▒▒▒▒████░▐█▌░▐█▌██▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▐████░▐░░░░░▌██▒▒▒█▌▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒████░░░▄█░░░██▒▒▐█▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒████░░░██░░██▌▒▒█▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒████▌░▐█░░███▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒▐████░░▌░███▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒▒▒████░░░███▒▒▒▒█▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▒▒██████▌░████▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒▐████████████▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ▒█████████████▄████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ██████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ██████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        █████████████████▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        █████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("        ████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("");
        Console.WriteLine("██╗░░░██╗░█████╗░██╗░░░██╗  ██╗░░░░░░█████╗░░██████╗███████╗██╗");
        Console.WriteLine("╚██╗░██╔╝██╔══██╗██║░░░██║  ██║░░░░░██╔══██╗██╔════╝██╔════╝██║");
        Console.WriteLine("░╚████╔╝░██║░░██║██║░░░██║  ██║░░░░░██║░░██║╚█████╗░█████╗░░██║");
        Console.WriteLine("░░╚██╔╝░░██║░░██║██║░░░██║  ██║░░░░░██║░░██║░╚═══██╗██╔══╝░░╚═╝");
        Console.WriteLine("░░░██║░░░╚█████╔╝╚██████╔╝  ███████╗╚█████╔╝██████╔╝███████╗██╗");
        Console.WriteLine("░░░╚═╝░░░░╚════╝░░╚═════╝░  ╚══════╝░╚════╝░╚═════╝░╚══════╝╚═╝");
    }

    public static void Comienzo()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⡆⢀⣤⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢀⣀⣤⣀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣀⡀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⡟⢀⣿⣿⣿⣿⡟⢻⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀
⠀⠀⠀⠀⢠⠆⢰⣿⣿⣿⣿⠁⣼⣿⣿⣿⡿⠀⣼⣿⣿⣿⠿⢿⣿⣿⣿⠇⠀⠀
⠀⠀⠀⠀⣿⠀⣾⣿⣿⣿⡟⢰⣿⣿⣿⣿⠃⣸⣿⣿⣿⠏⢠⣿⣿⣿⡿⠀⠀⠀
⠀⠀⠀⢸⡇⢠⣿⣿⣿⡿⠀⣾⣿⣿⣿⠇⢠⣿⣿⣿⡏⢠⣿⣿⣿⣿⠁⠀⠀⠀
⠀⠀⠀⣾⣧⡈⠛⢿⣿⠃⣸⣿⣿⣿⡏⢠⣿⣿⣿⡟⢀⣾⣿⣿⣿⠃⠀⠀⠀⠀
⠀⠀⠀⠿⣿⣿⣶⣄⡉⠀⢿⣿⣿⡟⠀⣾⣿⣿⡿⢀⣾⣿⣿⡿⠁⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠈⠉⠛⠛⠛⠒⠀⠈⠉⠁⠸⠿⠿⠿⠃⠾⠿⠟⠋⠀⠀⠀⠀⠀⠀⠀


███████╗██╗░██████╗░██╗░░██╗████████╗██╗
██╔════╝██║██╔════╝░██║░░██║╚══██╔══╝██║
█████╗░░██║██║░░██╗░███████║░░░██║░░░██║
██╔══╝░░██║██║░░╚██╗██╔══██║░░░██║░░░╚═╝
██║░░░░░██║╚██████╔╝██║░░██║░░░██║░░░██╗
╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝";
        Console.WriteLine(texto);
    }

    public static void Felicidades()
    {
        string texto = @"


█████████████████████████████████████████████████████████████████
█▄─▄▄─█▄─▄▄─█▄─▄███▄─▄█─▄▄▄─█▄─▄█▄─▄▄▀██▀▄─██▄─▄▄▀█▄─▄▄─█─▄▄▄▄█░█
██─▄████─▄█▀██─██▀██─██─███▀██─███─██─██─▀─███─██─██─▄█▀█▄▄▄▄─█▄█
▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▀";
        ImprimirConDelay(texto, 10);

    }

    public static void Fin()
    {
        string texto = @"

░██████╗░░█████╗░███╗░░░███╗███████╗  ░█████╗░██╗░░░██╗███████╗██████╗░
██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██║░░░██║██╔════╝██╔══██╗
██║░░██╗░███████║██╔████╔██║█████╗░░  ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝";
        Console.WriteLine(texto);
    }

    public static void Hulk()
    {
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣾⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⠿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢨⣿⣍⡁⠀⣁⣤⢞⣿⡂⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠔⠀⠀⣀⣷⡎⠉⠣⢔⣁⣈⣿⣷⣤⣀⠀⠀⠈⢳⣶⡤⠄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠟⢳⣶⡶⠟⢻⣿⣿⣿⣶⣶⣿⡿⠟⠛⠋⠛⠛⢿⠉⠉⠀⠀⠀⠀⠙⠂⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠀⠀⠀⠀⣰⠋⠁⠀⠀⠀⠙⢿⣿⣿⠟⠋⠀⠀⠀⠀⠀⠀⠀⠑⣀⠀⠀⠀⠀⠀⠀⠀⢧⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣶⣇⣠⣾⠁⠀⠀⠀⠀⠀⣀⣀⣿⣧⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣽⣿⣦⣄⣾⠀⣼⠀⣼⣤⡀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣷⣶⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣶⣶⣶⣾⣿⣿⣿⣿⣿⣿⣾⣿⣿⡿⠃⢱⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠟⠋⠋⠙⣿⣿⣿⣿⣿⣿⣿⠟⠋⡉⠉⠛⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠁⠈⠙⠛⠿⠃⠀⢸⡇⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⢀⠄⠀⢄⣀⣼⣿⣰⡂⠀⢀⣿⣿⣿⣿⣿⡿⠖⠀⠈⠉⠉⠈⠙⠻⢿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠰⣿⣿⠀⠀");
        Console.WriteLine("⠀⠀⠀⢀⠞⣦⣤⣤⡿⠛⢻⣿⣿⣶⣿⣿⣿⣿⣿⣿⣷⣤⣤⣴⣶⣦⣤⣤⣤⣾⣿⣿⣿⣿⣿⣿⡿⢿⣷⣿⣷⡐⣦⡄⠀⠀⠹⣿⣆⠀");
        Console.WriteLine("⠀⠀⠀⣼⣾⣿⣿⡏⠀⠀⠀⣹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⣉⣀⣀⣀⣀⣀⣨⣿⡿⠋⢠⣿⣿⡟⠁⠀⠹⣿⣿⣿⡿⠀⠀⠀⠀⣿⣿⡀");
        Console.WriteLine("⢀⣠⣴⠛⠹⠙⠟⠈⣶⠶⠾⠋⠜⠛⣻⣿⣿⣿⣿⣿⣿⣏⣁⣀⣤⣀⣀⣀⣼⣿⣦⣶⣿⣿⣿⣧⣄⠀⠀⣿⣿⣿⣿⣀⠀⠀⢀⣿⣿⡇");
        Console.WriteLine("⠻⣿⣿⣶⣷⡀⠸⣶⠋⠮⠶⣡⣴⣾⣿⠟⠁⣹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡉⠀⠀⢿⣿⣿⣿⡇⠀⣰⣿⣿⣿⡇");
        Console.WriteLine("⠀⠀⠀⢹⣟⣛⣢⣌⠁⠀⠀⢼⣟⣉⡅⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠉⠙⠿⣿⡇⠀⠀⠈⢿⣿⣿⣷⠀⢰⣿⣿⣿⡇");
        Console.WriteLine("⠀⠀⠀⣿⣯⣆⢢⣥⣈⣵⣿⣿⣿⠟⢁⣴⣿⡟⠉⠙⣿⣿⣿⣌⣿⣉⣴⣿⣿⣿⣿⣧⡀⠀⣾⣿⣿⣦⠀⠀⠈⣿⠿⠛⢿⣿⣿⣿⣿⠇");
        Console.WriteLine("⠀⠀⠀⠉⠛⠛⠉⠛⠛⠛⠉⠀⠀⠀⣸⡿⠉⣣⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠙⢷⣴⣿⡟⢿⣿⢀⣴⡋⠀⢀⣠⣴⣿⣿⣿⣿⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡇⡇⣴⠿⠟⢻⠿⣿⣿⣿⣿⣿⡿⣿⣿⣿⡀⠀⣸⣿⣿⣧⣿⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣷⡿⢧⣤⣴⠇⠀⢸⣿⣿⣿⠟⠘⢻⣿⣿⣿⣦⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⡟⠀⠀⣿⣧⣤⣤⣾⣿⣿⡏⠀⠀⠀⢻⣿⣿⣿⣿⣏⠁⠹⣿⣿⡇⠀⠉⠛⠛⠛⠿⠿⠛⠃⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢶⣇⡀⠀⣿⣿⣿⣿⣿⣿⣿⡁⠀⠀⠀⢾⣿⣿⣿⣧⣿⠛⠻⣿⣿⣷⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠸⢻⣿⣿⣿⣿⣷⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣿⣿⣿⣿⣿⣾⣿⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⢻⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠙⣿⣿⣿⣷⣾⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠔⠫⠌⠉⢽⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀⠀⣿⣿⣿⡿⠛⠉⠀⠉⢢⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣠⣴⣺⠕⠉⠐⠀⠀⠈⢻⣿⣿⣛⣉⣻⣷⠀⠀⠀⠀⠀⠀⣿⡿⠋⠀⠀⠀⠀⠀⠀⠁⠠⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀     ⠒⠚⠿⣽⣍⣀⣀⣤⡶⠖⠀⠰⠿⠟⠛⠛⣛⣿        ⣿⣇⣀⠀⠀⠀⢆⠀⠠⡀⠢⣓⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠉⠻⠦⠤⠤⠾⠶⠀⠚⠊⠁⠀⠀⠀⠀⠀⠀");

    }

    public static void Spiderman()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠂⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⠶⠒⠒⠛⠉⠉⠛⠛⠒⠶⢤⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠓⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣽⠶⠒⠺⠿⠳⣶⣦⣄⡀⠀⠀⠀⠸⡟⢶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣿⡟⠉⠀⠀⠀⠀⠀⠈⢚⣷⣭⣹⣶⣄⠀⠀⢷⠀⠨⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⡟⠙⠁⠀⠀⠀⠀⠀⢀⣴⠟⠁⢿⣌⠉⠙⠻⣄⠘⢦⡀⢻⣿⡍⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣏⣁⠀⠀⠀⠀⢀⣤⡾⠛⠁⠀⠀⠀⢻⡄⠀⠀⢹⣦⠀⠳⣼⣿⣿⡄⠀⠀⠀⠀⠀⠀⠘⠀⠀⠀⠀⠀⠀⠠⠀⠀⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠠⣤⡀⠀⠀⠀⠀⠀⠀⠀⣿⡟⠙⠻⠶⣦⣶⡟⠁⠀⠀⠀⠀⠀⢀⠈⢿⡄⠀⢈⣻⡄⠀⣿⣿⢿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⠙⢷⣄⠀⠀⠀⠀⠀⣿⣷⠀⠀⠀⣠⣍⠻⣦⣄⡐⠳⠂⠀⠈⢷⢘⣧⣀⣀⣸⣧⣹⣿⠏⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣇⠀⠀⠀⠀⣿⣿⠀⠀⠀⣿⣷⣭⣬⣉⠝⢄⠀⣀⣠⡶⠟⢻⡍⠉⢻⣿⣿⠏⠀⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡀⠀⠀⠀⢿⣿⣄⠀⣠⡏⢽⠛⠯⣭⠀⢀⣼⠟⠁⠀⠀⠸⣷⠀⣽⣿⡏⠀⠀⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠃⠀⠳⣄⡈⣿⣿⣞⣿⠛⠺⡶⣤⣄⣠⡿⠃⠀⠰⣤⡀⠀⣿⣄⣿⡟⠀⠀⠀⠀⠘⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⢻⣿⣿⣿⣷⣶⣼⣿⣿⣟⠷⣦⣄⡀⠈⢻⣾⠿⣿⣿⠃⠀⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣟⠉⠉⠙⠛⠛⠛⠿⠿⠿⠿⢿⣷⣿⣄⣴⣿⣿⡀⠀⠀⠀⠀⠀⣇⠀⠐⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣨⣿⣿⣿⣿⠙⢷⣄⡀⠀⢠⡿⠀⠀⠀⢻⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣦⣄⣀⡀⠀⠀⣀⣠⣴⣿⡿⠋⢹⡟⣿⠠⡄⠙⣿⣿⣿⡇⠀⠀⠀⠀⢷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⠿⡛⠉⠉⠀⠀⣸⡷⢿⣆⢹⡄⠉⠙⣾⠇⠀⠀⠀⠀⠈⠳⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣷⣌⢿⣭⠙⠠⡀⠈⠉⠛⠓⠶⣿⠿⢻⡏⠈⣧⠀⢰⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣷⣹⣿⢿⣄⠀⠀⠀⠀⢰⡟⠀⢘⡇⠀⠹⣤⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣀⠈⠙⠻⣦⣄⣸⣿⣁⣤⣾⡷⠀⠀⣿⣿⠹⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣻⣷⣄⡀⠀⠈⣿⠟⠋⠁⢸⡇⠀⢠⡟⢻⣄⣿⣷⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣾⣿⣿⣿⣿⣿⣶⣾⣏⡀⠀⡀⣸⣧⣤⣿⣇⣼⡏⠀⠹⣆⠉⠛⠶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣾⠛⣿⣥⠿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⣿⢼⣟⠉⣷⠀⠀⠘⣧⡀⠀⠀⠉⠻⢶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⣾⠿⠋⢁⣠⣴⢿⣅⣴⣿⣿⠉⢻⣿⣿⣿⣿⣿⡿⣿⠋⠁⣾⣿⣿⣿⠄⣰⡞⠛⢿⡶⢶⣶⣶⣄⣙⢿⡳⢦⣀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣠⣴⣾⣿⠟⠛⣦⣠⣴⠟⠉⠀⢀⣽⣿⢟⢿⡇⠈⡿⠋⣿⠛⠋⢠⣿⣀⣼⣿⡟⣿⡈⣷⣏⢀⣠⣼⠿⣟⠁⠀⣀⣙⣿⣿⣦⡉⠻⣦⣤⣄⣀⠀⠀
⠀⠀⢀⣤⣶⣶⣿⢟⣿⣿⡻⢿⠿⣯⣤⣠⣤⣿⠛⠷⣦⣤⣴⣿⠟⠋⢤⣿⡷⠲⢤⣼⡿⠐⠒⢺⣟⣿⢃⣸⣧⡬⢿⣦⣻⡟⠉⠀⣀⣽⡶⠛⠛⠉⠙⠛⠛⢿⣛⠛⠛⠛⢏⣛⡶
⠀⣰⣾⣿⢛⣧⣿⠿⡿⣩⠀⠈⣀⣴⡿⢛⣛⣛⠛⠛⣿⡿⣿⣽⣶⣶⣾⣿⣧⣀⣀⣿⣧⣤⣶⣾⣿⣿⣿⣿⡷⠶⠶⠿⠿⣷⣶⡟⠋⠁⠐⣄⠀⠺⢶⣄⣀⣀⣙⣦⣤⠖⠋⠉⠀
⣴⣿⣯⣾⡟⠉⡄⠀⠒⠨⢹⣶⠿⣷⣄⣠⠟⢉⣰⡿⠃⣀⣤⣾⣿⠟⠛⠟⣻⣿⣟⠿⣿⣭⣉⠏⠀⠀⠀⢠⣷⠀⠀⢠⣴⣿⠏⣿⠄⠀⠀⣘⣧⣠⣶⠾⠋⠉⠉⠉⠹⠳⣤⡀⠀
⣿⣨⡏⠿⣧⠀⠂⠀⢀⣴⡟⠁⠀⠀⣈⢉⣻⣾⣿⣿⣿⡿⠉⢻⣯⣤⣄⣀⣿⠋⣿⣷⣄⠈⠉⠻⠶⣤⡀⠀⣿⠀⠀⢸⣿⣻⠀⣿⡷⠐⠉⠉⠙⣧⡀⠀⠀⠀⠀⠀⠀⠡⡀⠙⠆
⠛⣿⡟⠀⢹⣷⣄⣀⣼⣟⠀⣰⣾⣿⣿⣿⣿⠿⠛⣋⣡⣴⣿⣿⡿⢿⣏⡙⠿⢾⣿⣻⣿⢿⣦⣄⠀⠸⠻⣶⣿⠿⠛⠛⣿⣥⡀⣿⣷⠀⠀⠀⠀⢹⣧⠀⠀⠀⠀⠀⠀⠀⢃⠀⢀
⢠⡽⣿⠔⠈⢿⣤⣿⣿⣷⡿⠛⣿⣿⠟⣋⣡⣶⢺⡿⣿⣼⣿⣿⣡⣾⣿⣿⣦⡄⠉⠛⢿⣾⠏⠻⣿⣄⡤⣺⣿⣷⣦⣘⢿⡇⠆⠸⣿⣷⣂⠀⢀⡀⢻⣄⣀⣀⡠⠤⠤⠤⠄⡖⠈
⢾⠀⣿⣾⣧⢸⣿⠟⠉⠈⠵⠛⣩⣴⠾⢹⣿⣯⢰⣇⢸⣿⣾⣿⣿⣍⠻⣿⣿⣿⣶⣄⠀⠙⠻⣦⡘⢻⣷⣄⠀⢻⡌⠻⣾⣿⣯⠀⢹⣿⣿⣿⣿⣶⣾⣧⣤⣀⠀⠀⠀⠀⠀⠸⠀
⢸⢸⣿⣒⣫⡿⠁⣀⣠⡶⣦⡾⠯⣝⡆⣿⣷⡒⢸⣷⢀⣿⢿⣿⣿⣿⣷⡈⠙⢿⣿⣿⣿⣦⣤⡬⢿⡿⠋⠉⢻⣿⣇⡀⠀⠙⢿⣇⠨⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣄⡀⠀⠀⡇
⠸⢸⣇⣒⡊⠀⠀⠰⣯⣾⠏⠀⣴⢉⣼⡟⠹⢣⣾⣯⠘⣿⣿⢹⣟⠻⣿⣿⣦⣀⠙⢻⣿⣿⣿⣷⡀⣠⠀⣀⣫⡿⢿⣿⣟⣉⠉⢇⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⣀⢸
⠇⢈⣿⣟⠛⣻⠷⢶⣽⣅⣀⣠⡿⣻⣋⠀⣧⣾⠟⣩⣾⣿⡇⠻⣿⣧⡛⢻⣟⣿⣷⣦⣤⣭⠁⠈⠛⣿⣾⠟⠁⠀⠀⢻⡾⠿⣦⠸⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⠈        ";
        Console.WriteLine(texto);
    }

    public static void Wonderwoman()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣠⣶⣿⣿⣿⣿⣿⣿⣿⣿⣶⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣴⣾⣿⣿⣿⠿⠛⠋⠩⠽⠿⣿⣿⣿⣿⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣠⠴⣿⣿⣿⣿⡟⠿⣨⡾⣓⠄⠀⠀⠈⠙⠻⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣠⠋⠀⠒⢚⡛⠻⠿⡟⠀⠘⢿⣀⡤⣀⣠⣤⡀⠀⠈⢻⣿⣿⣿⠘⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣼⠁⢀⡴⠞⠛⠻⢿⡶⠁⡶⡀⠀⠙⠻⠿⠿⣿⣿⣷⣦⡀⢻⣿⣿⠀⠘⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢰⡇⢠⠋⣠⣶⣾⡿⠊⣤⠒⠀⢉⠜⠁⠀⠀⠀⠀⠀⠉⣿⣿⡈⣿⣿⣇⡀⢿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠸⡇⠀⣼⣿⣿⣿⠁⠀⠀⣇⠔⠠⠆⠀⠀⠀⠀⠀⠀⠀⢹⣿⣇⢸⣿⣇⢧⢸⣿⣿⣿⣿⣿⣿⣦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢇⠀⣿⣿⣿⣿⠀⠀⠀⠀⢀⣀⣀⡀⠀⠀⣀⣀⣀⣀⠈⣿⣿⢸⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣗⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠸⡄⠹⣿⣿⣿⣠⡴⠚⠉⠁⠀⠀⠀⠀⢀⣤⣤⠤⢭⡙⣿⣿⠸⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢷⡄⠈⢿⣿⡟⠛⠷⣄⠀⠀⠀⠀⠀⠛⣁⣤⣤⣀⣠⠸⣿⣆⡌⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠈⣿⣆⠈⣿⣾⣷⡾⣿⣿⣆⠀⠀⠉⢈⡎⠛⡿⣿⠟⠀⠻⣿⣾⢬⡻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣿⣿⡄⢸⣿⠉⠓⠼⠛⡹⠀⠀⠀⠀⠀⠀⠈⠁⠀⠀⠀⠉⠻⢷⡯⢶⣍⠻⣿⣿⣿⣿⣿⣿⣿⢻⣿⣿⣷⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣸⣿⣿⡇⢸⣿⠀⠀⠀⢠⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠃⣸⣿⡕⠙⣿⣿⣿⣿⣿⣿⡘⣿⣿⣿⡄⠀⠀⠀⠀⠀
⠀⠀⠀⣰⣿⣿⣿⣇⣿⣿⡀⠀⠀⠘⣆⠀⠴⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠉⢉⣿⣿⣷⠀⣿⣿⣿⣿⣿⣿⡇⣿⣿⣿⡇⠀⠀⠀⠀⠀
⢸⠀⣰⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠘⣤⣫⣿⣿⣿⠀⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⠁⠀⠀⠀⠀⠀
⠘⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⢾⣿⣛⣛⣿⡶⠂⠀⠀⠀⠀⢰⢷⣸⣿⣿⣿⣿⠏⣰⣿⣿⣿⣿⣿⣿⢠⣿⣿⠏⠀⠻⣷⣄⠀⡀
⠀⠙⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠈⠿⠿⠿⠟⠁⠀⠀⠀⠀⠀⣾⣦⣙⣛⣻⡿⠋⣰⣿⣿⣿⣿⣿⣿⢃⣾⣿⣯⠀⠀⠀⢸⣿⡇⢡
⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⢿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠴⢻⣿⣿⣿⣏⣤⣾⣿⣿⣿⣿⣿⣿⠇⣼⣿⣿⣿⣠⣀⣠⣾⣿⣇⡜
⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⡆⠙⢿⣷⣄⣀⣀⣀⣠⡤⠖⠋⠀⠀⣄⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃
⠀⢀⡏⠀⠀⠀⠈⠉⢻⣿⣿⣿⣶⡌⠻⣿⣿⣿⣯⠁⠀⠀⠀⠀⠀⣹⣷⣝⣻⣿⣿⣿⣿⣿⣿⣿⣿⡇⠈⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀
⠀⠘⣧⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⡀⢹⣿⣿⣿⡄⠀⠀⠀⠀⠀⠙⢯⡻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢻⣿⣿⣿⣿⣿⣿⠏⣠⡆⠀
⠀⠀⠘⢷⣤⣤⣤⣾⣿⣿⣿⣿⢻⣿⡇⢸⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠉⠛⢿⣿⠿⠿⠿⢿⣿⣿⣿⣷⡀⢻⣿⣿⣿⣿⣿⣿⠟⠀⠀
⠀⠀⠀⠰⣄⣠⣤⣶⣿⣿⣿⠏⢀⣿⣗⣼⣿⣿⠿⠛⡄⠀⠀⠀⠀⠀⢀⡠⠚⠁⠀⠀⠀⠀⠀⠀⠈⠙⠻⣷⣤⣽⣿⣿⣿⣿⡗⠀⠀⡀
⠀⠀⠀⠀⠙⠯⠉⠉⠉⠉⠁⢀⣼⣿⣿⣿⠟⠁⠀⠀⡇⠀⠀⠀⠀⠐⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣤⣴⠟⠀
⠀⠀⠀⠀⠀⠘⣄⡀⠀⠤⠐⣡⣿⣿⣿⠏⠀⠀⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⡿⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣿⣿⠿⠃⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠛⠛⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⠟⠋⠁⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠴⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡆⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢀⣤⠞⢟⠁⠀⠀⠀⢀⠀⠀⠀⣀⣀⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢀⠴⡏⠈⡄⠘⡆⠀⣠⡶⠃⣀⠔⠊⠁⠀⠀⠈⠙⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⡇⠀⠀⠀⠀⠀
⠀⠀⠀⠀⡴⣁⠀⠘⣆⠸⡀⢰⠎⣼⡡⠊⣁⠔⠊⠉⠉⠙⠒⢤⡀⠙⢦⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠃⠀⠀⠀⠀⠀
⠀⠀⠀⡼⣄⠈⢣⡀⠘⡀⠱⠃⢠⠋⡠⠚⢁⡠⠔⠚⠓⠢⣄⠀⠙⢦⠀⠳⣄⣾⡿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣇⠈⠙⡄⠱⡀⢡⢀⡤⠘⠊⢀⠔⢁⣀⣀⣀⠀⠀⠈⠳⡀⠀⠳⡀⠸⡏⠀⢱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢻⡆⠀⠈⢆⢳⣸⠎⢱⢀⣴⠗⠊⠉⠀⠀⠀⠉⢢⡀⠀⠘⣆⠀⠙⡄⢣⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠈⢿⣄⠀⠘⡆⠁⡀⠸⠋⠀⣀⠤⠐⠚⠓⢄⠀⠀⠑⣄⠀⠈⢧⡀⣸⠈⢇⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠙⢷⠀⢹⣰⢣⠀⢀⡞⠁⠀⠀⠀⠀⠀⠳⡀⠀⠈⣣⡤⠖⠋⠀⠀⠘⡄⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⡄⠈⠇⠈⡆⡾⠀⠰⣦⡀⠀⠀⠀⠀⠈⠒⠉⠁⠀⠀⠀⠀⠀⠀⠁⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠷⠀⠀⠀⠘⠃⠀⠀⠈⠙⠛⠒⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void Batman()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡂⢸⠀⢀⣀⣤⣤⣤⣤⣄⡀⢰⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠘⣷⡿⠋⠀⣀⣀⣀⣈⡙⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⠙⠁⠔⢻⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⢀⢈⠉⠹⠿⢿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⣰⡁⠀⠀⠹⣿⡎⠀⣀⣹⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⢹⡿⢷⣢⣤⡟⣧⣭⣶⣿⣽⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⢩⠙⠶⣬⡉⠇⣿⣿⣿⣿⡟⡿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠆⠆⠀⡈⠓⠠⣿⣿⣿⠟⣼⢡⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠈⣴⠀⠐⢒⣲⣼⣿⣾⣆⣷⢹⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⡀⢌⠳⢄⠈⢀⣀⣼⣿⣿⣿⢸⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⣶⣿⣿⣿⣿⣷⡀⠛⣦⡙⠳⣶⣾⣿⣿⡇⢸⣿⣷⣦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⣿⣿⣿⣿⣿⣿⣿⡿⢿⣷⡄⠀⠙⢦⣤⣿⡟⠁⢱⡘⣿⣿⣿⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣀⣤⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⣠⣤⣼⣿⣶⣤⣀⠽⢿⡶⠤⠾⣷⣶⣿⣿⢿⣿⣿⠿⠿⣷⣦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣠⣾⡿⠟⠉⣉⣠⣴⣒⣀⣤⡤⠤⠤⣤⣶⣶⣶⡶⠟⠋⠁⠀⠀⢀⠁⠀⠀⠀⠈⠉⠓⢶⣶⣮⣝⠲⣤⣉⠛⠻⢿⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢀⣼⣿⡿⠖⠚⢉⣡⠴⠞⣉⡡⠴⢖⣫⣭⠶⢛⣿⣿⣤⣀⡀⠀⠀⠀⣸⣷⣿⡀⠀⠀⠀⣀⣼⣿⣿⣟⢿⣶⣿⣍⡓⠶⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢹⣿⣧⣴⠶⣛⡫⠵⣒⣩⡤⠶⠚⠋⠁⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢻⣿⡿⣯⣑⠒⠾⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢀⣿⣋⡵⢖⡩⠔⠚⠉⠁⠀⠀⠀⠀⡀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⢿⣿⠀⠈⣿⡇⠈⠻⢿⣝⡲⢿⣿⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢘⣿⠏⣴⠃⠀⠀⠀⠀⠀⠀⠀⠀⢀⠇⠀⠀⠀⠙⠉⠀⠀⠀⠙⠿⠛⠛⢿⣿⣿⣿⠿⠛⠋⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠹⢿⣾⣿⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠸⣯⣾⠃⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀⠀⠀⠀⠈⠻⣿⡇⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢿⣿⣆⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠇⠀⠀⠀⠀⠀⢰⡿⠁⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣿⠁⠈⠳⣄⠀⠀⠀⠀⠀⢹⣿⣿⣷⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⡀⠀⠀⠀⠀⢠⡿⣧⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⣾⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⠿⣝⠛⠳⠶⠤⠤⠤⠤⠤⠤⠤⠤⠶⣿⣿⡷⠦⠤⠤⠤⠤⠤⠤⢤⣴⣿⠉⠣⠀⠀⠀⠐⠉⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀
⠀⢠⣿⣿⣿⣦⡀⠀⢀⠀⠀⠀⠀⠀⢸⣏⠳⡀⠑⠀⠀⠀⠀⠀⢀⣀⠀⠀⠀⠀⠈⣿⠀⠀⠀⠀⢀⠀⠀⠀⠀⢻⡟⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀
⠠⠛⠛⠿⣿⠿⣿⣷⣤⣱⣔⣄⠀⠀⣸⣿⣦⡈⠂⠀⠀⢀⣤⣾⠟⠁⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⢳⡄⠀⠀⣸⡇⠀⠀⠀⠀⠀⣠⣴⣾⡾⣿⣶⣦⣤⠀⠀⠀⠀
⠀⠀⠀⠀⠉⢠⠹⣿⣿⣿⣿⣿⣿⣿⠿⠿⣿⣿⣷⠶⠾⠿⣿⣿⠀⠀⠀⠀⠀⠀⢰⣿⣄⣀⣀⠀⠀⠈⣿⣦⣴⣿⣷⡀⠀⠀⢀⣼⣿⣿⡧⠀⠀⠀⠉⠛⠧⠀⠀⠀
⠀⠀⠀⠀⣰⡇⠀⠘⠛⠻⣿⠋⣿⠿⠀⠀⠻⡏⠀⠀⠀⠀⠈⣿⣆⣠⣤⣴⡤⠴⠿⠿⣿⠅⠀⠈⠑⢦⣿⣿⡿⠿⢿⣿⣶⣤⣿⣿⡯⢻⣷⢀⠴⢶⣦⡀⢠⣄⡀⠀
⠐⢶⣆⠀⢸⡇⠀⠤⠶⣾⣮⡁⠃⢀⣧⡀⠀⠠⣤⣀⣀⡀⠀⢿⡿⠟⠛⠏⠀⠀⠀⠀⠙⠀⠀⠀⠀⠛⢻⣿⡇⠀⠀⠈⠟⠻⢿⣿⠁⠀⠙⠃⠀⠘⣿⡿⠿⠛⠛⠒
⠀⠈⠿⠿⣿⠀⠀⠀⠀⠈⠻⣧⣴⡿⠟⠃⠀⣴⡏⠉⠻⢿⣦⠘⠁⠘⣄⠀⠀⠀⣠⡶⠊⢀⣀⣤⣤⣤⣄⣻⣿⡆⠀⠀⠀⣀⡄⠉⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠟⠋⠀⠀⠀⢸⡿⠁⠀⠀⡌⠙⠇⠀⠀⠻⢿⣆⢸⡿⠁⠀⠀⠀⠀⠉⠛⠛⠛⠿⠀⢀⣴⠟⠻⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣇⠀⠀⢀⡇⠀⠀⠀⠀⠀⠀⠉⠻⠀⣀⣤⣶⣤⠄⠀⠀⠀⠀⠀⠀⣿⠟⠀⢸⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠀⠀⣾⣿⡀⣀⣀⣀⡀⠀⠀⠀⠀⠉⠁⢼⣧⣴⣤⡀⠀⠀⠀⠸⠃⠀⠀⠀⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⠟⠛⠿⠛⠛⠉⠀⠀⠀⠀⠀⠀⠘⠋⠉⠉⠣⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void Harley()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣠⡤⠖⠒⠒⠒⠒⠒⠦⣄⡀⠀⠀⠀⢀⣠⠞⠋⠁⣀⣤⣌⡉⠓⢦⣤⠴⢋⠉⠙⠓⢦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣠⠞⠁⣀⡤⠖⠚⠉⠉⠉⠉⠉⠛⢶⣤⣴⠋⠀⢀⣴⡾⠋⠀⠀⠉⠓⢦⡈⠳⣼⡄⠀⠀⠀⠉⠳⣄⣀⠴⠶⠚⠉⠛⠲⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢀⡾⢁⡴⠚⠁⠀⠀⠀⣀⡤⣞⣿⣿⠿⣿⣿⠓⢆⣴⡿⠋⠀⠀⠀⠀⠀⣠⠄⠈⠳⣜⣧⠀⢀⣠⠤⠒⠛⠓⢮⣉⠉⠉⠙⠳⢤⡙⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢠⣞⡴⠋⠀⠀⠀⢀⡴⢊⡵⠚⣵⠛⢁⡼⠋⠘⣷⣿⠟⠁⠀⠀⠀⢀⡴⠋⠉⠛⠲⢤⣈⢻⡔⠋⠀⣀⣀⣀⡀⠀⢻⡳⣄⠀⠀⠀⠙⢾⣳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢠⣿⠞⠁⠀⠀⢀⡴⠉⣠⠞⢁⡾⠁⢠⡞⠁⢀⣼⢫⡏⠀⠀⠀⠀⣰⠏⠀⠀⠀⠀⠀⠀⠈⠙⠒⠚⠉⠉⠀⠈⢿⣳⠀⢣⠘⣆⠀⠀⠀⠀⠹⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⢀⣾⠋⠀⠀⠀⢠⠏⠀⣰⠏⠀⡼⠁⢠⡟⠀⢀⡾⢁⡟⠀⠀⠀⢀⡾⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⢧⠘⡇⠸⡆⠀⠀⠀⠀⠘⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣼⠃⠀⠀⠀⣠⠏⠀⢰⡇⠀⢠⡇⠀⡿⠀⠀⣼⠁⢸⠁⠀⠀⢠⡞⢸⡗⠒⠲⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣼⡆⢸⠀⢳⠀⠀⠀⠀⠀⢹⡄⠀⠀⠀⠀⠀⠀⠀⠀
⢰⠇⠀⠀⠀⢠⡇⠀⢠⡟⠀⠀⣸⠁⠀⡇⠀⢰⡇⠀⣿⠀⠀⠀⡾⣦⣀⣀⣶⣴⣈⡻⣆⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠖⢻⣧⡇⢸⠀⢸⠀⠀⠀⠀⠀⠈⣧⠀⠀⠀⠀⠀⠀⠀⠀
⣼⠀⠀⠀⠀⣿⠀⠀⣼⡇⠀⢠⣿⡆⠀⢳⡀⣼⡇⠀⢻⠀⠀⠀⡇⠘⣿⠋⠉⢉⣉⠙⢮⡧⣤⠀⠀⠀⢀⣀⣴⠿⠛⢿⣾⠟⠃⢸⠆⢸⠀⠀⠀⠀⠀⠀⢻⠀⠀⠀⠀⠀⠀⠀⠀
⣿⠀⠀⠀⢰⡇⠀⠀⣿⡄⠀⠘⢸⣧⠀⠈⢷⠛⣷⠀⠘⡆⠀⠀⢳⠀⠸⣧⣄⣈⠉⣓⣈⣷⠈⠀⠀⠀⢸⡟⠁⠒⡄⢀⡿⠃⠀⢸⣀⣼⠀⠀⠀⠀⠀⠀⡿⠀⠀⠀⠀⠀⠀⠀⠀
⣿⠀⠀⠀⢸⡇⠀⠈⣿⢃⣠⣼⣾⣿⣆⠀⢸⠀⠋⣧⠀⢿⠀⠀⢸⠀⢠⡄⠈⠉⠉⠉⠉⠀⠀⠀⠀⢀⡈⠓⠲⠶⠶⠛⡇⠀⡀⣸⣿⡇⠀⠀⠀⠀⠀⣽⠃⠀⠀⠀⠀⠀⠀⠀⠀
⣿⡆⠀⠀⢸⡅⠄⠀⣿⣿⣿⣿⣿⣿⣿⡆⠀⢧⠀⠸⡇⠈⡇⠀⠘⡆⡾⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠈⢧⡀⠀⠀⠀⠀⣿⣰⢠⣿⡟⠀⠀⠀⠀⢀⣼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣿⣿⡀⠀⢸⡇⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣆⡈⠓⢤⣹⠀⢹⠀⠀⡇⣇⠀⠀⠀⠀⠀⠀⠀⠀⠻⠿⢿⡶⠋⠀⠀⠀⠀⣿⢃⣾⡟⠀⠀⠀⠀⣠⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠿⣿⣧⡀⢸⡇⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣟⠶⣤⣈⣇⠘⡄⠀⡇⢹⠀⠀⠀⢶⣤⣀⣀⣀⣀⣀⡀⢀⣀⣠⠀⠀⣼⠃⣼⡿⠁⠀⠀⢠⣾⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠈⠻⣮⣷⠄⡀⠀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⢦⣭⣿⠀⡇⢀⡇⠘⡇⠀⠀⠀⠉⠻⢿⣿⣿⣿⣿⣿⠟⠁⢀⣾⠏⣼⡿⠀⠀⢀⡴⢫⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠈⠙⢦⣕⠦⣄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⣸⣿⠀⠀⢸⣿⣦⡹⡄⠀⠀⠀⠀⠀⠈⠉⠙⠋⠁⢀⣰⠋⡄⣼⡿⠁⠀⢠⡟⢁⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠉⢳⣌⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢠⣿⣿⠀⠙⠷⣄⡀⠀⠀⠀⠀⠀⠀⠀⣠⠟⡇⠠⡸⢿⡇⠀⢰⡏⠀⡾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣾⣿⣿⣿⣿⣿⣿⣿⣿⠟⠿⣿⣀⣿⣿⣟⠀⠀⠀⠀⠙⠲⠤⣄⣀⢀⣠⠞⠁⠀⢧⢠⢷⢸⡄⠀⢸⡇⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠘⡾⠙⢻⣿⣦⣄⠀⠀⠒⠲⠤⠤⠙⣿⣿⣷⣦⣄⡘⡿⠈⢷⡇⠀⠀⢻⣼⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠁⢠⣾⣿⣿⣿⣿⣶⣶⣦⣤⠶⣾⣿⣧⣝⡿⣿⣿⣷⢦⣬⣳⡀⠀⠀⢻⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣤⣤⣴⣾⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢻⣿⣿⣿⣿⣷⣾⣿⣿⣶⣯⣻⡶⣤⣨⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⠟⠿⠿⣿⣿⣿⣻⣿⣿⣿⠿⠿⣧⠀⠈⠙⠻⠿⣿⣿⣿⣿⡀⢈⡿⠃⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣭⣟⡦⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣠⠖⠋⢀⡠⠴⠛⠀⠉⠙⢿⣿⣿⣷⠀⣀⣽⡄⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠁⠀⠀⠈⢿⡛⠛⠻⣏⠛⠿⢿⣿⣿⣿⣿⣾⣿⣷⣦⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣠⠞⢁⡴⠞⠉⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢷⣦⣤⣽⡆⠀⠀⠈⠹⡟⠿⣿⣿⣿⣿⣿⣿⣷⣦⣤⡀⠀⠐⡶⢠
⠀⠀⢀⡴⠟⣡⠞⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⡟⣿⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⡀⠀⠀⠀⢹⣦⠀⠉⠙⠻⢿⡿⠛⠛⠉⠁⠀⠀⠀⠈
⢀⠶⠋⣀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⠀⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣧⠀⠀⠀⠘⣿⣦⣴⠷⠶⢾⣿⣤⣶⣿⢀⡼⠀⠀⢠
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠘⠦⣿⣿⣿⣿⣿⣿⣿⣦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣦⡀⠀⠀⣿⠇⣿⠇⠀⠸⣿⡸⢿⣿⣿⣷⣧⣴⣇
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡴⠻⣄⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣄⠀⣿⡇⣿⠀⠀⠀⠈⢷⡜⣿⣿⣿⣿⣿⣿
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠞⠁⠀⠀⠈⠓⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣄⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⣿⣂⣿⠀⠀⠀⠀⠙⢻⣌⣿⣿⣿⣿⣿
⠀⠀⠀⠀⠀⠀⠀⢀⣠⡶⠟⠛⣧⡀⠀⢀⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣿⠀⠀⠀⠀⠀⢸⠛⢿⣿⣿⣿⡟
⠀⠀⠀⠀⣀⣤⠾⠛⠓⠀⠀⢀⡞⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣿⡆⣥⡾⠷⠶⠶⣤⡏⠀⠀⠈⠙⢛⠇
⣀⣤⣴⠚⢋⠀⠀⠀⣀⣀⠐⠛⠁⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠸⡆⠘⠇⠀⠀⢠⠏⠀⠀⠀⠀⠀⠈⠀";
        Console.WriteLine(texto);
    }

    public static void Joker()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣀⣀⡀⢀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣶⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⣶⣶⡜⢿⣿⣿⣿⢿⣿⣿⣿⣧⠘⢿⢿⣿⣿⣿⣿⣿⣿⣿⣶⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢀⣤⣾⣿⣿⣿⣿⣿⣦⠙⠿⣿⡞⡏⣿⡿⣿⡄⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣤⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢀⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡀⠀⣡⣤⡘⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢉⣹⣿⡀⠀⠀⠀⠀⠀⠀
⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣿⣿⣷⢰⡀⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠛⠉⣽⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀
⣤⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡏⠁⠀⠀⠋⢛⣿⣿⣿⣿⣧⡄⠀⠀⠀
⠸⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠛⠛⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⢁⣤⣿⣷⣦⣄⠀⠚⣿⣿⣿⣿⣿⣿⡆⠀⠀
⢀⠰⢿⠧⠀⢻⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠘⠟⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣄⢘⣿⣿⣿⣿⣿⣿⡀⠀
⠸⣿⢿⣷⣤⣿⣿⣿⡟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⣿⣿⣿⣿⣿⣿⡿⠁⠀
⠀⢸⣷⣶⣾⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠿⣿⣿⣿⣿⣿⣿⠛⠉⠀⠀⠀⠈⢻⣿⣿⣿⣿⠁⠀⠀
⠀⠸⣿⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣈⣿⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⠂⠀⠀
⠀⠀⢿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣾⣿⣿⣿⣿⣿⣿⣿⣶⣤⣄⡀⠀⢨⣿⣿⣿⣿⡇⠀⠀
⠀⢠⠞⢻⣿⣿⣿⣿⡷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⠋⠉⠀⠺⣿⣿⣿⣯⠴⢶⡄
⠀⣾⣶⣶⡿⣿⣿⣿⠁⠀⠀⣠⣴⣦⣀⠀⠀⠀⠀⠀⢀⠀⢸⡄⢰⣿⣿⣿⣿⣿⣿⡿⠛⣿⣿⡿⢿⠆⠀⢸⣿⣿⣿⣠⣾⣿
⠀⢻⣹⣿⡇⢸⣿⡏⠀⠀⠟⠋⠉⠈⢻⣧⠀⠀⠀⠀⠈⢷⡀⣿⣾⣿⣿⡟⣻⣿⡟⢁⡾⠋⠁⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⡿
⠀⠈⠏⠁⣰⣄⣿⣇⠀⠀⠀⣦⣸⣄⣤⣿⣷⣄⠀⠀⠀⢸⣷⣿⣿⣿⣿⢣⡿⢫⣶⣟⣥⣄⣀⣤⣴⣶⡄⣸⣿⡏⣾⡇⠘⠀
⠀⠀⠀⢸⣿⠋⢻⣿⠀⠀⠀⠘⠟⢻⣟⠉⠙⠛⢷⣤⣴⣼⣡⣇⣿⣿⣇⣻⡶⠿⡿⠟⣉⡿⣿⣿⣿⣿⣿⣿⣿⠁⢻⣧⡀⠀
⠀⠀⠰⡎⢻⣦⣈⣗⠀⠀⠀⠀⠀⠀⠭⣰⣶⣶⠿⠟⠉⠏⠈⠉⣿⣿⢾⣿⣷⣌⣙⣋⣉⣠⣿⣿⣿⣿⡉⠁⡏⢠⡾⠏⠃⠀
⠀⠀⠀⢳⡀⢸⠏⠉⠀⠀⠀⠀⠀⠀⣀⡈⠉⠁⠀⠀⠀⠀⠀⠀⠿⠋⠀⢿⣿⣿⣿⣿⣿⣿⣿⠟⠉⠀⠀⠀⠡⠿⠁⠀⠀⠀
⠀⠀⠀⠀⠉⠀⠀⠀⠀⣶⣶⣶⣶⣾⣿⣿⣦⣤⡄⠀⠀⠀⠀⠀⢾⣿⣶⡾⠿⠟⠻⠿⢿⣿⣿⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⡿⣿⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⡟⢹⣿⣿⣿⣷⣿⣿⣿⣷⣾⠇⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⢿⣶⣤⡀⠀⠀⠀⢀⣄⡀⠀⠀⣰⠟⢇⣸⣿⠿⣿⣟⡽⣟⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠁⢻⣿⣿⣷⣶⣤⣀⡀⠙⠦⠴⣿⣾⣿⣿⣿⣿⡿⢿⣾⡿⠉⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠀⠀⠀⠀⢿⣿⡉⠉⠛⠿⠿⣷⢶⣶⣿⣭⠹⡿⠉⠀⠀⢸⣿⠁⢠⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣇⠀⠀⠀⠘⣿⣧⣤⣀⡀⠀⠁⠀⠋⠀⠀⠀⡀⢠⣤⣴⣿⠇⠀⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣦⠀⠀⠀⠘⣿⣤⠀⠉⠓⠂⠀⠀⠠⠟⠛⢛⠉⣴⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⠳⠄⠀⠀⠘⢿⣦⡄⡀⢀⠀⡀⢠⢀⣼⣼⣿⣿⠃⠀⠀⠀⠀⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡆⠀⢱⡄⠀⠈⢻⣿⣷⣬⣤⣿⣿⣿⣿⣿⢿⠅⠀⠀⠀⡞⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⢱⡄⠀⠀⠉⠛⢿⣿⣿⣿⣿⠿⠛⠃⠀⠀⠀⣾⠁⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⡄⠀⠀⢣⡀⠀⢤⣤⣴⣿⣿⣿⣿⣿⣿⣿⡆⠀⣸⣿⠀⣸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢷⡄⠀⠈⢣⡀⠀⠙⠉⠉⠙⣛⠛⢿⣿⣿⠇⢠⣿⡟⣢⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣦⡀⠈⢣⡀⠀⠀⢀⣴⣋⣠⣾⣿⡟⣠⣿⡿⣷⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠦⡄⠙⠛⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⢦⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣹⣿⣍⡉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void Superman()
    {
        string texto = @"
⠀⣰⠐⢲⠉⠉⢻⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡟⠙⡄⠀⡇⠀⢸⡀⠘⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢱⠀⢳⡀⠹⡆⠈⢧⠀⠸⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠘⣦⣀⣓⣀⣙⣂⣈⣧⠀⢸⡟⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢸⡇⠀⢀⣀⡠⠤⠤⣤⡴⡏⠀⢸⣃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠘⣧⡀⠉⠁⠀⣠⠞⠉⠁⠙⠀⠈⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠈⣽⡶⢤⠘⣧⠀⠀⠀⠀⢀⡞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣷⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣴⠃⠹⣄⠀⠈⠙⠒⢲⣾⣍⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⢻⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣿⠀⠀⠈⠓⠶⠶⠖⠋⠀⠙⣧⣀⣤⠖⠋⠉⠙⠳⡀⠀⠀⠀⣰⣇⣠⣻⣷⡏⠙⠉⠀⣨⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡿⣖⠒⠦⣄⠀⠀⠹⣦⣀⣀⣿⠉⠭⠷⡆⠠⢴⣒⠂⢹⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠁⠙⣆⠀⠈⢳⡄⠀⢸⡀⢹⣿⠀⠀⣸⡁⠀⠀⠈⠀⢸⣫⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠈⠻⣦⡀⠀⠀⠀⠀⠀⠀⠈⠁⠀⠀⠸⠆⠀⠀⢹⡄⠀⡇⢀⡇⠀⢠⠬⣈⣀⠀⠀⠀⢀⣻⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠈⠻⣧⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣇⠀⡇⢸⡀⠀⠈⠉⠒⠉⠁⠀⠀⡞⣏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠘⣷⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣀⡇⢈⣧⠀⠀⠀⠀⠀⠀⠀⣴⠃⣿⠉⠉⠙⣆⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠴⠖⠛⠉⠉⠙⠲⣤⡀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠻⣦⡀⠀⠀⠀⠀⢠⠀⠀⠀⠀⠀⠸⣿⠀⣸⠉⠣⢤⣧⣀⣀⡴⠋⠁⡔⣟⣧⠀⠀⢸⠀⠀⢹⣤⣀⠀⠀⠀⠀⠀⣠⡴⠚⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢦⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⠶⢤⣀⣀⢸⠀⠀⠀⠀⠀⠀⠉⠺⣃⠀⠀⢰⠀⠀⠀⠀⠀⣼⠀⠘⢸⠀⠀⡞⠀⢀⡞⠀⠈⠳⣄⣠⠖⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠳
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡄⠀⠀⠈⠛⡆⠀⠀⠀⠀⠀⠀⠀⠈⠓⢤⣈⢷⠀⠀⠀⡼⠁⠀⢀⡟⢀⡾⠀⡠⠋⠀⠀⠀⠀⣿⢀⣀⣠⠤⠤⢴⠖⠛⠛⠉⠉⠁⠀⠀⠀⠀⠀⠈⠉
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣧⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀⣀⣀⡀⠈⠛⢧⣄⡞⠀⠀⢀⡞⣠⢎⣴⠊⠁⠀⠀⠀⠀⠀⡿⠉⠉⠀⠀⠀⠸⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡄⠀⠀⠀⢧⠀⠀⢀⣠⢴⣒⠿⣗⣢⠍⠓⠶⢤⣀⡉⠓⠶⠾⠭⠟⠉⠀⠀⠀⠀⡄⠀⣠⡾⠁⠀⠀⠀⠀⠀⠀⠄⠙⠳⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣄⠀⠀⢸⡄⠀⠘⢧⠻⠖⠋⢁⡠⠐⠒⠒⠢⢬⡉⢻⣒⠤⣄⠀⠀⠀⠀⠀⣼⠷⠛⢧⣄⣀⣤⠴⠚⣗⡦⣤⡀⠀⠀⠘⡇⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢧⡀⠀⠻⣄⠀⠀⠱⣄⠀⠈⠓⠦⠤⣀⣀⠀⠈⢦⠈⣠⣾⡀⠀⠀⢀⡾⠁⠀⢀⠞⠁⠀⠀⢀⣦⡈⣳⢼⡇⠀⠀⠀⡷⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⢮⡀⠈⠁⠤⣀⡈⠳⣜⠿⠓⣒⠀⠤⢉⡛⠣⣬⣽⣣⠷⢀⣴⠟⠒⠶⠤⢼⣀⠙⠒⣛⣽⠿⠵⣿⠟⠁⠂⠀⣰⠇⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⢦⡀⠀⠈⠉⠓⠮⢷⡠⡬⣶⡒⣺⣥⢔⣛⣩⣤⣿⣿⣦⡆⠀⠀⠀⠀⠈⠉⠉⠉⠛⠛⠛⠋⠀⠀⢀⣴⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡦⢄⣀⠀⠀⠀⠙⠛⠛⠉⢉⣉⢽⣿⣠⡿⠟⠋⠁⠙⢶⡒⠛⠓⠲⠦⣤⣀⣀⠀⠀⠀⣀⡴⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣶⣬⣻⣷⡂⠐⣖⠈⣉⣷⣤⣾⡿⠋⠀⠀⠀⠀⠀⠈⠻⣄⠀⠀⠀⠀⠈⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣦⡀⠈⠉⠉⠉⠉⠉⠉⢻⡷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⢦⡀⠀⠀⠀⠀⠀⠀⢷⠙⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠘⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠓⢦⣄⠀⠰⡄⠈⣦⠀⠻⣄⠀⠀⠀⠀⠀⠀⠀⠀⢻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣎⢙⡒⢷⣤⣼⣆⠐⣿⣦⠀⠀⠀⠀⠀⠀⠀⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⣽⣹⡻⠀⠘⠷⡹⡎⠳⡀⠀⠀⠀⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⣇⠀⢷⣻⡀⠘⠳⣤⣄⣀⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⡆⠈⢇⢧⠀⠀⢻⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢦⣸⡄⠳⣄⢈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void Ironman()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣤⠖⠉⠉⠉⣉⣙⣛⣲⣶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣿⣷⣶⣿⠿⠛⠉⠉⠉⠹⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡏⠉⠂⠀⠀⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⡿⢣⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢀⣤⢄⡀⠀⠀⠀⠀⠀⣿⣤⣤⣤⣦⡄⠀⠀⢀⣿⣿⣿⠿⠿⠿⢿⣿⡇⠀⣆⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⠀⢹⡄⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢸⣷⠀⠉⠂⠀⠀⠀⠀⣿⣿⠿⠿⠛⠃⠀⠀⢸⣿⣿⣏⠀⠀⠀⢸⣿⡇⠀⢻⡀⠀⠀⠀⠀⠀⣿⣿⣿⣿⠀⠀⣧⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠘⣿⣧⡀⠀⠀⠀⠀⠀⢱⣤⡀⠀⠀⣿⠀⠀⢸⣿⣿⣿⣷⣶⠀⣿⣿⡇⠀⢸⣧⠀⠀⠀⠀⠀⠘⠿⠿⠿⠀⠀⢹⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣶⣦⡀⠀⠀⢸⣿⣷⣀⣀⣿⣇⠀⢸⣿⣿⣿⠟⠋⠀⣿⣿⠃⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⠛⠋⠀⠀⠀⠀⣿⣿⣿⠿⠟⢿⣦⣾⣿⣿⣿⡶⠀⢠⠿⠃⠀⢀⣼⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀
⢀⣤⣤⣄⠀⠀⠀⠀⠀⠘⣿⣷⣄⣀⣀⡀⠀⢻⣤⣀⠀⠀⢸⣿⣿⣿⣿⣿⡟⠀⠀⠀⠀⣴⣅⡀⠈⠙⠻⢦⣤⣀⠀⠀⠀⠀⠀⢀⡇⠀⠀⠀⠀⠀
⠸⣧⣀⠉⠉⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⠀⢸⣿⣿⣆⣀⣼⣿⣿⣿⣿⣟⠁⠀⠀⠀⢸⣿⣿⣿⣷⣦⣤⣤⣿⣿⣿⣿⠶⠶⠶⡾⠁⠀⠀⠀⠀⠀
⠀⠙⢿⣿⣦⣴⣶⡦⠀⠀⠀⠸⣿⣿⣿⡁⢀⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⠀⢀⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣴⡶⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠙⢿⣿⠋⣀⡀⣀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠈⣇⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿⣷⡀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⢀⠈⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠙⢿⠛⠉⠀⢀⣼⣿⣿⣿⣿⡿⠿⢿⠉⠉⢙⡿⠿⣿⣿⣿⣿⣿⠉⠀⠀⠀⠈⠿⠿⠿⠿⠿⠿⠿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢦⣶⣿⣿⣿⣿⣿⠿⣀⢀⣸⣷⣶⣾⣄⠀⣸⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⢀⡀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿⡇⠀⢨⣿⠋⠁⠀⠈⠻⣿⡁⠀⢻⣿⣿⣯⣄⢸⣿⣶⣶⣾⣿⣿⣿⣿⣶⣶⣶⣶⡆⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢠⡏⢀⠀⣀⠔⠀⠀⠀⠈⣿⣿⣿⣿⡷⠒⢿⣇⠀⠀⠀⠀⠀⣿⡿⠒⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⣼⡁⣿⣾⡏⠀⠀⠀⠀⠀⢹⣿⣿⣿⣇⠀⣸⢿⣦⣄⣀⣠⣼⡿⣄⢀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠛⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢿⣿⣿⣿⡇⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⡁⠀⢹⠟⠛⢻⡅⠀⣨⣿⣿⣿⣿⣿⣿⣿⡿⠛⠛⠛⠿⣷⣦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢸⣿⣿⣿⡇⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣷⣿⣤⣤⣴⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣇⡀⠀⠀⠀⠈⠙⠿⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠈⢿⣿⣿⣷⠀⠀⠀⠀⠸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠈⠻⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠈⠻⣿⣿⡄⠀⠀⠀⠀⠹⣿⣿⣇⠙⠻⠿⠿⠿⠿⠿⠛⠛⠛⠛⠛⠛⣻⣿⣿⣿⣿⣯⡀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣷⣄⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠈⢿⣷⡀⠀⣄⠀⠀⠘⢿⣿⣷⣦⣤⣤⣤⣤⣤⣤⡴⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣶⣦⣄⣀⠀⠀⠀⠀⠀⠀⠈⢿⣦⡀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⣿⣄⠈⢷⣤⡀⠀⠈⠉⠉⠉⠉⠉⠉⠉⠁⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣀⠀⠀⠀⠀⣿⠓⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⠛⢿⣷⣤⣿⣿⣦⣄⣀⣀⣀⣀⣀⣀⣀⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⠀⢹⡄⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠙⢆⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⣠⣬⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠛⠛⠿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⣇⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⣤⣀⠀⠀⠀⠈⠻⣿⣿⣿⣷⡀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⣿⡆⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⡀⠈⠙⠿⣿⣿⣦⣄⠀⠀⠀⠙⣿⣿⣷⡀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⡀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⠛⠻⣿⣿⣿⣿⣷⣄⠀⠀⠙⠛⠿⠷⣄⠀⠀⢸⣿⣿⣧⡀⠀
⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠙⠻⣿⣿⣿⣷⣄⠀⠀⠀⠀⠘⢷⣄⣼⣿⣿⠿⣷⣄
⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⢳⡀⠀⠀⠀⠈⢿⣿⡿⠁⠀⠀⠉
⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡀⠀⠀⢀⣾⡟⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⡀⣠⣿⣿⣷⡀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣹⣿⡿⠉⠙⢷⡀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⠛⠛⠻⠿⣿⣿⣦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⡟⠁⠀⠀⠀⠑⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣄⠀⠀⠉⠙⠻⢷⣦⣀⠀⠀⠀⢀⣠⡶⠋⠉⠻⣷⡄⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠋⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠈⠉⠙⠋⠉⠉⠁⠀⠀⠀⠀⠙⠛⠀⠀⠀⠀⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void Wolverine()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⠀⠀⠀⠀⢠⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣀⣤⣶⣿⣿⣷⣿⣾⢯⣻⣷⣮⣿⣶⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣳⣟⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣟⣿⣿⣿⣿⣶⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣿⣿⣫⣿⣿⣷⣿⣿⣿⣿⣯⣿⣿⣾⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣾⣿⣿⣹⡿⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣾⣿⡿⡻⠛⠙⠙⢻⠿⠿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣿⡁⠀⠀⢀⠀⢠⠀⢠⡨⣹⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⡵⣀⣀⡀⣇⣞⣺⣵⣿⣿⣿⣿⣿⡟⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣯⢿⠿⡿⢛⡉⣿⡿⠟⠙⢿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣟⡄⠀⢠⡅⢿⢶⣀⠀⣽⣿⣿⣾⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣜⣤⣣⣅⡿⣿⣿⣾⣿⣿⣿⣯⣷⠈⠒⠤⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣩⣭⣭⣽⣿⣿⣿⣿⣿⡏⠈⠐⢀⠁⠠⣡⣂⠄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⡿⣦⣿⣿⠛⠋⣾⣿⡿⠂⢀⡀⠬⡲⠈⠉⡫⡀⢤⠬⡢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡙⡌⠄⠉⠀⢺⡿⠟⠋⢀⠃⠀⢀⠔⠕⡎⠶⠞⢂⡨⢙⡲⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣦⣒⠲⢤⡀⣀⠀⠀⠀⠀⠀⠀⠀⡰⢁⢲⣞⡆⠀⠀⠀⠀⢀⠌⣠⡰⡳⣡⠮⠂⣠⡶⠟⡻⡻⣷⣌⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⣿⣯⣿⣟⢿⣶⣦⣤⣀⠪⢦⣸⠟⣾⡵⢲⣮⣆⣲⠨⠋⠃⢥⢔⣥⣶⣿⣷⣾⣿⣿⣾⡼⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠛⠿⣿⣿⣭⣿⣿⣾⣾⢘⣿⡕⢸⣟⠍⣿⡇⢾⣦⣩⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⡿⣿⡇⢘⣿⠿⢰⢻⡙⣿⠧⣿⢿⣾⣿⣿⣿⣿⣿⣿⣟⣭⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⢁⡟⣓⣼⣿⡇⢹⡎⠃⣿⢘⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⢰⣻⣗⡺⠛⡱⣿⡟⡶⢿⣾⣿⣯⣽⣶⣞⣠⠍⢉⠛⠹⠽⣋⡽⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⡾⣯⢳⡘⢠⠞⠒⠞⣟⢿⢼⣿⣿⣿⣿⣿⣿⡷⢖⣧⣵⢒⡦⠡⣀⠂⠤⠄⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣽⣷⣿⣿⣶⣼⣾⣿⡟⡋⠋⢉⠜⠍⠋⢑⡌⠐⠈⣻⣢⣾⣿⠑⠚⠩⠆⢐⡂⠩⣔⠂⠤⢄⣀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⢹⣿⣟⠀⠀⠀⠀⠀⢀⣠⡀⠆⠐⠀⠀⡼⠁⠀⣀⢨⣿⣿⣿⠀⠀⠀⠀⠀⠀⠉⠀⠊⠡⠕⢒⠯⢭⣖⣢⣤
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣔⣥⢆⡷⣗⣦⢶⣶⡿⠟⠛⠩⢀⠤⠂⢀⣘⠄⠀⣿⣥⡴⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠐⠛⠹
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣺⣟⣶⣯⣆⢄⡀⠔⢜⣊⢕⠊⠘⣿⡿⣇⠃⠀⠀⠀⠀⡠⣈⣆⣴⡿⠃⠀⠀⠁⠿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣎⣮⣿⡿⢯⣿⡟⣇⣿⣧⣤⢨⣴⣯⣙⡝⣿⣴⣮⠶⡶⠷⠟⠛⢸⠃⠀⠀⠀⠀⠀⠀⠀⣴⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣀⠠⣤⣐⡶⠾⠟⢽⣯⣿⢭⡛⣿⠿⡷⣹⣷⠿⠿⠿⠛⣿⡙⢿⡾⠑⠀⠀⠀⠀⢀⠒⠀⠀⠀⠂⠀⠀⡀⣠⣿⣏⢇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣀⣤⣴⠦⠝⠒⠋⠉⠁⣀⣠⡴⠺⢛⣻⣧⢾⡊⣽⣰⠗⠛⠀⠀⠀⠀⠀⠓⣵⡟⣇⠣⣤⡱⠖⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣷⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠉⠁⠀⢀⣠⡤⡖⠮⠑⢈⣡⣴⠶⠋⠁⠉⠙⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⡏⣵⣒⢁⠀⠀⠀⠀⠄⠀⠀⠄⠄⠠⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠠⠶⠛⠛⠉⠀⣠⣴⠪⠙⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣄⡎⢀⢀⠀⠁⠁⠀⣐⣀⣐⣥⣬⣴⣶⣿⣿⣿⣿⣿⣿⣿⣿⡧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢀⢠⡶⠛⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣏⣿⣿⣿⣯⣭⣿⣽⣿⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣵⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⣿⣽⣿⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⢻⣿⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⢾⣿⣧⣶⣽⣿⣿⣿⣿⣷⣾⣿⣿⣿⣿⣿⣿⡿⣯⣷⡿⣗⣦⣶⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void CaptainMarvel()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠤⠶⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⡀⣤⣤⡊⢁⣽⠶⢿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⣿⡉⠻⣿⣏⠀⣼⡁⠷⢾⣿⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢀⣿⣿⡿⠛⣇⣀⣀⣁⣠⠿⣇⡀⢺⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⢿⣿⢷⣾⣬⣇⠉⣉⣶⠴⢿⣻⡿⠤⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠛⠙⠾⠏⠀⣿⣡⣤⣤⣄⣀⢙⣄⣠⣽⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣟⠩⢿⣋⢹⣿⣛⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣞⠋⡼⠙⢮⠁⠈⢉⣿⡁⢹⢇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢀⣠⢤⣶⣤⣀⣠⣾⣵⡞⠀⠀⢈⡇⠠⠊⠘⢹⣿⡾⡷⣄⠴⠚⣉⡙⠲⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⢀⡠⠚⠁⠉⠉⠁⢁⡞⠉⢛⡟⠀⠀⣠⣾⣅⠀⠀⢆⠀⡏⢦⡈⢿⣆⡉⠀⠀⠀⠈⠻⣆⠀⠀⠀⠀⠀⠀⠀⠀
⡴⣯⠀⠀⠀⢀⣀⡴⢋⢈⡴⡏⠀⢠⣾⣿⣿⣿⡟⣒⠒⠛⣷⣠⠍⠢⡿⠹⣷⣦⡀⠀⠀⠘⣧⠀⠀⠀⠀⠀⠀⠀
⠷⡏⠀⠀⣴⣿⣿⣖⣲⠏⠀⠘⡄⢹⡟⠁⠀⠀⢫⠙⠻⢍⣹⣿⡄⠀⢹⣾⣿⡿⠃⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀
⢀⡟⠀⠀⢧⣿⣟⣿⠃⠀⠀⢀⡇⠀⢳⡀⠀⠰⡀⠱⡄⠀⣸⣉⣷⡀⠀⠉⠉⠀⠀⠀⠀⡀⢸⠀⠀⠀⠀⠀⠀⠀
⣿⠀⢠⣄⠀⠀⠀⠀⢠⡴⠏⡙⠀⠀⣾⡻⣦⠀⠴⣤⢿⡄⡟⠘⡍⡻⠦⡄⠀⠀⣀⣤⡾⣡⠏⠀⠀⠀⠀⠀⠀⠀
⠹⡀⢠⠀⠉⠉⠉⠉⠚⠓⠉⠁⠀⠀⣿⠱⡈⠣⡀⠠⠀⢿⠁⢀⣧⠉⠑⠒⠒⠩⠵⠿⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠱⡼⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡀⢹⣶⢷⡄⠤⣼⠀⠈⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢸⠘⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⣻⠏⠒⢧⡴⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠘⠶⣯⠼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⡁⠀⣤⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠀⠉⠛⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠀⠀⡼⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡼⠀⣰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠻⣄⢤⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡆⠀⣸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⠞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠿⠛⠿⠿⢻⡹⠀⠤⣿⠛";
        Console.WriteLine(texto);
    }

    public static void Deadpool()
    {
        string texto = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡤⠤⠴⠶⠤⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⠁⠀⠀⠀⠀⠀⠀⠈⣳⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡏⣸⢄⣀⠀⠀⠀⠀⣀⣠⡏⢿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⢣⠇⠀⠘⡆⠀⠀⡜⠁⠀⡇⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢀⡤⢶⡀⠀⠀⠀⠀⠀⣿⡏⠀⠀⠀⢻⠀⡼⠁⠀⠀⢳⢸⠀⠀⠀⠀⠀⣴⣷⣤⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠈⢷⣖⣻⣄⠀⠀⠀⠀⣿⣇⠸⣿⡷⢺⡇⢧⣞⣹⠖⢸⣾⠀⠀⠀⢀⡾⣉⣾⠏⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠻⣶⣻⣆⠀⠀⠀⢻⠙⣄⠀⣠⠋⠀⠈⢦⠀⢀⡞⡿⠀⠀⢀⡎⢉⣶⠋⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠙⣷⣻⢧⡀⠀⠸⡆⠈⢟⠁⠀⠀⠀⠀⢱⠋⢠⡇⠀⢀⡞⢩⡾⠃⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢷⣫⢷⡀⠀⢻⡄⢸⠀⠀⠀⠀⠀⡟⢀⡞⠀⢠⡏⢈⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⡭⣷⣄⣼⣿⣾⠀⠀⠀⠀⣀⡿⣿⣷⣠⠟⠈⡼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣹⠷⢿⣿⠮⣝⡛⠶⠾⠭⠵⣚⡵⣿⠛⢦⡼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢀⡤⠖⠒⠒⠒⠻⣍⠀⢀⣠⠿⢦⣀⠉⠙⠒⠒⠋⠉⣰⠏⠀⠀⠉⠓⠒⣦⡤⣄⡀⠀⠀⠀⠀⠀
⠀⠀⠀⣰⠏⠀⠀⠀⠀⠀⠀⢸⣿⣭⢤⣤⣀⣈⣙⣲⣶⣶⣒⡿⠁⠀⠀⠀⠀⢀⡼⠋⠀⠀⠉⠢⣄⠀⠀⠀
⠀⠀⣰⠃⠀⠀⠀⠀⠀⠀⣠⢿⡜⠉⠒⠒⠒⠤⠤⣿⣿⡏⠉⢷⣀⠀⠀⢀⣴⠛⡇⠀⠀⠀⠀⠀⠘⢦⠀⠀
⠀⠀⡟⠀⠀⠀⠀⢀⡤⠞⢣⠏⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⢠⠊⢉⡿⠉⠉⠈⢧⢱⠀⠀⠀⠀⠀⠀⠈⣧⠀
⠀⢀⡇⠀⠀⠀⢀⡾⠁⠀⡏⠀⠀⠀⠀⠀⠀⠀⠀⡇⡏⣧⠇⢠⠋⠀⠀⠀⠀⠈⠾⣷⡄⠀⠀⠀⠀⠀⢸⠀
⠀⢸⠃⠀⠀⢀⣼⡷⣞⢦⡉⠓⢤⣀⠀⠀⠀⠀⢠⡇⣧⠏⣠⠃⠀⠀⠀⠀⣀⡤⠴⣇⣽⠀⠀⠀⠀⠀⢸⠀
⢀⣿⣶⣾⣿⣿⣟⠢⣌⠳⣷⣄⠀⠈⡟⠲⠤⣀⣀⡿⠃⡠⠃⣀⣀⣤⠖⠉⠀⠀⢠⠏⠈⢣⠀⠀⠀⠀⢸⠀
⠈⣿⠟⠉⠙⠻⠛⠓⠒⠛⠛⠻⠷⠾⠄⣀⣀⣀⣸⡇⠴⠯⠽⢿⡗⣾⣁⣀⣀⣀⣈⠀⠀⠈⠳⠤⠤⣄⣸⡀
⠀⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⠤⠤⠖⡇⢸⠀⠹⡄⠈⢻⣦⣤⣶⡾⠿⠿⣦⣬⡗
⠀⢿⣗⠦⢄⣀⣀⣀⡀⠀⠤⠤⠤⠤⠐⠒⠈⠉⠁⠀⠀⠀⢀⡼⠁⣸⣀⣀⠷⠒⠋⠉⠁⠀⠀⠀⠀⠈⢻⣧
⠀⠈⣎⠓⡄⢀⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡠⠤⠺⠗⠛⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⠃
⠀⠀⠈⠒⢧⣼⣀⠀⠀⠀⠀⠀⠀⠀⣀⣠⠔⠒⠉⠓⠤⢄⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠴⢋⡏⠀
⠀⠀⠀⠀⠀⠀⠀⠉⠹⡟⠛⠋⠉⠙⠓⢲⠤⢄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠒⠒⠚⠉⠉⠁⣤⢚⡟⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣀⣠⡇⠀⠀⠀⣀⣠⠋⠀⠀⠀⠀⠉⠒⠒⠤⠤⠤⠤⠤⠤⠤⢤⠤⠖⠒⠒⠛⠁⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void Catwoman()
    {
        string texto = @"
⣴⣶⣄⠀⠀⣀⣤⣤⣶⣶⣶⣶⣦⣤⣤⡀⠀⢀⣴⣶⡄
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇
⣿⣿⠛⠛⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠛⢻⣿⡇
⣿⣿⢀⣀⣤⣀⡈⠻⣿⣿⣿⣿⡿⠋⣀⣠⣄⡀⢸⣿⡇
⣿⣿⠈⠋⠉⢹⣿⣦⣽⣿⣿⣿⣥⣾⣿⠉⠉⠋⢸⣿⡇
⣿⣿⡀⠀⠀⠈⠉⢈⣹⣿⣿⣿⣅⠉⠉⠀⠀⠀⢸⣿⡇
⢸⣿⣿⣿⣿⡿⠛⠛⠋⠀⠀⠈⠛⠛⠻⣿⣿⣿⣿⣿⠀
⠀⢿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⡏⠀
⠀⠈⢿⣿⣿⣿⠀⠲⢿⣿⣾⣿⠷⠂⠀⣿⣿⣿⠟⠀⠀
⠀⠀⠈⠻⣿⣿⡀⠀⠀⠈⠉⠀⠀⢀⣼⣿⡿⠋⠀⠀⠀
⠀⠀⠀⠀⠈⠻⢿⣷⣶⣤⣤⣴⣾⣿⠟⠋⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀";
        Console.WriteLine(texto);
    }

    public static void ImprimirConDelay(string texto, int ms)
    {
        foreach (char c in texto)
        {
            Console.Write(c);
            Thread.Sleep(ms);
        }
    }
    public static void MostrarGanador(Personaje ganador)
    {
        switch (ganador.Datos.Apodo)
        {
            case "Hulk":
                Hulk();
                break;
            case "Spider-Man":
                Spiderman();
                break;
            case "Wonder Woman":
                Wonderwoman();
                break;
            case "Batman":
                Batman();
                break;
            case "Harley Quinn":
                Harley();
                break;
            case "Joker":
                Joker();
                break;
            case "Superman":
                Superman();
                break;
            case "Iron Man":
                Ironman();
                break;
            case "Wolverine":
                Wolverine();
                break;
            case "Captain Marvel":
                CaptainMarvel();
                break;
            case "Deadpool":
                Deadpool();
                break;
            case "Catwoman":
                Catwoman();
                break;

        }
    }

}
