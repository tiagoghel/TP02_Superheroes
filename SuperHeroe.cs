namespace Tp3_Ghelman_Urciuoli;
public class Superheroe {

    public string NOMBRE {get;set;}
    public string CIUDAD {get;set;}
     public double PESO {get;set;}
     public double FUERZA {get;set;}
     public double VELOCIDAD {get;set;}

     public Superheroe() {}
     public Superheroe (string nombre, string ciudad, double peso, double fuerza, double velocidad)
     {
        NOMBRE=nombre;
        CIUDAD=ciudad;
        PESO=peso;
        FUERZA=fuerza;
        VELOCIDAD=velocidad;
        }
    public double GenerateSkill()
    {
        double puntos;
        Random rnd=new Random();
        double random=rnd.Next(1,11);
        puntos=random+(VELOCIDAD*0.6)+(FUERZA*0.6);
        return puntos;
    }
       


}