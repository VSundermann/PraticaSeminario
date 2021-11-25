using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program{
  public class Teste{
    public class Celula{
      public String Nome{get; set;}
      public int idade{get; set;}
      public int ID{get; set;}
      public Celula Prox{get; set;}
      public Celula Ant{get; set;}
    }

    public class ListaD{
      public Celula Sentinela{get; set;}

      public void InsertCel(Celula novaCel){
        if (Sentinela == null){
          Sentinela = novaCel;
        } else {
          var ultimaCel = GetLastCel();
          ultimaCel.Prox = novaCel;
          novaCel.Ant = ultimaCel;
        }
      }
  
      public Celula GetLastCel(){
        var celAux = Sentinela;
        
        while (celAux.Prox != null){
          celAux = celAux.Prox;
        }
        
        return celAux;  
      }

      public List<Celula> GetCels(){
        var listaAux = new List<Celula>();
        var celAux = Sentinela;
        
        while (celAux != null){
          listaAux.Add(celAux);
          celAux = celAux.Prox;
        }
        
        return listaAux;
      }

      public List<Celula> GetCelsInv(){
        var listaAux = new List<Celula>();
        var celAux = GetLastCel();
        
        while (celAux != null){
          listaAux.Add(celAux);
          celAux = celAux.Ant;
        }
        
        return listaAux;
      }

      public void UpdateCel(Celula procuraCel){
        var celAux = Sentinela;
              
        while (celAux != null){
          if (procuraCel.ID == celAux.ID){
            procuraCel.Nome = celAux.Nome;
            procuraCel.idade = celAux.idade;
            return;
          }
          
          celAux = celAux.Prox;
        }
      }

      public void DeleteCel(int celulaId){
        var celAux = Sentinela;
        
        if (Sentinela.ID == celulaId){
          Sentinela = Sentinela.Prox;
        } else {
          while (celAux != null){
            if (celulaId == celAux.ID){
              celAux.Prox.Ant = celAux.Ant;
              celAux.Ant.Prox = celAux.Prox;
              return;
            }
          }
        }
      }
    }
    
    public static void Main(string[] args){

      var listaDupla = new ListaD();
      InsertCels(listaDupla);
      PrintLista(listaDupla);
      Console.WriteLine("");
      PrintListaInv(listaDupla);
    }

    public static void InsertCels(ListaD listaPrin){
      var Cel1 = new Celula() { Nome = "Anna Klara", idade = 19, ID = 622};
      var Cel2 = new Celula() { Nome = "Victor Gabriel", idade =19, ID = 027};
      var Cel3 = new Celula() { Nome = "Leonardo Mendes", idade = 15, ID = 345};
      var Cel4 = new Celula() { Nome = "João Antonio", idade = 32, ID = 999};
      var Cel5 = new Celula() { Nome = "Carlos Prates", idade = 47, ID = 420};
      var Cel6 = new Celula() { Nome = "Amelia Watson", idade = 22, ID = 218};
      var Cel7 = new Celula() { Nome = "Michael Jackson", idade = 79, ID = 369};
      var Cel8 = new Celula() { Nome = "Maria Silvia", idade = 63, ID = 145};
      var Cel9 = new Celula() { Nome = "Marco Rodrigo", idade = 48, ID = 893};
  
      listaPrin.InsertCel(Cel1);
      listaPrin.InsertCel(Cel2);
      listaPrin.InsertCel(Cel3);
      listaPrin.InsertCel(Cel4);
      listaPrin.InsertCel(Cel5);
      listaPrin.InsertCel(Cel6);
      listaPrin.InsertCel(Cel7);
      listaPrin.InsertCel(Cel8);
      listaPrin.InsertCel(Cel9);
    }

    public static void PrintLista(ListaD listaPrin){
      Console.WriteLine($"Printando a Lista");
      
      foreach (var item in listaPrin.GetCels()){
        Console.WriteLine($"Nome: {item.Nome} - Idade: {item.idade} - ID {item.ID}");
      }
      
      Console.WriteLine();
    }

    public static void PrintListaInv(ListaD listaPrin){
      Console.WriteLine($"Printando a Lista de tras pra frente");
      
      foreach (var item in listaPrin.GetCelsInv()){
        Console.WriteLine($"Nome: {item.Nome} - Idade: {item.idade} - ID {item.ID}");
      }
      
      Console.WriteLine();
    }
  }
}
