namespace Tp3_Ghelman_Urciuoli;
class program{
    static void Main(string[] args)
    {
        List <Superheroe> superheroes = new List<Superheroe>();
        double puntos1, puntos2;
        int elegir;
         elegir = Elegirmenu();        
       while (elegir != 4) {
      
       switch(elegir){
        case 1:
        Superheroe Super1 = CrearSuperHeroe();
        superheroes.Add(Super1);
        puntos1=GenerateSkill(Super1.FUERZA, Super1.VELOCIDAD);
        break;
        case 2:
        Superheroe Super2 =CrearSuperHeroe();
        superheroes.Add(Super2);
        puntos2=GenerateSkill(Super2.FUERZA, Super2.VELOCIDAD);         
        break;
        case 3:
       foreach (Superheroe super1 in superheroes){
         puntos1=GenerateSkill(super1.FUERZA, super1.VELOCIDAD);
         foreach(Superheroe super2 in superheroes){
            puntos2=GenerateSkill(super2.FUERZA, super2.VELOCIDAD);   
        Pelear(puntos1, puntos2, super1, super2);}}

        break;
        case 4:
        break;
       }   elegir = Elegirmenu();  
        }


    }   
    static Superheroe CrearSuperHeroe()
    {
        Superheroe objSuperHeroe = new Superheroe( );
        do {
            Console.WriteLine("Ingrese Su nombre");
            objSuperHeroe.NOMBRE = Console.ReadLine( );
        }while(objSuperHeroe.NOMBRE==" ");
        do{
            Console.WriteLine("Ingrese La ciudad donde reside" );
            objSuperHeroe.CIUDAD= Console.ReadLine( );
        }while(objSuperHeroe.CIUDAD==" ");
        do{
            Console.WriteLine("Ingrese la fuerza del superheroe");
            objSuperHeroe.FUERZA = double.Parse(Console.ReadLine( ));
        }while(objSuperHeroe.FUERZA<0 || objSuperHeroe.FUERZA>100 );
        do{ 
        Console.WriteLine("Ingrese la velocidad del superheroe");
        objSuperHeroe.VELOCIDAD = double.Parse(Console.ReadLine( ));
        }while(objSuperHeroe.VELOCIDAD<0 || objSuperHeroe.VELOCIDAD>100 );
        do{ 
        Console.WriteLine("Ingrese el peso del superheroe");
        objSuperHeroe.PESO = double.Parse(Console.ReadLine( ));
        }while(objSuperHeroe.PESO<0);
        return objSuperHeroe;
    }
    
     static int Elegirmenu()
     {
        int num;
        do {
            Console.WriteLine("Ingrese 1 si quiere cargar el superheroe 1, ingrese 2 si quiere cargar el superheroe 2, ingrese 3 si quiere que compitan los superheroes, ingrese 4 si quiere salir");
            int.TryParse(Console.ReadLine(), out num);
        }
        while(num < 1 && num > 4);
       return num;
     }
        static double GenerateSkill(double fuerza, double velocidad)
    {
        double puntos;
        Random rnd=new Random();
        double random=rnd.Next(1,11);
        puntos=random+(velocidad*0.6)+(fuerza*0.6);
        return puntos;
    }
    static void Pelear(double puntos1, double puntos2, Superheroe super1, Superheroe super2)
    {
        double diferencia=0;
        
        string nombremax="";
        if(puntos1 > puntos2){
        diferencia=puntos1-puntos2;
        nombremax= super1.NOMBRE;
        }
        else{
            diferencia = puntos2 - puntos1;
            nombremax = super2.NOMBRE;
        }  
        
        if(diferencia>=30)
        {
            Console.WriteLine("Gano el jugador " + nombremax + " por una amplia diferencia");
        }
        else if( diferencia<10 && diferencia>0)
        {
            Console.WriteLine("Gano el Jugador " + nombremax + " No le sobro nada");
        }
           else if(diferencia>=10 && diferencia<30)
        {
            Console.WriteLine("Gano el jugador " + nombremax + " Fue muy parejo");
        }
        
    }
    }


