static class Info
{
    static List<Pais> ListaPaises = new List<Pais>();
    private static void InicializarLista(){
        DateTime n1 = new DateTime(2010,10,10);
        Pais pais1 = new Pais("Curazao","curazao.png",152000, n1,"La playa");
        ListaPaises.Add(pais1);
        DateTime n2 = new DateTime(1953,6,18);
        Pais pais2 = new Pais("Egipto","egipto.png",109300000, n2,"Las pirámides");
        ListaPaises.Add(pais2);
        DateTime n3 = new DateTime(1055);
        Pais pais3 = new Pais("Gales","gales.png",3136000, n3,"Las estructuras antiguas");
        ListaPaises.Add(pais3);
        DateTime n4 = new DateTime(1991,10,27);
        Pais pais4 = new Pais("Turkmenistan","turkmenistan.png",6342000, n4,"Las mezquitas y otras construcciones");
        ListaPaises.Add(pais4);
        DateTime n5 = new DateTime(1978,10,1);
        Pais pais5 = new Pais("Tuvalu","tuvalu.png",11204, n5,"La playa");
        ListaPaises.Add(pais5);
        
    }
    public static List<Pais> ListarPaises(){
        if(ListaPaises.Count == 0){
            InicializarLista();
        }
        return ListaPaises;
    }
    public static Pais DetallePais(string nombre){
        Pais pais = null;
        foreach(Pais item in ListaPaises){
            if(item.Nombre == nombre){
                pais = item;
            }
        }
        return pais;
    }

}