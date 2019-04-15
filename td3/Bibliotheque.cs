public class Bibliotheque {

    private Livre [] tabLivre ; 
    private Abonne [] tabAbonne ; 
    private int nbreLivre ;    
    private int nbreAbonne ;    

    public Bibliotheque (int maxLivre, int maxAbonne){
        this.nbreLivre= maxLivre; 
        this.nbreAbonne= maxAbonne; 

    }


public Livre [] tabLivre(){
    get {
        return tabLivre; 
    }
}

public Abonne[] tabAbonne () { 
    get{
        return tabAbonne; 
    }
}

public int nbreLivre(){
    get{
        return nbreLivre; 
    }
}
}