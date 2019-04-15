public class Abonne
{


    private int numAbonne; 
    private string nom; 
    private Livre emprunt; 


    public Abonne(int numAbonne, string nom){
        this.nom = nom ; 
        this.numAbonne= numAbonne; 
    }

    public int NumAbonne{
        get{
            return numAbonne;
        }
    }

    public string Nom{
        get{
            return nom;
        }
        set{
            nom=value; 
        }
    }
    
    public  Livre Emprunt{
        get{
            return emprunt;
        }
        set{
            emprunt=value; 
        }
    }

    public override string ToString(){
        string ch = new string (); 
        ch="Le nom de l'abonné = " +NumAbonne.ToString()+ "le numéro d'abonné =" +; 

        if( emprunt == null){ 
            ch + = " Pas de livre emprunté ";

        }else { 
        ch + = "Il a emprunté =" + emprunt.titre();
        }

    return ch ; 

}






}