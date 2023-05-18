public class Pais{
    public string Nombre {get;}
    public string ImgBandera {get;}
    public int Poblacion {get;}
    public string FechaIndependencia {get;}
    public string AtractivoTuristico {get;}

    public Pais(string nombre, string img, int poblacion, DateTime fecha, string atractivo){
        Nombre = nombre;
        ImgBandera = img;
        Poblacion = poblacion;
        FechaIndependencia = fecha.ToShortDateString();
        AtractivoTuristico = atractivo;
    }
}